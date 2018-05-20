using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;



namespace DotNetBarProject
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> list = new List<Item>()
            {
                new Item(){Name="ABC", From="China", Fruit="apple"},
                new Item(){Name="BCF", From="American", Fruit="banana"},
                new Item(){Name="HDK", From="China", Fruit="Pear"},
                new Item(){Name="CHD", From="American ", Fruit="Lemon"},
            };

            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.DataSource = list;
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                this.textBoxX1.Focus();
            }
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxX2.Focus();
            }
        }
    }
}
