namespace SecCourseWork
{
    partial class AddPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPet));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PetName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxIsServiced = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddPet = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PictBoxPet = new System.Windows.Forms.PictureBox();
            this.ComBoxPetClass = new System.Windows.Forms.ComboBox();
            this.ComBoxPetKind = new System.Windows.Forms.ComboBox();
            this.ComBoxPetSpecies = new System.Windows.Forms.ComboBox();
            this.DTPickerPet = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PictBoxPet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кличка";
            // 
            // TB_PetName
            // 
            this.TB_PetName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PetName.Location = new System.Drawing.Point(12, 88);
            this.TB_PetName.Name = "TB_PetName";
            this.TB_PetName.Size = new System.Drawing.Size(272, 26);
            this.TB_PetName.TabIndex = 5;
            this.TB_PetName.Text = "";
            this.TB_PetName.TextChanged += new System.EventHandler(this.TB_PetName_TextChanged);
            this.TB_PetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PetName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Класс";
            // 
            // CheckBoxIsServiced
            // 
            this.CheckBoxIsServiced.AutoSize = true;
            this.CheckBoxIsServiced.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxIsServiced.Location = new System.Drawing.Point(12, 194);
            this.CheckBoxIsServiced.Name = "CheckBoxIsServiced";
            this.CheckBoxIsServiced.Size = new System.Drawing.Size(248, 24);
            this.CheckBoxIsServiced.TabIndex = 13;
            this.CheckBoxIsServiced.Text = "Обслуживается ли в клинике";
            this.CheckBoxIsServiced.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Род";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Порода";
            // 
            // BtnAddPet
            // 
            this.BtnAddPet.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddPet.Location = new System.Drawing.Point(12, 407);
            this.BtnAddPet.Name = "BtnAddPet";
            this.BtnAddPet.Size = new System.Drawing.Size(186, 30);
            this.BtnAddPet.TabIndex = 18;
            this.BtnAddPet.Text = "Добавить питомца";
            this.BtnAddPet.UseVisualStyleBackColor = true;
            this.BtnAddPet.Click += new System.EventHandler(this.BtnAddPet_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBack.Size = new System.Drawing.Size(88, 30);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PictBoxPet
            // 
            this.PictBoxPet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PictBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictBoxPet.Image = ((System.Drawing.Image)(resources.GetObject("PictBoxPet.Image")));
            this.PictBoxPet.InitialImage = null;
            this.PictBoxPet.Location = new System.Drawing.Point(315, 64);
            this.PictBoxPet.Name = "PictBoxPet";
            this.PictBoxPet.Size = new System.Drawing.Size(226, 290);
            this.PictBoxPet.TabIndex = 20;
            this.PictBoxPet.TabStop = false;
            this.PictBoxPet.Click += new System.EventHandler(this.PictBoxPet_Click);
            // 
            // ComBoxPetClass
            // 
            this.ComBoxPetClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetClass.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetClass.FormattingEnabled = true;
            this.ComBoxPetClass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBoxPetClass.Location = new System.Drawing.Point(12, 254);
            this.ComBoxPetClass.Name = "ComBoxPetClass";
            this.ComBoxPetClass.Size = new System.Drawing.Size(272, 25);
            this.ComBoxPetClass.TabIndex = 21;
            this.ComBoxPetClass.SelectedIndexChanged += new System.EventHandler(this.ComBoxPetClass_SelectedIndexChanged);
            // 
            // ComBoxPetKind
            // 
            this.ComBoxPetKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetKind.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetKind.FormattingEnabled = true;
            this.ComBoxPetKind.Location = new System.Drawing.Point(12, 309);
            this.ComBoxPetKind.Name = "ComBoxPetKind";
            this.ComBoxPetKind.Size = new System.Drawing.Size(272, 25);
            this.ComBoxPetKind.TabIndex = 22;
            this.ComBoxPetKind.SelectedIndexChanged += new System.EventHandler(this.ComBoxPetKind_SelectedIndexChanged);
            // 
            // ComBoxPetSpecies
            // 
            this.ComBoxPetSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetSpecies.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetSpecies.FormattingEnabled = true;
            this.ComBoxPetSpecies.Location = new System.Drawing.Point(12, 370);
            this.ComBoxPetSpecies.Name = "ComBoxPetSpecies";
            this.ComBoxPetSpecies.Size = new System.Drawing.Size(272, 25);
            this.ComBoxPetSpecies.TabIndex = 23;
            // 
            // DTPickerPet
            // 
            this.DTPickerPet.CalendarFont = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerPet.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerPet.Location = new System.Drawing.Point(12, 150);
            this.DTPickerPet.MaxDate = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            this.DTPickerPet.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPickerPet.Name = "DTPickerPet";
            this.DTPickerPet.Size = new System.Drawing.Size(272, 24);
            this.DTPickerPet.TabIndex = 63;
            this.DTPickerPet.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // AddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 453);
            this.Controls.Add(this.DTPickerPet);
            this.Controls.Add(this.ComBoxPetSpecies);
            this.Controls.Add(this.ComBoxPetKind);
            this.Controls.Add(this.ComBoxPetClass);
            this.Controls.Add(this.PictBoxPet);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddPet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBoxIsServiced);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_PetName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPet";
            this.Text = "Добавление питомца";
            ((System.ComponentModel.ISupportInitialize)(this.PictBoxPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TB_PetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxIsServiced;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddPet;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox PictBoxPet;
        private System.Windows.Forms.ComboBox ComBoxPetClass;
        private System.Windows.Forms.ComboBox ComBoxPetKind;
        private System.Windows.Forms.ComboBox ComBoxPetSpecies;
        private System.Windows.Forms.DateTimePicker DTPickerPet;
    }
}