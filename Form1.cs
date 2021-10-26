using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearLabel(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("This is a log");
            mainLabel.Text = "";
        }


        private void TypeValue(object send, EventArgs e) 
        {
            Button b = (Button)send;
            System.Diagnostics.Debug.WriteLine(b.Text);
            mainLabel.Text += b.Text;
        }

        private void Caculate(object sender, EventArgs e)
        {
            String math = mainLabel.Text;
            try
            {
                mainLabel.Text = new DataTable().Compute(math, null).ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }            
        }

        private void DeleteCharacter(object sender, EventArgs e)
        {
            try
            {
                mainLabel.Text = mainLabel.Text.Remove(mainLabel.Text.Length - 1);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
