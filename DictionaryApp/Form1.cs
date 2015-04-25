using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string ,string> dict=new Dictionary<string, string>();

        private string id;
        private string details;



        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text;
            details = detailsTextBox.Text;
            dict.Add(id,details);
            idTextBox.Text = "";
            detailsTextBox.Text = "";
        }

        private void searchInfoButton_Click(object sender, EventArgs e)
        {
            id = idBox.Text;

            if (dict.ContainsKey(id))
            {
                MessageBox.Show("Your Information is in the System");
            }
            else
            {
                MessageBox.Show("Not Found");
                showAllInformatiomButton.Enabled = false;
            }
        }

        private void showAllInformatiomButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string ,string > sPair in dict)
            {
                MessageBox.Show(sPair.Key+" "+sPair.Value);
            }
           
        }
    }
}
