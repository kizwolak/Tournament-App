namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TournamentHeader = new Label();
            TournamentName = new Label();
            RoundHeader = new Label();
            RoundDropdown = new ComboBox();
            UnplayedCheckbox = new CheckBox();
            matchupListbox = new ListBox();
            TeamOneName = new Label();
            TeamTwoName = new Label();
            ScoreLabel = new Label();
            TeamOneScore = new TextBox();
            TeamTwoScore = new TextBox();
            VersusLabel = new Label();
            ScoreButton = new Button();
            SuspendLayout();
            // 
            // TournamentHeader
            // 
            TournamentHeader.AutoSize = true;
            TournamentHeader.BackColor = SystemColors.Window;
            TournamentHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TournamentHeader.ForeColor = SystemColors.MenuHighlight;
            TournamentHeader.Location = new Point(10, 9);
            TournamentHeader.Name = "TournamentHeader";
            TournamentHeader.Size = new Size(207, 46);
            TournamentHeader.TabIndex = 0;
            TournamentHeader.Text = "Tournament:";
            TournamentHeader.Click += label1_Click;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.BackColor = SystemColors.Window;
            TournamentName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TournamentName.ForeColor = SystemColors.MenuHighlight;
            TournamentName.Location = new Point(223, 9);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(142, 46);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            TournamentName.Click += label2_Click;
            // 
            // RoundHeader
            // 
            RoundHeader.AutoSize = true;
            RoundHeader.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RoundHeader.ForeColor = SystemColors.ActiveCaptionText;
            RoundHeader.Location = new Point(26, 69);
            RoundHeader.Name = "RoundHeader";
            RoundHeader.Size = new Size(73, 28);
            RoundHeader.TabIndex = 2;
            RoundHeader.Text = "Round:";
            // 
            // RoundDropdown
            // 
            RoundDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RoundDropdown.FormattingEnabled = true;
            RoundDropdown.Location = new Point(105, 69);
            RoundDropdown.Name = "RoundDropdown";
            RoundDropdown.Size = new Size(125, 28);
            RoundDropdown.TabIndex = 3;
            // 
            // UnplayedCheckbox
            // 
            UnplayedCheckbox.AutoSize = true;
            UnplayedCheckbox.FlatStyle = FlatStyle.Flat;
            UnplayedCheckbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            UnplayedCheckbox.ForeColor = SystemColors.HotTrack;
            UnplayedCheckbox.Location = new Point(105, 103);
            UnplayedCheckbox.Name = "UnplayedCheckbox";
            UnplayedCheckbox.Size = new Size(183, 35);
            UnplayedCheckbox.TabIndex = 4;
            UnplayedCheckbox.Text = "Unplayed Only";
            UnplayedCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListbox
            // 
            matchupListbox.BorderStyle = BorderStyle.FixedSingle;
            matchupListbox.FormattingEnabled = true;
            matchupListbox.ItemHeight = 17;
            matchupListbox.Location = new Point(26, 156);
            matchupListbox.Name = "matchupListbox";
            matchupListbox.Size = new Size(262, 189);
            matchupListbox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TeamOneName.ForeColor = SystemColors.ActiveCaptionText;
            TeamOneName.Location = new Point(368, 156);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(116, 31);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<team 1>";
            TeamOneName.Click += TeamOneName_Click;
            // 
            // TeamTwoName
            // 
            TeamTwoName.AutoSize = true;
            TeamTwoName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TeamTwoName.ForeColor = SystemColors.ActiveCaptionText;
            TeamTwoName.Location = new Point(512, 156);
            TeamTwoName.Name = "TeamTwoName";
            TeamTwoName.Size = new Size(116, 31);
            TeamTwoName.TabIndex = 7;
            TeamTwoName.Text = "<team 2>";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ScoreLabel.Location = new Point(309, 193);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(56, 25);
            ScoreLabel.TabIndex = 8;
            ScoreLabel.Text = "Score";
            // 
            // TeamOneScore
            // 
            TeamOneScore.Location = new Point(385, 193);
            TeamOneScore.Name = "TeamOneScore";
            TeamOneScore.Size = new Size(78, 25);
            TeamOneScore.TabIndex = 9;
            TeamOneScore.TextChanged += teamOneScore_TextChanged;
            // 
            // TeamTwoScore
            // 
            TeamTwoScore.Location = new Point(528, 193);
            TeamTwoScore.Name = "TeamTwoScore";
            TeamTwoScore.Size = new Size(78, 25);
            TeamTwoScore.TabIndex = 10;
            TeamTwoScore.TextChanged += textBox2_TextChanged;
            // 
            // VersusLabel
            // 
            VersusLabel.AutoSize = true;
            VersusLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            VersusLabel.ForeColor = SystemColors.ActiveCaptionText;
            VersusLabel.Location = new Point(471, 125);
            VersusLabel.Name = "VersusLabel";
            VersusLabel.Size = new Size(58, 31);
            VersusLabel.TabIndex = 11;
            VersusLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.Black;
            ScoreButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ScoreButton.ForeColor = SystemColors.HotTrack;
            ScoreButton.Location = new Point(416, 248);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(155, 66);
            ScoreButton.TabIndex = 12;
            ScoreButton.Text = "End Match";
            ScoreButton.UseVisualStyleBackColor = true;
            ScoreButton.Click += button1_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 382);
            Controls.Add(ScoreButton);
            Controls.Add(VersusLabel);
            Controls.Add(TeamTwoScore);
            Controls.Add(TeamOneScore);
            Controls.Add(ScoreLabel);
            Controls.Add(TeamTwoName);
            Controls.Add(TeamOneName);
            Controls.Add(matchupListbox);
            Controls.Add(UnplayedCheckbox);
            Controls.Add(RoundDropdown);
            Controls.Add(RoundHeader);
            Controls.Add(TournamentName);
            Controls.Add(TournamentHeader);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentHeader;
        private Label TournamentName;
        private Label RoundHeader;
        private ComboBox RoundDropdown;
        private CheckBox UnplayedCheckbox;
        private ListBox matchupListbox;
        private Label TeamOneName;
        private Label TeamTwoName;
        private Label ScoreLabel;
        private TextBox TeamOneScore;
        private TextBox TeamTwoScore;
        private Label VersusLabel;
        private Button ScoreButton;
    }
}
