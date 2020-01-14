using Neo4jClient;
using Neo4jClient.Cypher;
using SalonNamestaja.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonNamestaja
{
    public partial class Form1 : Form
    {
        Narudzbenica narudzbenica;
        public Form1()
        {

            InitializeComponent();
            narudzbenica = new Narudzbenica();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("MATCH (soba: Soba) RETURN soba",
                                                          queryDict, CypherResultMode.Set);
            List<Soba> sobe = ((IRawGraphClient)Neo4JManager.Instance).ExecuteGetCypherResults<Soba>(query).ToList();
        }

        private void logInAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            if (fl.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void prostorijeToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string ime = e.ClickedItem.Text;
            SobaForm sobaForm = new SobaForm(narudzbenica, ime);
            sobaForm.Show();

        }

        private void proizvodiToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProizvodiForm pf;

            if (e.ClickedItem.Text.Equals("Bela Tehnika"))
            {
                pf = new ProizvodiForm("Tehnika", narudzbenica);
                pf.Show();
            }
            else
            {
                pf = new ProizvodiForm(e.ClickedItem.Text, narudzbenica);
                pf.Show();
            }
            if (pf.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
