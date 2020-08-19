namespace InstallAndrewOS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.Label();
            this.CompanyInput = new System.Windows.Forms.TextBox();
            this.PurposeBox = new System.Windows.Forms.Label();
            this.PurposeInput = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.SubmitDetails = new System.Windows.Forms.Button();
            this.InstallButton = new System.Windows.Forms.Button();
            this.InstallProgressBar = new System.Windows.Forms.ProgressBar();
            this.PercentComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the AndrewOS Installer!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click \"Continue\" to begin.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(181, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(162, 180);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(192, 20);
            this.NameInput.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Location = new System.Drawing.Point(77, 180);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(61, 13);
            this.NameBox.TabIndex = 4;
            this.NameBox.Text = "Your name:";
            this.NameBox.Click += new System.EventHandler(this.label3_Click);
            // 
            // CompanyBox
            // 
            this.CompanyBox.AutoSize = true;
            this.CompanyBox.Location = new System.Drawing.Point(24, 225);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(114, 13);
            this.CompanyBox.TabIndex = 5;
            this.CompanyBox.Text = "Your company\'s name:";
            this.CompanyBox.Click += new System.EventHandler(this.label4_Click);
            // 
            // CompanyInput
            // 
            this.CompanyInput.Location = new System.Drawing.Point(162, 218);
            this.CompanyInput.Name = "CompanyInput";
            this.CompanyInput.Size = new System.Drawing.Size(192, 20);
            this.CompanyInput.TabIndex = 6;
            // 
            // PurposeBox
            // 
            this.PurposeBox.AutoSize = true;
            this.PurposeBox.Location = new System.Drawing.Point(12, 266);
            this.PurposeBox.Name = "PurposeBox";
            this.PurposeBox.Size = new System.Drawing.Size(198, 13);
            this.PurposeBox.TabIndex = 7;
            this.PurposeBox.Text = "What do you plan to use AndrewOS for?";
            this.PurposeBox.Click += new System.EventHandler(this.label5_Click);
            // 
            // PurposeInput
            // 
            this.PurposeInput.Location = new System.Drawing.Point(216, 263);
            this.PurposeInput.Name = "PurposeInput";
            this.PurposeInput.Size = new System.Drawing.Size(138, 20);
            this.PurposeInput.TabIndex = 8;
            // 
            // EmailBox
            // 
            this.EmailBox.AutoSize = true;
            this.EmailBox.Location = new System.Drawing.Point(24, 300);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(88, 13);
            this.EmailBox.TabIndex = 9;
            this.EmailBox.Text = "Enter your e-mail:";
            this.EmailBox.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(118, 297);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(236, 20);
            this.EmailInput.TabIndex = 10;
            // 
            // SubmitDetails
            // 
            this.SubmitDetails.Location = new System.Drawing.Point(181, 351);
            this.SubmitDetails.Name = "SubmitDetails";
            this.SubmitDetails.Size = new System.Drawing.Size(75, 23);
            this.SubmitDetails.TabIndex = 11;
            this.SubmitDetails.Text = "Continue";
            this.SubmitDetails.UseVisualStyleBackColor = true;
            this.SubmitDetails.Click += new System.EventHandler(this.SubmitDetails_Click);
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(181, 79);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 12;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // InstallProgressBar
            // 
            this.InstallProgressBar.Location = new System.Drawing.Point(12, 323);
            this.InstallProgressBar.Name = "InstallProgressBar";
            this.InstallProgressBar.Size = new System.Drawing.Size(420, 23);
            this.InstallProgressBar.TabIndex = 13;
            this.InstallProgressBar.Value = 3;
            // 
            // PercentComplete
            // 
            this.PercentComplete.AutoSize = true;
            this.PercentComplete.Location = new System.Drawing.Point(12, 356);
            this.PercentComplete.Name = "PercentComplete";
            this.PercentComplete.Size = new System.Drawing.Size(35, 13);
            this.PercentComplete.TabIndex = 14;
            this.PercentComplete.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 526);
            this.Controls.Add(this.PercentComplete);
            this.Controls.Add(this.InstallProgressBar);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.SubmitDetails);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PurposeInput);
            this.Controls.Add(this.PurposeBox);
            this.Controls.Add(this.CompanyInput);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AndrewOS Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Label CompanyBox;
        private System.Windows.Forms.TextBox CompanyInput;
        private System.Windows.Forms.Label PurposeBox;
        private System.Windows.Forms.TextBox PurposeInput;
        private System.Windows.Forms.Label EmailBox;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Button SubmitDetails;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.ProgressBar InstallProgressBar;
        private System.Windows.Forms.Label PercentComplete;
    }
}

