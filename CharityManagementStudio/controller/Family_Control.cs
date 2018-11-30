using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio.controller
{
    class Family_Control
    {
        public string message;
        private string con;

        private bool checkForEmpty(Case_Family_info case_family)
        {
            if (case_family.familyMemberName == "" || case_family.familyMemberRelation=="" || case_family.familyMemberOccupation=="" || case_family.familyMemberIncome == "")
            {
                case_family.familyMemberInfo_ErrorMessage = "*Please fill all the feilds marked with *";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateForChars(Case_Family_info case_family)
        {
            Validate validateChars = new Validate();

            if(validateChars.validateName(case_family.familyMemberName))
            {
                if (validateChars.validateName(case_family.familyMemberRelation)) //validating Relation using validateName() function.
                {
                    if (validateChars.validateNumber(case_family.familyMemberAge)) //validating Age using validateNumber() function.
                    {
                            if (validateChars.validateName(case_family.familyMemberMaritalStatus)) //validating MaritalStatus using validateName() function.
                            {
                                if (validateChars.validateName(case_family.familyMemberOccupation)) //validating Occupation using ValidateAddress() function.
                                {
                                    if (validateChars.validateNumber(case_family.familyMemberIncome)) //validating Income using ValidateNumber() function.
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        case_family.familyMemberInfo_ErrorMessage = "*Invalid Income";
                                        return false;
                                    }
                                }
                                else
                                {
                                    case_family.familyMemberInfo_ErrorMessage = "*Invalid Occupation";
                                    return false;
                                }
                            }
                            else
                            {
                                case_family.familyMemberInfo_ErrorMessage = "*Invalid Marital Status";
                                return false;
                            }
                      
                    }
                    else
                    {
                        case_family.familyMemberInfo_ErrorMessage = "*Invalid Age";
                        return false;
                    }
                }
                else
                {
                    case_family.familyMemberInfo_ErrorMessage = "*Invalid Relation";
                    return false;
                }
            }
            else
            {
                case_family.familyMemberInfo_ErrorMessage = "*Invalid Name";
                return false;
            }            
        }

        public bool SaveFamilyDetails(Case_Family_info case_family)
        {
            if (checkForEmpty(case_family))
            {
                if (validateForChars(case_family))
                {
                    if(insertFamily(case_family))
                        return true;
                    return false;
                }
                else
                    return false;

            }
            else
                return false;

        }

        private bool insertFamily(Case_Family_info case_family)
        {
            string Query = "";
                try
                {
                    con = DbContext.ConnectDb();

                    using (SqlConnection connect = new SqlConnection(con))
                    {

                        Query = "insert into family_tb values('"+case_family.familyMemberName+"','"+case_family.familyMemberRelation+"','"+case_family.familyMemberAge+"','"+case_family.familyMemberEducation+"','"+case_family.familyMemberMaritalStatus+"','"+case_family.familyMemberOccupation+"','"+case_family.familyMemberIncome+"',"+case_family.familyMemberInfo_CaseSelected+");";
                        SqlCommand com = new SqlCommand(Query, connect);
                        connect.Open();
                        com.ExecuteNonQuery();
                    
                                            
                        
                        case_family.familyMemberInfo_ErrorMessage = case_family.familyMemberName+"-This Member was added successfully";
                        return true;
                    }
                }
                catch (Exception e)
                {
                //case_family.familyMemberInfo_ErrorMessage = case_family.familyMemberInfo_CaseSelected.ToString();
                //case_family.familyMemberInfo_ErrorMessage = "Something went wrong .. please try again";
                case_family.familyMemberInfo_ErrorMessage = e.Message;
                return false;
                }
          }      

        public bool CaseSelected(Case_Family_info case_family)
        {
            if (case_family.familyMemberInfo_CaseSelected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
