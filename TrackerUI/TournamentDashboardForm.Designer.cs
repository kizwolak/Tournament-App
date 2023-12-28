namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            TournamentDashboardHeader = new Label();
            LoadTournamentLabel = new Label();
            SelectTeaDropdown = new ComboBox();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardHeader
            // 
            TournamentDashboardHeader.AutoSize = true;
            TournamentDashboardHeader.BackColor = SystemColors.Window;
            TournamentDashboardHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TournamentDashboardHeader.ForeColor = SystemColors.MenuHighlight;
            TournamentDashboardHeader.Location = new Point(202, 35);
            TournamentDashboardHeader.Name = "TournamentDashboardHeader";
            TournamentDashboardHeader.Size = new Size(408, 50);
            TournamentDashboardHeader.TabIndex = 15;
            TournamentDashboardHeader.Text = "Tournament Dashboard";
            TournamentDashboardHeader.Click += TournamentDashboardHeader_Click;
            // 
            // LoadTournamentLabel
            // 
            LoadTournamentLabel.AutoSize = true;
            LoadTournamentLabel.BackColor = SystemColors.Window;
            LoadTournamentLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LoadTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            LoadTournamentLabel.Location = new Point(237, 127);
            LoadTournamentLabel.Name = "LoadTournamentLabel";
            LoadTournamentLabel.Size = new Size(334, 38);
            LoadTournamentLabel.TabIndex = 17;
            LoadTournamentLabel.Text = "Load Existing Tournament";
            LoadTournamentLabel.Click += SelectTeamMemberLabel_Click;
            // 
            // SelectTeaDropdown
            // 
            SelectTeaDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SelectTeaDropdown.FormattingEnabled = true;
            SelectTeaDropdown.Location = new Point(202, 184);
            SelectTeaDropdown.Name = "SelectTeaDropdown";
            SelectTeaDropdown.Size = new Size(397, 28);
            SelectTeaDropdown.TabIndex = 16;
            SelectTeaDropdown.SelectedIndexChanged += PlayerDropdown_SelectedIndexChanged;
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.Black;
            LoadTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoadTournamentButton.ForeColor = SystemColors.HotTrack;
            LoadTournamentButton.Location = new Point(267, 236);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(275, 53);
            LoadTournamentButton.TabIndex = 33;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            LoadTournamentButton.Click += LoadTournamentButton_Click;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.Black;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CreateTournamentButton.ForeColor = SystemColors.HotTrack;
            CreateTournamentButton.Location = new Point(202, 334);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(397, 91);
            CreateTournamentButton.TabIndex = 34;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadTournamentLabel);
            Controls.Add(SelectTeaDropdown);
            Controls.Add(TournamentDashboardHeader);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardHeader;
        private Label LoadTournamentLabel;
        private ComboBox SelectTeaDropdown;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}