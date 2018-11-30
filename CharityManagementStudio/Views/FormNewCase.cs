using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharityManagementStudio.Models;
using CharityManagementStudio.controller;
using System.Data.SqlClient;
using CharityManagementStudio.data;
using SmsClient;
using CharityManagementStudio.SMS_Services;
using System.Drawing.Imaging;
using System.IO;

namespace CharityManagementStudio.Views
{
    public partial class FormNewCase : Form
    {
        FormViewAllCases viewAll = new FormViewAllCases();
        string imgLocation;

        public FormNewCase()
        {
            InitializeComponent();

            ComboBox_ReasonForApproaching.SelectedIndex = 0;
            ComboBox_RevievingAssistance.SelectedIndex = 0;
            CaseStatus_Remarks.SelectedIndex = 0;

            loadCases(combo_bank);
            loadCases(ComboSelectCase);
            loadCases(comboBox_otherDetails);
            loadCases(NeedTab_ComboBoxCases);
            loadCases(ComboBox_RemarksTab);
            loadVerifiers(Combo_PersonalInfo_Verifier);
            loadVerifiers(Combo_SecondaryVerifier);

            //viewAll.loadGrid_Cases();
            Case_StartDate.Value = System.DateTime.Now;
            Case_StartDate.MinDate = System.DateTime.Now;

          
        }        

        public static void loadVerifiers(ComboBox combo)
        {
            List<AddTeamModel> caselist = new AddTeamController().getTeam();
            if (caselist != null)
            {
                // ComboSelectCase.Items.Clear();
                Dictionary<long, string> comboSource = new Dictionary<long, string>();
                comboSource.Add(0, "--Select a Verifier--");
                foreach (AddTeamModel mycase in caselist)
                {
                    comboSource.Add(Convert.ToInt64(mycase.teamMemberContact),  mycase.teamMemberName);
                }
                combo.DataSource = new BindingSource(comboSource, null);
                combo.DisplayMember = "Value";
                combo.ValueMember = "Key";
                caselist = null;
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong. Try Again","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }
        public static void loadCases(ComboBox selectCombo)
        {
            List<Case_Personal_Info> caselist = new case_Control().getAllCases();
            if (caselist != null)
            {
                // ComboSelectCase.Items.Clear();
                Dictionary<int, string> comboSource = new Dictionary<int, string>();
                comboSource.Add(0, "--Select a Case--");
                foreach (Case_Personal_Info mycase in caselist)
                {
                    comboSource.Add(mycase.id, "CASE-" + mycase.id + " / " + mycase.fullname + " / " + mycase.guardian + " / " + mycase.c_address);
                }
                selectCombo.DataSource = new BindingSource(comboSource, null);
                selectCombo.DisplayMember = "Value";
                selectCombo.ValueMember = "Key";
                caselist = null;
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong. Try Again", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.newCase != null)
                FormMainProfile.newCase = null;
            this.Close();
        }

        private void ComboBox_ReasonForApproaching_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ComboBox_ReasonForApproaching.SelectedIndex != 8)
            {
                TextBox_OtherReason.Enabled = false;
                Label_otherReasonForApproaching.Visible = false;
            }
            else
            {
                TextBox_OtherReason.Enabled = true;
                Label_otherReasonForApproaching.Visible = true;
            }
        }

        private void ComboBox_RevievingAssistance_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (ComboBox_RevievingAssistance.SelectedIndex == 1)
            {
                TextBox_AllreadyBenificiary.Enabled = true;
                Label_NameOfBenif.Visible = true;
                TextBox_TotalAmountRecieving.Enabled = true;
                Label_AmountRecieving.Visible = true;
            }
            else
            {
                Label_NameOfBenif.Visible = false;
                TextBox_AllreadyBenificiary.Enabled = false;
                TextBox_TotalAmountRecieving.Enabled = false;
                Label_AmountRecieving.Visible = false;
            }
        }

        private void clearPersonalInfo()
        {
            TextBox_FullName.Text = "";
            TextBox_Guardian.Text = "";
            TextBox_pAddress.Text = "";
            TextBox_cAddress.Text = "";
            TextBox_Age.Text = "";
            TextBox_ContactNumber.Text = "";
            TextBox_Aadhaar.Text = "";
        }

        private void case_personal_btn_Click(object sender, EventArgs e)
        {
            if (Combo_PersonalInfo_Verifier.SelectedIndex != 0)
            {
                Cursor.Current = Cursors.WaitCursor;

                Label_ErrorMessagePersonalInfo.Text = "";
                Case_Personal_Info case_new = new Case_Personal_Info();
                case_new.fullname = TextBox_FullName.Text;
                case_new.guardian = TextBox_Guardian.Text;
                case_new.p_address = TextBox_pAddress.Text;
                case_new.c_address = TextBox_cAddress.Text;
                case_new.age = TextBox_Age.Text;
                case_new.contact = TextBox_ContactNumber.Text;
                case_new.aadhaar = TextBox_Aadhaar.Text;
                

                //SMS Checkboxes below
                case_new.SMSCheckBox = CheckBox_SendSMS.Checked;

                case_new.verifier = Combo_PersonalInfo_Verifier.SelectedValue.ToString();
                case_new.secondary_verifier = Combo_SecondaryVerifier.SelectedValue.ToString();

                MemoryStream stream = new MemoryStream();

                Image img = ImageController.ReduceImg(PictureBox_Photo.Image, 5);
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                case_new.picture = stream.ToArray();
                stream.Flush();
                case_Control c_con = new case_Control();

                if (c_con.checkForEmpty(case_new))
                {
                    if (c_con.validateForChars(case_new))
                    {
                        if (c_con.InsertPersonalInf(case_new))
                        {
                            if (c_con.smsChecked(case_new))
                            {
                                NotifySMS sms = new NotifySMS();

                                if (sms.loginSMS())
                                {
                                    //long contact = ((KeyValuePair<long, string>)Combo_PersonalInfo_Verifier.SelectedItem).Key;
                                    if (sms.notifyViaSMS(case_new))
                                    {
                                        MessageBox.Show("SMS Notification has been Sent Successfully", "SMS Sent",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("The SMS Notification was not Sent. Make sure you are connected to the internet.", "SMS not Sent", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The SMS Login Failed.", "Message Not Sent",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                                }
                            }

                            clearPersonalInfo();

                            MessageBox.Show("Registration Success. Switch tabs to fill more details.", "Successfully Registered",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                            loadCases(ComboSelectCase);
                            loadCases(combo_bank);
                            loadCases(comboBox_otherDetails);
                            loadCases(NeedTab_ComboBoxCases);
                            loadCases(ComboBox_RemarksTab);

                            //viewAll.loadGrid_Cases();
                        }
                        else
                        {
                            Label_ErrorMessagePersonalInfo.Text = case_new.message;
                        }
                    }
                    else
                    {
                        Label_ErrorMessagePersonalInfo.Text = case_new.message;
                    }
                }
                else
                {
                    Label_ErrorMessagePersonalInfo.Text = case_new.message;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Verifier for this Case","Verifier Not Selected",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }




        private void Button_NewCaseClose1_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.newCase != null)
                FormMainProfile.newCase = null;
            this.Close();
        }

        private void Button_NewCaseClose2_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.newCase != null)
                FormMainProfile.newCase = null;
            this.Close();
        }

        private void Button_NewCaseClose3_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.newCase != null)
                FormMainProfile.newCase = null;
            this.Close();
        }

        private void Button_NewCaseClose4_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.newCase != null)
                FormMainProfile.newCase = null;
            this.Close();
        }

        private void Button_NewCaseClose5_Click(object sender, EventArgs e)
        {
            if (FormMainProfile.newCase != null)
                FormMainProfile.newCase = null;
            this.Close();
        }

        private void Button_SaveFamilyMember_Click(object sender, EventArgs e)
        {
            LabelErrorMessageFamilyDetails.Text = "";

            Case_Family_info familyInfo = new Case_Family_info(); // Object of Model Class
            Family_Control fm = new Family_Control(); // Object of Controller Class

            familyInfo.familyMemberInfo_CaseSelected = ComboSelectCase.SelectedIndex; // Setting the Value for ComboSelectCase Variable of Model Class

            if (fm.CaseSelected(familyInfo)) // Check if case is selected, by calling the function of controller class, If true then set other values
            {
                familyInfo.familyMemberName = TextBox_FamilyMemberName.Text;
                familyInfo.familyMemberRelation = TextBox_FamilyMemberRelation.Text;
                familyInfo.familyMemberAge = TextBox_FamilyMemberAge.Text;
                familyInfo.familyMemberEducation = TextBox_FamilyMemberEducation.Text;
                familyInfo.familyMemberMaritalStatus = TextBox_FamilyMemberMaritalStatus.Text;
                familyInfo.familyMemberOccupation = TextBox_FamilyMemberOccupation.Text;
                familyInfo.familyMemberIncome = TextBox_FamilyMemberIncome.Text;
                familyInfo.familyMemberInfo_CaseSelected = ((KeyValuePair<int, string>)ComboSelectCase.SelectedItem).Key;

                if (fm.SaveFamilyDetails(familyInfo))
                {
                    LabelErrorMessageFamilyDetails.Text = familyInfo.familyMemberInfo_ErrorMessage;
                    LoadFamilyGrid(((KeyValuePair<int, string>)ComboSelectCase.SelectedItem).Key);

                    clearFamilyInfo(); // Clears the text feilds
                }
                else
                {
                    LabelErrorMessageFamilyDetails.Text = familyInfo.familyMemberInfo_ErrorMessage;
                }
            }
            else // Else case is not selected. Because the selected Index of combo box ins still 0. HEnce the mesage!
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadBankGrid(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "Select name as BANK,bank_branch as BRANCH, ifsc as IFSC, account_no as 'ACCOUNT NO.', account_holder as 'ACCOUNT HOLDER', account_type as 'ACCOUNT TYPE' from bank_tb where person_id=" + key;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "bank_tb");
                    dataGrid_bank.DataSource = ds;
                    dataGrid_bank.DataMember = "bank_tb";
                }

            }
            catch (Exception e)
            {
                label_BankDetails_ErrorMessage.Text = "*Not able to retrieve data. Please try again";
            }
        }

        private void loadOtherDetails_Grid(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "Select reason as 'Reason for Approaching',whether_receiving as 'Whether allready recieving', recieving_benef as 'Benefeciaries Recieving', amount as 'Amount Recieving Allready' from other_case_details where person_id=" + key;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "other_case_details");
                    dataGrid_otherDetails.DataSource = ds;
                    dataGrid_otherDetails.DataMember = "other_case_details";
                }

            }
            catch (Exception e)
            {
                //LabelErrorMessage_OtherDetails.Text = "*Not able to retrieve data. Please try again";
                LabelErrorMessage_OtherDetails.Text = e.Message;
            }
        }

        private void LoadFamilyGrid(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {

                    Query = "Select name as NAME,relation as RELATION,age as AGE,education as EDUCATION,marital_status as 'MARITAL STATUS',occupation as OCCUPATION,income as 'FAMILY INCOME' from family_tb where person_id=" + key;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "family_tb");
                    familyGrid.DataSource = ds;
                    familyGrid.DataMember = "family_tb";
                }

            }
            catch (Exception e)
            {
                LabelErrorMessageFamilyDetails.Text = "*Not able to retrieve data. Please try again";
            }
        }

        private void ComboSelectCase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int keyy = ((KeyValuePair<int, string>)ComboSelectCase.SelectedItem).Key;
            LoadFamilyGrid(keyy);
        }

        private void clearFamilyInfo()
        {
            TextBox_FamilyMemberName.Text = "";
            TextBox_FamilyMemberRelation.Text = "";
            TextBox_FamilyMemberAge.Text = "";
            TextBox_FamilyMemberEducation.Text = "";
            TextBox_FamilyMemberMaritalStatus.Text = "";
            TextBox_FamilyMemberOccupation.Text = "";
            TextBox_FamilyMemberIncome.Text = "";
        }

        private void clearBankDetails()
        {
            TextBox_BankName.Text = "";
            TextBox_BankBranch.Text = "";
            TextBox_IFSC.Text = "";
            TextBox_AccountNumber.Text = "";
            TextBox_AccountHolder.Text = "";
            TextBox_AccountType.Text = "";
        }

        private void Button_SaveBankDetails_Click(object sender, EventArgs e)
        {
            label_BankDetails_ErrorMessage.Text = "";

            BankDetail_Control BankControl = new BankDetail_Control();
            Case_Bank_Details bankDetails = new Case_Bank_Details();

            bankDetails.bank_caseSelected = combo_bank.SelectedIndex;

            if (BankControl.caseSelected(bankDetails))
            {
                bankDetails.bankName = TextBox_BankName.Text;
                bankDetails.bankBranch = TextBox_BankBranch.Text;
                bankDetails.bankIfsc = TextBox_IFSC.Text;
                bankDetails.bankAccountNumber = TextBox_AccountNumber.Text;
                bankDetails.bankAccountHolderName = TextBox_AccountHolder.Text;
                bankDetails.bankAccountType = TextBox_AccountType.Text;
                bankDetails.bank_caseSelected = ((KeyValuePair<int, string>)combo_bank.SelectedItem).Key;

                if (BankControl.SaveBankDetails(bankDetails))
                {
                    label_BankDetails_ErrorMessage.Text = bankDetails.bankErrorMessage;
                    LoadBankGrid(((KeyValuePair<int, string>)ComboSelectCase.SelectedItem).Key);
                    LoadBankGrid(((KeyValuePair<int, string>)combo_bank.SelectedItem).Key);
                    clearBankDetails();
                }
                else
                {
                    label_BankDetails_ErrorMessage.Text = bankDetails.bankErrorMessage;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_bank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int keyy = ((KeyValuePair<int, string>)combo_bank.SelectedItem).Key;
            LoadBankGrid(keyy);
        }

        private void Button_Save_OtherDetails_Click(object sender, EventArgs e)
        {
            LabelErrorMessage_OtherDetails.Text = "";
            OtherDetails_Control otherDetailsCtr = new OtherDetails_Control();
            Other_Details otherDetailsMd = new Other_Details();

            otherDetailsMd.caseSelectedIndex = comboBox_otherDetails.SelectedIndex;
            if (otherDetailsCtr.caseSelected(otherDetailsMd))
            {

                otherDetailsMd.reasonForApproaching = ComboBox_ReasonForApproaching.SelectedItem.ToString();
                otherDetailsMd.otherReasonForApproaching = TextBox_OtherReason.Text;
                otherDetailsMd.WhetherAllreadyRecievingAssistance = ComboBox_RevievingAssistance.SelectedItem.ToString();
                otherDetailsMd.BeneficiariesAllreadyRecieving = TextBox_AllreadyBenificiary.Text;
                otherDetailsMd.totalAmountRecieving = TextBox_TotalAmountRecieving.Text;
                otherDetailsMd.caseSelectedIndex = ((KeyValuePair<int, string>)comboBox_otherDetails.SelectedItem).Key;
                if (otherDetailsCtr.saveOtherDetails(otherDetailsMd))
                {
                    LabelErrorMessage_OtherDetails.Text = "Data Saved Successfully";
                    LabelErrorMessage_OtherDetails.Text = otherDetailsCtr.message;
                    loadOtherDetails_Grid(((KeyValuePair<int, string>)comboBox_otherDetails.SelectedItem).Key);
                    //Clear Textboxes Now
                }
                else
                {
                    LabelErrorMessage_OtherDetails.Text = otherDetailsCtr.message;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Below are "Need Tab" CheckStateChange Events for Controls

        private void CheckBox_MonthlyAssistance_CheckStateChanged_1(object sender, EventArgs e)
        {

            if (CheckBox_MonthlyAssistance.Checked)
            {
                Text_MonthlyAssistanceAmount.Enabled = true;
            }
            else
            {
                Text_MonthlyAssistanceAmount.Enabled = false;
                Text_MonthlyAssistanceAmount.Text = "";

            }
        }

        private void CheckBox_MedicalAssistance_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_MedicalAssistance.Checked)
            {
                Text_MedicalAssistanceAmount.Enabled = true;
            }
            else
            {
                Text_MedicalAssistanceAmount.Enabled = false;
                Text_MedicalAssistanceAmount.Text = "";
            }
        }

        private void CheckBox_MarriageAssistance_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_MarriageAssistance.Checked)
            {
                Text_MarriageAssistanceAmount.Enabled = true;
            }
            else
            {
                Text_MarriageAssistanceAmount.Enabled = false;
                Text_MarriageAssistanceAmount.Text = "";
            }
        }

        private void CheckBox_EmploymentAssistance_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_EmploymentAssistance.Checked)
            {
                Text_EmploymentAssistanceAmount.Enabled = true;
            }
            else
            {
                Text_EmploymentAssistanceAmount.Enabled = false;
                Text_EmploymentAssistanceAmount.Text = "";
            }
        }

        private void CheckBox_OneTimeRehab_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_OneTimeRehab.Checked)
            {
                Text_OneTimeAssistanceAmount.Enabled = true;
            }
            else
            {
                Text_OneTimeAssistanceAmount.Enabled = false;
                Text_OneTimeAssistanceAmount.Text = "";
            }
        }

        private void CheckBox_OtherTypeOfAssistance_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_OtherTypeOfAssistance.Checked)
            {
                Text_OtherTypeOfAssistanceAmount.Enabled = true;
            }
            else
            {
                Text_OtherTypeOfAssistanceAmount.Enabled = false;
                Text_OtherTypeOfAssistanceAmount.Text = "";
            }
        }

        private void comboBox_otherDetails_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int keyy = ((KeyValuePair<int, string>)comboBox_otherDetails.SelectedItem).Key;
            loadOtherDetails_Grid(keyy);
        }

        private void Button_Save_NeedTab_Click(object sender, EventArgs e)
        {
            Label_ErorMessage_Needtb.Text = "";

            NeedTabMD needMd = new NeedTabMD();

            needMd.caseSelectedIndex = NeedTab_ComboBoxCases.SelectedIndex;

            needMd.monthlyChecked = CheckBox_MonthlyAssistance.Checked;
            needMd.medicalChecked = CheckBox_MedicalAssistance.Checked;
            needMd.marriageChecked = CheckBox_MarriageAssistance.Checked;
            needMd.employChecked = CheckBox_EmploymentAssistance.Checked;
            needMd.OneTimeChecked = CheckBox_OneTimeRehab.Checked;
            needMd.otherChecked = CheckBox_OtherTypeOfAssistance.Checked;

            needMd.monthlyAmount = Text_MonthlyAssistanceAmount.Text;
            needMd.medicalAmount = Text_MedicalAssistanceAmount.Text;
            needMd.marriageAmount = Text_MarriageAssistanceAmount.Text;
            needMd.employmentAmount = Text_EmploymentAssistanceAmount.Text;
            needMd.oneTimeAmount = Text_OneTimeAssistanceAmount.Text;
            needMd.otherAmount = Text_OtherTypeOfAssistanceAmount.Text;

            needMd.caseSelectedIndex = ((KeyValuePair<int, string>)NeedTab_ComboBoxCases.SelectedItem).Key;

            NeedTabCT needCt = new NeedTabCT();

            if (needCt.caseSelected(needMd))
            {
                if (CheckBox_MonthlyAssistance.Checked)
                {
                    if (needCt.BankDetailsAdded(needMd))
                    {
                        if (needCt.saveNeedDetails(needMd))
                        {
                            Label_ErorMessage_Needtb.Text = needMd.errorMessage;
                            loadNeedTabGrid(((KeyValuePair<int, string>)NeedTab_ComboBoxCases.SelectedItem).Key);
                            clearNeedTab();
                        }
                        else
                        {
                            Label_ErorMessage_Needtb.Text = needMd.errorMessage;
                        }
                    }
                    else
                    {
                        MessageBox.Show(needMd.errorMessage);
                    }
                }
                else
                {
                    if (needCt.saveNeedDetails(needMd))
                    {
                        Label_ErorMessage_Needtb.Text = needMd.errorMessage;
                        loadNeedTabGrid(((KeyValuePair<int, string>)NeedTab_ComboBoxCases.SelectedItem).Key);
                        clearNeedTab();
                    }
                    else
                    {
                        Label_ErorMessage_Needtb.Text = needMd.errorMessage;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Query = "select monthly AS 'Monthly Assistance', medical_assistence AS 'Medical Assistance',marriage_fund AS 'Marriage Assistance',employ_fund AS 'Employment Assistance',otr_fund AS 'One-Time Rehabilitation',other_fund AS 'Other Assistance' from need_details where person_id=" + key;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "need_details");

                    Needtab_dataGrid.DataSource = ds;
                    Needtab_dataGrid.DataMember = "need_details";
                }

            }
            catch (Exception e)
            {
                Label_ErorMessage_Needtb.Text = "Something went wrong! Please try again...";
            }
        }

        private void NeedTab_ComboBoxCases_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int keyy = ((KeyValuePair<int, string>)NeedTab_ComboBoxCases.SelectedItem).Key;
            loadNeedTabGrid(keyy);
        }

        private void clearNeedTab()
        {
            CheckBox_MonthlyAssistance.CheckState = CheckState.Unchecked;
            CheckBox_MedicalAssistance.CheckState = CheckState.Unchecked;
            CheckBox_MarriageAssistance.CheckState = CheckState.Unchecked;
            CheckBox_EmploymentAssistance.CheckState = CheckState.Unchecked;
            CheckBox_OneTimeRehab.CheckState = CheckState.Unchecked;
            CheckBox_OtherTypeOfAssistance.CheckState = CheckState.Unchecked;

            Text_MonthlyAssistanceAmount.Text = "";
            Text_MedicalAssistanceAmount.Text = "";
            Text_MarriageAssistanceAmount.Text = "";
            Text_EmploymentAssistanceAmount.Text = "";
            Text_OneTimeAssistanceAmount.Text = "";
            Text_OtherTypeOfAssistanceAmount.Text = "";
        }

        private void Button_SaveRemarks_Click(object sender, EventArgs e)
        {
            Label_ErrorMessage_Remarks.Text = "";

            remarksModel remarksMd = new remarksModel();
            remarksController remarksCt = new remarksController();

            remarksMd.caseSelected = ComboBox_RemarksTab.SelectedIndex;

            if (remarksMd.caseSelected != 0)
            {
                remarksMd.caseSelected = ((KeyValuePair<int, string>)ComboBox_RemarksTab.SelectedItem).Key;
                if (remarksCt.IsAllreadyExisting(remarksMd.caseSelected))
                {
                    MessageBox.Show("Details allready existing for this case!");
                }
                else
                {
                    if (remarksCt.checkNeedetailsFilled(remarksMd))
                    {
                        remarksMd.startDate = Case_StartDate.Text;
                        remarksMd.endDate = Case_EndDate.Text;
                        remarksMd.comments = Case_AdditionalComments.Text;
                        remarksMd.status = CaseStatus_Remarks.Text;

                        if (remarksCt.checkCaseType(remarksMd.caseSelected)) // check if case as Monthly
                        {
                            DateTime start_date= Case_StartDate.Value;
                            DateTime end_date = Case_EndDate.Value;
                            end_date = start_date.AddDays(31);
                            Case_EndDate.MinDate = end_date;

                            if (remarksCt.insertData(remarksMd))
                            {
                                MessageBox.Show("Details Saved Successfully");
                                loadRemarksGrid(remarksMd.caseSelected);
                                Case_AdditionalComments.Text = "";
                            }
                            else
                            {
                                Label_ErrorMessage_Remarks.Text = remarksMd.errorMessage;
                            }
                        }
                        else
                        {
                            if (remarksCt.insertData(remarksMd))
                            {
                                MessageBox.Show("Details Saved Successfully!");
                                loadRemarksGrid(remarksMd.caseSelected);
                                Case_AdditionalComments.Text = "";
                            }
                            else
                            {
                                Label_ErrorMessage_Remarks.Text = remarksMd.errorMessage;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill the Need Details for this case in the previous tab.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please Select a Case from the Dropdwn", "Case not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadRemarksGrid(int key)
        {
            string Query = "";
            try
            {
                string con = DbContext.ConnectDb();

                using (SqlConnection connect = new SqlConnection(con))
                {
                    Query = "SELECT startDate AS 'Start Date', endDate AS 'End Date', comments AS 'Additional Comments', status AS 'Status' from remarks_tb WHERE person_id="+key;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Query, con);
                    DataSet ds = new DataSet();
                    connect.Open();
                    dataadapter.Fill(ds, "remarks_tb");
                    Remarks_DataGrid.DataSource = ds;
                    Remarks_DataGrid.DataMember = "remarks_tb";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Somthing went wrong666. Please try again!");
            }
        }

        private void ComboBox_RemarksTab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int key = ((KeyValuePair<int, string>)ComboBox_RemarksTab.SelectedItem).Key;
            loadRemarksGrid(key);
        }

        OpenFileDialog open = new OpenFileDialog();

        private void button8_Click(object sender, EventArgs e)
        {
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Title = "Upload Photo";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLocation = open.FileName.ToString();
                PictureBox_Photo.ImageLocation = imgLocation;
               // PictureBox_Photo.Image = new Bitmap(open.FileName);
                //UploadPhotoPath = open.FileName;
            }  
        }
    }
}
