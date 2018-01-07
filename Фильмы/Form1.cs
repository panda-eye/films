using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Фильмы
{
    public partial class Form1 : Form
    {
        Info info = new Info();
        Image[] im = new Image[6];
        string[] rip = new string[6];
        string[] format = new string[6];
        string[] mark = new string[6];

        public Form1()
        {
            InitializeComponent();

            im[0] = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo1.jpeg");
            im[1] = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo2.jpeg");
            im[2] = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo3.jpeg");
            im[3] = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo4.jpeg");
            im[4] = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo5.jpeg");
            im[5] = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Photo6.jpeg");

            this.panel1.Size = new Size((Point)im[0].Size);
            this.panel2.Size = new Size((Point)im[1].Size);
            this.panel4.Size = new Size((Point)im[2].Size);
            this.panel5.Size = new Size((Point)im[3].Size);
            this.panel3.Size = new Size((Point)im[4].Size);
            this.panel6.Size = new Size((Point)im[5].Size);

            this.panel1.BackgroundImage = im[0];
            this.panel2.BackgroundImage = im[1];
            this.panel3.BackgroundImage = im[2];
            this.panel4.BackgroundImage = im[3];
            this.panel5.BackgroundImage = im[4];
            this.panel6.BackgroundImage = im[5];


            name1.Text = info.names[0];
            name2.Text = info.names[1];
            name3.Text = info.names[2];
            name4.Text = info.names[3];
            name5.Text = info.names[4];
            name6.Text = info.names[5];

            format1.Text = info.format[0];
            format2.Text = info.format[1];
            format3.Text = info.format[2];
            format4.Text = info.format[3];
            format5.Text = info.format[4];
            format6.Text = info.format[5];
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));
            try
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\info.xml");
                xs.Serialize(fs, info.names[0]);
                fs.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            toSearching();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));
            try
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\info.xml");
                xs.Serialize(fs, info.names[1]);
                fs.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            toSearching();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));
            try
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\info.xml");
                xs.Serialize(fs, info.names[2]);
                fs.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            toSearching();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));
            try
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\info.xml");
                xs.Serialize(fs, info.names[3]);
                fs.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            toSearching();
        }

        private void toSearching()
        {
            this.ShowInTaskbar = false;
            this.Hide();
            Searching s = new Searching();
            s.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));
            try
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\info.xml");
                xs.Serialize(fs, info.names[4]);
                fs.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            toSearching();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));
            try
            {
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\info.xml");
                xs.Serialize(fs, info.names[5]);
                fs.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            toSearching();
        }
    }
    public class Info
    {
        public string[] names { get; set; }
        public string[] rip { get; set; }
        public string[] format { get; set; }
        public string[] mark { get; set; }
    }
}
