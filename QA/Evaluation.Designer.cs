namespace QA
{
    partial class Evaluation
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
            this.CharsListDGV = new System.Windows.Forms.DataGridView();
            this.Compute = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.N0305 = new System.Windows.Forms.Button();
            this.N0401 = new System.Windows.Forms.Button();
            this.N0501 = new System.Windows.Forms.Button();
            this.N0502 = new System.Windows.Forms.Button();
            this.C0302 = new System.Windows.Forms.Button();
            this.C1002 = new System.Windows.Forms.Button();
            this.K1003 = new System.Windows.Forms.Button();
            this.K1004 = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.SaveData = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CharsListDGV)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharsListDGV
            // 
            this.CharsListDGV.AllowUserToAddRows = false;
            this.CharsListDGV.AllowUserToDeleteRows = false;
            this.CharsListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CharsListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.Description,
            this.Value});
            this.CharsListDGV.Location = new System.Drawing.Point(12, 12);
            this.CharsListDGV.Name = "CharsListDGV";
            this.CharsListDGV.Size = new System.Drawing.Size(668, 354);
            this.CharsListDGV.TabIndex = 0;
            // 
            // Compute
            // 
            this.Compute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Compute.Location = new System.Drawing.Point(605, 372);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 1;
            this.Compute.Text = "Посчитать";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.Location = new System.Drawing.Point(12, 372);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оценка от 0 до 1 включительно";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(689, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 23);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(689, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 23);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.panel3.Location = new System.Drawing.Point(689, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 23);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))));
            this.panel4.Location = new System.Drawing.Point(689, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 23);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Легенда:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Обязательный, введён неверно (для оценок)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Обязательный, введён верно";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Необязательный, введён неверно (для оценок)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(721, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Необязательный, введён верно";
            // 
            // N0305
            // 
            this.N0305.Enabled = false;
            this.N0305.Location = new System.Drawing.Point(8, 3);
            this.N0305.Name = "N0305";
            this.N0305.Size = new System.Drawing.Size(75, 23);
            this.N0305.TabIndex = 11;
            this.N0305.Text = "Н0305";
            this.N0305.UseVisualStyleBackColor = true;
            this.N0305.Click += new System.EventHandler(this.N0305_Click);
            // 
            // N0401
            // 
            this.N0401.Enabled = false;
            this.N0401.Location = new System.Drawing.Point(8, 30);
            this.N0401.Name = "N0401";
            this.N0401.Size = new System.Drawing.Size(75, 23);
            this.N0401.TabIndex = 12;
            this.N0401.Text = "Н0401";
            this.N0401.UseVisualStyleBackColor = true;
            this.N0401.Click += new System.EventHandler(this.N0401_Click);
            // 
            // N0501
            // 
            this.N0501.Enabled = false;
            this.N0501.Location = new System.Drawing.Point(8, 59);
            this.N0501.Name = "N0501";
            this.N0501.Size = new System.Drawing.Size(75, 23);
            this.N0501.TabIndex = 13;
            this.N0501.Text = "Н0501";
            this.N0501.UseVisualStyleBackColor = true;
            this.N0501.Click += new System.EventHandler(this.N0501_Click);
            // 
            // N0502
            // 
            this.N0502.Enabled = false;
            this.N0502.Location = new System.Drawing.Point(8, 88);
            this.N0502.Name = "N0502";
            this.N0502.Size = new System.Drawing.Size(75, 23);
            this.N0502.TabIndex = 14;
            this.N0502.Text = "Н0502";
            this.N0502.UseVisualStyleBackColor = true;
            this.N0502.Click += new System.EventHandler(this.N0502_Click);
            // 
            // C0302
            // 
            this.C0302.Enabled = false;
            this.C0302.Location = new System.Drawing.Point(89, 3);
            this.C0302.Name = "C0302";
            this.C0302.Size = new System.Drawing.Size(75, 23);
            this.C0302.TabIndex = 15;
            this.C0302.Text = "С0302";
            this.C0302.UseVisualStyleBackColor = true;
            this.C0302.Click += new System.EventHandler(this.C0302_Click);
            // 
            // C1002
            // 
            this.C1002.Enabled = false;
            this.C1002.Location = new System.Drawing.Point(89, 30);
            this.C1002.Name = "C1002";
            this.C1002.Size = new System.Drawing.Size(75, 23);
            this.C1002.TabIndex = 16;
            this.C1002.Text = "С1002";
            this.C1002.UseVisualStyleBackColor = true;
            this.C1002.Click += new System.EventHandler(this.C1002_Click);
            // 
            // K1003
            // 
            this.K1003.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K1003.Enabled = false;
            this.K1003.Location = new System.Drawing.Point(89, 59);
            this.K1003.Name = "K1003";
            this.K1003.Size = new System.Drawing.Size(75, 23);
            this.K1003.TabIndex = 17;
            this.K1003.Text = "К1003";
            this.K1003.UseVisualStyleBackColor = true;
            this.K1003.Click += new System.EventHandler(this.K1003_Click);
            // 
            // K1004
            // 
            this.K1004.Enabled = false;
            this.K1004.Location = new System.Drawing.Point(89, 88);
            this.K1004.Name = "K1004";
            this.K1004.Size = new System.Drawing.Size(75, 23);
            this.K1004.TabIndex = 18;
            this.K1004.Text = "К1004";
            this.K1004.UseVisualStyleBackColor = true;
            this.K1004.Click += new System.EventHandler(this.K1004_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Controls.Add(this.K1004);
            this.buttonPanel.Controls.Add(this.N0305);
            this.buttonPanel.Controls.Add(this.K1003);
            this.buttonPanel.Controls.Add(this.N0401);
            this.buttonPanel.Controls.Add(this.C1002);
            this.buttonPanel.Controls.Add(this.N0501);
            this.buttonPanel.Controls.Add(this.C0302);
            this.buttonPanel.Controls.Add(this.N0502);
            this.buttonPanel.Location = new System.Drawing.Point(686, 167);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(175, 117);
            this.buttonPanel.TabIndex = 19;
            // 
            // SaveData
            // 
            this.SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveData.Location = new System.Drawing.Point(847, 369);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(112, 23);
            this.SaveData.TabIndex = 12;
            this.SaveData.Text = "Сохранить данные";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ИД";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.HeaderText = "Наименование";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Value
            // 
            this.Value.HeaderText = "Оценка";
            this.Value.Name = "Value";
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 404);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.CharsListDGV);
            this.Name = "Evaluation";
            this.Text = "Ввод оценочных показателей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Evaluation_FormClosed);
            this.Load += new System.EventHandler(this.EvaluationLoad);
            ((System.ComponentModel.ISupportInitialize)(this.CharsListDGV)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CharsListDGV;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button N0305;
        private System.Windows.Forms.Button N0401;
        private System.Windows.Forms.Button N0501;
        private System.Windows.Forms.Button N0502;
        private System.Windows.Forms.Button C0302;
        private System.Windows.Forms.Button C1002;
        private System.Windows.Forms.Button K1003;
        private System.Windows.Forms.Button K1004;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}