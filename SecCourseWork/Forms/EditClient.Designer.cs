namespace SecCourseWork
{
    partial class EditClient
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
            this.DTPickerClientBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.RichTextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSaveClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_PhoneNum = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Fathername = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.RichTextBox();
            this.TB_Name = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DTPickerClientBirth
            // 
            this.DTPickerClientBirth.CalendarFont = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerClientBirth.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerClientBirth.Location = new System.Drawing.Point(10, 268);
            this.DTPickerClientBirth.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DTPickerClientBirth.MinDate = new System.DateTime(1950, 12, 31, 0, 0, 0, 0);
            this.DTPickerClientBirth.Name = "DTPickerClientBirth";
            this.DTPickerClientBirth.Size = new System.Drawing.Size(274, 24);
            this.DTPickerClientBirth.TabIndex = 76;
            this.DTPickerClientBirth.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "Электронный адрес";
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Email.Location = new System.Drawing.Point(12, 387);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(272, 25);
            this.TB_Email.TabIndex = 74;
            this.TB_Email.Text = "";
            this.TB_Email.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Email_KeyPress);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(10, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBack.Size = new System.Drawing.Size(88, 30);
            this.BtnBack.TabIndex = 73;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSaveClient
            // 
            this.BtnSaveClient.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveClient.Location = new System.Drawing.Point(12, 426);
            this.BtnSaveClient.Name = "BtnSaveClient";
            this.BtnSaveClient.Size = new System.Drawing.Size(186, 30);
            this.BtnSaveClient.TabIndex = 72;
            this.BtnSaveClient.Text = "Сохранить";
            this.BtnSaveClient.UseVisualStyleBackColor = true;
            this.BtnSaveClient.Click += new System.EventHandler(this.BtnSaveClient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 71;
            this.label5.Text = "Номер телефона";
            // 
            // TB_PhoneNum
            // 
            this.TB_PhoneNum.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PhoneNum.Location = new System.Drawing.Point(12, 329);
            this.TB_PhoneNum.Name = "TB_PhoneNum";
            this.TB_PhoneNum.Size = new System.Drawing.Size(272, 25);
            this.TB_PhoneNum.TabIndex = 70;
            this.TB_PhoneNum.Text = "";
            this.TB_PhoneNum.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_PhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PhoneNum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 69;
            this.label4.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Отчество";
            // 
            // TB_Fathername
            // 
            this.TB_Fathername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Fathername.Location = new System.Drawing.Point(12, 207);
            this.TB_Fathername.Name = "TB_Fathername";
            this.TB_Fathername.Size = new System.Drawing.Size(272, 25);
            this.TB_Fathername.TabIndex = 67;
            this.TB_Fathername.Text = "";
            this.TB_Fathername.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Fathername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Fathername_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Имя";
            // 
            // TB_Surname
            // 
            this.TB_Surname.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Surname.Location = new System.Drawing.Point(12, 145);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(272, 25);
            this.TB_Surname.TabIndex = 64;
            this.TB_Surname.Text = "";
            this.TB_Surname.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Surname_KeyPress);
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Name.Location = new System.Drawing.Point(12, 83);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(272, 26);
            this.TB_Name.TabIndex = 63;
            this.TB_Name.Text = "";
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 465);
            this.Controls.Add(this.DTPickerClientBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSaveClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_PhoneNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Fathername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Surname);
            this.Controls.Add(this.TB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditClient";
            this.Text = "Редактировать клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPickerClientBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TB_Email;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSaveClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox TB_PhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TB_Fathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TB_Surname;
        private System.Windows.Forms.RichTextBox TB_Name;
    }
}