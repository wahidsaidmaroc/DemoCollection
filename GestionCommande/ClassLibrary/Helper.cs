using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Helper
    {

        public List<Client> getListClient()
        {
            List<Client> list = new List<Client>();

            Client c1 = new Client() { id = 1 , adresse = "Hay Itissal 1", nomCLient = "IAM"};
            Client c2 = new Client() { id = 2, adresse = "Rue Zarktouni", nomCLient = "OCP" };
            Client c3 = new Client() { id = 3, adresse = "Hay EL FATH", nomCLient = "INWI" };
            Client c4 = new Client() { id = 4, adresse = "Moulay Smail", nomCLient = "Orange" };


            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);

            return list;
        }

        public List<Produit>  getListProduit()
        {

            var list = new List<Produit>()
            {
                new Produit{id = 1, nomProduit = "PC Portable"},
                new Produit{id = 2, nomProduit = "Ordinateur"},
            };


            return list;
        }

        public IList<BonCommande> getListCommande()
        {

            IList<BonCommande> list = new List<BonCommande>();

            return list;
        }
    }
}
