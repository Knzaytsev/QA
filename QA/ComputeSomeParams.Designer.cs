﻿namespace QA
{
    partial class ComputeSomeParams
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
            this.tvdop = new System.Windows.Forms.TextBox();
            this.Compute = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Recovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvdop
            // 
            this.tvdop.Location = new System.Drawing.Point(12, 27);
            this.tvdop.Name = "tvdop";
            this.tvdop.Size = new System.Drawing.Size(100, 20);
            this.tvdop.TabIndex = 1;
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(161, 78);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 3;
            this.Compute.Text = "Вычислить";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(161, 107);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recovery});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 167);
            this.dataGridView1.TabIndex = 5;
            // 
            // Recovery
            // 
            this.Recovery.HeaderText = "Время восстановления";
            this.Recovery.Name = "Recovery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Допустимое среднее время восстановления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время отказов";
            // 
            // ComputeSomeParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.tvdop);
            this.Name = "ComputeSomeParams";
            this.Text = "ComputeSomeParams";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tvdop;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recovery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}