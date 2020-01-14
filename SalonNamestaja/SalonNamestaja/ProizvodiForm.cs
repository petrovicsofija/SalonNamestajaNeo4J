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
    public partial class ProizvodiForm : Form
    {
        String imeProizvoda;
        String proizvod;
        List<Namestaj> namestaj;
        List<Dekoracija> dekoracija;
        List<Tehnika> tehnika;
        List<Rasveta> rasveta;
        PictureBox[] pbName;
        Button[] butns;
        Label[] labels;
        Narudzbenica narudzbenica;
        public ProizvodiForm(String ime,Narudzbenica n)
        {
            InitializeComponent();
            Neo4JManager.client = Neo4JManager.Instance;
            proizvod = ime;
            narudzbenica = n;
            Init();
        }
        private void Init()
        {
            int count = 0;
            if (proizvod.Equals("Dekoracija"))
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new CypherQuery("MATCH (m: Dekoracija) RETURN m",
                                                              queryDict, CypherResultMode.Set);
                dekoracija = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Dekoracija>(query).ToList();
                count = dekoracija.Count();

            }
            else if (proizvod.Equals("Tehnika"))
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new CypherQuery("MATCH (m: Tehnika) RETURN m",
                                                              queryDict, CypherResultMode.Set);
                tehnika = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Tehnika>(query).ToList();
                count = tehnika.Count();
            }
            else if (proizvod.Equals("Namestaj"))
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new CypherQuery("MATCH (m: Namestaj) RETURN m",
                                                              queryDict, CypherResultMode.Set);
                namestaj = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Namestaj>(query).ToList();
                count = namestaj.Count();
            }
            else if (proizvod.Equals("Rasveta"))
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query = new CypherQuery("MATCH (m: Rasveta) RETURN m",
                                                              queryDict, CypherResultMode.Set);
                rasveta = ((IRawGraphClient)Neo4JManager.client).ExecuteGetCypherResults<Rasveta>(query).ToList();
                count = rasveta.Count();
            }

            pbName = new PictureBox[count];
            butns = new Button[count];
            labels = new Label[count];

            for (int i = 0; i < count; i++)
            {
                pbName[i] = new PictureBox();
                pbName[i].Size = new Size(this.Size.Width / 8, this.Size.Width / 8);
                pbName[i].Image = Properties.Resources.card;
                pbName[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pbName[i].Anchor = AnchorStyles.Left;
                pbName[i].Visible = true;

                int x = 0;
                int y = 15;
                if (i >5)
                {
                    y += 220;
                }
                x = (int)((this.Size.Width / 5) * Math.IEEERemainder(i, 5)+280);
                pbName[i].Location = new Point(x+70, y);
                this.Controls.Add(pbName[i]);

                labels[i] = new Label();
                labels[i].MaximumSize = new Size(125, 0);
                labels[i].AutoSize = true;
                labels[i].BackColor = Color.Transparent;               

                if (proizvod.Equals("Namestaj"))
                {
                    imeProizvoda = namestaj[i].ime;
                    labels[i].Text = imeProizvoda + " " + namestaj[i].opis + " dimenzije: " + namestaj[i].dimenzija +" cena: "+ namestaj[i].cena + "EUR";
                }
                else if (proizvod.Equals("Dekoracija"))
                {
                    imeProizvoda = dekoracija[i].ime;
                    labels[i].Text = imeProizvoda + " " + dekoracija[i].tipDekoracije + " cena: " + dekoracija[i].cena + "EUR";
                }
                else if (proizvod.Equals("Tehnika"))
                {
                  
                    imeProizvoda = tehnika[i].ime;
                    if(tehnika[i].EnergetskiRazred==null)
                        labels[i].Text = imeProizvoda + " " + tehnika[i].opis + " cena: " + tehnika[i].cena + "EUR";
                    else
                        labels[i].Text = imeProizvoda + " " + tehnika[i].opis + " Energetski razred:" + tehnika[i].EnergetskiRazred + " cena:" + tehnika[i].cena + "EUR";
                }
                else if (proizvod.Equals("Rasveta"))
                {
                    imeProizvoda = rasveta[i].ime;
                    if (rasveta[i].EnergetskiRazred == null)
                        labels[i].Text = imeProizvoda + " " + rasveta[i].opis + " cena: " + rasveta[i].cena + "EUR";
                    else
                        labels[i].Text = imeProizvoda + " " + rasveta[i].opis + " Energetski razred: " + rasveta[i].EnergetskiRazred + " cena: " + rasveta[i].cena + "EUR";
                }
                labels[i].Location = new Point(x+70, y + 100);
               
                this.Controls.Add(labels[i]);

                butns[i] = new Button();
                butns[i].Click += new EventHandler(butns_Click);
                butns[i].Text = "Kupi";
                butns[i].Name = imeProizvoda;
                butns[i].Location = new Point(x+70, y + 195);
                butns[i].Tag = i;
                this.Controls.Add(butns[i]);

            }

            int width = this.Size.Width;
            int height = this.Size.Height;
            this.MaximumSize = new Size(width, height);
        }

        private void butns_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = Int32.Parse(b.Tag.ToString());

            ProizvodForm proizvodForm = new ProizvodForm(butns[i].Name, narudzbenica);
            proizvodForm.Show();
        }

    }
}
