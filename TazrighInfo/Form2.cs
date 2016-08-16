using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tazrighCustomerDataSet.Tazrigh' table. You can move, or remove it, as needed.
            this.tazrighTableAdapter.Fill(this.tazrighCustomerDataSet.Tazrigh);
            oleDbDataAdapter1.Fill(dataSet11);
            oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        
    }
}
