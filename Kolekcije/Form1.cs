using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije
{
    public partial class Form1 : Form
    {
        List<Kolekcije> list = new List<Kolekcije>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNunesi_Click(object sender, EventArgs e)
        {
            try
            {
                Kolekcije memory = new Kolekcije(TXTime.Text, TXTprezime.Text, Convert.ToInt32(TXTgod.Text), CMBrod.Text, "");
                list.Add(memory);
                TXTime.Clear();
                TXTprezime.Clear();
                TXTgod.Clear();

                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception greska)
            {
                MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNispisi_Click(object sender, EventArgs e)
        {
            RCBispis.Text = "Ime" + "\tPrezime" + "\tgodRod" + "\tRod" + "\tDodatak\r\n";
            foreach (Kolekcije memory in list)
            {
                RCBispis.AppendText(memory.ToString() + "\r\n" );
            }
        }

        private void BTNobradi_Click(object sender, EventArgs e)
        {
            foreach(Kolekcije memory in list)
            {
                if(memory.Rod == "M")
                {
                    memory.Brkovi = "Ima brkove";
                }
                if(memory.Rod == "Ž")
                {
                    memory.Brkovi = "Nema brkove";
                }
            }
            foreach(Kolekcije memory in list)
            {
                RCBispis.AppendText(memory.ToString() + "\r\n");
            }
        }
    }
}
