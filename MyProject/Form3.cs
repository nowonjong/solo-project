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
    public partial class Form3 : Form
    {
        public enum BattleResultChoice
        {
            None,
            Replay,
            Upgrade,
            Home
        }
        
        public BattleResultChoice SelectedChoice { get; set; }
        = BattleResultChoice.None;
        public Form3()
        {
            InitializeComponent();
        }

        public void BattleResult(string resultText)
        {
            lbBattleResult.Text = resultText;

            if (resultText == "승리")
            {
                btnPlay.Text = "다음 스테이지";
            }
            else
            {
                btnPlay.Text = "다시하기";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SelectedChoice = BattleResultChoice.Replay;
            Close();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            SelectedChoice = BattleResultChoice.Upgrade;
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SelectedChoice = BattleResultChoice.Home;
            Close();
        }
    }
}
