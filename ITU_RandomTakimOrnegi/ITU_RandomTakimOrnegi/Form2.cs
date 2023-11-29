using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU_RandomTakimOrnegi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele=new Random();
        int sivaspuan = 0;
        int fenerpuan = 0;
        int besiktaspuan = 0;
        int trabzonpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            int a = rastgele.Next(0,5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0,5);

            label4.Text=a.ToString();
            label5.Text=b.ToString();
            label7.Text=c.ToString();
            label6.Text=d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                sivaspuan += 3;
                labelsivaspuan.Text = sivaspuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fenerpuan += 3;
                labelfenerpuan.Text = fenerpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                sivaspuan += 1;
                fenerpuan += 1;
                labelsivaspuan.Text = sivaspuan.ToString();
                labelfenerpuan.Text=fenerpuan.ToString();
            }

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                besiktaspuan += 3;
                labelbesiktaspuan.Text = besiktaspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                trabzonpuan += 3;
                labeltrabzonpuan.Text = trabzonpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label7.Text))
            {
                trabzonpuan += 1;
                besiktaspuan += 1;
                labelbesiktaspuan.Text = besiktaspuan.ToString();
                labeltrabzonpuan.Text = trabzonpuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label21.Text = a.ToString();
            label18.Text = b.ToString();
            label12.Text = c.ToString();
            label11.Text = d.ToString();

            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label18.Text))
            {
                sivaspuan += 3;
                labelsivaspuan.Text = sivaspuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label21.Text))
            {
                besiktaspuan += 3;
                labelbesiktaspuan.Text = besiktaspuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label18.Text))
            {
                sivaspuan += 1;
                besiktaspuan += 1;
                labelsivaspuan.Text = sivaspuan.ToString();
                labelbesiktaspuan.Text = besiktaspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                fenerpuan += 3;
                labelfenerpuan.Text= fenerpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                trabzonpuan += 3;
                labeltrabzonpuan.Text = trabzonpuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label11.Text))
            {
                fenerpuan += 1;
                trabzonpuan += 1;
                labelfenerpuan.Text = fenerpuan.ToString();
                labeltrabzonpuan.Text = trabzonpuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label31.Text = a.ToString();
            label30.Text = b.ToString();
            label26.Text = c.ToString();
            label25.Text = d.ToString();

            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label30.Text))
            {
                fenerpuan += 3;
                labelfenerpuan.Text = fenerpuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label31.Text))
            {
                besiktaspuan += 3;
                labelbesiktaspuan.Text = besiktaspuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) == Convert.ToInt32(label30.Text))
            if (Convert.ToInt32(label31.Text) == Convert.ToInt32(label30.Text))
            {
                fenerpuan += 1;
                besiktaspuan += 1;
                labelfenerpuan.Text = fenerpuan.ToString();
                labelbesiktaspuan.Text = besiktaspuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label25.Text))
            {
                sivaspuan += 3;
                labelsivaspuan.Text = sivaspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                trabzonpuan += 3;
                labeltrabzonpuan.Text = trabzonpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) == Convert.ToInt32(label25.Text))
            {
                sivaspuan += 1;
                trabzonpuan += 1;
                labelsivaspuan.Text = sivaspuan.ToString();
                labeltrabzonpuan.Text = trabzonpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labelsivaspuan.Text)> Convert.ToInt32(labelfenerpuan.Text) && Convert.ToInt32(labelsivaspuan.Text) > Convert.ToInt32(labeltrabzonpuan.Text) && Convert.ToInt32(labelsivaspuan.Text) > Convert.ToInt32(labelbesiktaspuan.Text))
            {
                label35.Text="Şampiyon Sivas";
            }
            if (Convert.ToInt32(labelfenerpuan.Text) > Convert.ToInt32(labelsivaspuan.Text) && Convert.ToInt32(labelfenerpuan.Text) > Convert.ToInt32(labeltrabzonpuan.Text) && Convert.ToInt32(labelfenerpuan.Text) > Convert.ToInt32(labelbesiktaspuan.Text))
            {
                label35.Text = "Şampiyon Fener";

            }
            if (Convert.ToInt32(labeltrabzonpuan.Text) > Convert.ToInt32(labelsivaspuan.Text) && Convert.ToInt32(labeltrabzonpuan.Text) > Convert.ToInt32(labelfenerpuan.Text) && Convert.ToInt32(labeltrabzonpuan.Text) > Convert.ToInt32(labelbesiktaspuan.Text))
            {
                label35.Text = "Şampiyon Trabzon";
            }
            if (Convert.ToInt32(labelbesiktaspuan.Text) > Convert.ToInt32(labelsivaspuan.Text) && Convert.ToInt32(labelbesiktaspuan.Text) > Convert.ToInt32(labelfenerpuan.Text) && Convert.ToInt32(labelbesiktaspuan.Text) > Convert.ToInt32(labeltrabzonpuan.Text))
            {
                label35.Text = "Şampiyon Beşiktaş";
            }
        }
    }
}
