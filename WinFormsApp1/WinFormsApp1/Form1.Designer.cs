namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblLastName = new Label();
            lblSuffix = new Label();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtSuffix = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(369, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(369, 146);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(79, 15);
            lblMiddleName.TabIndex = 1;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(369, 218);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblSuffix
            // 
            lblSuffix.AutoSize = true;
            lblSuffix.Location = new Point(369, 297);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Size = new Size(36, 15);
            lblSuffix.TabIndex = 3;
            lblSuffix.Text = "Suffix";
            lblSuffix.Click += label4_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(481, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(481, 146);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(100, 23);
            txtMiddleName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(481, 215);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(481, 297);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(100, 23);
            txtSuffix.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(428, 361);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 502);
            Controls.Add(btnSubmit);
            Controls.Add(txtSuffix);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblSuffix);
            Controls.Add(lblLastName);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblLastName;
        private Label lblSuffix;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtSuffix;
        private Button btnSubmit;
    }
}
