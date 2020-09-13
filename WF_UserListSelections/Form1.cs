using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WF_UserListSelections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonUserSelShow_Click(object sender, EventArgs e)
        {
            labelUserSel.Text = listBox1.SelectedItem.ToString() + listBox2.SelectedItem.ToString();
            MessageBox.Show($"{listBox1.SelectedItem.ToString()} \n {listBox2.SelectedItem.ToString()}", "Ваш выбор:");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelUserSel.Text.ToUpper();
            labelUserSel.AutoSize = true;
        }
    }
}

