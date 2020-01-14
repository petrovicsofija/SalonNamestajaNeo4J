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
    public partial class FormAdmin : Form
    {
        List<Materijal> materijali;
        List<Namestaj> namestaj;
        List<Dekoracija> dekoracija;
        List<Rasveta> rasveta;
        List<Tehnika> tehnika;

        String imeProizvoda;
        String tip;
        bool soba = false;
        bool materijal = false;

        public FormAdmin()
        {
            InitializeComponent();
            Neo4JManager.client = Neo4JManager.Instance;
            Init();
        }

        #region Functions
        private void Init()
        {
            materijali = new List<Materijal>();
            PopulateComboMaterijal();
            txtCena.Enabled = false;
            txtLager.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void EnableControls()
        {
            txtCena.Enabled = true;
            txtLager.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateComboMaterijal()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("MATCH (m: Materijal) RETURN m",
                                                          queryDict, CypherResultMode.Set);
            materijali = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Materijal>(query).ToList();

            foreach (var m in materijali)
            {
                comboMaterijal.Items.Add(m.tipMaterijala);
            }
        }

        private void RefreshListBox(bool delete)
        {
            listProizvodi.Items.Clear();
            string s;
            if (delete)
                s = "";
            else
                s = txtTrazi.Text;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new CypherQuery("MATCH(n) WHERE (n:Namestaj OR n:Dekoracija OR n:Rasveta OR n:Tehnika) AND n.ime CONTAINS '" + s + "' RETURN n",
                                                          queryDict, CypherResultMode.Set);
            if (tip.Equals("Tehnika"))
            {
                tehnika = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList(); ;
                if (tehnika != null)
                {
                    foreach (var n in tehnika)
                    {
                        listProizvodi.Items.Add(n.ime);
                    }
                }
            }
            else if (tip.Equals("Dekoracija"))
            {
                dekoracija = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList();
                if (dekoracija != null)
                {
                    foreach (var n in dekoracija)
                    {
                        listProizvodi.Items.Add(n.ime);
                    }
                }
            }
            else if (tip.Equals("Namestaj"))
            {
                namestaj = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList();
                if (namestaj != null)
                {
                    foreach (var n in namestaj)
                    {
                        listProizvodi.Items.Add(n.ime);

                    }
                }
            }
            else if (tip.Equals("Rasveta"))
            {
                rasveta = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList();
                if (rasveta != null)
                {
                    foreach (var n in rasveta)
                    {
                        listProizvodi.Items.Add(n.ime);
                    }
                }
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            listProizvodi.Items.Clear();
            if (tip != null)
            {
                EnableControls();
                double cena = 0.0;
                int stanje = 0;

                if (tip.Equals("Dekoracija"))
                {
                    Dictionary<string, object> queryDict = new Dictionary<string, object>();
                    var query = new CypherQuery("MATCH(n) WHERE n:Dekoracija AND n.ime CONTAINS '" + txtTrazi.Text + "' RETURN n",
                                                                  queryDict, CypherResultMode.Set);
                    dekoracija = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList();
                    if (dekoracija.Count == 0)
                    {
                        MessageBox.Show("Molimo Vas da unesete validan naziv proizvoda!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        imeProizvoda = dekoracija[0].ime;
                        cena = dekoracija[0].cena;
                        stanje = dekoracija[0].stanjeNaLageru;
                        foreach (var n in dekoracija)
                        {
                            listProizvodi.Items.Add(n.ime);
                        }
                    }
                }
                else if (tip.Equals("Rasveta"))
                {
                    Dictionary<string, object> queryDict = new Dictionary<string, object>();
                    var query = new CypherQuery("MATCH(n) WHERE  n:Rasveta  AND n.ime CONTAINS '" + txtTrazi.Text + "' RETURN n",
                                                                  queryDict, CypherResultMode.Set);
                    rasveta = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList();
                    if (rasveta.Count == 0)
                    {
                        MessageBox.Show("Molimo Vas da unesete validan naziv proizvoda!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        imeProizvoda = rasveta[0].ime;
                        cena = rasveta[0].cena;
                        stanje = rasveta[0].stanjeNaLageru;
                        foreach (var n in rasveta)
                        {
                            listProizvodi.Items.Add(n.ime);
                        }
                    }
                }
                else if (tip.Equals("Namestaj"))
                {
                    Dictionary<string, object> queryDict = new Dictionary<string, object>();
                    var query = new CypherQuery("MATCH(n) WHERE n:Namestaj AND n.ime CONTAINS '" + txtTrazi.Text + "' RETURN n",
                                                                  queryDict, CypherResultMode.Set);
                    namestaj = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList();
                    if (namestaj.Count == 0)
                    {
                        MessageBox.Show("Molimo Vas da unesete validan naziv proizvoda!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        imeProizvoda = namestaj[0].ime;
                        cena = namestaj[0].cena;
                        stanje = namestaj[0].stanjeNaLageru;
                        foreach (var n in namestaj)
                        {
                            listProizvodi.Items.Add(n.ime);
                        }
                    }
                }
                else if (tip.Equals("Tehnika"))
                {
                    Dictionary<string, object> queryDict = new Dictionary<string, object>();
                    var query = new CypherQuery("MATCH(n) WHERE n:Tehnika AND n.ime CONTAINS '" + txtTrazi.Text + "' RETURN n",
                                                                  queryDict, CypherResultMode.Set);
                    tehnika = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList();
                    if (tehnika.Count == 0)
                    {
                        MessageBox.Show("Molimo Vas da unesete validan naziv proizvoda!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        imeProizvoda = tehnika[0].ime;
                        cena = tehnika[0].cena;
                        stanje = tehnika[0].stanjeNaLageru;
                        foreach (var t in tehnika)
                        {
                            listProizvodi.Items.Add(t.ime);
                        }
                    }

                }
                txtTrazi.Text = imeProizvoda;
                txtStaraCena.Text = cena.ToString();
                txtStariLager.Text = stanje.ToString();
            }
            else
                MessageBox.Show("Molimo Vas da unesete tip proizvoda!", "Warning", MessageBoxButtons.OK);
        }

        private void comboProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {
            tip = comboProizvod.SelectedItem.ToString();
        }

        private void comboSoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            soba = true;
        }

        private void comboMaterijal_SelectedIndexChanged(object sender, EventArgs e)
        {
            materijal = true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!CheckType()) return;
            if (txtLager.Text != String.Empty)
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new CypherQuery("MATCH (n { ime:'" + imeProizvoda + "'}) SET n.stanjeNaLageru = " + Int32.Parse(txtLager.Text) + " RETURN n",
                                                              queryDict, CypherResultMode.Set);
                if (tip.Equals("Tehnika"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query);
                else if (tip.Equals("Dekoracija"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query);
                else if (tip.Equals("Namestaj"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query);
                else if (tip.Equals("Rasveta"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query);
            }
            if (txtCena.Text != String.Empty)
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new CypherQuery("MATCH(n { ime:'" + imeProizvoda + "'}) SET n.cena = " + Double.Parse(txtCena.Text) + " RETURN n",
                                                              queryDict, CypherResultMode.Set);
                if (tip.Equals("Tehnika"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query);
                else if (tip.Equals("Dekoracija"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query);
                else if (tip.Equals("Namestaj"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query);
                else if (tip.Equals("Rasveta"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query);

            }
            if (soba)
            {
                /*MATCH(a: Dekoracija {ime:'OgledaloEKNE'})
MATCH(m:Soba {tipProstorije:'Kuhinja'}) 
MERGE(a)-[:JE_DEO {uloga:['ukrasno']}]->(m)*/
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (a:" + tip + "{ime:'" + imeProizvoda + "'})" +
                    "MATCH (m: Soba {tipProstorije:'" + comboSoba.SelectedItem.ToString() + "'}) MERGE(a)-[j:JE_DEO {uloga:['" + txtUloga.Text
                                                    + "']}]->(m) RETURN j",
                                                    queryDict, CypherResultMode.Set);
                if (tip.Equals("Tehnika"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query);
                else if (tip.Equals("Dekoracija"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query);
                else if (tip.Equals("Namestaj"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query);
                else if (tip.Equals("Rasveta"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query);
            }
            if (materijal)
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (a:" + tip + "{ime:'" + imeProizvoda + "'})" +
                    "MATCH (m: Materijal {tipMaterijala:'" + comboMaterijal.SelectedItem.ToString() + "'}) MERGE(a)-[j:SACINJEN_OD]->(m) RETURN j",
                                                    queryDict, CypherResultMode.Set);
                if (tip.Equals("Tehnika"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query);
                else if (tip.Equals("Dekoracija"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query);
                else if (tip.Equals("Namestaj"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query);
                else if (tip.Equals("Rasveta"))
                    ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query);
            }
            RefreshListBox(false);
            RefreshTextBox();
            MessageBox.Show("Azuriranje zavrseno", "Information", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (object itemChecked in listProizvodi.CheckedItems)
            {
                //MATCH (n { name: 'Andy' })
                //DETACH DELETE n
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n { ime:'" + imeProizvoda + "'}) DETACH DELETE (n)",
                                                    queryDict, CypherResultMode.Set);
                ((IRawGraphClient)Neo4JManager.client).ExecuteCypher(query);
            }

            RefreshListBox(true);

        }

        private void listProizvodi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RefreshTextBox();
        }

        private void RefreshTextBox()
        {
            if (listProizvodi.SelectedItem != null)
            {
                imeProizvoda = listProizvodi.SelectedItem.ToString();
            }
            else
            {
                imeProizvoda = listProizvodi.Items[0].ToString();
            }
            txtTrazi.Text = imeProizvoda;
            if (tip.Equals("Tehnika"))
            {
                foreach (var t in tehnika)
                {
                    if (t.ime.Equals(imeProizvoda))
                    {
                        txtStariLager.Text = t.stanjeNaLageru.ToString();
                        txtStaraCena.Text = t.cena.ToString();
                    }
                }
            }
            else if (tip.Equals("Dekoracija"))
                foreach (var t in dekoracija)
                {
                    if (t.ime.Equals(imeProizvoda))
                    {
                        txtStariLager.Text = t.stanjeNaLageru.ToString();
                        txtStaraCena.Text = t.cena.ToString();
                    }
                }
            else if (tip.Equals("Namestaj"))
                foreach (var t in namestaj)
                {
                    if (t.ime.Equals(imeProizvoda))
                    {
                        txtStariLager.Text = t.stanjeNaLageru.ToString();
                        txtStaraCena.Text = t.cena.ToString();
                    }
                }
            else if (tip.Equals("Rasveta"))
                foreach (var t in rasveta)
                {
                    if (t.ime.Equals(imeProizvoda))
                    {
                        txtStariLager.Text = t.stanjeNaLageru.ToString();
                        txtStaraCena.Text = t.cena.ToString();
                    }
                }
        }

        private void txtTrazi_Enter(object sender, EventArgs e)
        {
            txtTrazi.Text = "";
        }

        private bool CheckType()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (a:" + tip + "{ime:'" + imeProizvoda + "'}) RETURN a",
                                                queryDict, CypherResultMode.Set);
            if (tip.Equals("Tehnika"))
            {
                Tehnika t = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList().FirstOrDefault();
                if (t == null)
                {
                    MessageBox.Show("Dati proizvod nije odgovrajacuceg izabranog tipa.Molimo izaberite pravi tip proizvoda!", "Warning!", MessageBoxButtons.OK);
                    return false;
                }
            }
            else if (tip.Equals("Dekoracija"))
            {
                Dekoracija d = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList().FirstOrDefault();
                if (d == null)
                {
                    MessageBox.Show("Dati proizvod nije odgovrajacuceg izabranog tipa.Molimo izaberite pravi tip proizvoda!", "Warning!", MessageBoxButtons.OK);
                    return false;
                }
            }
            else if (tip.Equals("Namestaj"))
            {
                Namestaj n = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList().FirstOrDefault();
                if (n == null)
                {
                    MessageBox.Show("Dati proizvod nije odgovrajacuceg izabranog tipa.Molimo izaberite pravi tip proizvoda!", "Warning!", MessageBoxButtons.OK);
                    return false;
                }
            }
            else if (tip.Equals("Rasveta"))
            {
                Rasveta r = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList().FirstOrDefault();
                if (r == null)
                {
                    MessageBox.Show("Dati proizvod nije odgovrajacuceg izabranog tipa.Molimo izaberite pravi tip proizvoda!", "Warning!", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        #endregion
    }

}
