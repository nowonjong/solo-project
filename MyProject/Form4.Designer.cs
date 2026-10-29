namespace MyProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnContinue = new Button();
            btnReplay = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Transparent;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinue.ForeColor = Color.FromArgb(201, 168, 76);
            btnContinue.Location = new Point(130, 75);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(129, 61);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "계속하기";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnReplay
            // 
            btnReplay.BackColor = Color.Transparent;
            btnReplay.FlatStyle = FlatStyle.Flat;
            btnReplay.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReplay.ForeColor = Color.FromArgb(201, 168, 76);
            btnReplay.Location = new Point(130, 159);
            btnReplay.Name = "btnReplay";
            btnReplay.Size = new Size(129, 61);
            btnReplay.TabIndex = 0;
            btnReplay.Text = "다시하기";
            btnReplay.UseVisualStyleBackColor = false;
            btnReplay.Click += btnReplay_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.FromArgb(201, 168, 76);
            btnReturn.Location = new Point(130, 247);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(129, 61);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "홈으로";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(379, 389);
            Controls.Add(btnReturn);
            Controls.Add(btnReplay);
            Controls.Add(btnContinue);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnContinue;
        private Button btnReplay;
        private Button btnReturn;
    }
}