SELECT 
	p.fullname AS Name,
	p.contact_no AS Contact,
	p.c_address AS 'Current Address',
    o.reason  as 'Approaching Reason' , 
	r.status as Status FROM personal_info p 
JOIN other_case_details o ON p.id=o.person_id 
join remarks_tb r on p.id=r.person_id


select * from personal_info

select * from other_case_details