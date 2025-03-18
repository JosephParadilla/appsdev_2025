namespace SimpleFormsAppWithComboBox
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCuisine = new System.Windows.Forms.ComboBox();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.checkedListBoxFood = new System.Windows.Forms.CheckedListBox();
            this.btnAdd_Click = new System.Windows.Forms.Button();
            this.btnSelect_Click = new System.Windows.Forms.Button();
            this.btnRemove_Click = new System.Windows.Forms.Button();
            this.btnClearAll_Click = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuisine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "My Favorite Food List";
            // 
            // comboBoxCuisine
            // 
            this.comboBoxCuisine.FormattingEnabled = true;
            this.comboBoxCuisine.Items.AddRange(new object[] {
            "Filipino",
            "Japanese",
            "Chinese",
            "Korean"});
            this.comboBoxCuisine.Location = new System.Drawing.Point(150, 202);
            this.comboBoxCuisine.Name = "comboBoxCuisine";
            this.comboBoxCuisine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCuisine.TabIndex = 4;
            this.comboBoxCuisine.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.Location = new System.Drawing.Point(554, 210);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(165, 134);
            this.listBoxFavorites.TabIndex = 5;
            this.listBoxFavorites.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkedListBoxFood
            // 
            this.checkedListBoxFood.FormattingEnabled = true;
            this.checkedListBoxFood.Location = new System.Drawing.Point(349, 210);
            this.checkedListBoxFood.Name = "checkedListBoxFood";
            this.checkedListBoxFood.Size = new System.Drawing.Size(151, 139);
            this.checkedListBoxFood.TabIndex = 6;
            this.checkedListBoxFood.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnAdd_Click
            // 
            this.btnAdd_Click.Location = new System.Drawing.Point(349, 366);
            this.btnAdd_Click.Name = "btnAdd_Click";
            this.btnAdd_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Click.TabIndex = 7;
            this.btnAdd_Click.Text = "Add";
            this.btnAdd_Click.UseVisualStyleBackColor = true;
            this.btnAdd_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelect_Click
            // 
            this.btnSelect_Click.Location = new System.Drawing.Point(150, 241);
            this.btnSelect_Click.Name = "btnSelect_Click";
            this.btnSelect_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSelect_Click.TabIndex = 8;
            this.btnSelect_Click.Text = "Select";
            this.btnSelect_Click.UseVisualStyleBackColor = true;
            this.btnSelect_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemove_Click
            // 
            this.btnRemove_Click.Location = new System.Drawing.Point(745, 202);
            this.btnRemove_Click.Name = "btnRemove_Click";
            this.btnRemove_Click.Size = new System.Drawing.Size(75, 23);
            this.btnRemove_Click.TabIndex = 9;
            this.btnRemove_Click.Text = "remove";
            this.btnRemove_Click.UseVisualStyleBackColor = true;
            this.btnRemove_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClearAll_Click
            // 
            this.btnClearAll_Click.Location = new System.Drawing.Point(745, 241);
            this.btnClearAll_Click.Name = "btnClearAll_Click";
            this.btnClearAll_Click.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll_Click.TabIndex = 10;
            this.btnClearAll_Click.Text = "Clear/all";
            this.btnClearAll_Click.UseVisualStyleBackColor = true;
            this.btnClearAll_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Simple Favorite picker App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearAll_Click);
            this.Controls.Add(this.btnRemove_Click);
            this.Controls.Add(this.btnSelect_Click);
            this.Controls.Add(this.btnAdd_Click);
            this.Controls.Add(this.checkedListBoxFood);
            this.Controls.Add(this.listBoxFavorites);
            this.Controls.Add(this.comboBoxCuisine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCuisine;
        private System.Windows.Forms.ListBox listBoxFavorites;
        private System.Windows.Forms.CheckedListBox checkedListBoxFood;
        private System.Windows.Forms.Button btnAdd_Click;
        private System.Windows.Forms.Button btnSelect_Click;
        private System.Windows.Forms.Button btnRemove_Click;
        private System.Windows.Forms.Button btnClearAll_Click;
        private System.Windows.Forms.Label label4;
    }
}

