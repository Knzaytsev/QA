namespace QA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.EconomyRadioButton = new System.Windows.Forms.RadioButton();
            this.ManagingRadioButton = new System.Windows.Forms.RadioButton();
            this.ProjectingRadioButton = new System.Windows.Forms.RadioButton();
            this.ScienceResearchRadioButton = new System.Windows.Forms.RadioButton();
            this.ServiceComputingRadioButton = new System.Windows.Forms.RadioButton();
            this.ServiceSoftwareRadioButton = new System.Windows.Forms.RadioButton();
            this.ComputingProcessRadioButton = new System.Windows.Forms.RadioButton();
            this.InterfaceCommunicationRadioButton = new System.Windows.Forms.RadioButton();
            this.ProgrammingToolsRadioButton = new System.Windows.Forms.RadioButton();
            this.DBMSradioButton = new System.Windows.Forms.RadioButton();
            this.OSradioButton = new System.Windows.Forms.RadioButton();
            this.ChooseClass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OtherRadioButton);
            this.panel1.Controls.Add(this.EconomyRadioButton);
            this.panel1.Controls.Add(this.ManagingRadioButton);
            this.panel1.Controls.Add(this.ProjectingRadioButton);
            this.panel1.Controls.Add(this.ScienceResearchRadioButton);
            this.panel1.Controls.Add(this.ServiceComputingRadioButton);
            this.panel1.Controls.Add(this.ServiceSoftwareRadioButton);
            this.panel1.Controls.Add(this.ComputingProcessRadioButton);
            this.panel1.Controls.Add(this.InterfaceCommunicationRadioButton);
            this.panel1.Controls.Add(this.ProgrammingToolsRadioButton);
            this.panel1.Controls.Add(this.DBMSradioButton);
            this.panel1.Controls.Add(this.OSradioButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 285);
            this.panel1.TabIndex = 0;
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(3, 256);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(80, 17);
            this.OtherRadioButton.TabIndex = 11;
            this.OtherRadioButton.Tag = "11";
            this.OtherRadioButton.Text = "Прочие ПС";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            this.OtherRadioButton.CheckedChanged += new System.EventHandler(this.OtherRadioButton_CheckedChanged);
            // 
            // EconomyRadioButton
            // 
            this.EconomyRadioButton.AutoSize = true;
            this.EconomyRadioButton.Location = new System.Drawing.Point(3, 233);
            this.EconomyRadioButton.Name = "EconomyRadioButton";
            this.EconomyRadioButton.Size = new System.Drawing.Size(332, 17);
            this.EconomyRadioButton.TabIndex = 10;
            this.EconomyRadioButton.Tag = "10";
            this.EconomyRadioButton.Text = "Прикладные программы для решения экономических задач";
            this.EconomyRadioButton.UseVisualStyleBackColor = true;
            this.EconomyRadioButton.CheckedChanged += new System.EventHandler(this.EconomyRadioButton_CheckedChanged);
            // 
            // ManagingRadioButton
            // 
            this.ManagingRadioButton.AutoSize = true;
            this.ManagingRadioButton.Location = new System.Drawing.Point(3, 210);
            this.ManagingRadioButton.Name = "ManagingRadioButton";
            this.ManagingRadioButton.Size = new System.Drawing.Size(553, 17);
            this.ManagingRadioButton.TabIndex = 9;
            this.ManagingRadioButton.Tag = "9";
            this.ManagingRadioButton.Text = "Прикладные программы для управления техническими устройствами и технологическими " +
    "процессами";
            this.ManagingRadioButton.UseVisualStyleBackColor = true;
            this.ManagingRadioButton.CheckedChanged += new System.EventHandler(this.ManagingRadioButton_CheckedChanged);
            // 
            // ProjectingRadioButton
            // 
            this.ProjectingRadioButton.AutoSize = true;
            this.ProjectingRadioButton.Location = new System.Drawing.Point(3, 187);
            this.ProjectingRadioButton.Name = "ProjectingRadioButton";
            this.ProjectingRadioButton.Size = new System.Drawing.Size(258, 17);
            this.ProjectingRadioButton.TabIndex = 8;
            this.ProjectingRadioButton.Tag = "8";
            this.ProjectingRadioButton.Text = "Прикладные программы для проектирования";
            this.ProjectingRadioButton.UseVisualStyleBackColor = true;
            this.ProjectingRadioButton.CheckedChanged += new System.EventHandler(this.ProjectingRadioButton_CheckedChanged);
            // 
            // ScienceResearchRadioButton
            // 
            this.ScienceResearchRadioButton.AutoSize = true;
            this.ScienceResearchRadioButton.Location = new System.Drawing.Point(3, 164);
            this.ScienceResearchRadioButton.Name = "ScienceResearchRadioButton";
            this.ScienceResearchRadioButton.Size = new System.Drawing.Size(291, 17);
            this.ScienceResearchRadioButton.TabIndex = 7;
            this.ScienceResearchRadioButton.Tag = "7";
            this.ScienceResearchRadioButton.Text = "Прикладные программы для научных исследований";
            this.ScienceResearchRadioButton.UseVisualStyleBackColor = true;
            this.ScienceResearchRadioButton.CheckedChanged += new System.EventHandler(this.ScienceResearchRadioButton_CheckedChanged);
            // 
            // ServiceComputingRadioButton
            // 
            this.ServiceComputingRadioButton.AutoSize = true;
            this.ServiceComputingRadioButton.Location = new System.Drawing.Point(3, 141);
            this.ServiceComputingRadioButton.Name = "ServiceComputingRadioButton";
            this.ServiceComputingRadioButton.Size = new System.Drawing.Size(246, 17);
            this.ServiceComputingRadioButton.TabIndex = 6;
            this.ServiceComputingRadioButton.Tag = "6";
            this.ServiceComputingRadioButton.Text = "ПС обслуживания вычислительной техники";
            this.ServiceComputingRadioButton.UseVisualStyleBackColor = true;
            this.ServiceComputingRadioButton.CheckedChanged += new System.EventHandler(this.ServiceComputingRadioButton_CheckedChanged);
            // 
            // ServiceSoftwareRadioButton
            // 
            this.ServiceSoftwareRadioButton.AutoSize = true;
            this.ServiceSoftwareRadioButton.Location = new System.Drawing.Point(3, 118);
            this.ServiceSoftwareRadioButton.Name = "ServiceSoftwareRadioButton";
            this.ServiceSoftwareRadioButton.Size = new System.Drawing.Size(144, 17);
            this.ServiceSoftwareRadioButton.TabIndex = 5;
            this.ServiceSoftwareRadioButton.Tag = "5";
            this.ServiceSoftwareRadioButton.Text = "Сервисные программы";
            this.ServiceSoftwareRadioButton.UseVisualStyleBackColor = true;
            this.ServiceSoftwareRadioButton.CheckedChanged += new System.EventHandler(this.ServiceSoftwareRadioButton_CheckedChanged);
            // 
            // ComputingProcessRadioButton
            // 
            this.ComputingProcessRadioButton.AutoSize = true;
            this.ComputingProcessRadioButton.Location = new System.Drawing.Point(3, 95);
            this.ComputingProcessRadioButton.Name = "ComputingProcessRadioButton";
            this.ComputingProcessRadioButton.Size = new System.Drawing.Size(385, 17);
            this.ComputingProcessRadioButton.TabIndex = 4;
            this.ComputingProcessRadioButton.Tag = "4";
            this.ComputingProcessRadioButton.Text = "ПС организации вычислительного процесса (планирования, контроля)";
            this.ComputingProcessRadioButton.UseVisualStyleBackColor = true;
            this.ComputingProcessRadioButton.CheckedChanged += new System.EventHandler(this.ComputingProcessRadioButton_CheckedChanged);
            // 
            // InterfaceCommunicationRadioButton
            // 
            this.InterfaceCommunicationRadioButton.AutoSize = true;
            this.InterfaceCommunicationRadioButton.Location = new System.Drawing.Point(3, 72);
            this.InterfaceCommunicationRadioButton.Name = "InterfaceCommunicationRadioButton";
            this.InterfaceCommunicationRadioButton.Size = new System.Drawing.Size(267, 17);
            this.InterfaceCommunicationRadioButton.TabIndex = 3;
            this.InterfaceCommunicationRadioButton.Tag = "3";
            this.InterfaceCommunicationRadioButton.Text = "ПС интерфейса и управления коммуникациями";
            this.InterfaceCommunicationRadioButton.UseVisualStyleBackColor = true;
            this.InterfaceCommunicationRadioButton.CheckedChanged += new System.EventHandler(this.InterfaceCommunicationRadioButton_CheckedChanged);
            // 
            // ProgrammingToolsRadioButton
            // 
            this.ProgrammingToolsRadioButton.AutoSize = true;
            this.ProgrammingToolsRadioButton.Location = new System.Drawing.Point(3, 49);
            this.ProgrammingToolsRadioButton.Name = "ProgrammingToolsRadioButton";
            this.ProgrammingToolsRadioButton.Size = new System.Drawing.Size(357, 17);
            this.ProgrammingToolsRadioButton.TabIndex = 2;
            this.ProgrammingToolsRadioButton.Tag = "2";
            this.ProgrammingToolsRadioButton.Text = "Инструментально-технологические средства программирования";
            this.ProgrammingToolsRadioButton.UseVisualStyleBackColor = true;
            this.ProgrammingToolsRadioButton.CheckedChanged += new System.EventHandler(this.ProgrammingToolsRadioButton_CheckedChanged);
            // 
            // DBMSradioButton
            // 
            this.DBMSradioButton.AutoSize = true;
            this.DBMSradioButton.Location = new System.Drawing.Point(3, 26);
            this.DBMSradioButton.Name = "DBMSradioButton";
            this.DBMSradioButton.Size = new System.Drawing.Size(229, 17);
            this.DBMSradioButton.TabIndex = 1;
            this.DBMSradioButton.Tag = "1";
            this.DBMSradioButton.Text = "Программные средства управления БД";
            this.DBMSradioButton.UseVisualStyleBackColor = true;
            this.DBMSradioButton.CheckedChanged += new System.EventHandler(this.DBMSradioButton_CheckedChanged);
            // 
            // OSradioButton
            // 
            this.OSradioButton.AutoSize = true;
            this.OSradioButton.Checked = true;
            this.OSradioButton.Location = new System.Drawing.Point(3, 3);
            this.OSradioButton.Name = "OSradioButton";
            this.OSradioButton.Size = new System.Drawing.Size(287, 17);
            this.OSradioButton.TabIndex = 0;
            this.OSradioButton.TabStop = true;
            this.OSradioButton.Tag = "0";
            this.OSradioButton.Text = "Операционные системы и средства их расширения";
            this.OSradioButton.UseVisualStyleBackColor = true;
            this.OSradioButton.CheckedChanged += new System.EventHandler(this.OSradioButton_CheckedChanged);
            // 
            // ChooseClass
            // 
            this.ChooseClass.Location = new System.Drawing.Point(464, 303);
            this.ChooseClass.Name = "ChooseClass";
            this.ChooseClass.Size = new System.Drawing.Size(117, 23);
            this.ChooseClass.TabIndex = 12;
            this.ChooseClass.Text = "Далее";
            this.ChooseClass.UseVisualStyleBackColor = true;
            this.ChooseClass.Click += new System.EventHandler(this.ChooseClass_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ChooseClass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 336);
            this.Controls.Add(this.ChooseClass);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Выбор класса ПС";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OSradioButton;
        private System.Windows.Forms.RadioButton DBMSradioButton;
        private System.Windows.Forms.RadioButton ProgrammingToolsRadioButton;
        private System.Windows.Forms.RadioButton InterfaceCommunicationRadioButton;
        private System.Windows.Forms.RadioButton ComputingProcessRadioButton;
        private System.Windows.Forms.RadioButton ServiceSoftwareRadioButton;
        private System.Windows.Forms.RadioButton ServiceComputingRadioButton;
        private System.Windows.Forms.RadioButton ScienceResearchRadioButton;
        private System.Windows.Forms.RadioButton ProjectingRadioButton;
        private System.Windows.Forms.RadioButton ManagingRadioButton;
        private System.Windows.Forms.RadioButton EconomyRadioButton;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.Button ChooseClass;
    }
}

