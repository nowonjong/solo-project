namespace MyProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnPlay = new Button();
            btnReturn = new Button();
            lbBattleResult = new Label();
            btnUpgrade = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.DialogResult = DialogResult.Yes;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.FromArgb(201, 168, 76);
            btnPlay.Location = new Point(155, 147);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(183, 78);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "다시하기";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.DialogResult = DialogResult.No;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.FromArgb(201, 168, 76);
            btnReturn.Location = new Point(155, 342);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(183, 78);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "처음으로";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lbBattleResult
            // 
            lbBattleResult.AutoSize = true;
            lbBattleResult.BackColor = Color.Transparent;
            lbBattleResult.FlatStyle = FlatStyle.Flat;
            lbBattleResult.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbBattleResult.ForeColor = Color.FromArgb(224, 184, 77);
            lbBattleResult.Location = new Point(198, 84);
            lbBattleResult.Name = "lbBattleResult";
            lbBattleResult.Size = new Size(96, 50);
            lbBattleResult.TabIndex = 1;
            lbBattleResult.Text = "결과";
            // 
            // btnUpgrade
            // 
            btnUpgrade.BackColor = Color.Transparent;
            btnUpgrade.FlatStyle = FlatStyle.Flat;
            btnUpgrade.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpgrade.ForeColor = Color.FromArgb(201, 168, 76);
            btnUpgrade.Location = new Point(155, 248);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(183, 75);
            btnUpgrade.TabIndex = 2;
            btnUpgrade.Text = "강화하기";
            btnUpgrade.UseVisualStyleBackColor = false;
            btnUpgrade.Click += btnUpgrade_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(491, 533);
            Controls.Add(btnUpgrade);
            Controls.Add(lbBattleResult);
            Controls.Add(btnReturn);
            Controls.Add(btnPlay);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private Button btnReturn;
        private Label lbBattleResult;
        private Button btnUpgrade;
    }
}