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
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оценка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharsListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CharsListDGV
            // 
            this.CharsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CharsListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.Наименование,
            this.Оценка});
            this.CharsListDGV.Location = new System.Drawing.Point(0, 0);
            this.CharsListDGV.Name = "CharsListDGV";
            this.CharsListDGV.Size = new System.Drawing.Size(378, 150);
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
            // Наименование
            // 
            this.Наименование.HeaderText = "NameChar";
            this.Наименование.Name = "Наименование";
            this.Наименование.ReadOnly = true;
            // 
            // Оценка
            // 
            this.Оценка.HeaderText = "Value";
            this.Оценка.Name = "Оценка";
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(384, 12);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 1;
            this.Compute.Text = "Вычислить";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.CharsListDGV);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.EvaluationLoad);
            ((System.ComponentModel.ISupportInitialize)(this.CharsListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CharsListDGV;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оценка;
    }
}