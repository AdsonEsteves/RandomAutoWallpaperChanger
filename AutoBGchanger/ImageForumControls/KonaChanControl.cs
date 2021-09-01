using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoBGchanger
{
    public partial class KonaChanControl : UserControl
    {
        string apilink = "https://konachan.com/post.json?tags=order%3Arandom";
        Thread timedBGThread = null;
        WallpaperLoop wpl = new WallpaperLoop();

        public KonaChanControl()
        {
            InitializeComponent();
        }

        public void executeKonaChanLoop(Decimal time)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(apilink + "+");
            builder.Append(getTags() + "+");
            builder.Append(getRating() + "+");
            builder.Append(getSize());
            Debug.WriteLine(builder.ToString());

            timedBGThread = new Thread(() => wpl.timedLoopBG(builder.ToString(), (int)time));
            timedBGThread.Start();
        }

        public void executeOneTime()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(apilink + "+");
            builder.Append(getTags() + "+");
            builder.Append(getRating() + "+");
            builder.Append(getSize());
            Debug.WriteLine(builder.ToString());


            timedBGThread = new Thread(() => wpl.oneTimeBGChange(builder.ToString()));
            timedBGThread.Start();
        }

        public void stopKonaChanLoop()
        {
            wpl.stopTimer();
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
    }
}
