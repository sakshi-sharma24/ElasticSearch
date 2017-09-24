using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchSolution
{
    public class Hotel
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public Hotel(int id, string name, string country)
        {
            this.ID = id;
            this.Name = name;
            this.Country = country;
        }

    }
}


