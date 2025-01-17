namespace FinancialCrm
{
    partial class FrmTransactions
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTBank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTAmount = new System.Windows.Forms.TextBox();
            this.txtSpendingCategory = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTType = new System.Windows.Forms.TextBox();
            this.txtTDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTDescription = new System.Windows.Forms.TextBox();
            this.txtTId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnBillings = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Hareketleri Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 56);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 292);
            this.dataGridView1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(118)))));
            this.panel3.Controls.Add(this.txtTBank);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTAmount);
            this.panel3.Controls.Add(this.txtSpendingCategory);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Controls.Add(this.txtTType);
            this.panel3.Controls.Add(this.txtTDate);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnList);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTDescription);
            this.panel3.Controls.Add(this.txtTId);
            this.panel3.Location = new System.Drawing.Point(254, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 271);
            this.panel3.TabIndex = 24;
            // 
            // txtTBank
            // 
            this.txtTBank.Location = new System.Drawing.Point(175, 158);
            this.txtTBank.Name = "txtTBank";
            this.txtTBank.Size = new System.Drawing.Size(538, 22);
            this.txtTBank.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Banka Id:";
            // 
            // txtTAmount
            // 
            this.txtTAmount.Location = new System.Drawing.Point(175, 129);
            this.txtTAmount.Name = "txtTAmount";
            this.txtTAmount.Size = new System.Drawing.Size(538, 22);
            this.txtTAmount.TabIndex = 30;
            // 
            // txtSpendingCategory
            // 
            this.txtSpendingCategory.AutoSize = true;
            this.txtSpendingCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingCategory.Location = new System.Drawing.Point(103, 126);
            this.txtSpendingCategory.Name = "txtSpendingCategory";
            this.txtSpendingCategory.Size = new System.Drawing.Size(70, 24);
            this.txtSpendingCategory.TabIndex = 28;
            this.txtSpendingCategory.Text = "Miktar:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(131, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 24);
            this.lbl.TabIndex = 27;
            this.lbl.Text = "Tür:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(117, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 24);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "Tarih:";
            // 
            // txtTType
            // 
            this.txtTType.Location = new System.Drawing.Point(175, 101);
            this.txtTType.Name = "txtTType";
            this.txtTType.Size = new System.Drawing.Size(538, 22);
            this.txtTType.TabIndex = 25;
            // 
            // txtTDate
            // 
            this.txtTDate.Location = new System.Drawing.Point(175, 75);
            this.txtTDate.Name = "txtTDate";
            this.txtTDate.Size = new System.Drawing.Size(538, 22);
            this.txtTDate.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(669, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 51);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "İşlemi Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(457, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 51);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "İşlemi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(235, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 51);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "İşlem Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(13, 197);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(206, 51);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "İşlemleri Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // txtTDescription
            // 
            this.txtTDescription.Location = new System.Drawing.Point(175, 47);
            this.txtTDescription.Name = "txtTDescription";
            this.txtTDescription.Size = new System.Drawing.Size(538, 22);
            this.txtTDescription.TabIndex = 17;
            // 
            // txtTId
            // 
            this.txtTId.Location = new System.Drawing.Point(175, 19);
            this.txtTId.Name = "txtTId";
            this.txtTId.Size = new System.Drawing.Size(538, 22);
            this.txtTId.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnBillings);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 579);
            this.panel1.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(39, 381);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 41);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSettings.Location = new System.Drawing.Point(39, 334);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 41);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDashboard.Location = new System.Drawing.Point(39, 287);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 41);
            this.btnDashboard.TabIndex = 13;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTransactions.Location = new System.Drawing.Point(39, 240);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(170, 41);
            this.btnTransactions.TabIndex = 12;
            this.btnTransactions.Text = "Banka Hareketleri";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.BackColor = System.Drawing.Color.Transparent;
            this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnSpendings.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSpendings.Location = new System.Drawing.Point(37, 193);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(170, 41);
            this.btnSpendings.TabIndex = 11;
            this.btnSpendings.Text = "Giderler";
            this.btnSpendings.UseVisualStyleBackColor = false;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnBillings
            // 
            this.btnBillings.BackColor = System.Drawing.Color.Transparent;
            this.btnBillings.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnBillings.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBillings.Location = new System.Drawing.Point(39, 146);
            this.btnBillings.Name = "btnBillings";
            this.btnBillings.Size = new System.Drawing.Size(170, 44);
            this.btnBillings.TabIndex = 10;
            this.btnBillings.Text = "Faturalar";
            this.btnBillings.UseVisualStyleBackColor = false;
            this.btnBillings.Click += new System.EventHandler(this.btnBillings_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.Transparent;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnBanks.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBanks.Location = new System.Drawing.Point(39, 99);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(170, 41);
            this.btnBanks.TabIndex = 9;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12.2F);
            this.btnCategories.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCategories.Location = new System.Drawing.Point(39, 52);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(170, 41);
            this.btnCategories.TabIndex = 8;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click_1);
            // 
            // FrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 646);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransactions";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTAmount;
        private System.Windows.Forms.Label txtSpendingCategory;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtTType;
        private System.Windows.Forms.TextBox txtTDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTDescription;
        private System.Windows.Forms.TextBox txtTId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnBillings;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.TextBox txtTBank;
        private System.Windows.Forms.Label label4;
    }
}