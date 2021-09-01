using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace AutoBGchanger
{
    public partial class UnsplashControl : UserControl
    {
        string apilink = "https://source.unsplash.com";
        WallpaperLoop wpl = new WallpaperLoop();

        public UnsplashControl()
        {
            InitializeComponent();
        }

        public void executeUnsplashLoop(Decimal timer)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(apilink + "/");

            if (getUser() != "")
                builder.Append("user/" + getUser() + "/");
            else if (getCollection() != "")
                builder.Append("collection/" + getCollection() + "/");
            else if (getPhoto() != "")
                builder.Append(getPhoto() + "/");
            else
                builder.Append("random/");

            if (boxWidth.Text != "" && boxHeight.Text != "")
                builder.Append(getSize() + "/");

            if (boxTags.Text != "")
                builder.Append("?" + getTags() + "/");

            Debug.WriteLine(builder.ToString());

            wpl.timedLoopBG(builder.ToString(), (int)timer);
        }

        public void executeOneTime()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(apilink + "/");

            if (getUser() != "")
                builder.Append("user/" + getUser() + "/");
            else if (getCollection() != "")
                builder.Append("collection/" + getCollection() + "/");
            else if (getPhoto() != "")
                builder.Append(getPhoto() + "/");
            else
                builder.Append("random/");

            if (boxWidth.Text != "" && boxHeight.Text != "")
                builder.Append(getSize() + "/");

            if (boxTags.Text != "")
                builder.Append("?" + getTags() + "/");

            Debug.WriteLine(builder.ToString());
            wpl.oneTimeBGChange(builder.ToString());
        }

        public void stopUnsplashLoop()
        {
            wpl.stopTimer();
        }

        private string getTags()
        {
            StringBuilder builder = new StringBuilder();

            string tags = boxTags.Text;
            builder.Append(tags.Replace(" ", ","));

            return builder.ToString();
        }

        private string getSize()
        {
            StringBuilder builder = new StringBuilder();

            string width = boxWidth.Text;
            string height = boxHeight.Text;

            if (!width.Equals(""))
            {
                builder.Append("" + width + "x");
            }

            if (!height.Equals(""))
            {
                builder.Append("" + height + "");
            }

            return builder.ToString();
        }

        private string getUser()
        {
            return textBoxUser.Text;
        }

        private string getCollection()
        {
            return textBoxCollection.Text;
        }

        private string getPhoto()
        {
            return textBoxPhoto.Text;
        }
    }
}
