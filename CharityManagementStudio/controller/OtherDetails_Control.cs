using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.controller
{
    class OtherDetails_Control
    {
        public string message;
        public bool caseSelected(Other_Details otherDetailsMd)
        {
            if (otherDetailsMd.caseSelectedIndex == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Other_Details details(Other_Details otherDetailsMd)
        {
            Other_Details det = new Other_Details();
            if (otherDetailsMd.reasonForApproaching == "Other")
                det.reasonForApproaching = otherDetailsMd.otherReasonForApproaching;
            else
                det.reasonForApproaching = otherDetailsMd.reasonForApproaching;

            if (otherDetailsMd.WhetherAllreadyRecievingAssistance == "Yes")
            {
                det.WhetherAllreadyRecievingAssistance = "Yes";
                det.BeneficiariesAllreadyRecieving = otherDetailsMd.BeneficiariesAllreadyRecieving;
                det.totalAmountRecieving = otherDetailsMd.totalAmountRecieving;
            }
            else
            {
                det.WhetherAllreadyRecievingAssistance = "No";
                det.BeneficiariesAllreadyRecieving = "";
                det.totalAmountRecieving = "";
            }

            det.caseSelectedIndex = otherDetailsMd.caseSelectedIndex;

            return det;
        }
        private bool saveInDb(Other_Details otherDetailsMd)
        {

            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    otherDetailsMd = details(otherDetailsMd);
                    Query = "insert into other_case_details values('" + otherDetailsMd.reasonForApproaching + "','" + otherDetailsMd.WhetherAllreadyRecievingAssistance + "','" + otherDetailsMd.BeneficiariesAllreadyRecieving + "','" + otherDetailsMd.totalAmountRecieving + "'," + otherDetailsMd.caseSelectedIndex + ")";
                    SqlCommand com = new SqlCommand(Query, connect);
                    connect.Open();
                    com.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool saveOtherDetails(Other_Details otherDetailsMd)
        {
            if (isOtherDetailNotExisting(otherDetailsMd.caseSelectedIndex))
            {
                if (isSelected(otherDetailsMd.reasonForApproaching) && isSelected(otherDetailsMd.WhetherAllreadyRecievingAssistance))
                {
                    if (checkForEmpty(otherDetailsMd))
                    {
                        if (saveInDb(otherDetailsMd))
                            return true;
                        return false;
                    }
                    else
                        return false;
                }
                else
                {
                    this.message = "*Please Select an option from the dropdown";
                    return false;
                }
            }
            else
            {
                this.message = "Details already existing for this Case";
                return false;
            }
        }

        private bool checkForEmpty(Other_Details otherDetailsMd)
        {
            if (otherDetailsMd.reasonForApproaching == "Other")
            {
                if (otherDetailsMd.otherReasonForApproaching == "")
                {
                    this.message = "*Please enter the reason for approaching";
                    return false;

                }
                else
                {

                    if (otherDetailsMd.WhetherAllreadyRecievingAssistance == "Yes")
                    {
                        if (otherDetailsMd.totalAmountRecieving == "" || !new Validate().validateNumber(otherDetailsMd.totalAmountRecieving))
                        {
                            this.message = "*Please enter a valid Amount";
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public bool isOtherDetailNotExisting(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "select count(*) from other_case_details where person_id =" + key;
                    SqlCommand com = new SqlCommand(Query, connect);

                    connect.Open();
                    int count = (int)com.ExecuteScalar();
                    if (count == 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception e)
            {                
                return false;
            }
        }

        private bool isSelected(string val)
        {
            if (val != "Select")
                return true;
            return false;
        }
    }
}
