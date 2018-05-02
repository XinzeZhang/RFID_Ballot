using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SQL Connection
using System.Data.SqlClient;
using System.Data.Sql;
//使用rfid api
using DesktopRfidApi;
// 
using Microsoft.Office;
using Microsoft.Office.Interop;

namespace CheckIn
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        // initiallize the rfid api
        DesktopRfidApi.RfidApi Api = new DesktopRfidApi.RfidApi();

        //initiallize the rfid tagcount
        public byte TagReading = 0;
        public int Tagcount = 0;
        // initiallize the grouptype_id
        public int GroupType_Id = 2;
        // initiallize the candidate_pool_list interview
        private static List<int> Shenji_Interview = new List<int>();
        private static List<int> NotQuan_Interview = new List<int>();
        private static List<int> Quan_Interview = new List<int>();
        // initiallize the candidate_pool_list english
        private static List<int> Shenji_English = new List<int>();
        private static List<int> NotQuan_English = new List<int>();
        private static List<int> Quan_English = new List<int>();




        /// <summary>
        /// CheckIn_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckIn_Load(object sender , EventArgs e)
        {
            //panel operation
            //ListPanel.Add(panel_AthletesCheckIn);
            //ListPanel.Add(panel_RFIDConfigure);
            //ListPanel[PanelIndex].BringToFront();

            try
            {
                //RFID设备 端口号初始化设置，设置为COM3
                commport_toolStripComboBox.SelectedIndex = 2;
                //RFID设备 波段初始化设置，设置为9600
                boundrate_toolStripComboBox.SelectedIndex = 0;
                //RFID设备 频率范围: 0 - 2;
                //0 for 中国China(920 m ~920 m); 1 for 美国American(902 m ~902 m)
                //其他the other for 特殊special models (868 m)
                //RFID设备 频率初始化设置，设置为美国, frequency default as 1;
                freqtype_toolStripComboBox.SelectedIndex = 1;

                Connect_ToolStripMenuItem.Enabled = true;//配置初始化，连接按钮启用
                Disconnect_ToolStripMenuItem.Enabled = false;//配置初始化，断开连接按钮禁用

                pf_ToolStripMenuItem.Enabled = false;//配置初始化，功率与频率groupbox禁用
                ant_ToolStripMenuItem.Enabled = false;//配置初始化，天线设置禁用

                dataregion_toolStripComboBox.SelectedIndex = 1;//配置初始化，标签读写区初始化为EPC区域

                //initialize data address comboBox//配置初始化，标签起始地址为2
                int nloop = 0;
                for(nloop = 0 ; nloop < 256 ; nloop++)
                {
                    dataaddress_toolStripComboBox.Items.Add(Convert.ToString(nloop));
                }
                dataaddress_toolStripComboBox.SelectedIndex = 2;

                //initiallize power index
                for(nloop = 1 ; nloop < 31 ; nloop++)
                {
                    power_toolStripComboBox.Items.Add(Convert.ToString(nloop));
                }

                //initiallize data length comboBox//配置初始化，标签读写长度为1, 4位16进制数字
                for(nloop = 1 ; nloop < 14 ; nloop++)
                {
                    datalength_toolStripComboBox.Items.Add(Convert.ToString(nloop));
                }
                datalength_toolStripComboBox.SelectedIndex = 0;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            stopcheck_button.Enabled = false;

            //initiallize the datagridview_checkin
            //ToolStripMenuItem_Major_Click(null , null);
            ToolStripMenuItem_English_Click(null , null);

        }

        /// <summary>
        /// 连接读卡器，开启stopcheck_button，关闭check_button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_button_Click(object sender , EventArgs e)
        {
            Connect_ToolStripMenuItem_Click(null , null);

            int status;
            byte v1 = 0;
            byte v2 = 0;

            status = Api.GetFirmwareVersion(ref v1 , ref v2);
            if(status == 0)
            {
                stopcheck_button.Enabled = true;
                check_button.Enabled = false;

                try
                {
                    if(TagReading == 0)
                    {
                        Api.ClearIdBuf();

                        Tagcount = 0;
                        check_timer.Interval = 250;
                        check_timer.Enabled = true;
                        TagReading = 1;
                    }
                }
                catch(Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }

        }

        /// <summary>
        /// 关闭读卡器，开启check_button，关闭stopcheck_button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopcheck_button_Click(object sender , EventArgs e)
        {
            Disconnect_ToolStripMenuItem_Click(null , null);
            stopcheck_button.Enabled = false;
            check_button.Enabled = true;

            try
            {
                if(TagReading == 1)
                {
                    check_timer.Enabled = false;
                    TagReading = 0;
                }
            }
            catch(Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void check_timer_Tick(object sender , EventArgs e)
        {
            int dataregion_timer;
            int dataaddress_timer;
            int datalength_timer;

            int status = 0;
            byte[] value = new byte[16];

            string s1 = "";

            int Candidate_CarNum_Value = 0;

            //下面是一条测试用sql命令
            //SELECT View_Check.Name,View_Check.ContestantName,View_Check.AthleteOrder,View_Check.AthleteStatu FROM View_Check WHERE View_Check.CompetitionProjectName = '男子儿童组自选长拳A组'AND View_Check.AthleteId='30'

            dataregion_timer = dataregion_toolStripComboBox.SelectedIndex;
            dataaddress_timer = dataaddress_toolStripComboBox.SelectedIndex;
            datalength_timer = datalength_toolStripComboBox.SelectedIndex + 1;

            status = Api.EpcRead((byte) dataregion_timer , (byte) dataaddress_timer , (byte) datalength_timer , ref value);

            if(status == 0)
            {
                int globe_order = new int();
                int lableinfo_id = new int();
                //test
                check_timer.Enabled = false;

                for(int i = 0 ; i < datalength_timer * 2 ; i++)
                {
                    s1 += string.Format("{0:X2}" , value[i]);
                }

                Candidate_CarNum_Value = Convert.ToInt32(s1);

                try
                {

                    string sql_exist = "select View_CandidateInfo.Candidate_LocalOrder FROM View_CandidateInfo WHERE View_CandidateInfo.Candidate_Id = '" + Candidate_CarNum_Value + "' AND View_CandidateInfo.GroupTypeInfo_Id='" + GroupType_Id + "' and View_CandidateInfo.Candidate_LocalOrder is not null;";
                    if(DataAccess.sql_exist(sql_exist))
                    {
                        string sqlselect_pooled = "SELECT View_CandidateInfo.Candidate_Id,View_CandidateInfo.Candidate_Index,View_CandidateInfo.Candidate_Name,View_CandidateInfo.Person_Id,View_CandidateInfo.Label_Name,View_CandidateInfo.InterviewGroup_Id,View_CandidateInfo.Candidate_LocalOrder FROM View_CandidateInfo WHERE View_CandidateInfo.Candidate_Id = '" + Candidate_CarNum_Value + "' and View_CandidateInfo.GroupTypeInfo_Id='" + GroupType_Id + "';";
                        DataSet dataset_CandidateInfo_pooled = DataAccess.GetDataSetBySql(sqlselect_pooled);
                        textBox_CandidateId.Text = dataset_CandidateInfo_pooled.Tables[0].Rows[0][0].ToString().Trim();
                        textBox_CandidateIndex.Text = dataset_CandidateInfo_pooled.Tables[0].Rows[0][1].ToString().Trim();
                        textBox_CandidateName.Text = dataset_CandidateInfo_pooled.Tables[0].Rows[0][2].ToString().Trim();
                        textBox_CandidatePersonId.Text = dataset_CandidateInfo_pooled.Tables[0].Rows[0][3].ToString().Trim();
                        textBox_CandidateLabel.Text = dataset_CandidateInfo_pooled.Tables[0].Rows[0][4].ToString().Trim();
                        int InterviewGroup_Id_Pooled = Convert.ToInt32(dataset_CandidateInfo_pooled.Tables[0].Rows[0][5]);
                        textBox_EnterOrder.Text = dataset_CandidateInfo_pooled.Tables[0].Rows[0][6].ToString().Trim();

                        string sql_select_interviewName_pooled = "select InterviewGroup_Name from InterviewGroupInfo where Id='" + InterviewGroup_Id_Pooled + "';";
                        DataSet dataset_interviewName_pooled = DataAccess.GetDataSetBySql(sql_select_interviewName_pooled);
                        textBox_InterviewGroup.Text = dataset_interviewName_pooled.Tables[0].Rows[0][0].ToString().Trim();

                        DialogResult answer = MessageBox.Show("已抽签！");
                        if(answer == DialogResult.OK)
                        {
                            check_timer.Enabled = true;
                        }
                    }
                    else
                    {
                        string sqlselect = "SELECT View_CandidateInfo.Candidate_Id,View_CandidateInfo.Candidate_Index,View_CandidateInfo.Candidate_Name,View_CandidateInfo.Person_Id,View_CandidateInfo.Label_Name,View_CandidateInfo.LabelInfo_Id FROM View_CandidateInfo WHERE View_CandidateInfo.Candidate_Id = '" + Candidate_CarNum_Value + "' and View_CandidateInfo.GroupTypeInfo_Id='" + GroupType_Id + "';";
                        DataSet dataset_CandidateInfo = DataAccess.GetDataSetBySql(sqlselect);
                        textBox_CandidateId.Text = dataset_CandidateInfo.Tables[0].Rows[0][0].ToString().Trim();
                        textBox_CandidateIndex.Text = dataset_CandidateInfo.Tables[0].Rows[0][1].ToString().Trim();
                        textBox_CandidateName.Text = dataset_CandidateInfo.Tables[0].Rows[0][2].ToString().Trim();
                        textBox_CandidatePersonId.Text = dataset_CandidateInfo.Tables[0].Rows[0][3].ToString().Trim();
                        textBox_CandidateLabel.Text = dataset_CandidateInfo.Tables[0].Rows[0][4].ToString().Trim();
                        lableinfo_id = Convert.ToInt32(dataset_CandidateInfo.Tables[0].Rows[0][5]);

                        String sql_select_interviewinfo = "select Id,Start_Id, End_Id from InterviewGroupInfo where InterviewGroupInfo.GroupTpyeInfo_Id='" + GroupType_Id + "';";
                        DataSet dataset_interviewinfo = DataAccess.GetDataSetBySql(sql_select_interviewinfo);

                        globe_order = getOrder(GroupType_Id , lableinfo_id);

                        Tuple<int , int> r = GetDataGroupInfoId(dataset_interviewinfo.Tables[0] , globe_order);
                        int InterviewGroup_Id = r.Item1;
                        int Candidate_LocalOrder = r.Item2;

                        String sql_select_interviewName = "select InterviewGroup_Name from InterviewGroupInfo where Id='" + InterviewGroup_Id + "';";
                        DataSet dataset_interviewName = DataAccess.GetDataSetBySql(sql_select_interviewName);
                        textBox_InterviewGroup.Text = dataset_interviewName.Tables[0].Rows[0][0].ToString().Trim();
                        textBox_EnterOrder.Text = globe_order.ToString().Trim();
                        InsertIntoOrder(Candidate_CarNum_Value , InterviewGroup_Id , Candidate_LocalOrder , globe_order , lableinfo_id);
                        Refresh_datagridview_checkinfo(GroupType_Id);
                    }
                }
                catch(Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
        }

        /// <summary>
        /// 已知面试人ID，面试人在该组的顺序以及改组的ID，更新数据库
        /// </summary>
        /// <param name="CandidateId"></param>
        /// <param name="InterviewGroup_Id"></param>
        /// <param name="Candidate_LocalOrder"></param>
        /// /// <param name="LabelInfo_Id"></param>
        public void InsertIntoOrder(int CandidateId , int InterviewGroup_Id , int Candidate_LocalOrder,int Candidate_GlobeOrder , int LabelInfo_Id)
        {
            String sql_update = "";
            if(LabelInfo_Id < 3)
            {
                sql_update = "update View_CandidateInfo set InterviewGroup_Id= '" + InterviewGroup_Id + "', Candidate_LocalOrder= '" + Candidate_LocalOrder + "',Candidate_GlobeOrder='" + Candidate_GlobeOrder + "'  where Candidate_Id = '" + CandidateId + "' and GroupTypeInfo_Id = '" + GroupType_Id + "' ; update Num_Pool set Statu= '" + 1 + "' where GroupTypeInfo_Id = '" + GroupType_Id + "'  AND GlobeOrder ='" + Candidate_GlobeOrder + "';";
            }
            else
            {
                sql_update = "update View_CandidateInfo set InterviewGroup_Id= '" + InterviewGroup_Id + "', Candidate_LocalOrder= '" + Candidate_LocalOrder + "',Candidate_GlobeOrder='" + Candidate_GlobeOrder + "'  where Candidate_Id = '" + CandidateId + "' and GroupTypeInfo_Id = '" + GroupType_Id + "' ; update Num_Pool set Statu= '" + 1 + "' where GroupTypeInfo_Id = '" + GroupType_Id + "' AND LabelInfo_Id = '" + LabelInfo_Id + "' AND GlobeOrder ='" + Candidate_GlobeOrder + "';";

            }
            try
            {
                if(DataAccess.sql_command(sql_update))
                {
                    DialogResult answer = MessageBox.Show("抽签成功！");
                    //test
                    if(answer == DialogResult.OK)
                    {
                        check_timer.Enabled = true;
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        /// <summary>
        /// 该函数用于接受学生的id，并据此判断学生在哪个类别，然后产生一个在该类别范围之类的随机数
        /// </summary>
        /// <param name="GroupType_Id"></param>
        //
        public int getOrder(int GroupType_Id , int LabelInfo_Id)
        {
            int order = new int();
            if(GroupType_Id == 1)
            {
                if(LabelInfo_Id == 1 || LabelInfo_Id == 2)
                {
                    order = getGlobeOrder(Shenji_Interview);
                    //Update_NumPool(order , GroupType_Id , LabelInfo_Id);
                }
                if(LabelInfo_Id == 3)
                {
                    order = getGlobeOrder(NotQuan_Interview);
                    //Update_NumPool(order , GroupType_Id , LabelInfo_Id);
                }

                if(LabelInfo_Id == 4)
                {
                    order = getGlobeOrder(Quan_Interview);
                    //Update_NumPool(order , GroupType_Id , LabelInfo_Id);
                }

            }
            if(GroupType_Id == 2)
            {
                if(LabelInfo_Id == 1 || LabelInfo_Id == 2)
                {
                    order = getGlobeOrder(Shenji_English);
                    //Update_NumPool(order , GroupType_Id , LabelInfo_Id);
                }
                if(LabelInfo_Id == 3)
                {
                    order = getGlobeOrder(NotQuan_English);
                    //Update_NumPool(order , GroupType_Id , LabelInfo_Id);
                }

                if(LabelInfo_Id == 4)
                {
                    order = getGlobeOrder(Quan_English);
                    //Update_NumPool(order , GroupType_Id , LabelInfo_Id);
                }
            }
            return order;
        }

        /// <summary>
        /// 该函数用于从参数List中随机抽取一个属，并将该数删去
        /// </summary>
        /// <param name="L"></param>
        public int getGlobeOrder(List<int> L)
        {
            int order = 0;
            Random ra = new Random();
            int index = ra.Next(0 , L.Count);
            order = L[index];
            L.RemoveAt(index);
            return order;
        }

        /// <summary>
        /// 已知面试人ID，面试人在该组的顺序以及改组的ID，更新数据库
        /// </summary>
        /// <param name="CandidateId"></param>
        /// <param name="DataGroupInfoId"></param>
        /// <param name="GlobeOrder"></param>
        public void Update_NumPool(int GlobeOrder , int GroupTypeInfo_Id , int LabelInfo_Id)
        {
            String sql_update = "update Num_Pool set Statu= '" + 1 + "' where GroupTypeInfo_Id = '" + GroupTypeInfo_Id + "' AND LabelInfo_Id = '" + LabelInfo_Id + "' AND GlobeOrder ='" + GlobeOrder + "';";
            try
            {
                DataAccess.sql_command(sql_update);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        /// <summary>
        /// 根据最初的Order所处的区间，选出order所在的InterviewGroupInfo,并计算出在该组排第几
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="order"></param>
        public Tuple<int , int> GetDataGroupInfoId(DataTable dt , int order)
        {
            int InterviewGroupInfo_Id = 0;   //这就是InterviewGroupInfo表里的主键
            int Candidate_LocalOrder = 0;   //面试人在该组排第几个出场
            for(int i = 0 ; i < dt.Rows.Count ; i++)
            {
                if(order >= int.Parse(dt.Rows[i]["Start_Id"].ToString()) && order <= int.Parse(dt.Rows[i]["End_Id"].ToString()))
                {
                    InterviewGroupInfo_Id = int.Parse(dt.Rows[i]["Id"].ToString());
                    Candidate_LocalOrder = order - int.Parse(dt.Rows[i]["Start_Id"].ToString()) + 1;
                    break;
                }

            }
            return new Tuple<int , int>(InterviewGroupInfo_Id , Candidate_LocalOrder);
        }


        /// <summary>
        /// 连接读写器：打开读写器端口->调用读写器固件版本->设置读写器功率与使用频段（地区）->设置读写器天线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connect_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            int status;
            byte v1 = 0;
            byte v2 = 0;
            //string s = "";

            //open comm port//打开读写器端口
            status = Api.OpenCommPort(commport_toolStripComboBox.SelectedItem.ToString());
            if(status != 0)
            {
                MessageBox.Show("获取设备端口失败，请检查设备端口是否正常!");
                return;
            }

            //get firmware version//调用读写器固件版本
            status = Api.GetFirmwareVersion(ref v1 , ref v2);
            if(status != 0)
            {
                MessageBox.Show("无法获取设备固件信息!");
                Api.CloseCommPort();
                return;
            }
            MessageBox.Show("设备连接成功!");

            Connect_ToolStripMenuItem.Enabled = false;//连接成功，连接按钮禁用
            Connect_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            Disconnect_ToolStripMenuItem.Enabled = true;//连接成功，断开连接按钮启用

            pf_ToolStripMenuItem.Enabled = true;//连接成功，功率与频率groupbox启用
            ant_ToolStripMenuItem.Enabled = true;//连接成功，天线设置区域启用

            pfconfig_ToolStripMenuItem_Click(null , null);//连接成功，功率和频率进行默认设置
            antconfig_ToolStripMenuItem_Click(null , null);//连接成功，天线进行默认设置
        }

        /// <summary>
        /// 与读写器断开连接，关闭读写器端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Disconnect_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            Api.CloseCommPort();//关闭读写器端口
            Connect_ToolStripMenuItem.Enabled = true;
            Disconnect_ToolStripMenuItem.Enabled = false;

            pfconfig_ToolStripMenuItem.Enabled = false;
            ant_ToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// 设置读写器功率与使用地区（频段）参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pfset_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            //power range: 0-30
            //power default as 15
            byte power = 15;
            //frequency range: 0-2; 0 for China (920 m ~ 920 m), 1 for American (902 m ~ 902 m), the other for special models (868 m)
            //frequency default as 1;
            byte frequency = 1;

            int status;

            power = (byte) (power_toolStripComboBox.SelectedIndex);
            frequency = (byte) (freqtype_toolStripComboBox.SelectedIndex);
            status = Api.SetRf(power , frequency);

            if(status != 0)
            {
                MessageBox.Show("设置功率与使用地区失败!");
                return;
            }
            MessageBox.Show("设置功率与使用地区成功!");
        }

        /// <summary>
        /// 获取读写器功率与使用地区（频段）参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pfconfig_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            //power range: 0-30//功率范围：0-30
            //power default as 15//功率初始化为15
            byte power = 15;
            //frequency range: 0-2; 0 for China (920 m ~ 920 m), 1 for American (902 m ~ 902 m), the other for special models (868 m)
            //frequency default as 1; 初始化设置，设置为美国
            byte frequency = 1;

            int status;

            status = Api.GetRf(ref power , ref frequency);
            if(status != 0)
            {
                MessageBox.Show("获取功率与使用地区失败！");
                return;
            }
            power_toolStripComboBox.SelectedIndex = power;
            freqtype_toolStripComboBox.SelectedIndex = frequency;
            //MessageBox.Show("Get Power & Freq settings success!");
        }

        /// <summary>
        /// 设置读写器天线参数，开启与关闭读写器天线单元
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void antset_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            //天线具有4天线，任一天线均可用
            byte ant_sel = 0;
            int status;

            if(ant1_ToolStripMenuItem.ForeColor == System.Drawing.Color.Green)
                ant_sel |= 0x01;
            if(ant2_ToolStripMenuItem.ForeColor == System.Drawing.Color.Green)
                ant_sel |= 0x02;
            if(ant3_ToolStripMenuItem.ForeColor == System.Drawing.Color.Green)
                ant_sel |= 0x04;
            if(ant4_ToolStripMenuItem.ForeColor == System.Drawing.Color.Green)
                ant_sel |= 0x08;

            status = Api.SetAnt(ant_sel);
            if(status != 0)
            {
                MessageBox.Show("天线设置失败!请重试。");
                return;
            }
            MessageBox.Show("天线设置成功!");
        }

        /// <summary>
        /// 获取读写器天线配置参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void antconfig_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            byte ant_sel = 0;

            int status;

            status = Api.GetAnt(ref ant_sel);
            if(status != 0)
            {
                MessageBox.Show("获取天线信息失败!");
                return;
            }
            //MessageBox.Show("Get Ant settings success!");

            if((ant_sel & 0x01) == 0x01)
                ant1_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            else
                ant1_ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            if((ant_sel & 0x02) == 0x02)
                ant2_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            else
                ant2_ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            if((ant_sel & 0x04) == 0x04)
                ant3_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            else
                ant3_ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            if((ant_sel & 0x08) == 0x08)
                ant4_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            else
                ant4_ToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
        }

        private void ant1_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            ant1_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
        }

        private void ant2_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            ant2_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
        }

        private void ant3_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            ant3_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
        }

        private void ant4_ToolStripMenuItem_Click(object sender , EventArgs e)
        {
            ant4_ToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
        }

        /// <summary>
        /// 设置datagridview_checkinfo为面试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Major_Click(object sender , EventArgs e)
        {
            GroupType_Id = 1;
            check_view_candidateinfo();
            Refresh_datagridview_checkinfo(GroupType_Id);
            // 初始化 未抽签的list
            try
            {
                string sql_getlist_ShenJi = "SELECT [GlobeOrder] FROM [db_MPACC2018].[dbo].[Num_Pool] WHERE Statu='0' AND LabelInfo_Id<'3' AND GroupTypeInfo_Id='" + GroupType_Id + "'; ";
                DataSet datasets_ShenJi = DataAccess.GetDataSetBySql(sql_getlist_ShenJi);
                foreach(DataRow row in datasets_ShenJi.Tables[0].Rows)
                {
                    Shenji_Interview.Add(Convert.ToInt32(row[0]));
                }
                string sql_getlist_NotQuan = "SELECT [GlobeOrder] FROM [db_MPACC2018].[dbo].[Num_Pool] WHERE Statu='0' AND LabelInfo_Id='3' AND GroupTypeInfo_Id='" + GroupType_Id + "'; ";
                DataSet datasets_NotQuan = DataAccess.GetDataSetBySql(sql_getlist_NotQuan);
                foreach(DataRow row in datasets_NotQuan.Tables[0].Rows)
                {
                    NotQuan_Interview.Add(Convert.ToInt32(row[0]));
                }
                string sql_getlist_Quan = "SELECT [GlobeOrder] FROM [db_MPACC2018].[dbo].[Num_Pool] WHERE Statu='0' AND LabelInfo_Id='4' AND GroupTypeInfo_Id='" + GroupType_Id + "'; ";
                DataSet datasets_Quan = DataAccess.GetDataSetBySql(sql_getlist_Quan);
                foreach(DataRow row in datasets_Quan.Tables[0].Rows)
                {
                    Quan_Interview.Add(Convert.ToInt32(row[0]));
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_datagridview_checkinfo(int GroupType_Id)
        {
            try
            {
                string sql =
                    "SELECT View_CandidateInfo.Candidate_Id,View_CandidateInfo.Candidate_Index,View_CandidateInfo.Candidate_Name,View_CandidateInfo.Label_Name,View_CandidateInfo.InterviewGroup_Id,View_CandidateInfo.Candidate_LocalOrder, View_CandidateInfo.Candidate_GlobeOrder FROM View_CandidateInfo WHERE View_CandidateInfo.GroupTypeInfo_Id = '" + GroupType_Id + "';";
                DataSet datasets_GetCheckInfo = DataAccess.GetDataSetBySql(sql);
                DataTable table_GetCheckInfo = datasets_GetCheckInfo.Tables[0];

                dataGridView_checkinfo.DataSource = table_GetCheckInfo;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 设置datagridview_checkinfo为英语
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_English_Click(object sender , EventArgs e)
        {
            GroupType_Id = 2;

            check_view_candidateinfo();
            try
            {
                string sql =
                    "SELECT View_CandidateInfo.Candidate_Id,View_CandidateInfo.Candidate_Name,View_CandidateInfo.Label_Name,View_CandidateInfo.InterviewGroup_Id,View_CandidateInfo.Candidate_LocalOrder FROM View_CandidateInfo WHERE View_CandidateInfo.GroupTypeInfo_Id = '" + GroupType_Id + "';";
                DataSet datasets_GetCheckInfo = DataAccess.GetDataSetBySql(sql);
                DataTable table_GetCheckInfo = datasets_GetCheckInfo.Tables[0];

                dataGridView_checkinfo.DataSource = table_GetCheckInfo;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            // 初始化 未抽签的list
            try
            {
                string sql_getlist_ShenJi = "SELECT [GlobeOrder] FROM [db_MPACC2018].[dbo].[Num_Pool] WHERE Statu='0' AND LabelInfo_Id<'3' AND GroupTypeInfo_Id='" + GroupType_Id + "'; ";
                DataSet datasets_ShenJi = DataAccess.GetDataSetBySql(sql_getlist_ShenJi);
                foreach(DataRow row in datasets_ShenJi.Tables[0].Rows)
                {
                    Shenji_English.Add(Convert.ToInt32(row[0]));
                }
                string sql_getlist_NotQuan = "SELECT [GlobeOrder] FROM [db_MPACC2018].[dbo].[Num_Pool] WHERE Statu='0' AND LabelInfo_Id='3' AND GroupTypeInfo_Id='" + GroupType_Id + "'; ";
                DataSet datasets_NotQuan = DataAccess.GetDataSetBySql(sql_getlist_NotQuan);
                foreach(DataRow row in datasets_NotQuan.Tables[0].Rows)
                {
                    NotQuan_English.Add(Convert.ToInt32(row[0]));
                }
                string sql_getlist_Quan = "SELECT [GlobeOrder] FROM [db_MPACC2018].[dbo].[Num_Pool] WHERE Statu='0' AND LabelInfo_Id='4' AND GroupTypeInfo_Id='" + GroupType_Id + "'; ";
                DataSet datasets_Quan = DataAccess.GetDataSetBySql(sql_getlist_Quan);
                foreach(DataRow row in datasets_Quan.Tables[0].Rows)
                {
                    Quan_English.Add(Convert.ToInt32(row[0]));
                }
                Refresh_datagridview_checkinfo(GroupType_Id);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 检查View_CandidateInfo是否建立
        /// </summary>
        private void check_view_candidateinfo()
        {
            try
            {
                if(!DataAccess.sql_exist("SELECT View_CandidateInfo.Id FROM View_CandidateInfo"))
                {
                    string sql_creat_view_candidateinfo = "CREATE VIEW dbo.View_CandidateInfo AS SELECT dbo.EnterOrderInfo.Id, dbo.CandidateInfo.Candidate_Index, dbo.CandidateInfo.Candidate_Name, dbo.CandidateInfo.Person_Id,  dbo.labelInfo.Label_Name, dbo.EnterOrderInfo.GroupTypeInfo_Id, dbo.EnterOrderInfo.Candidate_LocalOrder,dbo.EnterOrderInfo.Candidate_GlobeOrder,  dbo.EnterOrderInfo.Candidate_Id, dbo.EnterOrderInfo.InterviewGroup_Id, dbo.CandidateInfo.LabelInfo_Id FROM dbo.EnterOrderInfo INNER JOIN  dbo.CandidateInfo ON dbo.EnterOrderInfo.Candidate_Id = dbo.CandidateInfo.Id INNER JOIN dbo.GroupTypeInfo ON dbo.EnterOrderInfo.GroupTypeInfo_Id = dbo.GroupTypeInfo.Id INNER JOIN dbo.labelInfo ON dbo.CandidateInfo.LabelInfo_Id = dbo.labelInfo.Id;";
                    DataAccess.sql_command(sql_creat_view_candidateinfo);
                }
            }
            catch(Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void dataGridView_checkinfo_CellFormatting(object sender , DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView_checkinfo.Columns[e.ColumnIndex].DataPropertyName == "InterviewGroup_Id")
            {
                string sqlselect = "SELECT [Id],[InterviewGroup_Name] FROM [db_MPACC2018].[dbo].[InterviewGroupInfo];";
                DataSet dataset_interviewgroupinfo = DataAccess.GetDataSetBySql(sqlselect);
                foreach(DataRow row in dataset_interviewgroupinfo.Tables[0].Rows)
                {
                    if(e.Value.ToString() == row[0].ToString().Trim())
                    {
                        e.Value = row[1].ToString().Trim();
                    }
                }
            }
        }

        private void button_output_Click(object sender , EventArgs e)
        {
            SaveFileDialog mySaveFile = new SaveFileDialog();
            DataGridView myDgv = dataGridView_checkinfo;
            Export export = new Export();
            int output_statu = new int();
            output_statu=export.ExportExcel(myDgv , mySaveFile);
            if(output_statu == 0)
            {
                MessageBox.Show("导出成功！");
            }
        }
    }

    //导出类
    public class Export
    {
        ///<summary>
        ///DataGridView导出Excel
        ///</summary>
        ///
        ///<param name="mrDGV">DataGridView控件</param>
        ///<return>0:成功;1:DataGridView中无记录;2:Excel无法启动;9999:异常错误</return>
        public int ExportExcel(DataGridView myDGV , SaveFileDialog savefile)
        {
            int result = 9999;

            savefile.Filter = "Excel files(*.xlsx)|*.xlsx";
            savefile.FilterIndex = 0;
            savefile.RestoreDirectory = true;
            savefile.Title = "Export Excel File";
            if(savefile.ShowDialog() == DialogResult.OK)
            {
                if(savefile.FileName == "")
                {
                    MessageBox.Show("请输入保存文件名称！");
                    savefile.ShowDialog();
                }

                int ColIndex = 0;
                int RowIndex = 0;
                int ColCount = myDGV.ColumnCount;
                int RowCount = myDGV.RowCount;

                //如果DataGridView中没有数据则不进行操作
                if(myDGV.RowCount == 0)
                {
                    result = 1;
                }
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                if(xlApp == null)
                {
                    //Excel无法启动则返回2
                    result = 2;
                }
                try
                {
                    //创建Excel对象
                    Microsoft.Office.Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
                    Microsoft.Office.Interop.Excel.Worksheet xlSheet = (Microsoft.Office.Interop.Excel.Worksheet) xlBook.Worksheets[1];
                    //设置标题
                    Microsoft.Office.Interop.Excel.Range range = xlSheet.get_Range(xlApp.Cells[1 , 1] , xlApp.Cells[1 , ColCount]);
                    range.NumberFormatLocal = "@";
                    //创建缓存数据
                    object[,] objData = new object[RowCount + 1 , ColCount];
                    //获取列标题
                    foreach(DataGridViewColumn col in myDGV.Columns)
                    {
                        objData[RowIndex , ColIndex++] = col.HeaderText;
                    }
                    //获取数据
                    for(RowIndex = 0; RowIndex < RowCount+1 ; RowIndex++)
                    {
                        for(ColIndex = 0 ; ColIndex < ColCount ; ColIndex++)
                        {
                            if(myDGV[ColIndex , RowIndex ].FormattedValueType == typeof(string) || myDGV[ColIndex , RowIndex].FormattedValueType == typeof(DateTime))
                            {
                                objData[RowIndex , ColIndex] = "" + myDGV[ColIndex , RowIndex].FormattedValue;
                            }
                            else
                            {
                                objData[RowIndex , ColIndex] = myDGV[ColIndex , RowIndex].Value;
                                objData[RowIndex, ColIndex] = myDGV[ColIndex, RowIndex].FormattedValue;
                            }
                        }
                        System.Windows.Forms.Application.DoEvents();
                    }
                    range = xlSheet.get_Range(xlApp.Cells[1 , 1] , xlApp.Cells[RowCount+1 , ColCount]);
                    range.Value2 = objData;

                    xlBook.Saved = true;
                    xlBook.SaveCopyAs(savefile.FileName);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    xlApp.Quit();
                    GC.Collect();
                }
                result = 0;
            }
            return result;
        }
    }


}




