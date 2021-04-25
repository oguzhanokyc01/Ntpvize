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
        }
    }
}
