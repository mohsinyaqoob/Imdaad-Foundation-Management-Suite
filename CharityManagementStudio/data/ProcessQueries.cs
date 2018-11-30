using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.data
{
    class ProcessQueries
    {
        public string AllCases = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address', o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id;";

        public string OnlyMonthly = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id= p.id where n.monthly>0";
        public string OnlyMedical = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id= p.id where n.medical_assistence>0";
        public string OnlyMarriage = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where n.marriage_fund>0";
        public string OnlyEmploymentAssistance = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where n.employ_fund>0";
        public string OnlyOneTimeCases = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where n.otr_fund>0";
        public string OnlyOtherFundingCases = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where n.other_fund>0";
        public string AllRejectedCases = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where r.status='Rejected';";
        public string AllVerifiedCases = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where r.status='Verified';";
        public string AllPendingCases = "SELECT p.fullname AS Name,p.guardian AS Guardian, p.contact_no AS Contact,p.c_address AS 'Current Address',p.verifier AS Verifier, o.reason  as 'Approaching Reason' , r.status as Status FROM personal_info p JOIN other_case_details o ON p.id=o.person_id join remarks_tb r on p.id=r.person_id join need_details n on n.person_id=p.id where r.status='Pending';";
        public string All_including_incomplete = "SELECT id AS 'Case ID', fullname AS Name, guardian AS Guardian, c_address AS 'Current Address', contact_no AS Contact,verifier AS Verifier  from personal_info";
    }
}
