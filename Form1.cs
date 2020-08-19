using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallAndrewOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NameBox.Hide();
            NameInput.Hide();
            CompanyBox.Hide();
            CompanyInput.Hide();
            PurposeBox.Hide();
            PurposeInput.Hide();
            EmailBox.Hide();
            EmailInput.Hide();
            SubmitDetails.Hide();
            InstallButton.Hide();
            PercentComplete.Hide();
            InstallProgressBar.Hide();

        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public string EncodeUserDetails()
        {
            string ToEncode = NameInput.Text + " " + CompanyInput.Text + " " + PurposeInput.Text + " " + EmailInput.Text;
            return Base64Encode(ToEncode);
        }

        public void WarningMessage()
        {
            var Messages = new List<string>(); //["Missing DLL: servrcohandler.dll", "Missing DLL: WindowsRuntimeLib.dll", "Broken Registry Entry: Windows.System.PasswordDatabase", "Your system is too old and slow..."];
            Messages.Add("Missing Shared DLL: SCOSDataFIle.dll");
            Messages.Add("Missing Shared DLL: MasterSysFunctions.dll");
            Messages.Add("Filesystem error: Boot partition contains corrupted data");
            Messages.Add("System error: There are issues...");
            Messages.Add("ERROR: No OEM Data Detected");
            Messages.Add("FS Error: explorer.exe unreadable");
            Messages.Add("Missing Shared DLL: WinDefendAPI.dll");
            Messages.Add("ERROR: MakeItWork() Does not exist in this instance");
            Messages.Add("ERROR: This is an error....");
            Messages.Add("Missing System File \"InstallProgram.exe\"");
            Messages.Add("MS .NET Runtime Library Missing");

            var random = new Random();
            int index = random.Next(Messages.Count);
            string selected = Messages[index];
            MessageBox.Show(selected);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Registraion";
            label2.Text = "Please enter the correct information.";
            button1.Hide();
            NameBox.Show();
            NameInput.Show();
            CompanyBox.Show();
            CompanyInput.Show();
            PurposeBox.Show();
            PurposeInput.Show();
            EmailBox.Show();
            EmailInput.Show();
            SubmitDetails.Show();
        }

        // Start of functions by Windows Forms
        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }


        private void label5_Click(object sender, EventArgs e) { }

        private void label3_Click_1(object sender, EventArgs e) { }
        // End of functions by Windows Forms

        private void SubmitDetails_Click(object sender, EventArgs e)
        {
            NameBox.Hide();
            NameInput.Hide();
            CompanyBox.Hide();
            CompanyInput.Hide();
            PurposeBox.Hide();
            PurposeInput.Hide();
            EmailBox.Hide();
            EmailInput.Hide();
            SubmitDetails.Hide();
            label1.Text = "Installation";
            label2.Text = "Click \"Install\" To install...";
            InstallButton.Show();

            string DetailsEncoded = EncodeUserDetails();
            System.IO.File.WriteAllText(@".\UserDetails.txt", DetailsEncoded);
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int CurrentProgressVal = 3;

            InstallButton.Hide();
            label1.Text = "Installing...";
            label2.Text = "Sit back and relax..........";
            PercentComplete.Text = "0% Complete";

            InstallProgressBar.Show();
            PercentComplete.Show();
            WarningMessage();

            PercentComplete.Text = "3% complete";
            InstallProgressBar.Value = 3;
            WarningMessage();

            while (!(InstallProgressBar.Value >= 100))
            {
                CurrentProgressVal = random.Next(CurrentProgressVal, CurrentProgressVal + 20);
                if (CurrentProgressVal < 100)
                {
                    InstallProgressBar.Value = CurrentProgressVal;
                    PercentComplete.Text = CurrentProgressVal + "% complete";
                }
                
                WarningMessage();
                Task.Delay(2000);
            }
        }
    }
}
