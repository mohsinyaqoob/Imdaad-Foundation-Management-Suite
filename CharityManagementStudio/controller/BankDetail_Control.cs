using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using CharityManagementStudio.data;
using System.Data.SqlClient;

namespace CharityManagementStudio.controller
{
    class BankDetail_Control
    {
        public static string con;
        private bool checkForEmpty(Case_Bank_Details bankDetails)
        {
            if (bankDetails.bankName != "" && bankDetails.bankBranch != "" && bankDetails.bankAccountNumber != "" && bankDetails.bankAccountHolderName != "")
            {
                return true;
            }
            else
            {
                bankDetails.bankErrorMessage = "*Please fill all feilds marke with *";
                return false;
            }
        }

        private bool checkForChars(Case_Bank_Details bankDetails)
        {
            Validate valid = new Validate();

            if (valid.validateAddress(bankDetails.bankName)) //Validate Bank name using ValidateAddress(); Function
            {
                if (valid.validateAddress(bankDetails.bankBranch)) //Validate Bank Branch using ValidateAddress(); Function
                {
                   
                        if (valid.validateNumber(bankDetails.bankAccountNumber)) //Validate Account Number using ValidateNumber(); Function
                        {
                            if(valid.validateName(bankDetails.bankAccountHolderName))
                            {
                                return true;
                            }
                            else
                            {
                                bankDetails.bankErrorMessage = "*Invalid Account Holder Name!";
                                return false;
                            }
                        }
                        else
                        {
                            bankDetails.bankErrorMessage = "*Invalid Account Number!";
                            return false;
                        }
                }
                else
                {
                    bankDetails.bankErrorMessage = "*Invalid Branch Name!";
                    return false;
                }
            }
            else
            {
                bankDetails.bankErrorMessage = "*Invalid Bank Name!";
                return false;
            }
        }

        private bool insertBankDetails(Case_Bank_Details bankDetails)
        {
            string Query = "";
            try
            {
                con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "insert into bank_tb values('" + bankDetails.bankName+ "','" + bankDetails.bankBranch + "','" + bankDetails.bankIfsc + "','" + bankDetails.bankAccountNumber+ "','" + bankDetails.bankAccountHolderName + "','" + bankDetails.bankAccountType + "','" + bankDetails.bank_caseSelected + "')";
                    SqlCommand com = new SqlCommand(Query, connect);

                    connect.Open();
                    com.ExecuteNonQuery();
                  
                    return true;
                }

            }
            catch (Exception e)
            {
                bankDetails.bankErrorMessage = "*Somthing went wrong! Please try again.";                
                return false;
            }
        }

        public bool SaveBankDetails(Case_Bank_Details bankDetails)
        {
            if (checkForEmpty(bankDetails))
            {
                if (checkForChars(bankDetails))
                {
                    if (this.isBankDetailNotExisting(bankDetails.bank_caseSelected))
                    {
                        if (insertBankDetails(bankDetails))
                        {
                            bankDetails.bankErrorMessage = "Bank Details Added Successfully!";
                            return true;
                        }
                        else
                        {
                            //bankDetails.bankErrorMessage = "**Somthing went wrong! Please try again";
                            return false;
                        }
                    }
                    else
                    {
                        bankDetails.bankErrorMessage = "**Bank Detail Already Existing";
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }              

        public bool caseSelected(Case_Bank_Details bankDetails)
        {
            if (bankDetails.bank_caseSelected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isBankDetailNotExisting(int key)
        {
            string Query = "";
            try
            {
                con = DbContext.ConnectDb();
                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "select count(*) from bank_tb where person_id ="+key;
                    SqlCommand com = new SqlCommand(Query, connect);

                    connect.Open();
                    int count=(int)com.ExecuteScalar();
                    if (count == 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception e)
            {
               // bankDetails.bankErrorMessage = "*Somthing went wrong! Please try again.";
                return false;
            }
        }
    }
}
