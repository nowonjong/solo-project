using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form5 : Form
    {
        private const int UpgradeCost = 500;
        private const int BasePlayerMinAttack = 5;
        private const int BasePlayerMaxAttack = 20;
        private const int BasePlayerMaxHp = 100;
        private const int BasePlayerHeal = 10;

        private readonly Random random = new Random();

        public int WeaponUpgradeLevel { get; set; }
        public int HpUpgradeLevel { get; set; }
        public int HealUpgradeLevel { get; set; }
        public int Playergold { get; private set; }
        public Form5()
        {
            InitializeComponent();

            cbUpgradeType.DropDownStyle = ComboBoxStyle.DropDownList; // 사용자가 직접 입력 X

            cbUpgradeType.SelectedIndex = 0;
        }
        public void SetGold(int gold) // 골드 전달받는 메서드
        {
            Playergold = gold;
            UpdateUpgradeScreen();
        }

        private int GetSuccessRate(int upgradeLevel) // 강화 성공 확률 메서드
        {
            return Math.Max(20, 100 - upgradeLevel * 20);
        }

        private bool TryUpgrade(string upgradeName, int upgradeLevel) // 강화 시도 메서드
        {
            if (Playergold < UpgradeCost)
            {
                int sub = UpgradeCost - Playergold;
                MessageBox.Show(this, $"{sub}골드가 부족합니다.\n" + "강화할 수 없습니다.\n");
                return false;
            }

            Playergold -= UpgradeCost;

            int succesRate = GetSuccessRate(upgradeLevel);
            int randomNumber = random.Next(1, 101);

            if (randomNumber <= succesRate)
            {
                MessageBox.Show(
                    this,
                    $"{upgradeName} 강화에 성공했습니다!\n" +
                    $"현재 강화 단계: {upgradeLevel+1}\n" +
                    $"남은 골드: {Playergold}"
                    );

                return true;
            }

            MessageBox.Show(
                this,
                $"{upgradeName} 강화에 실패했습니다.\n"+
                $"{UpgradeCost}골드가 사용되었습니다" +
                $"남은 골드: {Playergold}"
                );
            return false;
        }

        public void SetUpgradeLevels(int weaponLevel, int hpLevel, int healLevel) // 강화 단계 전달받는 메서드
        {
            WeaponUpgradeLevel = weaponLevel;
            HpUpgradeLevel = hpLevel;
            HealUpgradeLevel = healLevel;

            UpdateUpgradeScreen();
        }

        private void UpdateUpgradeScreen() // 강화 화면 정보 갱신 메서드
        {
            lbGold.Text = $"보유 골드: {Playergold}";

            int upgradeLevel;
            string upgradeName;
            string upgradeEffect;
            string currentStat;
            string nextStat;

            if (cbUpgradeType.SelectedIndex == 0)
            {
                upgradeName = "무기 강화";
                upgradeLevel = WeaponUpgradeLevel;
                upgradeEffect = "최소 공격력 +2, 최대 공격력 +5";

                int currentMinAttack = BasePlayerMinAttack + upgradeLevel * 2;
                int currentMaxAttack = BasePlayerMaxAttack + upgradeLevel * 5;
                int nextMinAttack = currentMinAttack + 2;
                int nextMaxAttack = currentMaxAttack + 5;

                currentStat = $"{upgradeLevel}단계 최소 공격력: {currentMinAttack}, 최대 공격력: {currentMaxAttack}";
                nextStat = $"{upgradeLevel + 1}단계 최소 공격력: {nextMinAttack}, 최대 공격력: {nextMaxAttack}";
            }
            else if (cbUpgradeType.SelectedIndex == 1)
            {
                upgradeName = "체력 강화";
                upgradeLevel = HpUpgradeLevel;
                upgradeEffect = "최대 체력 +20";

                int currentMaxHp = BasePlayerMaxHp + upgradeLevel * 20;
                int nextMaxHp = currentMaxHp + 20;

                currentStat = $"{upgradeLevel}단계 최대 체력: {currentMaxHp}";
                nextStat = $"{upgradeLevel + 1}단계 최대 체력: {nextMaxHp}";
            }
            else if (cbUpgradeType.SelectedIndex == 2)
            {
                upgradeName = "회복 강화";
                upgradeLevel = HealUpgradeLevel;
                upgradeEffect = "회복량 + 5";

                int currentHeal = BasePlayerHeal + upgradeLevel * 5;
                int nextHeal = currentHeal + 5;

                currentStat = $"{upgradeLevel}단계 회복량: {currentHeal}";
                nextStat = $"{upgradeLevel + 1}단계 회복량: {nextHeal}";
            }
            else
            {
                tbUpgradeInfo.Text = "강화 종류를 선택해주세요.";
                return;
            }
            int successRate = GetSuccessRate(upgradeLevel);

            tbUpgradeInfo.Text =
                $"강화 종류: {upgradeLevel}{Environment.NewLine}"+
                $"강화 단계: {upgradeLevel} -> {upgradeLevel + 1}{Environment.NewLine}" +
                $"강화 효과: {upgradeEffect}{Environment.NewLine}"+
                $"강화 비용: {UpgradeCost}골드{Environment.NewLine}"+
                $"성공 확률: {successRate}%";

            lbUpgradeResult.Text = $"{currentStat}\n\n{nextStat}\n";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbUpgradeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUpgradeScreen();
        }

        private void btnUpgrade_Click(object sender, EventArgs e) // 강화 버튼 클릭
        {
            if (cbUpgradeType.SelectedIndex == 0)
            {
                if (TryUpgrade("무기 강화", WeaponUpgradeLevel))
                {
                    WeaponUpgradeLevel++;
                }
            }
            else if (cbUpgradeType.SelectedIndex == 1)
            {
                if(TryUpgrade("체력 강화", HpUpgradeLevel))
                {
                    HpUpgradeLevel++;
                }
            }
            else if (cbUpgradeType.SelectedIndex == 2)
            {
                if(TryUpgrade("회복 강화", HealUpgradeLevel))
                {
                    HealUpgradeLevel++;
                }
            }
            else
            {
                MessageBox.Show(this, "강화 종류를 선택해주세요.");
                return;
            }

            UpdateUpgradeScreen();
        }
    }
}
