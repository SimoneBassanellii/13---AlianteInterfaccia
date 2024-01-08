using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___AlianteInterfaccia
{
    public partial class Form1 : Form
    {
        private List<string> values = new List<string>();
        private Aliante aliante;

        public Form1()
        {
            InitializeComponent();
            aliante = new Aliante();
        }

        private void Aggiungibutton_Click(object sender, EventArgs e)
        {
            if (FusoliaraRadio.Checked)
            {
                values.Add($"La lunghezza è: " + textBox1.Text); 
                values.Add($"La larghezza è: " + textBox2.Text);
            }
            if (AlaRadio.Checked)
            {
                values.Add($"La lunghezza è: " + textBox4.Text);
                values.Add($"L'apertura è: " + textBox3.Text);
            }
            if (CodaRadio.Checked)
            {
                values.Add($"La lunghezza è: " + textBox5.Text);
            }
            if (RuotaRadio.Checked)
            {
                values.Add($"L'altezza è: " + textBox7.Text);
                values.Add($"La larghezza è: " + textBox6.Text);
                values.Add($"Il raggio è: " + textBox8.Text);
                values.Add($"I pollici sono: " + textBox10.Text);
                values.Add($"Il materiale è: " + textBox9.Text);
            }
        }

        private void Visualizzabutton_Click(object sender, EventArgs e)
        {
            foreach (string value in values)
            {
                listView1.Items.Add(value);
            }
        }

        private void Prezzo_Click(object sender, EventArgs e)
        {
            //
        }

    }
}
