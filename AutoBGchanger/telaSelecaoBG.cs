using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoBGchanger
{
    public partial class telaSelecaoBG : Form
    {
        KonaChanControl kcc;
        UnsplashControl usc;
        String runnningHub = "";

        Thread timedBGThread = null;

        public telaSelecaoBG()
        {
            InitializeComponent();
            kcc = new KonaChanControl();
            usc = new UnsplashControl();

            comboBoxHub.Items.Add("Konachan");
            comboBoxHub.Items.Add("Unsplash");
            comboBoxHub.SelectedIndex = 0;
        }

        private void acaoChangeHub(object sender, EventArgs e)
        {
            var selectedHub = comboBoxHub.SelectedItem.ToString();
            if (selectedHub == "Konachan")
            {
                panelHub.Controls.Clear();
                panelHub.Controls.Add(kcc);
            }
            else if (selectedHub == "Unsplash")
            {
                panelHub.Controls.Clear();
                panelHub.Controls.Add(usc);
            }
        }

        private void acaoRun(object sender, EventArgs e)
        {
            if (buttonRun.Text == "Run")
            {
                var selectedHub = comboBoxHub.SelectedItem.ToString();
                if (selectedHub == "Konachan")
                {
                    kcc.executeKonaChanLoop(numericUpDownTimer.Value);
                }
                else if (selectedHub == "Unsplash")
                {
                    usc.executeUnsplashLoop(numericUpDownTimer.Value);
                }
                buttonRun.Text = "Stop";
                runnningHub = selectedHub;
            }
            else
            {
                if (runnningHub == "Konachan")
                {
                    kcc.stopKonaChanLoop();
                }
                else if (runnningHub == "Unsplash")
                {
                    usc.stopUnsplashLoop();
                }
                buttonRun.Text = "Run";
            }

        }

        private void acaoRun1(object sender, EventArgs e)
        {
            var selectedHub = comboBoxHub.SelectedItem.ToString();
            if (selectedHub == "Konachan")
            {
                kcc.executeOneTime();
            }
            else if (selectedHub == "Unsplash")
            {
                usc.executeOneTime();
            }
        }

        private void telaSelecaoBG_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500, "AutoBG", "Running in background", ToolTipIcon.Info);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}
