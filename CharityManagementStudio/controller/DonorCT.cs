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
    class DonorCT
    {
        Validate vd = new Validate();
        private bool isNotEmpty(DonorMD donorModel)
        {
            if (donorModel.DonorName != "")
            {
                if (donorModel.DonationAmount != "")
                {
                    return true;
                }
                else
                {
                    donorModel.ErrorMessageDonors = "*Donation Amount Cannot be empty";
                    return false;
                }
            }
            else
            {
                donorModel.ErrorMessageDonors = "*Donor Name Cannot be empty";
                return false;
            }
        }

        private bool validateChars(DonorMD donorModel)
        {
            if (vd.validateName(donorModel.DonorName))
            {
                if (vd.validateNumber(donorModel.DonationAmount))
                {
                    return true;
                }
                else
                {
                    donorModel.ErrorMessageDonors = "*Invalid amount";
                    return false;
                }
            }
            else
            {
                donorModel.ErrorMessageDonors = "*Invalid Name";
                return false;
            }
        }

        public bool SaveDonorDetails(DonorMD donorModel)
        {
            if (isNotEmpty(donorModel))
            {
                if (validateChars(donorModel))
                {
                    if (insertData(donorModel))
                    {
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

        public bool smsChecked(DonorMD donorModel)
        {
            if (donorModel.smsChecked)
                return true;
            return false;            
        }

        private bool insertData(DonorMD donorModel)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {

                    Query = "insert into donors_tb values('" + donorModel.DonorName + "','" + donorModel.DonorGuardian + "','" + donorModel.DonorAddress + "','"+donorModel.DonorContact+"','"+donorModel.DonationAmount+ "','"+donorModel.DonationDate+"');";
                    SqlCommand com = new SqlCommand(Query, connect);
                    connect.Open();
                    com.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception e)
            {
                donorModel.ErrorMessageDonors = "Somthing went wrong444! Please try again";
                return false;
            }
        }
    }
}
