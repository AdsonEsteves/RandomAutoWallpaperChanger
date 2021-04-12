using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoBGchanger
{
    public partial class telaSelecaoBG : Form
    {
        string apilink = "https://konachan.com/post.json?tags=order%3Arandom";
        Thread timedBGThread = null;
        bool running = false;
        public telaSelecaoBG()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void acaoRun(object sender, EventArgs e)
        {
            if (button1.Text == "Run")
            {
                running = true;
                StringBuilder builder = new StringBuilder();
                builder.Append(apilink + "+");
                builder.Append(getTags() + "+");
                builder.Append(getRating() + "+");
                builder.Append(getSize());
                Debug.WriteLine(builder.ToString());

                timedBGThread = new Thread(() => timedLoopBG(builder.ToString()));
                timedBGThread.Start();
                button1.Text = "Stop";
            }
            else if (button1.Text == "Stop")
            {
                running = false;
                button1.Text = "Run";
            }

        }

        private void timedLoopBG(string link)
        {
            int timer = (int)numericUpDownTimer.Value;
            try
            {
                while (running)
                {
                    string linkBG = getBG(link);
                    changeBG(linkBG);
                    Thread.Sleep(timer * 1000);
                }
            }
            catch (Exception e)
            {
                DialogResult dialogResult = MessageBox.Show("The used tags are not available", "Error", MessageBoxButtons.OK);
                running = false;
                button1.Text = "Run";
            }
        }

        private void changeBG(string link)
        {
            Wallpaper.Set(new Uri(link), Wallpaper.Style.Fill);
        }

        private string getBG(string formatedLink)
        {
            string responseBody = new WebClient().DownloadString(formatedLink);

            dynamic jsonBG = JsonConvert.DeserializeObject(responseBody);

            try
            {
                return jsonBG[0].file_url;
            }
            catch (Exception e)
            {
                throw;
            }

        }

        private string getTags()
        {
            StringBuilder builder = new StringBuilder();

            string tags = boxTags.Text;
            builder.Append(tags.Replace(" ", "+"));

            return builder.ToString();
        }

        private string getSize()
        {
            StringBuilder builder = new StringBuilder();

            string width = boxWidth.Text;
            string height = boxHeight.Text;

            if (!width.Equals(""))
            {
                builder.Append("width%3A" + width + "..+");
            }

            if (!width.Equals(""))
            {
                builder.Append("height%3A" + height + "..");
            }

            return builder.ToString();
        }

        private string getRating()
        {
            string ratingInput = comboBoxRating.SelectedItem == null ? "" : comboBoxRating.SelectedItem.ToString();
            switch (ratingInput)
            {
                case "Safe":
                    return "rating%3Asafe";

                case "Safe - Questionable":
                    return "rating%3Aquestionableless";

                case "Questionable":
                    return "rating%3Aquestionable";

                case "Questionable - Explicit":
                    return "rating%3Aquestionableplus";

                case "Explicit":
                    return "rating%3Aexplicit";

                default:
                    return "";
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
