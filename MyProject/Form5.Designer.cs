namespace MyProject
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lbGold = new Label();
            btnPlay = new Button();
            cbUpgradeType = new ComboBox();
            tbUpgradeInfo = new TextBox();
            btnUpgrade = new Button();
            lbUpgradeResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbGold
            // 
            lbGold.AutoSize = true;
            lbGold.BackColor = Color.Transparent;
            lbGold.FlatStyle = FlatStyle.Flat;
            lbGold.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbGold.ForeColor = Color.FromArgb(201, 168, 76);
            lbGold.Location = new Point(225, 34);
            lbGold.Name = "lbGold";
            lbGold.Size = new Size(99, 21);
            lbGold.TabIndex = 2;
            lbGold.Text = "보유 골드: 0";
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.FromArgb(201, 168, 76);
            btnPlay.Location = new Point(542, 349);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(171, 82);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "계속하기";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // cbUpgradeType
            // 
            cbUpgradeType.FormattingEnabled = true;
            cbUpgradeType.Items.AddRange(new object[] { "무기 강화", "체력 강화", "회복 강화" });
            cbUpgradeType.Location = new Point(70, 81);
            cbUpgradeType.Name = "cbUpgradeType";
            cbUpgradeType.Size = new Size(121, 23);
            cbUpgradeType.TabIndex = 4;
            cbUpgradeType.SelectedIndexChanged += cbUpgradeType_SelectedIndexChanged;
            // 
            // tbUpgradeInfo
            // 
            tbUpgradeInfo.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUpgradeInfo.Location = new Point(212, 81);
            tbUpgradeInfo.Multiline = true;
            tbUpgradeInfo.Name = "tbUpgradeInfo";
            tbUpgradeInfo.ReadOnly = true;
            tbUpgradeInfo.Size = new Size(285, 128);
            tbUpgradeInfo.TabIndex = 5;
            // 
            // btnUpgrade
            // 
            btnUpgrade.BackColor = Color.Transparent;
            btnUpgrade.FlatStyle = FlatStyle.Flat;
            btnUpgrade.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpgrade.ForeColor = Color.FromArgb(201, 168, 76);
            btnUpgrade.Location = new Point(517, 81);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(134, 59);
            btnUpgrade.TabIndex = 6;
            btnUpgrade.Text = "강화하기";
            btnUpgrade.UseVisualStyleBackColor = false;
            btnUpgrade.Click += btnUpgrade_Click;
            // 
            // lbUpgradeResult
            // 
            lbUpgradeResult.AutoSize = true;
            lbUpgradeResult.BackColor = Color.Transparent;
            lbUpgradeResult.FlatStyle = FlatStyle.Flat;
            lbUpgradeResult.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUpgradeResult.ForeColor = Color.FromArgb(201, 168, 76);
            lbUpgradeResult.Location = new Point(280, 227);
            lbUpgradeResult.Name = "lbUpgradeResult";
            lbUpgradeResult.Size = new Size(55, 21);
            lbUpgradeResult.TabIndex = 7;
            lbUpgradeResult.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(201, 168, 76);
            label1.Location = new Point(184, 227);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 8;
            label1.Text = "강화 결과 :";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 493);
            Controls.Add(label1);
            Controls.Add(lbUpgradeResult);
            Controls.Add(btnUpgrade);
            Controls.Add(tbUpgradeInfo);
            Controls.Add(cbUpgradeType);
            Controls.Add(btnPlay);
            Controls.Add(lbGold);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbGold;
        private Button btnPlay;
        private ComboBox cbUpgradeType;
        private TextBox tbUpgradeInfo;
        private Button btnUpgrade;
        private Label lbUpgradeResult;
        private Label label1;
    }
}