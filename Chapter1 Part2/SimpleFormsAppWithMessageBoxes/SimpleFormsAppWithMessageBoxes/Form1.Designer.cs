namespace SimpleFormsAppWithMessageBoxes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            firstname = new TextBox();
            lastname = new TextBox();
            middlename = new TextBox();
            suffix = new TextBox();
            Submit = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 118);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 189);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 244);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Suffix";
            // 
            // firstname
            // 
            firstname.Location = new Point(295, 78);
            firstname.Name = "firstname";
            firstname.Size = new Size(100, 23);
            firstname.TabIndex = 4;
            // 
            // lastname
            // 
            lastname.Location = new Point(295, 147);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 5;
            // 
            // middlename
            // 
            middlename.Location = new Point(295, 207);
            middlename.Name = "middlename";
            middlename.Size = new Size(100, 23);
            middlename.TabIndex = 6;
            // 
            // suffix
            // 
            suffix.Location = new Point(295, 272);
            suffix.Name = "suffix";
            suffix.Size = new Size(100, 23);
            suffix.TabIndex = 7;
            // 
            // Submit
            // 
            Submit.Location = new Point(308, 313);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 8;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(218, 9);
            label5.Name = "label5";
            label5.Size = new Size(299, 32);
            label5.TabIndex = 9;
            label5.Text = "Simple Application Form";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Submit);
            Controls.Add(suffix);
            Controls.Add(middlename);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox middlename;
        private TextBox suffix;
        private Button Submit;
        private Label label5;
    }
}
