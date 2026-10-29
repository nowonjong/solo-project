namespace MyProject
{
    partial class form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            btnAttack = new Button();
            btnHeal = new Button();
            label1 = new Label();
            lbPlayHp = new Label();
            lbEnemyName = new Label();
            lbenemyHp = new Label();
            pbEnemyHp = new ProgressBar();
            pbPlayerHp = new ProgressBar();
            textBox1 = new TextBox();
            button1 = new Button();
            lbStage = new Label();
            lbGold = new Label();
            timer_EnemyTurn = new System.Windows.Forms.Timer(components);
            pbPlayer = new PictureBox();
            pbEnemy = new PictureBox();
            timer_hitEffect = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy).BeginInit();
            SuspendLayout();
            // 
            // btnAttack
            // 
            btnAttack.BackColor = Color.Transparent;
            btnAttack.FlatStyle = FlatStyle.Flat;
            btnAttack.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAttack.ForeColor = Color.FromArgb(224, 184, 77);
            btnAttack.Location = new Point(266, 447);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(154, 74);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "공격하기";
            btnAttack.UseVisualStyleBackColor = false;
            btnAttack.Click += btnAttack_Click;
            // 
            // btnHeal
            // 
            btnHeal.BackColor = Color.Transparent;
            btnHeal.FlatStyle = FlatStyle.Flat;
            btnHeal.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHeal.ForeColor = Color.FromArgb(224, 184, 77);
            btnHeal.Location = new Point(554, 447);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(154, 74);
            btnHeal.TabIndex = 0;
            btnHeal.Text = "회복하기";
            btnHeal.UseVisualStyleBackColor = false;
            btnHeal.Click += btnHeal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 184, 77);
            label1.Location = new Point(294, 67);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 1;
            label1.Text = "플레이어";
            // 
            // lbPlayHp
            // 
            lbPlayHp.AutoSize = true;
            lbPlayHp.BackColor = Color.Transparent;
            lbPlayHp.FlatStyle = FlatStyle.Flat;
            lbPlayHp.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlayHp.ForeColor = Color.FromArgb(224, 184, 77);
            lbPlayHp.Location = new Point(296, 85);
            lbPlayHp.Name = "lbPlayHp";
            lbPlayHp.Size = new Size(70, 21);
            lbPlayHp.TabIndex = 1;
            lbPlayHp.Text = "100/100";
            // 
            // lbEnemyName
            // 
            lbEnemyName.AutoSize = true;
            lbEnemyName.BackColor = Color.Transparent;
            lbEnemyName.FlatStyle = FlatStyle.Flat;
            lbEnemyName.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEnemyName.ForeColor = Color.FromArgb(224, 184, 77);
            lbEnemyName.Location = new Point(654, 67);
            lbEnemyName.Name = "lbEnemyName";
            lbEnemyName.Size = new Size(84, 21);
            lbEnemyName.TabIndex = 1;
            lbEnemyName.Text = "슬라임 Lv.";
            // 
            // lbenemyHp
            // 
            lbenemyHp.AutoSize = true;
            lbenemyHp.BackColor = Color.Transparent;
            lbenemyHp.FlatStyle = FlatStyle.Flat;
            lbenemyHp.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbenemyHp.ForeColor = Color.FromArgb(224, 184, 77);
            lbenemyHp.Location = new Point(672, 85);
            lbenemyHp.Name = "lbenemyHp";
            lbenemyHp.Size = new Size(52, 21);
            lbenemyHp.TabIndex = 1;
            lbenemyHp.Text = "80/80";
            // 
            // pbEnemyHp
            // 
            pbEnemyHp.Location = new Point(632, 109);
            pbEnemyHp.Maximum = 80;
            pbEnemyHp.Name = "pbEnemyHp";
            pbEnemyHp.Size = new Size(129, 28);
            pbEnemyHp.TabIndex = 2;
            // 
            // pbPlayerHp
            // 
            pbPlayerHp.Location = new Point(266, 109);
            pbPlayerHp.Name = "pbPlayerHp";
            pbPlayerHp.Size = new Size(129, 28);
            pbPlayerHp.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(194, 303);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(624, 129);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 184, 77);
            button1.Location = new Point(935, 1);
            button1.Name = "button1";
            button1.Size = new Size(46, 47);
            button1.TabIndex = 4;
            button1.Text = "⚙";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbStage
            // 
            lbStage.AutoSize = true;
            lbStage.BackColor = Color.Transparent;
            lbStage.FlatStyle = FlatStyle.Flat;
            lbStage.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbStage.ForeColor = Color.FromArgb(224, 184, 77);
            lbStage.Location = new Point(448, 13);
            lbStage.Name = "lbStage";
            lbStage.Size = new Size(121, 40);
            lbStage.TabIndex = 5;
            lbStage.Text = "Stage 1";
            // 
            // lbGold
            // 
            lbGold.AutoSize = true;
            lbGold.BackColor = Color.Transparent;
            lbGold.FlatStyle = FlatStyle.Flat;
            lbGold.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbGold.ForeColor = Color.FromArgb(224, 184, 77);
            lbGold.Location = new Point(29, 26);
            lbGold.Name = "lbGold";
            lbGold.Size = new Size(123, 25);
            lbGold.TabIndex = 6;
            lbGold.Text = "보유 골드 : 0";
            // 
            // timer_EnemyTurn
            // 
            timer_EnemyTurn.Interval = 900;
            timer_EnemyTurn.Tick += timer1_Tick;
            // 
            // pbPlayer
            // 
            pbPlayer.BackColor = Color.Transparent;
            pbPlayer.BackgroundImage = (Image)resources.GetObject("pbPlayer.BackgroundImage");
            pbPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            pbPlayer.Location = new Point(266, 156);
            pbPlayer.Name = "pbPlayer";
            pbPlayer.Size = new Size(129, 132);
            pbPlayer.TabIndex = 7;
            pbPlayer.TabStop = false;
            // 
            // pbEnemy
            // 
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.BackgroundImage = (Image)resources.GetObject("pbEnemy.BackgroundImage");
            pbEnemy.BackgroundImageLayout = ImageLayout.Stretch;
            pbEnemy.Location = new Point(632, 156);
            pbEnemy.Name = "pbEnemy";
            pbEnemy.Size = new Size(129, 132);
            pbEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnemy.TabIndex = 7;
            pbEnemy.TabStop = false;
            // 
            // timer_hitEffect
            // 
            timer_hitEffect.Interval = 80;
            timer_hitEffect.Tick += timer_hitEffect_Tick;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(pbEnemy);
            Controls.Add(pbPlayer);
            Controls.Add(lbGold);
            Controls.Add(lbStage);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pbPlayerHp);
            Controls.Add(pbEnemyHp);
            Controls.Add(lbenemyHp);
            Controls.Add(lbEnemyName);
            Controls.Add(lbPlayHp);
            Controls.Add(label1);
            Controls.Add(btnHeal);
            Controls.Add(btnAttack);
            Name = "form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Battle Form";
            ((System.ComponentModel.ISupportInitialize)pbPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAttack;
        private Button btnHeal;
        private Label label1;
        private Label lbPlayHp;
        private Label lbEnemyName;
        private Label lbenemyHp;
        private ProgressBar pbEnemyHp;
        private ProgressBar pbPlayerHp;
        private TextBox textBox1;
        private Button button1;
        private Label lbStage;
        private Label lbGold;
        private System.Windows.Forms.Timer timer_EnemyTurn;
        private PictureBox pbPlayer;
        private PictureBox pbEnemy;
        private System.Windows.Forms.Timer timer_hitEffect;
    }
}