using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;

namespace SalonNamestaja.Entiteti
{
    public class Neo4JManager
    {
        public static GraphClient client = null;
        private static readonly object padlock = new object();

        Neo4JManager()
        {

        }

        static void Connect()
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "naprednebaze");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

            }
        }
        public static GraphClient Instance
        {
            get
            {
                if (client == null)
                {
                    lock (padlock)
                    {
                        if (client == null)
                        {
                            Connect();
                        }
                    }
                }
                return client;
            }
        }
    }


}