using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           label3.Visible = true;
            for (int a = 0; a <=2; a++)
                if (Convert.ToInt32(textBox1.Text) == a)
                    label3.Text = "Очень преочень белый";


            for (int a = 3; a <=4; a++)
                if (Convert.ToInt32(textBox1.Text) == a)
                    label3.Text = "Просто белый";


                if (Convert.ToInt32(textBox1.Text) == 5)
                    label3.Text = "Не очень белый или не очень мулат";


                for (int a = 6; a <= 16; a++)
                    if (Convert.ToInt32(textBox1.Text) == a)
                        label3.Text = " Не очень мулат или не очень белый";

                for (int a = 17; a <= 27; a++)
                    if (Convert.ToInt32(textBox1.Text) == a)
                        label3.Text = "Просто мулат";


                for (int a = 28; a <= 58; a++)
                    if (Convert.ToInt32(textBox1.Text) == a)
                        label3.Text = "Очень мулат или не очень негр";


                for (int a = 59; a <= 67; a++)
                    if (Convert.ToInt32(textBox1.Text) == a)
                        label3.Text = "Очень негр или не очень мулат";

                for (int a = 68; a <= 76; a++)
                    if (Convert.ToInt32(textBox1.Text) == a)
                        label3.Text = "Просто негр";

                
                    if (Convert.ToInt32(textBox1.Text)>76)
                        label3.Text = "Очень  негр";

        }
    }
}
