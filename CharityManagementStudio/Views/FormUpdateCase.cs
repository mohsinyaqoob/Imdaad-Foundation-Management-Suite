using CharityManagementStudio.controller;
using CharityManagementStudio.data;
using CharityManagementStudio.Models;
using CharityManagementStudio.UpdateController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio.Views
{
    public partial class FormUpdateCase : Form
    {

        SqlDataAdapter dataadapter = null;
        DataTable ds = null;
        private BindingSource bindingSource = null;

        string imgLocation;


        public FormUpdateCase()
        {
            InitializeComponent();
            FormNewCase.loadCases(Combo_UpdatePersonal);
            FormNewCase.loadCases(Combo_familyUpdate);
            FormNewCase.loadCases(Combo_BankUpdate);
            //FormNewCase.loadCases(Combo_OtherDetailsUpdate);
            FormNewCase.loadCases(Combo_NeedUpdate);
            FormNewCase.loadCases(ComboBox_RemarksTab);
            


        }

       

        private void Combo_UpdatePersonal_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (Combo_UpdatePersonal.SelectedIndex != 0)
            {
                int keyy = ((KeyValuePair<int, string>)Combo_UpdatePersonal.SelectedItem).Key;
                UpdatePersonalControl person_control = new UpdatePersonalControl();
                Case_Personal_Info person = person_control.getPersonalData(keyy);

                TextBox_FullName.Text = person.fullname;
                TextBox_Guardian.Text = person.guardian;
                TextBox_pAddress.Text = person.p_address;
                TextBox_cAddress.Text = person.c_address;
                TextBox_ContactNumber.Text = person.contact;
                TextBox_Age.Text = person.age;
                TextBox_Aadhaar.Text = person.aadhaar;

                byte[] imageData = person.picture;
                MemoryStream ms = new MemoryStream(imageData);
                ms.Seek(0, SeekOrigin.Begin);                
                Picture_UpdatePhoto.Image = Image.FromStream(ms);
                ms.Flush();
                //Primary Verifier
                //Secodary Verifier

                LabelError_Personl.Text = person.message;
            }

        }

        private void Combo_familyUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Combo_familyUpdate.SelectedIndex != 0)
            {
                int keyy = ((KeyValuePair<int, string>)Combo_familyUpdate.SelectedItem).Key;
                LoadFamilyGrid(keyy);

                // Check if family members have been added allready();
                UpdateFamilyDetails familyCt = new UpdateFamilyDetails();
                if (!familyCt.FamilyDetailsFilled(keyy))
                {
                    MessageBox.Show("Please fill the Family details for this case in 'New Case' Tab and then try to Update", "Family details not Found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void Combo_BankUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Combo_BankUpdate.SelectedIndex != 0)
            {
                int keyy = ((KeyValuePair<int, string>)Combo_BankUpdate.SelectedItem).Key;
                UpdateBankControl bankCt = new UpdateBankControl();
                Case_Bank_Details bank_details = bankCt.getBankData(keyy);

                TextBox_BankName.Text = bank_details.bankName;
                TextBox_BankBranch.Text = bank_details.bankBranch;
                TextBox_IFSC.Text = bank_details.bankIfsc;
                TextBox_AccountNumber.Text = bank_details.bankAccountNumber;
                TextBox_AccountHolder.Text = bank_details.bankAccountHolderName;
                TextBox_AccountType.Text = bank_details.bankAccountType;

                if (TextBox_BankName.Text == "")
                {
                    MessageBox.Show("Please fill the Bank details for this case in 'New Case' Tab and then try to Update", "Bank details not Found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

                label_BankDetails_ErrorMessage.Text = bank_details.bankErrorMessage;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Button_UpdatePersonal.Enabled = true;
        }

        private void Button_UpdatePersonal_Click(object sender, EventArgs e)
        {
            if (Combo_UpdatePersonal.SelectedIndex != 0)
            {

                int key = ((KeyValuePair<int, string>)Combo_UpdatePersonal.SelectedItem).Key;

                Case_Personal_Info personalModel = new Case_Personal_Info();

                personalModel.fullname = TextBox_FullName.Text;
                personalModel.guardian = TextBox_Guardian.Text;
                personalModel.p_address = TextBox_pAddress.Text;
                personalModel.c_address = TextBox_cAddress.Text;
                personalModel.contact = TextBox_ContactNumber.Text;
                personalModel.age = TextBox_Age.Text;
                personalModel.aadhaar = TextBox_Aadhaar.Text;                
                personalModel.caseKey = key;

                MemoryStream stream = new MemoryStream();
                Image img = ImageController.ReduceImg(Picture_UpdatePhoto.Image, 4);
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                personalModel.picture = stream.ToArray();
                stream.Flush();
                

                UpdatePersonalControl updateControl = new UpdatePersonalControl();
                if (updateControl.updateDetails(personalModel))
                {
                    MessageBox.Show(personalModel.message);
                }
                else
                {
                    MessageBox.Show(personalModel.message);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void TextBox_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button_UpdatePersonal.Enabled = true;
        }

        private void Button_SaveBankDetails_Click(object sender, EventArgs e)
        {
            label_BankDetails_ErrorMessage.Text="";

            if (Combo_BankUpdate.SelectedIndex != 0)
            {
                Case_Bank_Details bankModel = new Case_Bank_Details();
                UpdateBankControl bankControl = new UpdateBankControl();

                bankModel.bankName = TextBox_BankName.Text;
                bankModel.bankBranch = TextBox_BankBranch.Text;
                bankModel.bankIfsc = TextBox_IFSC.Text;
                bankModel.bankAccountNumber = TextBox_AccountNumber.Text;
                bankModel.bankAccountHolderName = TextBox_AccountHolder.Text;
                bankModel.bankAccountType = TextBox_AccountType.Text;
                bankModel.bank_caseSelected = ((KeyValuePair<int, string>)Combo_BankUpdate.SelectedItem).Key;

                if (bankControl.UpdateDetails(bankModel))
                {
                    MessageBox.Show(bankModel.bankErrorMessage);
                }
                else
                {
                    MessageBox.Show(bankModel.bankErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Below variables are Initialized at top
        //SqlDataAdapter dataadapter = null; 
        //DataTable ds = null;
        //private BindingSource bindingSource = null;

        private void LoadFamilyGrid(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {

                    Query = "Select id, name as NAME,relation as RELATION,age as AGE,education as EDUCATION,marital_status as 'MARITAL STATUS',occupation as OCCUPATION,income as 'FAMILY INCOME' from family_tb where person_id=" + key;
                    dataadapter = new SqlDataAdapter(Query, con);
                     ds= new DataTable();
                    connect.Open();
                    dataadapter.Fill(ds);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = ds;
                    Grid_UpdateFamily.DataSource = bindingSource;
                    Grid_UpdateFamily.Columns["id"].Visible = false;
                 
                }

            }
            catch (Exception e)
            {
                Label_ErrorFamilyUpdate.Text = "*Not able to retrieve data. Please try again";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Combo_familyUpdate.SelectedIndex != 0)
            {
                try
                {
                    dataadapter.UpdateCommand = new SqlCommandBuilder(dataadapter).GetUpdateCommand();
                    dataadapter.Update(ds);
                    MessageBox.Show("Update Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Somthing went wrong or Invalid characters used");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBox_BankBranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button_SaveBankDetails.Enabled = true;
        }

        private void Button_SaveRemarks_Click(object sender, EventArgs e)
        {
            if (ComboBox_RemarksTab.SelectedIndex != 0)
            {
                int keyy = ((KeyValuePair<int, string>)ComboBox_RemarksTab.SelectedItem).Key;
                //UpdatePersonalControl person_control = new UpdatePersonalControl();
                //Case_Personal_Info person = person_control.getPersonalData(keyy);

                UpdateRemarksControl remarksCt = new UpdateRemarksControl();
                remarksModel remarksMd = remarksCt.getRemarksDetails(keyy);

                remarksMd.startDate = Case_StartDate.Text;
                remarksMd.endDate = Case_EndDate.Text;
                remarksMd.comments = Case_AdditionalComments.Text;
                remarksMd.status = CaseStatus_Remarks.Text;
                remarksMd.caseSelected = keyy;

                if (remarksCt.checkCaseType(remarksMd.caseSelected)) // check if case as Monthly
                {
                    DateTime start_date = Case_StartDate.Value;
                    DateTime end_date = Case_EndDate.Value;
                    end_date = start_date.AddDays(31);
                    Case_EndDate.MinDate = end_date;

                    if (remarksCt.updateData(remarksMd))
                    {
                        MessageBox.Show("Details Updated Successfully");
                    }
                    else
                    {
                         MessageBox.Show(remarksMd.errorMessage);
                    }
                }
                else
                {
                    if (remarksCt.updateData(remarksMd))
                    {
                        MessageBox.Show("Details Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show(remarksMd.errorMessage);
                    }
                }                
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBox_RemarksTab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ComboBox_RemarksTab.SelectedIndex != 0)
            {
                int keyy = ((KeyValuePair<int, string>)ComboBox_RemarksTab.SelectedItem).Key;
                UpdateRemarksControl remarksCt = new UpdateRemarksControl();
                remarksModel remarksMd = remarksCt.getRemarksDetails(keyy);


                //if (remarksMd.startDate==null || remarksMd.endDate == null)
                //{
                //    MessageBox.Show("Please fill the Remarks details for this case in 'New Case' Tab and then try to Update", "Remarks details not Found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //}
                if (remarksMd.comments == "")
                {
                    MessageBox.Show("Please fill the Remarks details for this case in 'New Case' Tab and then try to Update", "Remarks details not Found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Case_StartDate.Value = DateTime.Parse(remarksMd.startDate);
                        Case_EndDate.Value = DateTime.Parse(remarksMd.endDate);

                        Case_AdditionalComments.Text = remarksMd.comments;
                        CaseStatus_Remarks.SelectedItem = remarksMd.status;
                        //LabelError_Personl.Text = person.message;
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void Button_DeleteCaseEntirely_Click(object sender, EventArgs e)
        {
            UpdatePersonalControl upd = new UpdatePersonalControl();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this case from the database?", "Delete Case", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Yes)
            {
                if (Combo_UpdatePersonal.SelectedIndex != 0)
                {
                    int keyy = ((KeyValuePair<int, string>)Combo_UpdatePersonal.SelectedItem).Key;
                    upd.deleteEntireCase(keyy);
                    MessageBox.Show(upd.error);

                    this.Close();
                    FormMainProfile.updateCase = null;
                    new FormMainProfile().Show();                    
                }
                else
                {
                    MessageBox.Show("Please select a Case from the dropdown");
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void Combo_NeedUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Combo_NeedUpdate.SelectedIndex != 0)
            {
                int keyy = ((KeyValuePair<int, string>)Combo_NeedUpdate.SelectedItem).Key;
                loadNeedTabGrid(keyy);

                // Check if family members have been added allready();
                // UpdateFamilyDetails familyCt = new UpdateFamilyDetails();
                UpdateNeedDetailsControl needCt = new UpdateNeedDetailsControl();

                if (!needCt.NeedDetailsFilled(keyy))
                {
                    MessageBox.Show("Please fill the Family details for this case in 'New Case' Tab and then try to Update", "Family details not Found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
        private void loadNeedTabGrid(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {

                    Query = "Select id, monthly as Monthly,medical_assistence as 'Medical Assistance',marriage_fund as 'Marriage Fund',employ_fund as 'Employment Fund',otr_fund as 'One-Time Fund',other_fund as 'Other Fund' from need_details where person_id=" + key;
                    dataadapter = new SqlDataAdapter(Query, con);
                    ds = new DataTable();
                    connect.Open();
                    dataadapter.Fill(ds);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = ds;
                    DataGrid_NeedUpdate.DataSource = bindingSource;
                    DataGrid_NeedUpdate.Columns["id"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //Label_ErrorFamilyUpdate.Text = "*Not able to retrieve data. Please try again";
            }
        }

        private void Button_Save_NeedTab_Click(object sender, EventArgs e)
        {
            if (Combo_NeedUpdate.SelectedIndex != 0)
            {

                try
                {
                    dataadapter.UpdateCommand = new SqlCommandBuilder(dataadapter).GetUpdateCommand();
                    dataadapter.Update(ds);
                    MessageBox.Show("Need Details Updated Successfully", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Somthing went wrong or Invalid characters used");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Title = "Update Photo";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLocation = open.FileName.ToString();
                Picture_UpdatePhoto.ImageLocation = imgLocation;
            }  
        }
    }
}
