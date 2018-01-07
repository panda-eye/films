using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace Фильмы
{
    public partial class StartProgram : Form
    {
        byte color = 245;
        Image[] im = new Image[6];
        public string[] names = new string[10];
        public string[] rip = new string[10];
        public string[] format = new string[10];
        public string[] mark = new string[10];
        
        public StartProgram()
        {
            InitializeComponent();

            this.timer1.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var req = (HttpWebRequest)WebRequest.Create("http://7ba.ru/video");
            var resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string data = sr.ReadToEnd();
            resp.Close();
            stream.Close();
            sr.Close();

            string[] imagesUrl = data.Substrings("><img src=\"" + @"http://7ba.ru/video/poster/", ".jpg\" alt=");
            names = data.Substrings(".jpg\" alt=\"", "\" class=\"");
            rip = data.Substrings("Качество:</span> <span style=color:#C00000;>", "</span>");
            string[] formt = data.Substrings("Формат:<b>", "</b></span>");
            for (int i = 0; i < 10; i++)
            {
                string[] one = formt[i].Split(new string[] { "</b>+<b>" }, StringSplitOptions.None);
                if (one.Count() == 1)
                {
                    format[i] = one[0];
                }
                else if (one.Count() == 2)
                {
                    format[i] = one[0] + " + " + one[1];
                }
                else if (one.Count() == 3)
                {
                    format[i] = one[0] + " + " + one[1] + " + " + one[2];
                }
                else
                {
                    format[i] = one[0] + " + " + one[1] + " + " + one[2] + " + " + one[3];
                }
            }

            WebClient wc = new WebClient();
            wc.DownloadFile(new Uri("http://7ba.ru/video/poster/" + imagesUrl[0] + ".jpg"), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo1.jpeg");
            wc.DownloadFile(new Uri("http://7ba.ru/video/poster/" + imagesUrl[1] + ".jpg"), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo2.jpeg");
            wc.DownloadFile(new Uri("http://7ba.ru/video/poster/" + imagesUrl[2] + ".jpg"), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo3.jpeg");
            wc.DownloadFile(new Uri("http://7ba.ru/video/poster/" + imagesUrl[3] + ".jpg"), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo4.jpeg");
            wc.DownloadFile(new Uri("http://7ba.ru/video/poster/" + imagesUrl[4] + ".jpg"), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo5.jpeg");
            wc.DownloadFile(new Uri("http://7ba.ru/video/poster/" + imagesUrl[5] + ".jpg"), Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo6.jpeg");

            XmlSerializer xs = new XmlSerializer(typeof(string[]));
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Films.xml");
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Films.xml");
                xs.Serialize(fs, names);
                fs.Close();
            }
            catch
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Films.xml");
                xs.Serialize(fs, names);
                fs.Close();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            this.Dispose();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.ForeColor = Color.FromArgb(color, color, color);
            color--;
            if (color == 0)
            {
                timer1.Enabled = false;
                this.backgroundWorker1.RunWorkerAsync();
            }
        }
    }
    public static class myString
    {
        public static string Substring(this string str, string left, int startIndex)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            int leftPosBegin = str.IndexOf(left, startIndex, StringComparison.Ordinal);
            if (leftPosBegin == -1)
            {
                return string.Empty;
            }
            int leftPosEnd = leftPosBegin + left.Length;
            int length = str.Length - leftPosEnd;
            return str.Substring(leftPosEnd, length);
        }
        public static string Substring(this string str, string left, string right, int startIndex)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            int leftPosBegin = str.IndexOf(left, startIndex, StringComparison.Ordinal);
            if (leftPosBegin == -1)
            {
                return string.Empty;
            }
            int leftPosEnd = leftPosBegin + left.Length;
            int rightPos = str.IndexOf(right, leftPosEnd, StringComparison.Ordinal);
            if (rightPos == -1)
            {
                return string.Empty;
            }
            int length = rightPos - leftPosEnd;
            return str.Substring(leftPosEnd, length);
        }
        public static string Substring(this string str, string left)
        {
            return Substring(str, left, 0);
        }
        public static string[] Substrings(this string str, string left, string right, int startIndex)
        {
            if (string.IsNullOrEmpty(str))
            {
                return new string[0];
            }
            int currentStartIndex = startIndex;
            List<string> strings = new List<string>();
            while (true)
            {
                int leftPosBegin = str.IndexOf(left, currentStartIndex, StringComparison.Ordinal);
                if (leftPosBegin == -1)
                {
                    break;
                }
                int leftPosEnd = leftPosBegin + left.Length;
                int rightPos = str.IndexOf(right, leftPosEnd, StringComparison.Ordinal);
                if (rightPos == -1)
                {
                    break;
                }
                int length = rightPos - leftPosEnd;
                strings.Add(str.Substring(leftPosEnd, length));
                currentStartIndex = rightPos + right.Length;
            }
            return strings.ToArray();
        }
        public static string[] Substrings(this string str, string left, string right)
        {
            return str.Substrings(left, right, 0);
        }
    }
}
