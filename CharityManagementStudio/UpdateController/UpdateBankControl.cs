using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.securities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementStudio.UpdateController
{
    class UpdateBankControl
    {
        string connection;
        public UpdateBankControl()
        {
            connection = DbContext.ConnectDb();
        }
        public Case_Bank_Details getBankData(int id)
        {
            string query = "Select * from bank_tb where person_id=" + id;
            Case_Bank_Details bank = new Case_Bank_Details();
            try
            {
                using (SqlConnection connect = new SqlConnection(this.connection))
                {
                    connect.Open();
                    SqlCommand com = new SqlCommand(query, connect);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        bank.bankName = reader["name"].ToString();
                        bank.bankBranch = reader["bank_branch"].ToString();
                        bank.bankIfsc = reader["ifsc"].ToString();
                        bank.bankAccountNumber = reader["account_no"].ToString();
                        bank.bankAccountHolderName = reader["account_holder"].ToString();
                        bank.bankAccountType = reader["account_type"].ToString();                        
                    }
                    return bank;
                }
            }
            catch (Exception e)
            {
                bank.bankErrorMessage = e.Message;
                return bank;
            }
        }


        public bool UpdateDetails(Case_Bank_Details bankModel)
        {
            if (checkForEmpty(bankModel))
            {
                if (validateChars(bankModel))
                {
                    if (insertData(bankModel))
                    {
                        bankModel.bankErrorMessage = "Details Updated Successfully";
                        return true;
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
            else
            {
                return false;
            }            
        }

        private bool checkForEmpty(Case_Bank_Details bankModel)
        {
            if(bankModel.bankName==""|| bankModel.bankBranch=="" || bankModel.bankAccountNumber == "" || bankModel.bankAccountNumber == "")
            {
                bankModel.bankErrorMessage = "Feilds marked with * cannot be blank";
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool validateChars(Case_Bank_Details bankModel)
        {
            Validate vd = new Validate();

            if (vd.validateAddress(bankModel.bankName))
            {
                if (vd.validateAddress(bankModel.bankBranch))
                {
                    if (vd.validateEducation(bankModel.bankIfsc))
                    {
                        if (vd.validateNumber(bankModel.bankAccountNumber))
                        {
                            if (vd.validateName(bankModel.bankAccountHolderName))
                            {
                                if (vd.validateName(bankModel.bankAccountType))
                                {
                                    return true;
                                    //insert
                                }
                                else
                                {
                                    bankModel.bankErrorMessage = "Invalid Account Type";
                                    return false;
                                }
                            }
                            else
                            {
                                bankModel.bankErrorMessage = "Invalid Account Holder's Name";
                                return false;
                            }
                        }
                        else
                        {
                            bankModel.bankErrorMessage = "Invalid Account Nnumber";
                            return false;
                        }
                    }
                    else
                    {
                        bankModel.bankErrorMessage = "Invalid IFSC";
                        return false;
                    }
                }
                else
                {
                    bankModel.bankErrorMessage = "Invalid Branch Name";
                    return false;
                }
            }
            else
            {
                bankModel.bankErrorMessage = "Invalid Bank Name";
                return false;
            }
        }

        private bool insertData(Case_Bank_Details bankModel)
        {
            string Query = "";
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    Query = "UPDATE bank_tb SET name='" + bankModel.bankName + "', bank_branch='" + bankModel.bankBranch + "', ifsc='" + bankModel.bankIfsc + "',account_no='" + bankModel.bankAccountNumber + "',account_holder='" + bankModel.bankAccountHolderName + "',account_type='" + bankModel.bankAccountType + "' WHERE person_id="+bankModel.bank_caseSelected;
                    SqlCommand com = new SqlCommand(Query, connect);

                    connect.Open();
                    com.ExecuteNonQuery();                   
                    return true;
                }
            }
            catch (Exception e)
            {
                bankModel.bankErrorMessage = e.Message;
                return false;
            }
        }
    }
}
