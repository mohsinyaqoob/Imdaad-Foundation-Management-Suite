create view monthly_view_enddate 
as
select b.person_id, account_holder AS Name,name AS Bank,bank_branch AS Branch,account_no AS 'Account Number',monthly as 'Amount' from bank_tb b join need_details n on b.person_id=n.person_id
		where b.person_id in (select person_id from need_details where monthly>0 and person_id in(select person_id from remarks_tb where endDate>=GETDATE() and status='Verified')) 

select person_id from remarks_tb where endDate>=GETDATE() and status='Verified'