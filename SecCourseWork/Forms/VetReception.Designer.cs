namespace SecCourseWork
{
    partial class VetReception
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnGetReception = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxIsNotif = new System.Windows.Forms.CheckBox();
            this.DTPickerReception = new System.Windows.Forms.DateTimePicker();
            this.ComBoxPetName = new System.Windows.Forms.ComboBox();
            this.ComboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.ComboBoxService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBack.Size = new System.Drawing.Size(88, 30);
            this.BtnBack.TabIndex = 59;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnGetReception
            // 
            this.BtnGetReception.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGetReception.Location = new System.Drawing.Point(16, 401);
            this.BtnGetReception.Name = "BtnGetReception";
            this.BtnGetReception.Size = new System.Drawing.Size(186, 30);
            this.BtnGetReception.TabIndex = 58;
            this.BtnGetReception.Text = "Записаться";
            this.BtnGetReception.UseVisualStyleBackColor = true;
            this.BtnGetReception.Click += new System.EventHandler(this.BtnGetReception_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Дата и время записи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Услуга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Врач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Кличка питомца";
            // 
            // CheckBoxIsNotif
            // 
            this.CheckBoxIsNotif.AutoSize = true;
            this.CheckBoxIsNotif.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxIsNotif.Location = new System.Drawing.Point(12, 356);
            this.CheckBoxIsNotif.Name = "CheckBoxIsNotif";
            this.CheckBoxIsNotif.Size = new System.Drawing.Size(225, 24);
            this.CheckBoxIsNotif.TabIndex = 60;
            this.CheckBoxIsNotif.Text = "Уведомление по эл. почте";
            this.CheckBoxIsNotif.UseVisualStyleBackColor = true;
            // 
            // DTPickerReception
            // 
            this.DTPickerReception.CalendarFont = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerReception.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerReception.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPickerReception.Location = new System.Drawing.Point(16, 310);
            this.DTPickerReception.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DTPickerReception.MinDate = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            this.DTPickerReception.Name = "DTPickerReception";
            this.DTPickerReception.Size = new System.Drawing.Size(347, 24);
            this.DTPickerReception.TabIndex = 61;
            this.DTPickerReception.Value = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            // 
            // ComBoxPetName
            // 
            this.ComBoxPetName.BackColor = System.Drawing.SystemColors.Window;
            this.ComBoxPetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetName.FormattingEnabled = true;
            this.ComBoxPetName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBoxPetName.Location = new System.Drawing.Point(16, 80);
            this.ComBoxPetName.Name = "ComBoxPetName";
            this.ComBoxPetName.Size = new System.Drawing.Size(347, 25);
            this.ComBoxPetName.TabIndex = 62;
            // 
            // ComboBoxDoctor
            // 
            this.ComboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDoctor.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxDoctor.FormattingEnabled = true;
            this.ComboBoxDoctor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComboBoxDoctor.Location = new System.Drawing.Point(16, 249);
            this.ComboBoxDoctor.Name = "ComboBoxDoctor";
            this.ComboBoxDoctor.Size = new System.Drawing.Size(347, 25);
            this.ComboBoxDoctor.TabIndex = 63;
            // 
            // ComboBoxService
            // 
            this.ComboBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxService.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxService.FormattingEnabled = true;
            this.ComboBoxService.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComboBoxService.Location = new System.Drawing.Point(16, 142);
            this.ComboBoxService.Name = "ComboBoxService";
            this.ComboBoxService.Size = new System.Drawing.Size(347, 25);
            this.ComboBoxService.TabIndex = 64;
            this.ComboBoxService.SelectedIndexChanged += new System.EventHandler(this.ComboBoxService_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Примерная стоимость:";
            // 
            // TBPrice
            // 
            this.TBPrice.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPrice.Location = new System.Drawing.Point(208, 187);
            this.TBPrice.Multiline = true;
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.ReadOnly = true;
            this.TBPrice.Size = new System.Drawing.Size(107, 21);
            this.TBPrice.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "руб.";
            // 
            // VetReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxService);
            this.Controls.Add(this.ComboBoxDoctor);
            this.Controls.Add(this.ComBoxPetName);
            this.Controls.Add(this.DTPickerReception);
            this.Controls.Add(this.CheckBoxIsNotif);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGetReception);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VetReception";
            this.Text = "Запись на прием";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnGetReception;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxIsNotif;
        private System.Windows.Forms.DateTimePicker DTPickerReception;
        private System.Windows.Forms.ComboBox ComBoxPetName;
        private System.Windows.Forms.ComboBox ComboBoxDoctor;
        private System.Windows.Forms.ComboBox ComboBoxService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label label6;
    }
}