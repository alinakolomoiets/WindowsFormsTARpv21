using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTARpv21
{
    public  class MinuVorm: Form
    {
        public MinuVorm() { }
        public MinuVorm (string Pealkiri,string Nupp,string Fail)
        {
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = Nupp,
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.LavenderBlush,
            };
            nupp.Click += Nupp_Click;
            Label failimini = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(100, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.Lavender,
            };
            this.Controls.Add(nupp);
            this.Controls.Add(failimini);
            Button nupp1 = new Button
            {
                Text = Nupp,
                Location = new System.Drawing.Point(100, 50),
                Size = new System.Drawing.Size(200, 50),
                BackColor = System.Drawing.Color.BlueViolet,
            };
            nupp.Click += Nupp_Click;
            Label failimini1 = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(100, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.Lavender,
            };
            this.Controls.Add(nupp1);
            this.Controls.Add(failimini1);
        }

        private void Nupp_Click(object sender, System.EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata ahem?", "Küsimus", MessageBoxButtons.YesNo);
            if(vastus == DialogResult.Yes)
            {
                using(var muusika= new SoundPlayer(@"..\..\ahem_x.wav"))
                {
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
            Button nupp1_sender = (Button)sender;
            var vastus1 = MessageBox.Show("Kas tahad muusikat kuulata hem ?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus1 == DialogResult.Yes)
            {
                using (var muusika1 = new SoundPlayer(@"..\..\hem_x.wav"))
                {
                    muusika1.Play();
                }
            }

            else
            {
                MessageBox.Show(":(");
            }
        }
    }
}
