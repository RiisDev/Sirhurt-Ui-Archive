using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirhurtV4ReCreate
{
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Russian
            if (checkBox3.Checked == true)
            {
                Properties.Settings.Default["Language"] = "Russian";
                Properties.Settings.Default.Save();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Portuguese
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default["Language"] = "Portuguese";
                Properties.Settings.Default.Save();
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            //German
            if (checkBox4.Checked == true)
            {
                Properties.Settings.Default["Language"] = "German";
                Properties.Settings.Default.Save();
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            //French
            if (checkBox5.Checked == true)
            {
                Properties.Settings.Default["Language"] = "French";
                Properties.Settings.Default.Save();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default["Language"] = "English";
                Properties.Settings.Default.Save();
            }
        }

        private void Language_Load(object sender, EventArgs e)
        {
            TopMost = true;

            string Language = Properties.Settings.Default.Language;

            if (Language == "English")
            {
                checkBox1.Checked = true;
            }

            if (Language == "Russian")
            {
                checkBox3.Checked = true;
            }

            if (Language == "French")
            {
                checkBox5.Checked = true;
            }

            if (Language == "Portuguese")
            {
                checkBox2.Checked = true;
            }

            if (Language == "German")
            {
                checkBox4.Checked = true;
            }
        }
    }
}
