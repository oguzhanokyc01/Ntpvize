using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Ntpvize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { String dosya = "CnnTürk.txt";
            XmlTextReader rsscek = new XmlTextReader("https://www.cnnturk.com/feed/rss/spor/news");
            FileStream filestream = new FileStream(dosya, FileMode.Create, FileAccess.Write);
            StreamWriter yazdir =new  StreamWriter(filestream);

            while (rsscek.Read())
            {
                if (rsscek.Name=="title")
                {
                    string veriyaz = rsscek.ReadString();
                    yazdir.WriteLine(veriyaz);

                }

            }

            yazdir.Flush();
            yazdir.Close();
            filestream.Close();

            FileStream fileStream1 = new FileStream(dosya, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream1);
            string rssveri = reader.ReadLine();
            while (rssveri!=null)
            {
                dataGridView1.Rows.Add(rssveri);
                rssveri = reader.ReadLine();
            }

            reader.Close();
            fileStream1.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String dosya = "CnnTürk.txt";
            XmlTextReader rsscek = new XmlTextReader("https://www.cnnturk.com/feed/rss/spor/news");
            FileStream filestream = new FileStream(dosya, FileMode.Create, FileAccess.Write);
            StreamWriter yazdir = new StreamWriter(filestream);

            while (rsscek.Read())
            {
                if (rsscek.Name == "title")
                {
                    string veriyaz = rsscek.ReadString();
                    yazdir.WriteLine(veriyaz);

                }

            }

            yazdir.Flush();
            yazdir.Close();
            filestream.Close();

            FileStream fileStream1 = new FileStream(dosya, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream1);
            string rssveri = reader.ReadLine();
            while (rssveri != null)
            {
                dataGridView1.Rows.Add(rssveri);
                rssveri = reader.ReadLine();
            }

            reader.Close();
            fileStream1.Close();


        }
    }
}
