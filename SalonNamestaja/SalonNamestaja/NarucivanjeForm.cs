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
    public partial class NarucivanjeForm : Form
    {
        int count; string ime;
        Narudzbenica narudzbenica;
        Dekoracija dekoracija;
        Namestaj namestaj;
        Rasveta rasveta;
        Tehnika tehnika;
        double cena;
        public NarucivanjeForm(Narudzbenica narudzbenica, Namestaj n, Tehnika t, Rasveta r, Dekoracija d)
        {
            InitializeComponent();

            namestaj = n;
            tehnika = t;
            rasveta = r;
            dekoracija = d;
            this.narudzbenica = narudzbenica;

            InitializeForm();
            if (narudzbenica != null)
            {
                tbImePrezime.text = narudzbenica.ImeKupca;
                tbAdresaDostave.text = narudzbenica.AdresaDostave;
            }

        }
        private void InitializeForm()
        {

            if (namestaj != null)
            {
                ime = namestaj.ime;
                tbImeProizvoda.text = ime;
                cena = namestaj.cena;

            }
            else if (dekoracija != null)
            {
                ime = dekoracija.ime;
                tbImeProizvoda.text = ime;
                cena = dekoracija.cena;
            }
            else if (rasveta != null)
            {
                ime = rasveta.ime;
                tbImeProizvoda.text = ime;
                cena = rasveta.cena;
            }
            else
            {
                ime = tehnika.ime;
                tbImeProizvoda.text = ime;
                cena = tehnika.cena;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            count = Int32.Parse(numericUpDown1.Value.ToString());
            tbRacun.Text = (narudzbenica.Racun = count * cena).ToString();


        }

        private void btnKorpa_Click(object sender, EventArgs e)
        {
            if (tbImePrezime.text.Equals("") || tbAdresaDostave.Equals("") || numericUpDown1.Value.ToString().Equals("0"))
            {
                MessageBox.Show("Molimo Vas, obavezno unesite ime,adresu dostave i zeljenu kolicinu");
                return;
            }

            narudzbenica.ImeKupca = tbImePrezime.text;
            narudzbenica.Racun += Double.Parse(tbRacun.Text);
            narudzbenica.AdresaDostave = tbAdresaDostave.text;
            narudzbenica.Porudzbina.Add(tbImeProizvoda.text, cena);
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            int novo = 0;

            if (namestaj != null  && ((namestaj.stanjeNaLageru - count) < 0))
            {

                MessageBox.Show("Nazalost, trenutno na stanju nemamo zeljenu kolicinu");
                return;

            }
            else if (namestaj != null && ((namestaj.stanjeNaLageru - count) >= 0))
            {
                novo = namestaj.stanjeNaLageru - count;

                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n { ime:'" + ime + "'}) SET n.stanjeNaLageru = " + novo + " RETURN n",
                                                               queryDict, CypherResultMode.Set);
                ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query);

                query = new Neo4jClient.Cypher.CypherQuery("CREATE (o:Narudzbenica {ImeKupca:'" + tbImePrezime.text + "', PrezimeKupca:'" + tbPrezime.text + "', Racun:" + narudzbenica.Racun + ",AdresaDostave: '" + narudzbenica.AdresaDostave + "', Porudzbina: '" + ime + ", " + cena + "'})",
                                                               queryDict, CypherResultMode.Projection);
                ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Object>(query);

            }

            if (tehnika != null && ((tehnika.stanjeNaLageru - count) < 0))
            {
                MessageBox.Show("Nazalost, trenutno na stanju nemamo zeljenu kolicinu");
                return;
            }
            else if (tehnika!=null && ((tehnika.stanjeNaLageru - count) >= 0))
            {
               
                novo = tehnika.stanjeNaLageru - count;
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n { ime:'" + ime + "'}) SET n.stanjeNaLageru = " + novo + " RETURN n",
                                                       queryDict, CypherResultMode.Set);
                ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query);

            }
            if (rasveta != null && ((rasveta.stanjeNaLageru - count) < 0))
            {
                MessageBox.Show("Nazalost, trenutno na stanju nemamo zeljenu kolicinu");
                return;
            }
            else if (rasveta!=null && ((rasveta.stanjeNaLageru - count) >= 0))
            {
               

                novo = rasveta.stanjeNaLageru - count;
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n { ime:'" + ime + "'}) SET n.stanjeNaLageru = " + novo + " RETURN n",
                                                       queryDict, CypherResultMode.Set);
                ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query);


            }
            if (dekoracija!= null && (dekoracija.stanjeNaLageru - count) >= 0)
            {
                novo = dekoracija.stanjeNaLageru - count;
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n { ime:'" + ime + "'}) SET n.stanjeNaLageru = " + novo + " RETURN n",
                                                           queryDict, CypherResultMode.Set);
                ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query);
            }
            else if (dekoracija!=null && (dekoracija.stanjeNaLageru - count) < 0)
            {
                MessageBox.Show("Nazalost, trenutno na stanju nemamo zeljenu kolicinu");
                return;

            }

            this.Close();
        }
    }
}
