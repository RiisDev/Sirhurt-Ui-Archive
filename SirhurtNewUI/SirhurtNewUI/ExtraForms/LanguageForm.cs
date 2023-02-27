using SirhurtNewUI.RandomStuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirhurtNewUI.ExtraForms
{
    public partial class LanguageForm : Form
    {
        Editor ColorClass = new Editor();
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Process.GetCurrentProcess().Kill();
        }

        public void UpdateLang(string Lang)
        {
            var MyIni = ColorClass.MyIni;

            MyIni.Write("language", Lang, "main");
        }


        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Russian
            foreach (Control Cont in Controls)
            {
                try
                {
                    var Current = sender as CheckBox;
                    if (Cont is CheckBox)
                    {
                        var Box = Cont as CheckBox;
                        if (Box.Name != Current.Name)
                        {
                            Box.Checked = false;
                        }
                    }
                }
                catch { }
            }
            if (checkBox3.Checked == true)
            {
                UpdateLang("Russian");
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Portuguese
            foreach (Control Cont in Controls)
            {
                try
                {
                    var Current = sender as CheckBox;
                    if (Cont is CheckBox)
                    {
                        var Box = Cont as CheckBox;
                        if (Box.Name != Current.Name)
                        {
                            Box.Checked = false;
                        }
                    }
                }
                catch { }
            }
            if (checkBox2.Checked == true)
            {
                UpdateLang("Portuguese");
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            //German
            foreach (Control Cont in Controls)
            {
                try
                {
                    var Current = sender as CheckBox;
                    if (Cont is CheckBox)
                    {
                        var Box = Cont as CheckBox;
                        if (Box.Name != Current.Name)
                        {
                            Box.Checked = false;
                        }
                    }
                }
                catch { }
            }
            if (checkBox4.Checked == true)
            {
                UpdateLang("German");
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            //French
            foreach (Control Cont in Controls)
            {
                try
                {
                    var Current = sender as CheckBox;
                    if (Cont is CheckBox)
                    {
                        var Box = Cont as CheckBox;
                        if (Box.Name != Current.Name)
                        {
                            Box.Checked = false;
                        }
                    }
                }
                catch { }
            }
            if (checkBox5.Checked == true)
            {
                UpdateLang("French");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control Cont in Controls)
            {
                try
                {
                    var Current = sender as CheckBox;
                    if (Cont is CheckBox)
                    {
                        var Box = Cont as CheckBox;
                        if (Box.Name != Current.Name)
                        {
                            Box.Checked = false;
                        }
                    }
                }
                catch { }
            }
            if (checkBox1.Checked == true)
            {
                UpdateLang("English");
            }
        }

        private void Language_Load(object sender, EventArgs e)
        {
            TopMost = true;
            var MyIni = ColorClass.MyIni;

            string Language = MyIni.Read("language", "main");
            Console.WriteLine(Language);
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

            if (Language == "Polski")
            {
                checkBox6.Checked = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control Cont in Controls)
            {
                try
                {
                    var Current = sender as CheckBox;
                    if (Cont is CheckBox)
                    {
                        var Box = Cont as CheckBox;
                        if (Box.Name != Current.Name)
                        {
                            Box.Checked = false;
                        }
                    }
                }
                catch { }
            }
            if (checkBox6.Checked == true)
            {
                UpdateLang("Polski");
            }
        }
    }
}
