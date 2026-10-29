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
    public partial class Form4 : Form
    {
        public PauseChoice SelectedChoice { get; private set; }  // 설정 화면에서 선택한 결과
        = PauseChoice.Continue;
        public Form4()
        {
            InitializeComponent();
        }
        public enum PauseChoice
        {
            Continue,
            Retry,
            Home
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SelectedChoice = PauseChoice.Continue;
            Close();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            SelectedChoice = PauseChoice.Retry;
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SelectedChoice = PauseChoice.Home;
            Close();
        }
    }
}
