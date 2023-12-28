namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeHeader = new Label();
            PrizePercentageInput = new TextBox();
            PrizePercentageLabel = new Label();
            PrizeAmountInput = new TextBox();
            PrizeAmountLabel = new Label();
            PlaceNameInput = new TextBox();
            PlaceNameLabel = new Label();
            PlaceNumberInput = new TextBox();
            PlaceNumberLabel = new Label();
            label1 = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeHeader
            // 
            CreatePrizeHeader.AutoSize = true;
            CreatePrizeHeader.BackColor = SystemColors.Window;
            CreatePrizeHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreatePrizeHeader.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeHeader.Location = new Point(12, 22);
            CreatePrizeHeader.Name = "CreatePrizeHeader";
            CreatePrizeHeader.Size = new Size(199, 46);
            CreatePrizeHeader.TabIndex = 14;
            CreatePrizeHeader.Text = "Create Prize";
            // 
            // PrizePercentageInput
            // 
            PrizePercentageInput.Font = new Font("Segoe UI", 16.2F);
            PrizePercentageInput.Location = new Point(414, 300);
            PrizePercentageInput.Name = "PrizePercentageInput";
            PrizePercentageInput.Size = new Size(164, 43);
            PrizePercentageInput.TabIndex = 29;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.BackColor = SystemColors.Window;
            PrizePercentageLabel.Font = new Font("Segoe UI", 16.2F);
            PrizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            PrizePercentageLabel.Location = new Point(223, 300);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(109, 38);
            PrizePercentageLabel.TabIndex = 30;
            PrizePercentageLabel.Text = "Prize %";
            // 
            // PrizeAmountInput
            // 
            PrizeAmountInput.Font = new Font("Segoe UI", 16.2F);
            PrizeAmountInput.Location = new Point(414, 199);
            PrizeAmountInput.Name = "PrizeAmountInput";
            PrizeAmountInput.Size = new Size(164, 43);
            PrizeAmountInput.TabIndex = 27;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.BackColor = SystemColors.Window;
            PrizeAmountLabel.Font = new Font("Segoe UI", 16.2F);
            PrizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            PrizeAmountLabel.Location = new Point(223, 199);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(185, 38);
            PrizeAmountLabel.TabIndex = 28;
            PrizeAmountLabel.Text = "Prize Amount";
            // 
            // PlaceNameInput
            // 
            PlaceNameInput.Font = new Font("Segoe UI", 16.2F);
            PlaceNameInput.Location = new Point(414, 146);
            PlaceNameInput.Name = "PlaceNameInput";
            PlaceNameInput.Size = new Size(164, 43);
            PlaceNameInput.TabIndex = 25;
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.BackColor = SystemColors.Window;
            PlaceNameLabel.Font = new Font("Segoe UI", 16.2F);
            PlaceNameLabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNameLabel.Location = new Point(223, 146);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.Size = new Size(164, 38);
            PlaceNameLabel.TabIndex = 26;
            PlaceNameLabel.Text = "Place Name";
            PlaceNameLabel.Click += PrizeAmoun_Click;
            // 
            // PlaceNumberInput
            // 
            PlaceNumberInput.Font = new Font("Segoe UI", 16.2F);
            PlaceNumberInput.Location = new Point(414, 90);
            PlaceNumberInput.Name = "PlaceNumberInput";
            PlaceNumberInput.Size = new Size(164, 43);
            PlaceNumberInput.TabIndex = 23;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.BackColor = SystemColors.Window;
            PlaceNumberLabel.Font = new Font("Segoe UI", 16.2F);
            PlaceNumberLabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNumberLabel.Location = new Point(223, 90);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(133, 38);
            PlaceNumberLabel.TabIndex = 24;
            PlaceNumberLabel.Text = "Place No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(377, 259);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 31;
            label1.Text = "or";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CreatePrizeButton.ForeColor = SystemColors.HotTrack;
            CreatePrizeButton.Location = new Point(313, 368);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(181, 53);
            CreatePrizeButton.TabIndex = 32;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(CreatePrizeButton);
            Controls.Add(label1);
            Controls.Add(PrizePercentageInput);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PrizeAmountInput);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PlaceNameInput);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PlaceNumberInput);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeHeader);
            ForeColor = Color.Black;
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeHeader;
        private TextBox PrizePercentageInput;
        private Label PrizePercentageLabel;
        private TextBox PrizeAmountInput;
        private Label PrizeAmountLabel;
        private TextBox PlaceNameInput;
        private Label PlaceNameLabel;
        private TextBox PlaceNumberInput;
        private Label PlaceNumberLabel;
        private Label label1;
        private Button CreatePrizeButton;
    }
}