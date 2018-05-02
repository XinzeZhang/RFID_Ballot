use db_MPACC2018;
update Num_Pool set Statu = '0';
update View_CandidateInfo set InterviewGroup_Id = NULL;
update EnterOrderInfo set InterviewGroup_Id = NULL;
update EnterOrderInfo set Candidate_GlobeOrder = NULL;
update EnterOrderInfo set Candidate_LocalOrder = NULL;