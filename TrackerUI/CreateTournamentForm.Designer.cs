namespace TrackerUI
{
    partial class CreateTournamentForm
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
            CreateTournamentHeader = new Label();
            TournamentNameInput = new TextBox();
            TournamentNameLabel = new Label();
            EntryFeeLabel = new Label();
            EntryFeeInput = new TextBox();
            RoundDropdown = new ComboBox();
            SelectTeamLabel = new Label();
            CreateTeamLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            ParticipantsListbox = new ListBox();
            ParticipantsLabel = new Label();
            PrizesLabel = new Label();
            PrizesListBox = new ListBox();
            DeletePrizeButton = new Button();
            DeleteTeamButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentHeader
            // 
            CreateTournamentHeader.AutoSize = true;
            CreateTournamentHeader.BackColor = SystemColors.Window;
            CreateTournamentHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreateTournamentHeader.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentHeader.Location = new Point(26, 24);
            CreateTournamentHeader.Name = "CreateTournamentHeader";
            CreateTournamentHeader.Size = new Size(307, 46);
            CreateTournamentHeader.TabIndex = 1;
            CreateTournamentHeader.Text = "Create Tournament";
            // 
            // TournamentNameInput
            // 
            TournamentNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TournamentNameInput.Location = new Point(331, 86);
            TournamentNameInput.Name = "TournamentNameInput";
            TournamentNameInput.Size = new Size(177, 34);
            TournamentNameInput.TabIndex = 11;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TournamentNameLabel.Location = new Point(65, 82);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(247, 38);
            TournamentNameLabel.TabIndex = 10;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EntryFeeLabel.Location = new Point(65, 141);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(132, 38);
            EntryFeeLabel.TabIndex = 12;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // EntryFeeInput
            // 
            EntryFeeInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EntryFeeInput.Location = new Point(331, 145);
            EntryFeeInput.Name = "EntryFeeInput";
            EntryFeeInput.Size = new Size(75, 34);
            EntryFeeInput.TabIndex = 13;
            EntryFeeInput.Text = "0";
            // 
            // RoundDropdown
            // 
            RoundDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RoundDropdown.FormattingEnabled = true;
            RoundDropdown.Location = new Point(65, 242);
            RoundDropdown.Name = "RoundDropdown";
            RoundDropdown.Size = new Size(314, 28);
            RoundDropdown.TabIndex = 15;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SelectTeamLabel.Location = new Point(65, 201);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(164, 38);
            SelectTeamLabel.TabIndex = 16;
            SelectTeamLabel.Text = "Select Team";
            SelectTeamLabel.Click += SelectTeamLabel_Click;
            // 
            // CreateTeamLink
            // 
            CreateTeamLink.AutoSize = true;
            CreateTeamLink.Location = new Point(235, 215);
            CreateTeamLink.Name = "CreateTeamLink";
            CreateTeamLink.Size = new Size(126, 20);
            CreateTeamLink.TabIndex = 17;
            CreateTeamLink.TabStop = true;
            CreateTeamLink.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.Black;
            AddTeamButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddTeamButton.ForeColor = SystemColors.HotTrack;
            AddTeamButton.Location = new Point(65, 287);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(126, 41);
            AddTeamButton.TabIndex = 18;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            CreatePrizeButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CreatePrizeButton.ForeColor = SystemColors.HotTrack;
            CreatePrizeButton.Location = new Point(65, 343);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(126, 41);
            CreatePrizeButton.TabIndex = 19;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // ParticipantsListbox
            // 
            ParticipantsListbox.BorderStyle = BorderStyle.FixedSingle;
            ParticipantsListbox.FormattingEnabled = true;
            ParticipantsListbox.Location = new Point(537, 117);
            ParticipantsListbox.Name = "ParticipantsListbox";
            ParticipantsListbox.Size = new Size(228, 122);
            ParticipantsListbox.TabIndex = 20;
            ParticipantsListbox.SelectedIndexChanged += TournamentPlayersListbox_SelectedIndexChanged;
            // 
            // ParticipantsLabel
            // 
            ParticipantsLabel.AutoSize = true;
            ParticipantsLabel.BackColor = SystemColors.Window;
            ParticipantsLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ParticipantsLabel.ForeColor = SystemColors.MenuHighlight;
            ParticipantsLabel.Location = new Point(572, 68);
            ParticipantsLabel.Name = "ParticipantsLabel";
            ParticipantsLabel.Size = new Size(193, 46);
            ParticipantsLabel.TabIndex = 21;
            ParticipantsLabel.Text = "Participants";
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.BackColor = SystemColors.Window;
            PrizesLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PrizesLabel.ForeColor = SystemColors.MenuHighlight;
            PrizesLabel.Location = new Point(572, 242);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(106, 46);
            PrizesLabel.TabIndex = 23;
            PrizesLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.Location = new Point(537, 293);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(228, 102);
            PrizesListBox.TabIndex = 22;
            // 
            // DeletePrizeButton
            // 
            DeletePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            DeletePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            DeletePrizeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            DeletePrizeButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DeletePrizeButton.ForeColor = SystemColors.HotTrack;
            DeletePrizeButton.Location = new Point(235, 343);
            DeletePrizeButton.Name = "DeletePrizeButton";
            DeletePrizeButton.Size = new Size(144, 41);
            DeletePrizeButton.TabIndex = 24;
            DeletePrizeButton.Text = "Remove Prize";
            DeletePrizeButton.UseVisualStyleBackColor = true;
            DeletePrizeButton.Click += DeletePrizeButton_Click;
            // 
            // DeleteTeamButton
            // 
            DeleteTeamButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            DeleteTeamButton.FlatAppearance.MouseOverBackColor = Color.Black;
            DeleteTeamButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DeleteTeamButton.ForeColor = SystemColors.HotTrack;
            DeleteTeamButton.Location = new Point(235, 287);
            DeleteTeamButton.Name = "DeleteTeamButton";
            DeleteTeamButton.Size = new Size(144, 41);
            DeleteTeamButton.TabIndex = 25;
            DeleteTeamButton.Text = "Remove Team";
            DeleteTeamButton.TextAlign = ContentAlignment.MiddleRight;
            DeleteTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.Black;
            CreateTournamentButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CreateTournamentButton.ForeColor = SystemColors.HotTrack;
            CreateTournamentButton.Location = new Point(65, 397);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(314, 41);
            CreateTournamentButton.TabIndex = 26;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeleteTeamButton);
            Controls.Add(DeletePrizeButton);
            Controls.Add(PrizesLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(ParticipantsLabel);
            Controls.Add(ParticipantsListbox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateTeamLink);
            Controls.Add(SelectTeamLabel);
            Controls.Add(RoundDropdown);
            Controls.Add(EntryFeeInput);
            Controls.Add(EntryFeeLabel);
            Controls.Add(TournamentNameInput);
            Controls.Add(TournamentNameLabel);
            Controls.Add(CreateTournamentHeader);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTournamentHeader;
        private TextBox TournamentNameInput;
        private Label TournamentNameLabel;
        private Label EntryFeeLabel;
        private TextBox EntryFeeInput;
        private ComboBox RoundDropdown;
        private Label SelectTeamLabel;
        private LinkLabel CreateTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox ParticipantsListbox;
        private Label ParticipantsLabel;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button DeletePrizeButton;
        private Button DeleteTeamButton;
        private Button CreateTournamentButton;
    }
}