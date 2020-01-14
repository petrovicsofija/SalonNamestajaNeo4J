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
    public partial class SobaForm : Form
    {
        string prostorija;
        Narudzbenica narudzbenica;
        List<Namestaj> listaNamestaja;
        List<Rasveta> listaRasvete;
        List<Dekoracija> listaDekoracije;
        List<Tehnika> listaTehnike;

        public SobaForm(Narudzbenica n, String prostorija)
        {

            Neo4JManager.client = Neo4JManager.Instance;
            this.prostorija = prostorija;
            narudzbenica = n;
            listaDekoracije = new List<Dekoracija>();
            listaNamestaja = new List<Namestaj>();
            listaTehnike = new List<Tehnika>();
            listaRasvete = new List<Rasveta>();
            InitializeComponent();

            InitializeForm(prostorija);
        }

        public void InitializeForm(String prostorija)
        {
            bunifuCustomLabel1.Text = prostorija;
            bunifuCustomLabel6.Text = "Prikazite proizvode iz kategorije klikom na sliku";
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (soba: Soba {tipProstorije: '" + prostorija + "'}) <-[:JE_DEO]-(rasvete: Rasveta) RETURN rasvete",
                                                        queryDict, CypherResultMode.Set);
            listaRasvete = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList();


            query = new Neo4jClient.Cypher.CypherQuery("MATCH (soba: Soba {tipProstorije: '" + prostorija + "'}) <-[:JE_DEO]-(namestaj: Namestaj) RETURN namestaj",
                                                    queryDict, CypherResultMode.Set);
            listaNamestaja = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList();

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (soba: Soba {tipProstorije: '" + prostorija + "'}) <-[:JE_DEO]-(dekoracija: Dekoracija) RETURN dekoracija",
                                             queryDict, CypherResultMode.Set);
            listaDekoracije = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList();

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (soba: Soba {tipProstorije: '" + prostorija + "'}) <-[:JE_DEO]-(tehnika: Tehnika) RETURN tehnika",
                                  queryDict, CypherResultMode.Set);
            listaTehnike = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList();

        }

        private void pbNamestaj_Click(object sender, EventArgs e)
        {
            InitializeForm(prostorija);

            lbProizvodi.Items.Clear();
            foreach (Namestaj n in listaNamestaja)
            {
                lbProizvodi.Items.Add(n.ime);
            }
        }

        private void pbRasveta_Click(object sender, EventArgs e)
        {
            InitializeForm(prostorija);

            lbProizvodi.Items.Clear();
            foreach (Rasveta n in listaRasvete)
            {
                lbProizvodi.Items.Add(n.ime);
            }
        }

        private void lbProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ime = lbProizvodi.Items[lbProizvodi.SelectedIndex].ToString();

            ProizvodForm proizvodForma = new ProizvodForm(ime, narudzbenica);
            proizvodForma.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pretraga = tbSearch.text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Rasveta)-[:JE_DEO {uloga:['" + pretraga + "']}]->(soba: Soba {tipProstorije: '"+prostorija+"'}) return proizvod",
                                                             queryDict, CypherResultMode.Set);
            listaRasvete = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList();

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Tehnika)-[:JE_DEO {uloga:['" + pretraga + "']}]->(soba: Soba {tipProstorije: '" + prostorija + "'}) return proizvod",
                                                              queryDict, CypherResultMode.Set);
            listaTehnike = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList();

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Dekoracija)-[:JE_DEO {uloga:['" + pretraga + "']}]->(soba: Soba {tipProstorije: '" + prostorija + "'}) return proizvod",
                                                        queryDict, CypherResultMode.Set);
            listaDekoracije = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList();

            query = new Neo4jClient.Cypher.CypherQuery("MATCH (proizvod: Namestaj)-[:JE_DEO {uloga:['" + pretraga + "']}]->(soba: Soba {tipProstorije: '" + prostorija + "'}) return proizvod",
                                                  queryDict, CypherResultMode.Set);
            listaNamestaja = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList();


            lbProizvodi.Items.Clear();


            foreach (Dekoracija n in listaDekoracije)
            {
                if (!lbProizvodi.Items.Contains(n.ime))
                    lbProizvodi.Items.Add(n.ime);
            }
            foreach (Namestaj n in listaNamestaja)
            {
                if (!lbProizvodi.Items.Contains(n.ime))
                    lbProizvodi.Items.Add(n.ime);
            }
            foreach (Tehnika n in listaTehnike)
            {
                if (!lbProizvodi.Items.Contains(n.ime))
                    lbProizvodi.Items.Add(n.ime);
            }
            foreach (Rasveta n in listaRasvete)
            {
                if (!lbProizvodi.Items.Contains(n.ime))
                    lbProizvodi.Items.Add(n.ime);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitializeForm(prostorija);
            lbProizvodi.Items.Clear();
            foreach (Tehnika n in listaTehnike)
            {
                lbProizvodi.Items.Add(n.ime);
            }
        }

        private void pbDekoracija_Click_1(object sender, EventArgs e)
        {
            InitializeForm(prostorija);

            lbProizvodi.Items.Clear();
            foreach (Dekoracija n in listaDekoracije)
            {
                lbProizvodi.Items.Add(n.ime);
            }
        }

   
    }
}
