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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label7 = new System.Windows.Forms.Label();
            this.SaveData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharsListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CharsListDGV
            // 
            this.CharsListDGV.AllowUserToAddRows = false;
            this.CharsListDGV.AllowUserToDeleteRows = false;
            this.CharsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CharsListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.Description,
            this.Value});
            this.CharsListDGV.Location = new System.Drawing.Point(12, 12);
            this.CharsListDGV.Name = "CharsListDGV";
            this.CharsListDGV.Size = new System.Drawing.Size(577, 354);
            this.CharsListDGV.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ИД";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Наименование";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Оценка";
            this.Value.Name = "Value";
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(514, 372);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 1;
            this.Compute.Text = "Далее";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // back
            // 
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оценка от 0 до 1 включительно";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(598, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 23);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(598, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 23);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.panel3.Location = new System.Drawing.Point(598, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 23);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))));
            this.panel4.Location = new System.Drawing.Point(598, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 23);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Легенда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Обязательный, введён неверно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Обязательный, введён верно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Необязательный, введён неверно";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Необязательный, введён верно";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Результаты оценки всех уровней доступны \r\nпри сохранении в файл";
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(723, 369);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(112, 23);
            this.SaveData.TabIndex = 12;
            this.SaveData.Text = "Сохранить данные";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 404);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.label7);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CharsListDGV;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveData;
    }
}