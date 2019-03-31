namespace SecCourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGWPets = new System.Windows.Forms.DataGridView();
            this.BtnAddPet = new System.Windows.Forms.Button();
            this.BtnEditPet = new System.Windows.Forms.Button();
            this.BtnDeletePet = new System.Windows.Forms.Button();
            this.BtnMyPets = new System.Windows.Forms.Button();
            this.BtnReception = new System.Windows.Forms.Button();
            this.BtnMyReceptions = new System.Windows.Forms.Button();
            this.BtnEditClient = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.DgwReceptions = new System.Windows.Forms.DataGridView();
            this.BtnDeleteReception = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGWPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwReceptions)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWPets
            // 
            this.DGWPets.AllowUserToAddRows = false;
            this.DGWPets.AllowUserToDeleteRows = false;
            this.DGWPets.AllowUserToOrderColumns = true;
            this.DGWPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWPets.Location = new System.Drawing.Point(12, 49);
            this.DGWPets.Name = "DGWPets";
            this.DGWPets.ReadOnly = true;
            this.DGWPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGWPets.Size = new System.Drawing.Size(637, 163);
            this.DGWPets.TabIndex = 13;
            // 
            // BtnAddPet
            // 
            this.BtnAddPet.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddPet.Location = new System.Drawing.Point(656, 49);
            this.BtnAddPet.Name = "BtnAddPet";
            this.BtnAddPet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAddPet.Size = new System.Drawing.Size(170, 30);
            this.BtnAddPet.TabIndex = 33;
            this.BtnAddPet.Text = "Добавить питомца";
            this.BtnAddPet.UseVisualStyleBackColor = true;
            this.BtnAddPet.Click += new System.EventHandler(this.BtnAddPet_Click);
            // 
            // BtnEditPet
            // 
            this.BtnEditPet.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditPet.Location = new System.Drawing.Point(655, 96);
            this.BtnEditPet.Name = "BtnEditPet";
            this.BtnEditPet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEditPet.Size = new System.Drawing.Size(170, 51);
            this.BtnEditPet.TabIndex = 34;
            this.BtnEditPet.Text = "Редактировать данные питомца";
            this.BtnEditPet.UseVisualStyleBackColor = true;
            this.BtnEditPet.Click += new System.EventHandler(this.BtnEditPet_Click);
            // 
            // BtnDeletePet
            // 
            this.BtnDeletePet.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeletePet.Location = new System.Drawing.Point(655, 166);
            this.BtnDeletePet.Name = "BtnDeletePet";
            this.BtnDeletePet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDeletePet.Size = new System.Drawing.Size(170, 30);
            this.BtnDeletePet.TabIndex = 35;
            this.BtnDeletePet.Text = "Удалить питомца";
            this.BtnDeletePet.UseVisualStyleBackColor = true;
            this.BtnDeletePet.Click += new System.EventHandler(this.BtnDeletePet_Click);
            // 
            // BtnMyPets
            // 
            this.BtnMyPets.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMyPets.Location = new System.Drawing.Point(12, 18);
            this.BtnMyPets.Name = "BtnMyPets";
            this.BtnMyPets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMyPets.Size = new System.Drawing.Size(118, 25);
            this.BtnMyPets.TabIndex = 37;
            this.BtnMyPets.Text = "Мои питомцы";
            this.BtnMyPets.UseVisualStyleBackColor = true;
            this.BtnMyPets.Click += new System.EventHandler(this.BtnShowPets_Click);
            // 
            // BtnReception
            // 
            this.BtnReception.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReception.Location = new System.Drawing.Point(12, 452);
            this.BtnReception.Name = "BtnReception";
            this.BtnReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReception.Size = new System.Drawing.Size(310, 40);
            this.BtnReception.TabIndex = 39;
            this.BtnReception.Text = "Записаться на прием";
            this.BtnReception.UseVisualStyleBackColor = true;
            this.BtnReception.Click += new System.EventHandler(this.BtnReception_Click);
            // 
            // BtnMyReceptions
            // 
            this.BtnMyReceptions.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMyReceptions.Location = new System.Drawing.Point(12, 238);
            this.BtnMyReceptions.Name = "BtnMyReceptions";
            this.BtnMyReceptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMyReceptions.Size = new System.Drawing.Size(118, 25);
            this.BtnMyReceptions.TabIndex = 40;
            this.BtnMyReceptions.Text = "Мои записи";
            this.BtnMyReceptions.UseVisualStyleBackColor = true;
            this.BtnMyReceptions.Click += new System.EventHandler(this.BtnMyReceptions_Click);
            // 
            // BtnEditClient
            // 
            this.BtnEditClient.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditClient.Location = new System.Drawing.Point(655, 212);
            this.BtnEditClient.Name = "BtnEditClient";
            this.BtnEditClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEditClient.Size = new System.Drawing.Size(170, 51);
            this.BtnEditClient.TabIndex = 41;
            this.BtnEditClient.Text = "Редактировать личные данные";
            this.BtnEditClient.UseVisualStyleBackColor = true;
            this.BtnEditClient.Click += new System.EventHandler(this.BtnEditClient_Click);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExcel.Location = new System.Drawing.Point(656, 279);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnExcel.Size = new System.Drawing.Size(170, 30);
            this.BtnExcel.TabIndex = 42;
            this.BtnExcel.Text = "Экспорт в Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // DgwReceptions
            // 
            this.DgwReceptions.AllowUserToAddRows = false;
            this.DgwReceptions.AllowUserToDeleteRows = false;
            this.DgwReceptions.AllowUserToOrderColumns = true;
            this.DgwReceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwReceptions.Location = new System.Drawing.Point(13, 269);
            this.DgwReceptions.Name = "DgwReceptions";
            this.DgwReceptions.ReadOnly = true;
            this.DgwReceptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwReceptions.Size = new System.Drawing.Size(637, 163);
            this.DgwReceptions.TabIndex = 43;
            // 
            // BtnDeleteReception
            // 
            this.BtnDeleteReception.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteReception.Location = new System.Drawing.Point(656, 402);
            this.BtnDeleteReception.Name = "BtnDeleteReception";
            this.BtnDeleteReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDeleteReception.Size = new System.Drawing.Size(170, 30);
            this.BtnDeleteReception.TabIndex = 44;
            this.BtnDeleteReception.Text = "Удалить запись";
            this.BtnDeleteReception.UseVisualStyleBackColor = true;
            this.BtnDeleteReception.Click += new System.EventHandler(this.BtnDeleteReception_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 504);
            this.Controls.Add(this.BtnDeleteReception);
            this.Controls.Add(this.DgwReceptions);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnEditClient);
            this.Controls.Add(this.BtnMyReceptions);
            this.Controls.Add(this.BtnReception);
            this.Controls.Add(this.BtnMyPets);
            this.Controls.Add(this.BtnDeletePet);
            this.Controls.Add(this.BtnEditPet);
            this.Controls.Add(this.BtnAddPet);
            this.Controls.Add(this.DGWPets);
            this.Name = "MainForm";
            this.Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)(this.DGWPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwReceptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGWPets;
        private System.Windows.Forms.Button BtnAddPet;
        private System.Windows.Forms.Button BtnEditPet;
        private System.Windows.Forms.Button BtnDeletePet;
        private System.Windows.Forms.Button BtnMyPets;
        private System.Windows.Forms.Button BtnReception;
        private System.Windows.Forms.Button BtnMyReceptions;
        private System.Windows.Forms.Button BtnEditClient;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.DataGridView DgwReceptions;
        private System.Windows.Forms.Button BtnDeleteReception;
    }
}

