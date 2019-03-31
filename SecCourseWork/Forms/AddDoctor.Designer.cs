namespace SecCourseWork
{
    partial class AddDoctor
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
            this.ComBoxSpecializ = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSaveDoctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Fathername = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.RichTextBox();
            this.TB_Name = new System.Windows.Forms.RichTextBox();
            this.ComBoxClinic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ComBoxSpecializ
            // 
            this.ComBoxSpecializ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxSpecializ.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxSpecializ.FormattingEnabled = true;
            this.ComBoxSpecializ.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBoxSpecializ.Location = new System.Drawing.Point(12, 272);
            this.ComBoxSpecializ.Name = "ComBoxSpecializ";
            this.ComBoxSpecializ.Size = new System.Drawing.Size(272, 25);
            this.ComBoxSpecializ.TabIndex = 88;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(10, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBack.Size = new System.Drawing.Size(88, 30);
            this.BtnBack.TabIndex = 87;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnSaveDoctor
            // 
            this.BtnSaveDoctor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveDoctor.Location = new System.Drawing.Point(12, 378);
            this.BtnSaveDoctor.Name = "BtnSaveDoctor";
            this.BtnSaveDoctor.Size = new System.Drawing.Size(186, 30);
            this.BtnSaveDoctor.TabIndex = 86;
            this.BtnSaveDoctor.Text = "Сохранить";
            this.BtnSaveDoctor.UseVisualStyleBackColor = true;
            this.BtnSaveDoctor.Click += new System.EventHandler(this.BtnSaveDoctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "Название клиники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 83;
            this.label4.Text = "Специализация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "Отчество";
            // 
            // TB_Fathername
            // 
            this.TB_Fathername.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Fathername.Location = new System.Drawing.Point(12, 211);
            this.TB_Fathername.Name = "TB_Fathername";
            this.TB_Fathername.Size = new System.Drawing.Size(272, 25);
            this.TB_Fathername.TabIndex = 81;
            this.TB_Fathername.Text = "";
            this.TB_Fathername.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Fathername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Fathername_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 79;
            this.label2.Text = "Имя";
            // 
            // TB_Surname
            // 
            this.TB_Surname.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Surname.Location = new System.Drawing.Point(12, 149);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(272, 25);
            this.TB_Surname.TabIndex = 78;
            this.TB_Surname.Text = "";
            this.TB_Surname.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Surname_KeyPress);
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Name.Location = new System.Drawing.Point(12, 87);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(272, 26);
            this.TB_Name.TabIndex = 77;
            this.TB_Name.Text = "";
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_ChildTextChanged);
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            // 
            // ComBoxClinic
            // 
            this.ComBoxClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxClinic.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxClinic.FormattingEnabled = true;
            this.ComBoxClinic.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBoxClinic.Location = new System.Drawing.Point(12, 333);
            this.ComBoxClinic.Name = "ComBoxClinic";
            this.ComBoxClinic.Size = new System.Drawing.Size(272, 25);
            this.ComBoxClinic.TabIndex = 89;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 440);
            this.Controls.Add(this.ComBoxClinic);
            this.Controls.Add(this.ComBoxSpecializ);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSaveDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Fathername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Surname);
            this.Controls.Add(this.TB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDoctor";
            this.Text = "Добавить врача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComBoxSpecializ;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSaveDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TB_Fathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TB_Surname;
        private System.Windows.Forms.RichTextBox TB_Name;
        private System.Windows.Forms.ComboBox ComBoxClinic;
    }
}