using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace AutoBGchanger
{
    class WallpaperLoop
    {
        bool running = false;

        public void oneTimeBGChange(string link)
        {
            string linkBG = getBG(link);
            changeBG(linkBG);
        }

        public void timedLoopBG(string link, int timer)
        {
            running = true;
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
                (Application.OpenForms["telaSelecaoBG"] as telaSelecaoBG).buttonRun.BeginInvoke(new MethodInvoker(() =>
                {
                    (Application.OpenForms["telaSelecaoBG"] as telaSelecaoBG).buttonRun.Text = "Run";
                }));

                running = false;
                MessageBox.Show("It was not possible to download the required image", "Error", MessageBoxButtons.OK);
            }
        }

        public void stopTimer()
        {
            running = false;
        }

        private void changeBG(string link)
        {
            Wallpaper.Set(new Uri(link), Wallpaper.Style.Fill);
        }

        private string getBG(string formatedLink)
        {
            if (formatedLink.Contains("unsplash"))
            {
                return formatedLink;
            }

            string responseBody = new WebClient().DownloadString(formatedLink);

            try
            {
                dynamic jsonBG = JsonConvert.DeserializeObject(responseBody);
                return jsonBG[0].file_url;
            }
            catch (Exception e)
            {
                throw;
            }

        }

    }


}
