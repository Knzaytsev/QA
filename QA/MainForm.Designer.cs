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
            this.OSradioButton = new System.Windows.Forms.RadioButton();
            this.DBMSradioButton = new System.Windows.Forms.RadioButton();
            this.ProgrammingToolsRadioButton = new System.Windows.Forms.RadioButton();
            this.InterfaceCommunicationRadioButton = new System.Windows.Forms.RadioButton();
            this.PlanningRadioButton = new System.Windows.Forms.RadioButton();
            this.ServiceProgramsRadioButton = new System.Windows.Forms.RadioButton();
            this.ComputerServiceRadioButton = new System.Windows.Forms.RadioButton();
            this.ScienceResearchRadioButton = new System.Windows.Forms.RadioButton();
            this.ProjectingProgramRadioButton = new System.Windows.Forms.RadioButton();
            this.ManagementRadioButton = new System.Windows.Forms.RadioButton();
            this.EconomyRadioButton = new System.Windows.Forms.RadioButton();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OSradioButton
            // 
            this.OSradioButton.AutoSize = true;
            this.OSradioButton.Location = new System.Drawing.Point(18, 20);
            this.OSradioButton.Name = "OSradioButton";
            this.OSradioButton.Size = new System.Drawing.Size(287, 17);
            this.OSradioButton.TabIndex = 0;
            this.OSradioButton.TabStop = true;
            this.OSradioButton.Tag = "0";
            this.OSradioButton.Text = "Операционные системы и средства их расширения";
            this.OSradioButton.UseVisualStyleBackColor = true;
            this.OSradioButton.CheckedChanged += new System.EventHandler(this.OSradioButton_CheckedChanged);
            // 
            // DBMSradioButton
            // 
            this.DBMSradioButton.AutoSize = true;
            this.DBMSradioButton.Location = new System.Drawing.Point(18, 43);
            this.DBMSradioButton.Name = "DBMSradioButton";
            this.DBMSradioButton.Size = new System.Drawing.Size(229, 17);
            this.DBMSradioButton.TabIndex = 1;
            this.DBMSradioButton.TabStop = true;
            this.DBMSradioButton.Tag = "1";
            this.DBMSradioButton.Text = "Программные средства управления БД";
            this.DBMSradioButton.UseVisualStyleBackColor = true;
            // 
            // ProgrammingToolsRadioButton
            // 
            this.ProgrammingToolsRadioButton.AutoSize = true;
            this.ProgrammingToolsRadioButton.Location = new System.Drawing.Point(18, 66);
            this.ProgrammingToolsRadioButton.Name = "ProgrammingToolsRadioButton";
            this.ProgrammingToolsRadioButton.Size = new System.Drawing.Size(334, 17);
            this.ProgrammingToolsRadioButton.TabIndex = 2;
            this.ProgrammingToolsRadioButton.TabStop = true;
            this.ProgrammingToolsRadioButton.Tag = "2";
            this.ProgrammingToolsRadioButton.Text = "Инструментально-технические средства программирования";
            this.ProgrammingToolsRadioButton.UseVisualStyleBackColor = true;
            // 
            // InterfaceCommunicationRadioButton
            // 
            this.InterfaceCommunicationRadioButton.AutoSize = true;
            this.InterfaceCommunicationRadioButton.Location = new System.Drawing.Point(18, 89);
            this.InterfaceCommunicationRadioButton.Name = "InterfaceCommunicationRadioButton";
            this.InterfaceCommunicationRadioButton.Size = new System.Drawing.Size(267, 17);
            this.InterfaceCommunicationRadioButton.TabIndex = 3;
            this.InterfaceCommunicationRadioButton.TabStop = true;
            this.InterfaceCommunicationRadioButton.Tag = "3";
            this.InterfaceCommunicationRadioButton.Text = "ПС интерфейса и управления коммуникациями";
            this.InterfaceCommunicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlanningRadioButton
            // 
            this.PlanningRadioButton.AutoSize = true;
            this.PlanningRadioButton.Location = new System.Drawing.Point(18, 112);
            this.PlanningRadioButton.Name = "PlanningRadioButton";
            this.PlanningRadioButton.Size = new System.Drawing.Size(385, 17);
            this.PlanningRadioButton.TabIndex = 4;
            this.PlanningRadioButton.TabStop = true;
            this.PlanningRadioButton.Tag = "4";
            this.PlanningRadioButton.Text = "ПС организации вычислительного процесса (планирования, контроля)";
            this.PlanningRadioButton.UseVisualStyleBackColor = true;
            // 
            // ServiceProgramsRadioButton
            // 
            this.ServiceProgramsRadioButton.AutoSize = true;
            this.ServiceProgramsRadioButton.Location = new System.Drawing.Point(18, 135);
            this.ServiceProgramsRadioButton.Name = "ServiceProgramsRadioButton";
            this.ServiceProgramsRadioButton.Size = new System.Drawing.Size(144, 17);
            this.ServiceProgramsRadioButton.TabIndex = 5;
            this.ServiceProgramsRadioButton.TabStop = true;
            this.ServiceProgramsRadioButton.Tag = "5";
            this.ServiceProgramsRadioButton.Text = "Сервисные программы";
            this.ServiceProgramsRadioButton.UseVisualStyleBackColor = true;
            // 
            // ComputerServiceRadioButton
            // 
            this.ComputerServiceRadioButton.AutoSize = true;
            this.ComputerServiceRadioButton.Location = new System.Drawing.Point(18, 158);
            this.ComputerServiceRadioButton.Name = "ComputerServiceRadioButton";
            this.ComputerServiceRadioButton.Size = new System.Drawing.Size(240, 17);
            this.ComputerServiceRadioButton.TabIndex = 6;
            this.ComputerServiceRadioButton.TabStop = true;
            this.ComputerServiceRadioButton.Tag = "6";
            this.ComputerServiceRadioButton.Text = "ПС обслуживания вычисительной техники";
            this.ComputerServiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // ScienceResearchRadioButton
            // 
            this.ScienceResearchRadioButton.AutoSize = true;
            this.ScienceResearchRadioButton.Location = new System.Drawing.Point(18, 181);
            this.ScienceResearchRadioButton.Name = "ScienceResearchRadioButton";
            this.ScienceResearchRadioButton.Size = new System.Drawing.Size(291, 17);
            this.ScienceResearchRadioButton.TabIndex = 7;
            this.ScienceResearchRadioButton.TabStop = true;
            this.ScienceResearchRadioButton.Tag = "7";
            this.ScienceResearchRadioButton.Text = "Прикладные программы для научных исследований";
            this.ScienceResearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProjectingProgramRadioButton
            // 
            this.ProjectingProgramRadioButton.AutoSize = true;
            this.ProjectingProgramRadioButton.Location = new System.Drawing.Point(18, 204);
            this.ProjectingProgramRadioButton.Name = "ProjectingProgramRadioButton";
            this.ProjectingProgramRadioButton.Size = new System.Drawing.Size(247, 17);
            this.ProjectingProgramRadioButton.TabIndex = 8;
            this.ProjectingProgramRadioButton.TabStop = true;
            this.ProjectingProgramRadioButton.Tag = "8";
            this.ProjectingProgramRadioButton.Text = "Прикладные программы для планирования";
            this.ProjectingProgramRadioButton.UseVisualStyleBackColor = true;
            // 
            // ManagementRadioButton
            // 
            this.ManagementRadioButton.AutoSize = true;
            this.ManagementRadioButton.Location = new System.Drawing.Point(18, 227);
            this.ManagementRadioButton.Name = "ManagementRadioButton";
            this.ManagementRadioButton.Size = new System.Drawing.Size(553, 17);
            this.ManagementRadioButton.TabIndex = 9;
            this.ManagementRadioButton.TabStop = true;
            this.ManagementRadioButton.Tag = "9";
            this.ManagementRadioButton.Text = "Прикладные программы для управления техническими устройствами и технологическими " +
    "процессами";
            this.ManagementRadioButton.UseVisualStyleBackColor = true;
            // 
            // EconomyRadioButton
            // 
            this.EconomyRadioButton.AutoSize = true;
            this.EconomyRadioButton.Location = new System.Drawing.Point(18, 250);
            this.EconomyRadioButton.Name = "EconomyRadioButton";
            this.EconomyRadioButton.Size = new System.Drawing.Size(332, 17);
            this.EconomyRadioButton.TabIndex = 10;
            this.EconomyRadioButton.TabStop = true;
            this.EconomyRadioButton.Tag = "10";
            this.EconomyRadioButton.Text = "Прикладные программы для решения экономических задач";
            this.EconomyRadioButton.UseVisualStyleBackColor = true;
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(18, 273);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(86, 17);
            this.OtherRadioButton.TabIndex = 11;
            this.OtherRadioButton.TabStop = true;
            this.OtherRadioButton.Tag = "11";
            this.OtherRadioButton.Text = "Пррочие ПС";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OSradioButton);
            this.panel1.Controls.Add(this.OtherRadioButton);
            this.panel1.Controls.Add(this.DBMSradioButton);
            this.panel1.Controls.Add(this.EconomyRadioButton);
            this.panel1.Controls.Add(this.ProgrammingToolsRadioButton);
            this.panel1.Controls.Add(this.ManagementRadioButton);
            this.panel1.Controls.Add(this.InterfaceCommunicationRadioButton);
            this.panel1.Controls.Add(this.ProjectingProgramRadioButton);
            this.panel1.Controls.Add(this.PlanningRadioButton);
            this.panel1.Controls.Add(this.ScienceResearchRadioButton);
            this.panel1.Controls.Add(this.ServiceProgramsRadioButton);
            this.panel1.Controls.Add(this.ComputerServiceRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 304);
            this.panel1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 347);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton OSradioButton;
        private System.Windows.Forms.RadioButton DBMSradioButton;
        private System.Windows.Forms.RadioButton ProgrammingToolsRadioButton;
        private System.Windows.Forms.RadioButton InterfaceCommunicationRadioButton;
        private System.Windows.Forms.RadioButton PlanningRadioButton;
        private System.Windows.Forms.RadioButton ServiceProgramsRadioButton;
        private System.Windows.Forms.RadioButton ComputerServiceRadioButton;
        private System.Windows.Forms.RadioButton ScienceResearchRadioButton;
        private System.Windows.Forms.RadioButton ProjectingProgramRadioButton;
        private System.Windows.Forms.RadioButton ManagementRadioButton;
        private System.Windows.Forms.RadioButton EconomyRadioButton;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.Panel panel1;
    }
}

