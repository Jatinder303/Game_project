using System.Windows.Forms;

namespace Game_project
{
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            InitializeComponent();
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }

        private void btn_PlayAgain_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }

        private void btn_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Load_Click(object sender, System.EventArgs e)
        {
            btn_Spin.Enabled = true;
            btn_Load.Enabled = false;
        }

        private void btn_Spin_Click(object sender, System.EventArgs e)
        {
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            btn_Spin.Enabled = false;
        }
    }
}
