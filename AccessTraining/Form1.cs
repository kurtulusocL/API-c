using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessTraining
{
    public partial class Form1 : Form
    {
        void Loadsss()
        {
            var client = new WebClient();
            var text = client.DownloadString("https://jsonplaceholder.typicode.com/posts");
            //text = JsonConvert.SerializeObject(text);
            //Posts deserialized= JsonConvert.DeserializeObject<Posts>(text);
            listBox1.Items.Add(text).ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loadsss();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
