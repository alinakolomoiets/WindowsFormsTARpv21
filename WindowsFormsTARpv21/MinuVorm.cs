using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTARpv21
{
    public class MinuVorm: Form
    {
		RadioButton rnup1, rnup2;
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
            Label failinimi = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(100, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.Lavender,
            };
			rnup1 = new RadioButton
			{
				Text = "ahem",
				Location = new System.Drawing.Point(50, 175),
				Size = new System.Drawing.Size(100, 20),
				BackColor = System.Drawing.Color.LightCoral,
			};
			rnup2 = new RadioButton
			{
				Text = "hem",
				Location = new System.Drawing.Point(150, 175),
				Size = new System.Drawing.Size(100, 20),
				BackColor = System.Drawing.Color.LightCoral,
			};
			this.Controls.Add(rnup1);
			this.Controls.Add(rnup2);
            this.Controls.Add(nupp);
            this.Controls.Add(failinimi);
        }

        private void Nupp_Click(object sender, System.EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata ahem või hem?", "Küsimus", MessageBoxButtons.YesNo);
			if (vastus == DialogResult.Yes)
			{
				if (rnup1.Checked == true)
				{
					using (var muusika = new SoundPlayer(@"..\..\ahem_x.wav"))
					{
						muusika.Play();
						MessageBox.Show("mäng: ahem", "muusika");

					}
					rnup1.Checked = false;
				}
				else if (rnup2.Checked == true)
				{
					using (var muusika = new SoundPlayer(@"..\..\hem_x.wav"))
					{
						muusika.Play();
						MessageBox.Show("mängib: hem ", "Muusika");
			
					}
					rnup2.Checked = false;
				}
				else
				{
					MessageBox.Show(":(");
				}
			}
		}
	}
}
