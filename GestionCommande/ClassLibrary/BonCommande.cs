using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BonCommande
    {
        public int idCommande { get; set; }
        public DateTime dateCommande { get; set; }
        public decimal totalCommande { get; set; }
        public int _idClient { get; set; }
    }
}
