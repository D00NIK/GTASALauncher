using System.Diagnostics;

namespace GTASALauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum GAME_SELECTION
        {
            GTA,
            MTA,
            SAMP
        }

        private string GTA_PATH = "gta_sa.exe";
        private string MTA_PATH = "C:\\Program Files (x86)\\MTA San Andreas 1.6\\Multi Theft Auto.exe";
        private string SAMP_PATH = "samp.exe";

        private void run(GAME_SELECTION game)
        {
            string path;

            if (game == GAME_SELECTION.GTA)
                path = GTA_PATH;
            else if (game == GAME_SELECTION.MTA)
                path = MTA_PATH;
            else
                path = SAMP_PATH;

            var process = Process.Start(path);
            this.Hide();
            process.WaitForExit();
            Application.Exit();
        }

        // GTA SA
        private void button1_Click(object sender, EventArgs e)
        {
            run(GAME_SELECTION.GTA);
        }

        // MTA
        private void button2_Click(object sender, EventArgs e)
        {
            run(GAME_SELECTION.MTA);
        }

        // SAMP
        private void button3_Click(object sender, EventArgs e)
        {
            run(GAME_SELECTION.SAMP);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
