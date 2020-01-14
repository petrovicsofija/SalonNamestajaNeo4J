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
    public partial class FormLogin : Form
    {
        public Osoba Admin;
        public FormLogin()
        {
            InitializeComponent();
            Neo4JManager.client = Neo4JManager.Instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("MATCH (z: Osoba {ime: '" + txtUsername.Text + "', sifra: '" + txtPassword.Text + "'}) RETURN z",
                                                          queryDict, CypherResultMode.Set);
            Admin = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Osoba>(query).ToList().FirstOrDefault();
            if (Admin != null)
            {
                FormAdmin fa = new FormAdmin();
                fa.Show();
                if (fa.DialogResult == DialogResult.OK)
                {
                    fa.Close();
                }
            }
            else
            {
                MessageBox.Show("Nevalidan nalog", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
