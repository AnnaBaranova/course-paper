namespace SecCourseWork
{
    partial class EditPet
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
            this.BtnSaveEdited = new System.Windows.Forms.Button();
            this.CheckBoxIsServiced = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PetName = new System.Windows.Forms.RichTextBox();
            this.DTPickerPetBirth = new System.Windows.Forms.DateTimePicker();
            this.ComBoxPetSpecies = new System.Windows.Forms.ComboBox();
            this.ComBoxPetKind = new System.Windows.Forms.ComboBox();
            this.ComBoxPetClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PandaImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PandaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(12, 9);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnBack.Size = new System.Drawing.Size(88, 30);
            this.BtnBack.TabIndex = 32;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSaveEdited
            // 
            this.BtnSaveEdited.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveEdited.Location = new System.Drawing.Point(12, 408);
            this.BtnSaveEdited.Name = "BtnSaveEdited";
            this.BtnSaveEdited.Size = new System.Drawing.Size(186, 30);
            this.BtnSaveEdited.TabIndex = 31;
            this.BtnSaveEdited.Text = "Сохранить изменения";
            this.BtnSaveEdited.UseVisualStyleBackColor = true;
            this.BtnSaveEdited.Click += new System.EventHandler(this.BtnSaveEdited_Click);
            // 
            // CheckBoxIsServiced
            // 
            this.CheckBoxIsServiced.AutoSize = true;
            this.CheckBoxIsServiced.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxIsServiced.Location = new System.Drawing.Point(12, 195);
            this.CheckBoxIsServiced.Name = "CheckBoxIsServiced";
            this.CheckBoxIsServiced.Size = new System.Drawing.Size(248, 24);
            this.CheckBoxIsServiced.TabIndex = 26;
            this.CheckBoxIsServiced.Text = "Обслуживается ли в клинике";
            this.CheckBoxIsServiced.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Кличка";
            // 
            // TB_PetName
            // 
            this.TB_PetName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PetName.Location = new System.Drawing.Point(12, 89);
            this.TB_PetName.Name = "TB_PetName";
            this.TB_PetName.Size = new System.Drawing.Size(272, 26);
            this.TB_PetName.TabIndex = 20;
            this.TB_PetName.Text = "";
            this.TB_PetName.TextChanged += new System.EventHandler(this.TB_PetName_TextChanged);
            this.TB_PetName.Enter += new System.EventHandler(this.RelocatePandaImage);
            this.TB_PetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PetName_KeyPress);
            // 
            // DTPickerPetBirth
            // 
            this.DTPickerPetBirth.CalendarFont = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerPetBirth.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPickerPetBirth.Location = new System.Drawing.Point(12, 151);
            this.DTPickerPetBirth.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DTPickerPetBirth.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPickerPetBirth.Name = "DTPickerPetBirth";
            this.DTPickerPetBirth.Size = new System.Drawing.Size(274, 24);
            this.DTPickerPetBirth.TabIndex = 62;
            this.DTPickerPetBirth.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.DTPickerPetBirth.Enter += new System.EventHandler(this.RelocatePandaImage);
            // 
            // ComBoxPetSpecies
            // 
            this.ComBoxPetSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetSpecies.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetSpecies.FormattingEnabled = true;
            this.ComBoxPetSpecies.Location = new System.Drawing.Point(12, 362);
            this.ComBoxPetSpecies.Name = "ComBoxPetSpecies";
            this.ComBoxPetSpecies.Size = new System.Drawing.Size(272, 25);
            this.ComBoxPetSpecies.TabIndex = 68;
            this.ComBoxPetSpecies.SelectedIndexChanged += new System.EventHandler(this.ComBoxPetSpecies_SelectedIndexChanged);
            this.ComBoxPetSpecies.Enter += new System.EventHandler(this.RelocatePandaImage);
            // 
            // ComBoxPetKind
            // 
            this.ComBoxPetKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetKind.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetKind.FormattingEnabled = true;
            this.ComBoxPetKind.Location = new System.Drawing.Point(12, 301);
            this.ComBoxPetKind.Name = "ComBoxPetKind";
            this.ComBoxPetKind.Size = new System.Drawing.Size(272, 25);
            this.ComBoxPetKind.TabIndex = 67;
            this.ComBoxPetKind.SelectedIndexChanged += new System.EventHandler(this.ComBoxPetKind_SelectedIndexChanged);
            this.ComBoxPetKind.Enter += new System.EventHandler(this.RelocatePandaImage);
            // 
            // ComBoxPetClass
            // 
            this.ComBoxPetClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxPetClass.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComBoxPetClass.FormattingEnabled = true;
            this.ComBoxPetClass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBoxPetClass.Location = new System.Drawing.Point(12, 246);
            this.ComBoxPetClass.Name = "ComBoxPetClass";
            this.ComBoxPetClass.Size = new System.Drawing.Size(272, 25);
            this.ComBoxPetClass.TabIndex = 66;
            this.ComBoxPetClass.SelectedIndexChanged += new System.EventHandler(this.ComBoxPetClass_SelectedIndexChanged);
            this.ComBoxPetClass.Enter += new System.EventHandler(this.RelocatePandaImage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Порода";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Род";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Класс";
            // 
            // PandaImage
            // 
            this.PandaImage.BackgroundImage = global::SecCourseWork.Properties.Resources.PandaIcon;
            this.PandaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PandaImage.Location = new System.Drawing.Point(290, 51);
            this.PandaImage.Name = "PandaImage";
            this.PandaImage.Size = new System.Drawing.Size(64, 64);
            this.PandaImage.TabIndex = 69;
            this.PandaImage.TabStop = false;
            // 
            // EditPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.ComBoxPetSpecies);
            this.Controls.Add(this.ComBoxPetKind);
            this.Controls.Add(this.ComBoxPetClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPickerPetBirth);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSaveEdited);
            this.Controls.Add(this.CheckBoxIsServiced);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_PetName);
            this.Controls.Add(this.PandaImage);
            this.Name = "EditPet";
            this.Text = "Редактировать питомца";
            ((System.ComponentModel.ISupportInitialize)(this.PandaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSaveEdited;
        private System.Windows.Forms.CheckBox CheckBoxIsServiced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TB_PetName;
        private System.Windows.Forms.DateTimePicker DTPickerPetBirth;
        private System.Windows.Forms.ComboBox ComBoxPetSpecies;
        private System.Windows.Forms.ComboBox ComBoxPetKind;
        private System.Windows.Forms.ComboBox ComBoxPetClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PandaImage;
    }
}