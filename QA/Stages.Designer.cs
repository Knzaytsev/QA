namespace QA
{
    partial class Stages
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServiceRadioButton = new System.Windows.Forms.RadioButton();
            this.ExploitationRadioButton = new System.Windows.Forms.RadioButton();
            this.IntroductionRadioButton = new System.Windows.Forms.RadioButton();
            this.ManufactureTestRadioButton = new System.Windows.Forms.RadioButton();
            this.ManufactureReleaseRadioButton = new System.Windows.Forms.RadioButton();
            this.TestingRadioButton = new System.Windows.Forms.RadioButton();
            this.ImplementationRadioButton = new System.Windows.Forms.RadioButton();
            this.ProjectingRadioButton = new System.Windows.Forms.RadioButton();
            this.Analysis = new System.Windows.Forms.RadioButton();
            this.ChoosePhase = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ServiceRadioButton);
            this.panel1.Controls.Add(this.ExploitationRadioButton);
            this.panel1.Controls.Add(this.IntroductionRadioButton);
            this.panel1.Controls.Add(this.ManufactureTestRadioButton);
            this.panel1.Controls.Add(this.ManufactureReleaseRadioButton);
            this.panel1.Controls.Add(this.TestingRadioButton);
            this.panel1.Controls.Add(this.ImplementationRadioButton);
            this.panel1.Controls.Add(this.ProjectingRadioButton);
            this.panel1.Controls.Add(this.Analysis);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 249);
            this.panel1.TabIndex = 0;
            // 
            // ServiceRadioButton
            // 
            this.ServiceRadioButton.AutoSize = true;
            this.ServiceRadioButton.Location = new System.Drawing.Point(13, 196);
            this.ServiceRadioButton.Name = "ServiceRadioButton";
            this.ServiceRadioButton.Size = new System.Drawing.Size(189, 17);
            this.ServiceRadioButton.TabIndex = 9;
            this.ServiceRadioButton.TabStop = true;
            this.ServiceRadioButton.Tag = "8";
            this.ServiceRadioButton.Text = "Обслуживание (сопровождение)";
            this.ServiceRadioButton.UseVisualStyleBackColor = true;
            this.ServiceRadioButton.CheckedChanged += new System.EventHandler(this.ServiceRadioButton_CheckedChanged);
            // 
            // ExploitationRadioButton
            // 
            this.ExploitationRadioButton.AutoSize = true;
            this.ExploitationRadioButton.Location = new System.Drawing.Point(12, 173);
            this.ExploitationRadioButton.Name = "ExploitationRadioButton";
            this.ExploitationRadioButton.Size = new System.Drawing.Size(96, 17);
            this.ExploitationRadioButton.TabIndex = 8;
            this.ExploitationRadioButton.TabStop = true;
            this.ExploitationRadioButton.Tag = "7";
            this.ExploitationRadioButton.Text = "Эксплуатация";
            this.ExploitationRadioButton.UseVisualStyleBackColor = true;
            this.ExploitationRadioButton.CheckedChanged += new System.EventHandler(this.ExploitationRadioButton_CheckedChanged);
            // 
            // IntroductionRadioButton
            // 
            this.IntroductionRadioButton.AutoSize = true;
            this.IntroductionRadioButton.Location = new System.Drawing.Point(12, 150);
            this.IntroductionRadioButton.Name = "IntroductionRadioButton";
            this.IntroductionRadioButton.Size = new System.Drawing.Size(80, 17);
            this.IntroductionRadioButton.TabIndex = 7;
            this.IntroductionRadioButton.TabStop = true;
            this.IntroductionRadioButton.Tag = "6";
            this.IntroductionRadioButton.Text = "Внедрение";
            this.IntroductionRadioButton.UseVisualStyleBackColor = true;
            this.IntroductionRadioButton.CheckedChanged += new System.EventHandler(this.IntroductionRadioButton_CheckedChanged);
            // 
            // ManufactureTestRadioButton
            // 
            this.ManufactureTestRadioButton.AutoSize = true;
            this.ManufactureTestRadioButton.Location = new System.Drawing.Point(12, 127);
            this.ManufactureTestRadioButton.Name = "ManufactureTestRadioButton";
            this.ManufactureTestRadioButton.Size = new System.Drawing.Size(213, 17);
            this.ManufactureTestRadioButton.TabIndex = 6;
            this.ManufactureTestRadioButton.TabStop = true;
            this.ManufactureTestRadioButton.Tag = "5";
            this.ManufactureTestRadioButton.Text = "Изготовление (Подфаза: испытания)";
            this.ManufactureTestRadioButton.UseVisualStyleBackColor = true;
            this.ManufactureTestRadioButton.CheckedChanged += new System.EventHandler(this.ManufactureTestRadioButton_CheckedChanged);
            // 
            // ManufactureReleaseRadioButton
            // 
            this.ManufactureReleaseRadioButton.AutoSize = true;
            this.ManufactureReleaseRadioButton.Location = new System.Drawing.Point(12, 104);
            this.ManufactureReleaseRadioButton.Name = "ManufactureReleaseRadioButton";
            this.ManufactureReleaseRadioButton.Size = new System.Drawing.Size(195, 17);
            this.ManufactureReleaseRadioButton.TabIndex = 5;
            this.ManufactureReleaseRadioButton.TabStop = true;
            this.ManufactureReleaseRadioButton.Tag = "4";
            this.ManufactureReleaseRadioButton.Text = "Изготовление (Подфаза: выпуск)";
            this.ManufactureReleaseRadioButton.UseVisualStyleBackColor = true;
            this.ManufactureReleaseRadioButton.CheckedChanged += new System.EventHandler(this.ManufactureReleaseRadioButton_CheckedChanged);
            // 
            // TestingRadioButton
            // 
            this.TestingRadioButton.AutoSize = true;
            this.TestingRadioButton.Location = new System.Drawing.Point(12, 81);
            this.TestingRadioButton.Name = "TestingRadioButton";
            this.TestingRadioButton.Size = new System.Drawing.Size(97, 17);
            this.TestingRadioButton.TabIndex = 4;
            this.TestingRadioButton.TabStop = true;
            this.TestingRadioButton.Tag = "3";
            this.TestingRadioButton.Text = "Тестирование";
            this.TestingRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImplementationRadioButton
            // 
            this.ImplementationRadioButton.AutoSize = true;
            this.ImplementationRadioButton.Location = new System.Drawing.Point(12, 58);
            this.ImplementationRadioButton.Name = "ImplementationRadioButton";
            this.ImplementationRadioButton.Size = new System.Drawing.Size(86, 17);
            this.ImplementationRadioButton.TabIndex = 3;
            this.ImplementationRadioButton.TabStop = true;
            this.ImplementationRadioButton.Tag = "2";
            this.ImplementationRadioButton.Text = "Реализация";
            this.ImplementationRadioButton.UseVisualStyleBackColor = true;
            this.ImplementationRadioButton.CheckedChanged += new System.EventHandler(this.ImplementationRadioButton_CheckedChanged);
            // 
            // ProjectingRadioButton
            // 
            this.ProjectingRadioButton.AutoSize = true;
            this.ProjectingRadioButton.Location = new System.Drawing.Point(12, 35);
            this.ProjectingRadioButton.Name = "ProjectingRadioButton";
            this.ProjectingRadioButton.Size = new System.Drawing.Size(110, 17);
            this.ProjectingRadioButton.TabIndex = 2;
            this.ProjectingRadioButton.TabStop = true;
            this.ProjectingRadioButton.Tag = "1";
            this.ProjectingRadioButton.Text = "Проектирование";
            this.ProjectingRadioButton.UseVisualStyleBackColor = true;
            this.ProjectingRadioButton.CheckedChanged += new System.EventHandler(this.ProjectingRadioButton_CheckedChanged);
            // 
            // Analysis
            // 
            this.Analysis.AutoSize = true;
            this.Analysis.Location = new System.Drawing.Point(12, 12);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(62, 17);
            this.Analysis.TabIndex = 1;
            this.Analysis.TabStop = true;
            this.Analysis.Tag = "0";
            this.Analysis.Text = "Анализ";
            this.Analysis.UseVisualStyleBackColor = true;
            this.Analysis.CheckedChanged += new System.EventHandler(this.Analysis_CheckedChanged);
            // 
            // ChoosePhase
            // 
            this.ChoosePhase.Location = new System.Drawing.Point(236, 267);
            this.ChoosePhase.Name = "ChoosePhase";
            this.ChoosePhase.Size = new System.Drawing.Size(74, 23);
            this.ChoosePhase.TabIndex = 10;
            this.ChoosePhase.Text = "Далее";
            this.ChoosePhase.UseVisualStyleBackColor = true;
            this.ChoosePhase.Click += new System.EventHandler(this.ChoosePhase_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 267);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 11;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Stages
            // 
            this.AcceptButton = this.ChoosePhase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 298);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ChoosePhase);
            this.Controls.Add(this.panel1);
            this.Name = "Stages";
            this.Text = "Выбор фазы ЖЦ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stages_FormClosed);
            this.Load += new System.EventHandler(this.Stages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Analysis;
        private System.Windows.Forms.RadioButton ProjectingRadioButton;
        private System.Windows.Forms.RadioButton ImplementationRadioButton;
        private System.Windows.Forms.RadioButton ManufactureReleaseRadioButton;
        private System.Windows.Forms.RadioButton TestingRadioButton;
        private System.Windows.Forms.RadioButton ManufactureTestRadioButton;
        private System.Windows.Forms.RadioButton IntroductionRadioButton;
        private System.Windows.Forms.RadioButton ExploitationRadioButton;
        private System.Windows.Forms.RadioButton ServiceRadioButton;
        private System.Windows.Forms.Button ChoosePhase;
        private System.Windows.Forms.Button Back;
    }
}