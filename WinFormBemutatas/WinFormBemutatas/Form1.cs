using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBemutatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToInt32(textBoxA.Text);
                var b = Convert.ToInt32(textBoxB.Text);
                var c = a / b;

                labelEredmeny.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           



        }
    }
}
