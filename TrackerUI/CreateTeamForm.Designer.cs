namespace TrackerUI
{
    partial class CreateTeamForm
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
            CreateTeamNameLabel = new Label();
            TeamNameInput = new TextBox();
            PlayerDropdown = new ComboBox();
            SelectPlayerLabel = new Label();
            CreateTeamHeader = new Label();
            AddPlayerButton = new Button();
            CreateNewPlayerGroupBox = new GroupBox();
            CreatePlayerButton = new Button();
            PlayerPhoneInput = new TextBox();
            PlayerPhoneLabel = new Label();
            PlayerEmailInput = new TextBox();
            PlayerEmailLabel = new Label();
            LastNameInput = new TextBox();
            LastNameLabel = new Label();
            FirstNameInput = new TextBox();
            FirstNameLabel = new Label();
            TeamPlayersListBox = new ListBox();
            RemovePlayerButton = new Button();
            CreateTeamButton = new Button();
            CreateNewPlayerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CreateTeamNameLabel
            // 
            CreateTeamNameLabel.AutoSize = true;
            CreateTeamNameLabel.BackColor = SystemColors.Window;
            CreateTeamNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreateTeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            CreateTeamNameLabel.Location = new Point(12, 88);
            CreateTeamNameLabel.Name = "CreateTeamNameLabel";
            CreateTeamNameLabel.Size = new Size(164, 38);
            CreateTeamNameLabel.TabIndex = 1;
            CreateTeamNameLabel.Text = "Team Name";
            CreateTeamNameLabel.Click += CreateTeamNameLabel_Click;
            // 
            // TeamNameInput
            // 
            TeamNameInput.Location = new Point(12, 129);
            TeamNameInput.Name = "TeamNameInput";
            TeamNameInput.Size = new Size(284, 27);
            TeamNameInput.TabIndex = 11;
            // 
            // PlayerDropdown
            // 
            PlayerDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PlayerDropdown.FormattingEnabled = true;
            PlayerDropdown.Location = new Point(12, 213);
            PlayerDropdown.Name = "PlayerDropdown";
            PlayerDropdown.Size = new Size(284, 28);
            PlayerDropdown.TabIndex = 10;
            // 
            // SelectPlayerLabel
            // 
            SelectPlayerLabel.AutoSize = true;
            SelectPlayerLabel.BackColor = SystemColors.Window;
            SelectPlayerLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SelectPlayerLabel.ForeColor = SystemColors.MenuHighlight;
            SelectPlayerLabel.Location = new Point(12, 172);
            SelectPlayerLabel.Name = "SelectPlayerLabel";
            SelectPlayerLabel.Size = new Size(175, 38);
            SelectPlayerLabel.TabIndex = 12;
            SelectPlayerLabel.Text = "Select Player";
            // 
            // CreateTeamHeader
            // 
            CreateTeamHeader.AutoSize = true;
            CreateTeamHeader.BackColor = SystemColors.Window;
            CreateTeamHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreateTeamHeader.ForeColor = SystemColors.MenuHighlight;
            CreateTeamHeader.Location = new Point(12, 30);
            CreateTeamHeader.Name = "CreateTeamHeader";
            CreateTeamHeader.Size = new Size(206, 46);
            CreateTeamHeader.TabIndex = 13;
            CreateTeamHeader.Text = "Create Team";
            // 
            // AddPlayerButton
            // 
            AddPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            AddPlayerButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            AddPlayerButton.FlatAppearance.MouseOverBackColor = Color.Black;
            AddPlayerButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddPlayerButton.ForeColor = SystemColors.HotTrack;
            AddPlayerButton.Location = new Point(363, 188);
            AddPlayerButton.Name = "AddPlayerButton";
            AddPlayerButton.Size = new Size(181, 53);
            AddPlayerButton.TabIndex = 14;
            AddPlayerButton.Text = "Add Player";
            AddPlayerButton.UseVisualStyleBackColor = true;
            AddPlayerButton.Click += AddPlayerButton_Click;
            // 
            // CreateNewPlayerGroupBox
            // 
            CreateNewPlayerGroupBox.Controls.Add(CreatePlayerButton);
            CreateNewPlayerGroupBox.Controls.Add(PlayerPhoneInput);
            CreateNewPlayerGroupBox.Controls.Add(PlayerPhoneLabel);
            CreateNewPlayerGroupBox.Controls.Add(PlayerEmailInput);
            CreateNewPlayerGroupBox.Controls.Add(PlayerEmailLabel);
            CreateNewPlayerGroupBox.Controls.Add(LastNameInput);
            CreateNewPlayerGroupBox.Controls.Add(LastNameLabel);
            CreateNewPlayerGroupBox.Controls.Add(FirstNameInput);
            CreateNewPlayerGroupBox.Controls.Add(FirstNameLabel);
            CreateNewPlayerGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreateNewPlayerGroupBox.Location = new Point(28, 259);
            CreateNewPlayerGroupBox.Name = "CreateNewPlayerGroupBox";
            CreateNewPlayerGroupBox.Size = new Size(287, 307);
            CreateNewPlayerGroupBox.TabIndex = 15;
            CreateNewPlayerGroupBox.TabStop = false;
            CreateNewPlayerGroupBox.Text = "Create Player";
            CreateNewPlayerGroupBox.Enter += CreateNewPlayerGroupBox_Enter;
            // 
            // CreatePlayerButton
            // 
            CreatePlayerButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePlayerButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreatePlayerButton.FlatAppearance.MouseOverBackColor = Color.Black;
            CreatePlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CreatePlayerButton.ForeColor = SystemColors.HotTrack;
            CreatePlayerButton.Location = new Point(71, 255);
            CreatePlayerButton.Name = "CreatePlayerButton";
            CreatePlayerButton.Size = new Size(148, 46);
            CreatePlayerButton.TabIndex = 16;
            CreatePlayerButton.Text = "Create Player";
            CreatePlayerButton.UseVisualStyleBackColor = true;
            CreatePlayerButton.Click += button1_Click;
            // 
            // PlayerPhoneInput
            // 
            PlayerPhoneInput.Location = new Point(117, 201);
            PlayerPhoneInput.Name = "PlayerPhoneInput";
            PlayerPhoneInput.Size = new Size(164, 34);
            PlayerPhoneInput.TabIndex = 21;
            // 
            // PlayerPhoneLabel
            // 
            PlayerPhoneLabel.AutoSize = true;
            PlayerPhoneLabel.BackColor = SystemColors.Window;
            PlayerPhoneLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PlayerPhoneLabel.ForeColor = SystemColors.MenuHighlight;
            PlayerPhoneLabel.Location = new Point(6, 201);
            PlayerPhoneLabel.Name = "PlayerPhoneLabel";
            PlayerPhoneLabel.Size = new Size(92, 25);
            PlayerPhoneLabel.TabIndex = 22;
            PlayerPhoneLabel.Text = "Phone no.";
            // 
            // PlayerEmailInput
            // 
            PlayerEmailInput.Location = new Point(117, 148);
            PlayerEmailInput.Name = "PlayerEmailInput";
            PlayerEmailInput.Size = new Size(164, 34);
            PlayerEmailInput.TabIndex = 19;
            // 
            // PlayerEmailLabel
            // 
            PlayerEmailLabel.AutoSize = true;
            PlayerEmailLabel.BackColor = SystemColors.Window;
            PlayerEmailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PlayerEmailLabel.ForeColor = SystemColors.MenuHighlight;
            PlayerEmailLabel.Location = new Point(6, 148);
            PlayerEmailLabel.Name = "PlayerEmailLabel";
            PlayerEmailLabel.Size = new Size(61, 25);
            PlayerEmailLabel.TabIndex = 20;
            PlayerEmailLabel.Text = "E-mail";
            PlayerEmailLabel.Click += PlayerEmail_Click;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(117, 95);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(164, 34);
            LastNameInput.TabIndex = 17;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.BackColor = SystemColors.Window;
            LastNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LastNameLabel.ForeColor = SystemColors.MenuHighlight;
            LastNameLabel.Location = new Point(6, 95);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(95, 25);
            LastNameLabel.TabIndex = 18;
            LastNameLabel.Text = "Last Name";
            LastNameLabel.Click += label2_Click;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(117, 39);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(164, 34);
            FirstNameInput.TabIndex = 16;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.BackColor = SystemColors.Window;
            FirstNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FirstNameLabel.ForeColor = SystemColors.MenuHighlight;
            FirstNameLabel.Location = new Point(6, 39);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(97, 25);
            FirstNameLabel.TabIndex = 16;
            FirstNameLabel.Text = "First Name";
            // 
            // TeamPlayersListBox
            // 
            TeamPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamPlayersListBox.FormattingEnabled = true;
            TeamPlayersListBox.Location = new Point(363, 278);
            TeamPlayersListBox.Name = "TeamPlayersListBox";
            TeamPlayersListBox.Size = new Size(371, 282);
            TeamPlayersListBox.TabIndex = 16;
            // 
            // RemovePlayerButton
            // 
            RemovePlayerButton.FlatAppearance.BorderColor = Color.Silver;
            RemovePlayerButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            RemovePlayerButton.FlatAppearance.MouseOverBackColor = Color.Black;
            RemovePlayerButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            RemovePlayerButton.ForeColor = SystemColors.HotTrack;
            RemovePlayerButton.Location = new Point(550, 188);
            RemovePlayerButton.Name = "RemovePlayerButton";
            RemovePlayerButton.Size = new Size(184, 53);
            RemovePlayerButton.TabIndex = 17;
            RemovePlayerButton.Text = "Remove Player";
            RemovePlayerButton.UseVisualStyleBackColor = true;
            RemovePlayerButton.Click += RemovePlayerTeamButton_Click;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.Black;
            CreateTeamButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CreateTeamButton.ForeColor = SystemColors.HotTrack;
            CreateTeamButton.Location = new Point(456, 103);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(181, 53);
            CreateTeamButton.TabIndex = 18;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(760, 591);
            Controls.Add(CreateTeamButton);
            Controls.Add(RemovePlayerButton);
            Controls.Add(TeamPlayersListBox);
            Controls.Add(CreateNewPlayerGroupBox);
            Controls.Add(AddPlayerButton);
            Controls.Add(CreateTeamHeader);
            Controls.Add(SelectPlayerLabel);
            Controls.Add(TeamNameInput);
            Controls.Add(PlayerDropdown);
            Controls.Add(CreateTeamNameLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            CreateNewPlayerGroupBox.ResumeLayout(false);
            CreateNewPlayerGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTeamNameLabel;
        private TextBox TeamNameInput;
        private ComboBox PlayerDropdown;
        private Label SelectPlayerLabel;
        private Label CreateTeamHeader;
        private Button AddPlayerButton;
        private GroupBox CreateNewPlayerGroupBox;
        private TextBox PlayerPhoneInput;
        private Label PlayerPhoneLabel;
        private TextBox PlayerEmailInput;
        private Label PlayerEmailLabel;
        private TextBox LastNameInput;
        private Label LastNameLabel;
        private TextBox FirstNameInput;
        private Label FirstNameLabel;
        private Button CreatePlayerButton;
        private ListBox TeamPlayersListBox;
        private Button RemovePlayerButton;
        private Button CreateTeamButton;
    }
}