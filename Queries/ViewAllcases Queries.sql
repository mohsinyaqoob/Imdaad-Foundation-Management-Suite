SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address 
AS 'Current Address', o.reason  as 'Approaching Reason' , r.status 
as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id

SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address 
AS 'Current Address', o.reason  as 'Approaching Reason' , r.status 
as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where n.monthly>0

SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address', o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where r.status='Rejected';

SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address', o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where r.status='Verified';

SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address', o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where r.status='Pending';


