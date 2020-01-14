using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonNamestaja.Entiteti;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace SalonNamestaja
{
    public partial class ProizvodForm : Form
    {
        Narudzbenica narudzbenica;
        Dekoracija dekoracija;
        Namestaj namestaj;
        Rasveta rasveta;
        Tehnika tehnika;

        public ProizvodForm(String ime, Narudzbenica n)
        {
            InitializeComponent();
            InitializeForm(ime);
            InitializeControls();
            narudzbenica = n;
        }
        public void InitializeControls()
        {

            if (dekoracija != null)
            {
                lblNaziv.Text = dekoracija.ime;
                lblCena.Text = dekoracija.cena.ToString() + "e";
                Dictionary<string, object> queryDict = new Dictionary<string, object>();

                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Dekoracija {ime: '" + dekoracija.ime + "'})-[l:JE_DEO]->(soba: Soba) return soba",
                                                               queryDict, CypherResultMode.Set);
                Soba s = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Soba>(query).ToList().FirstOrDefault();

                query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Dekoracija {ime: '" + dekoracija.ime + "'}) - [l:JE_DEO]->(soba: Soba) return l",
                                                               queryDict, CypherResultMode.Set);
                Deo d = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Deo>(query).ToList().FirstOrDefault();

                String u = d.uloga.Substring(6);
                u = u.Substring(0, u.Length - 4);

                dekoracija.jeDeo(s, u);

                lblOpis.Text = dekoracija.deo.uloga + ": \n" + dekoracija.tipDekoracije;
                Dictionary<string, object> queryDict1 = new Dictionary<string, object>();

                var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Dekoracija {ime: '" + dekoracija.ime + "'})-[l:SACINJEN_OD]->(m: Materijal) return m",
                                                               queryDict1, CypherResultMode.Set);
                List<Materijal> materijali = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Materijal>(query1).ToList();

                lblMat.Text = "";
                foreach (var m in materijali)
                {
                    if (m.boja != null && m.klasa!=null)
                        lblMat.Text += m.tipMaterijala + " boje: " + m.boja + " klase:" + m.klasa + "\r\n";
                    else if(m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " klase:" + m.klasa + "\r\n";
                    else
                        lblMat.Text += m.tipMaterijala +"\r\n";
                }
                return;

            }

            if (tehnika != null)
            {
                lblNaziv.Text = tehnika.ime;
                lblCena.Text = tehnika.cena.ToString() + "e";
                Dictionary<string, object> queryDict = new Dictionary<string, object>();

                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Tehnika {ime: '" + tehnika.ime + "'})-[l:JE_DEO]->(soba: Soba) return soba",
                                                               queryDict, CypherResultMode.Set);
                Soba s = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Soba>(query).ToList().FirstOrDefault();

                query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Tehnika {ime: '" + tehnika.ime + "'}) - [l:JE_DEO]->(soba: Soba) return l",
                                                               queryDict, CypherResultMode.Set);
                Deo d = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Deo>(query).ToList().FirstOrDefault();

                String u = d.uloga.Substring(6);
                u = u.Substring(0, u.Length - 4);

                tehnika.jeDeo(s, u);

                lblOpis.Text = tehnika.deo.uloga + ": \n" + tehnika.opis;

                Dictionary<string, object> queryDict1 = new Dictionary<string, object>();

                var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Tehnika {ime: '" + tehnika.ime + "'})-[l:SACINJEN_OD]->(m: Materijal) return m",
                                                               queryDict1, CypherResultMode.Set);
                List<Materijal> materijali = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Materijal>(query1).ToList();

                lblMat.Text = "";
                foreach (var m in materijali)
                {
                    if (m.boja != null && m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " boje: " + m.boja + " klase:" + m.klasa + "\r\n";
                    else if (m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " klase:" + m.klasa + "\r\n";
                    else
                        lblMat.Text += m.tipMaterijala + "\r\n";
                }
                return;
            }
            if (namestaj != null)
            {
                lblNaziv.Text = namestaj.ime;
                lblCena.Text = namestaj.cena.ToString() + "e";
                Dictionary<string, object> queryDict = new Dictionary<string, object>();

                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Namestaj {ime: '" + namestaj.ime + "'})-[l:JE_DEO]->(soba: Soba) return soba",
                                                               queryDict, CypherResultMode.Set);
                Soba s = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Soba>(query).ToList().FirstOrDefault();

                query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Namestaj {ime: '" + namestaj.ime + "'}) - [l:JE_DEO]->(soba: Soba) return l",
                                                               queryDict, CypherResultMode.Set);
                Deo d = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Deo>(query).ToList().FirstOrDefault();

                String u = d.uloga.Substring(6);
                u = u.Substring(0, u.Length - 4);

                namestaj.jeDeo(s, u);

                lblOpis.Text = namestaj.deo.uloga + ": \n" + namestaj.opis;
                Dictionary<string, object> queryDict1 = new Dictionary<string, object>();

                var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Namestaj {ime: '" + namestaj.ime + "'})-[l:SACINJEN_OD]->(m: Materijal) return m",
                                                               queryDict1, CypherResultMode.Set);
                List<Materijal> materijali = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Materijal>(query1).ToList();

                lblMat.Text = "";
                foreach (var m in materijali)
                {
                    if (m.boja != null && m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " boje: " + m.boja + " klase:" + m.klasa + "\r\n";
                    else if (m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " klase:" + m.klasa + "\r\n";
                    else
                        lblMat.Text += m.tipMaterijala + "\r\n";
                }
                return;
            }
            if (rasveta != null)
            {
                lblNaziv.Text = rasveta.ime;
                lblCena.Text = rasveta.cena.ToString() + "e";
                Dictionary<string, object> queryDict = new Dictionary<string, object>();

                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Rasveta {ime: '" + rasveta.ime + "'})-[l:JE_DEO]->(soba: Soba) return soba",
                                                               queryDict, CypherResultMode.Set);
                Soba s = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Soba>(query).ToList().FirstOrDefault();

                query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Rasveta {ime: '" + rasveta.ime + "'}) - [l:JE_DEO]->(soba: Soba) return l",
                                                               queryDict, CypherResultMode.Set);
                Deo d = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Deo>(query).ToList().FirstOrDefault();

                String u = d.uloga.Substring(6);
                u = u.Substring(0, u.Length - 4);

                rasveta.jeDeo(s, u);

                lblOpis.Text = rasveta.deo.uloga + ": \n" + rasveta.opis;

                Dictionary<string, object> queryDict1 = new Dictionary<string, object>();

                var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Rasveta {ime: '" + rasveta.ime + "'})-[l:SACINJEN_OD]->(m: Materijal) return m",
                                                               queryDict1, CypherResultMode.Set);
                List<Materijal> materijali = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Materijal>(query1).ToList();

                lblMat.Text = "";
                foreach (var m in materijali)
                {
                    if (m.boja != null && m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " boje: " + m.boja + " klase:" + m.klasa + "\r\n";
                    else if (m.klasa != null)
                        lblMat.Text += m.tipMaterijala + " klase:" + m.klasa + "\r\n";
                    else
                        lblMat.Text += m.tipMaterijala + "\r\n";
                }
                return;
            }
        }
        public void InitializeForm(String ime)
        {

            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Dekoracija {ime: '" + ime + "'}) return proizvod",
                                                           queryDict, CypherResultMode.Set);
            List<Dekoracija> listaD = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList();
            if (listaD.Count != 0)
            {
                dekoracija = listaD.First();
            }

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Namestaj {ime: '" + ime + "'}) return proizvod",
                                                           queryDict, CypherResultMode.Set);
            List<Namestaj> listaN = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList();
            if (listaN.Count != 0)
            {
                namestaj = listaN.First();
            }

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Rasveta {ime: '" + ime + "'}) return proizvod",
                                                         queryDict, CypherResultMode.Set);
            List<Rasveta> listaR = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList();
            if (listaR.Count != 0)
            {
                rasveta = listaR.First();
            }

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Tehnika {ime: '" + ime + "'}) return proizvod",
                                                queryDict, CypherResultMode.Set);
            List<Tehnika> listaT = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList();
            if (listaT.Count != 0)
            {
                tehnika = listaT.First();
            }

        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {

            NarucivanjeForm narucivanjeForm = new NarucivanjeForm(narudzbenica, namestaj, tehnika, rasveta, dekoracija);
            narucivanjeForm.Show();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
