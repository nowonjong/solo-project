using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyProject.Form4;

namespace MyProject
{
    public partial class form2 : Form
    {
        private int currentStage = 1;

        private int gold = 0;

        private const int BasePlayerMaxHp = 100;    // 플레이어 관련 변수
        private const int BasePlayerMinAttack = 5;
        private const int BasePlayerMaxAttack = 20;
        private const int BasePlayerHeal = 10;
        private int playerMaxHp = BasePlayerMaxHp;
        private int playerHp;

        private int enemyMaxHp;    // 적 관련 변수
        private int enemyHp;
        private string enemyName;

        private readonly Random random = new Random();  // 최대, 최소 데미지 사이에 랜덤 숫자로 타격
        private int playerHeal = BasePlayerHeal;

        private int playerMinAttack = BasePlayerMinAttack; // 데미지 관련 변수
        private int playerMaxAttack = BasePlayerMaxAttack;
        private int enemyMinAttack;
        private int enemyMaxAttack;

        private int weaponUpgradeLevel = 0;  // 강화 레벨 변수
        private int hpUpgradeLevel = 0;
        private int healUpgradeLevel = 0;

        private PictureBox hitTarget; 
        private int hitBlinkCount;

        public form2()
        {
            InitializeComponent();
            ResetBattle();
        }

        private void ResetBattle()  // 전투 초기화 메서드
        {
            timer_EnemyTurn.Stop();
            timer_hitEffect.Stop();

            hitTarget = null;
            hitBlinkCount = 0;

            pbPlayer.Visible = true;
            pbEnemy.Visible = true;

            playerHp = playerMaxHp;

            SetStage();
            enemyHp = enemyMaxHp;

            pbPlayerHp.Maximum = playerMaxHp;
            pbEnemyHp.Maximum = enemyMaxHp;

            btnAttack.Enabled = true;
            btnHeal.Enabled = true;

            textBox1.Clear();
            textBox1.AppendText($"Stage {currentStage} 전투가 시작되었습니다!" + Environment.NewLine);

            UpdateBattleScreen();
        }

        private void UpdateBattleScreen() // 전투 화면 갱신 메서드
        {
            pbPlayerHp.Value = playerHp;
            pbEnemyHp.Value = enemyHp;

            lbPlayHp.Text = $"{playerHp}/{playerMaxHp}";
            lbenemyHp.Text = $"{enemyHp}/{enemyMaxHp}";

            lbGold.Text = $"보유 골드 : {gold}";
        }

        private void EnemyTurn() // 적 공격 메서드
        {
            if (enemyHp <= 0 || playerHp <= 0)
            {
                return;
            }

            int EnemyAttack = random.Next(enemyMinAttack, enemyMaxAttack + 1);
            playerHp -= EnemyAttack;

            if (playerHp < 0)
            {
                playerHp = 0;
            }

            ShowHitEffect(pbPlayer);

            textBox1.AppendText($"{enemyName}이(가) 플레이어에게 {EnemyAttack}의 피해를 입혔습니다." +Environment.NewLine);

            UpdateBattleScreen();

            if (playerHp == 0)
            {
                MessageBox.Show(this, "플레이어가 죽었습니다!");
                btnAttack.Enabled= false;
                btnHeal.Enabled= false;

                ShowBattleResult(false);
                return;
            }
        }

        private void SetStage() // 스테이지 올라갈 때마다 적 스텟 변경 메서드
        {
            enemyMaxHp = 80 + (currentStage - 1) * 30;

            enemyMinAttack = 5 + (currentStage - 1) * 2;
            enemyMaxAttack = 20 + (currentStage - 1) * 3;

            enemyHp = enemyMaxHp;
            pbEnemyHp.Maximum = enemyMaxHp;

            lbStage.Text = $"Stage {currentStage}";

            SetEnemyName();
        }

        private void StartNextStage() // 스테이지 +1 메서드
        {
            currentStage++;
            ResetBattle();
        }

        private int StageReward() // 보상 계산 메서드
        {
            return 1000 + (currentStage - 1) * 500;
        }

        private void UpgradeStats() // 플레이어 강화 능력치 적용 메서드
        {
            playerMinAttack = BasePlayerMinAttack + weaponUpgradeLevel * 2;
            playerMaxAttack = BasePlayerMaxAttack + weaponUpgradeLevel * 5;
            playerMaxHp = BasePlayerMaxHp + hpUpgradeLevel * 20;
            playerHeal = BasePlayerHeal + healUpgradeLevel * 5;
        }

        //public void SetUpgradeLevels(int weaponLevel, int hpLevel, int healLevel) // 강화 단계 설정 메서드
        //{
        //    weaponUpgradeLevel = weaponLevel;
        //    hpUpgradeLevel = hpLevel;
        //    healUpgradeLevel = healLevel;
        //}

        private void OpenUpgradeForm() // 강화 화면 열기 메서드
        {
            using (Form5 form5 = new Form5())
            {
                form5.SetGold(gold);

                form5.SetUpgradeLevels(
                    weaponUpgradeLevel,
                    hpUpgradeLevel,
                    healUpgradeLevel);

                form5.ShowDialog(this);

                gold = form5.Playergold;
                weaponUpgradeLevel = form5.WeaponUpgradeLevel;
                hpUpgradeLevel = form5.HpUpgradeLevel;
                healUpgradeLevel= form5.HealUpgradeLevel;
            }
            UpgradeStats();

            pbPlayerHp.Maximum = playerMaxHp;
            UpdateBattleScreen();
        }

        private void ShowBattleResult(bool isvictory) //전투 결과 화면 메서드
        {
            while (true)
            {
                Form3.BattleResultChoice choice;

                using (Form3 form3 = new Form3())
                {
                    if (isvictory)
                    {
                        form3.BattleResult("승리");
                    }
                    else
                    {
                        form3.BattleResult("패배");
                    }
                    form3.ShowDialog(this);

                    choice = form3.SelectedChoice;
                }

                if (choice == Form3.BattleResultChoice.Replay)
                {
                    if (isvictory)
                    {
                        StartNextStage();
                    }
                    else
                    {
                        ResetBattle();
                    }
                    return;
                }
                else if (choice == Form3.BattleResultChoice.Upgrade)
                {
                    OpenUpgradeForm();

                    continue;
                }
                else if (choice == Form3.BattleResultChoice.Home)
                {
                    Close();
                    return;
                }
            }
        }

        private void SetEnemyName() // 슬라임 이름 설정 메서드
        {
            enemyName = $"슬라임 Lv.{currentStage}";
            lbEnemyName.Text = enemyName;
        }

        private void ShowHitEffect(PictureBox target) //타격 효과 메서드
        {
            hitTarget = target;

            hitBlinkCount = 0;

            timer_hitEffect.Start();
        }

        private void button1_Click(object sender, EventArgs e) // 설정 버튼 클릭
        {
            using (Form4 form4 = new Form4())
            {
                form4.ShowDialog(this);

                if (form4.SelectedChoice == PauseChoice.Retry)
                {
                    ResetBattle();
                }
                else if (form4.SelectedChoice == PauseChoice.Home)
                {
                    Close();
                }
            }
        }

        private void btnAttack_Click(object sender, EventArgs e) // 플레이어 공격 버튼
        {
            if (enemyHp <= 0)
            {
                return;
            }

            btnAttack.Enabled = false;
            btnHeal.Enabled = false;

            int PlayerAttack = random.Next(playerMinAttack, playerMaxAttack + 1);
            enemyHp -= PlayerAttack;

            if (enemyHp < 0)
            {
                enemyHp = 0;
            }

            ShowHitEffect(pbEnemy);

            textBox1.AppendText(Environment.NewLine + $"플레이어가 {enemyName}에게 {PlayerAttack}의 피해를 입혔습니다." + Environment.NewLine);
            timer_EnemyTurn.Start();

            UpdateBattleScreen();

            if (enemyHp == 0)
            {
                int Reward = StageReward();
                gold += Reward;

                MessageBox.Show(this, enemyName+"을(를) 쓰러뜨렸습니다!\n" + "스테이지 클리어 보상으로" + Reward + "골드를 획득했습니다.\n" + "현재 골드:" + gold + "\n");

                btnAttack.Enabled = false;
                btnHeal.Enabled = false;

                ShowBattleResult(true);
                return;
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (playerHp <= 0 || enemyHp <= 0)
            {
                return;
            }
            if (playerHp >= playerMaxHp)
            {
                textBox1.AppendText("이미 체력이 가득 차 있습니다." + Environment.NewLine);

                return;
            }
            int hpBeforeHeal = playerHp;

            playerHp += playerHeal;

            if (playerHp >  playerMaxHp)
            {
                playerHp = playerMaxHp;
            }
            int HealAmount = playerHp - hpBeforeHeal;

            textBox1.AppendText($"플레이어가 {HealAmount}만큼 체력을 회복했습니다." + Environment.NewLine);

            UpdateBattleScreen();

            timer_EnemyTurn.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_EnemyTurn.Stop();

            textBox1.AppendText("적의 공격!" + Environment.NewLine);

            EnemyTurn();

            if (playerHp > 0 && enemyHp > 0)
            {
                btnAttack.Enabled = true;
                btnHeal.Enabled = true;
            }
        }

        private void timer_hitEffect_Tick(object sender, EventArgs e)
        {
            if(hitTarget == null)
            {
                timer_hitEffect.Stop();
                return;
            }

            hitTarget.Visible = !hitTarget.Visible;

            hitBlinkCount++;

            if(hitBlinkCount >= 6)
            {
                timer_hitEffect.Stop();

                hitTarget.Visible = true;

                hitTarget = null;
            }
        }
    }
}
