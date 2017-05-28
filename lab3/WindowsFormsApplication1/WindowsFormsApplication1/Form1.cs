using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
               
                textBox1.Text = openFileDialog1.FileName;
            }
            path = textBox1.Text;
            var httpRequest = (HttpWebRequest)HttpWebRequest.Create("http://localhost:56738/home/Read?path=" + path);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            var reader = new StreamReader(httpResponse.GetResponseStream());
            string result = reader.ReadToEnd();
            richTextBox1.Text = result;
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        
    }
    public class Content
    {
        public string path { get; set; }
        public string text { get; set; }
    }
}
