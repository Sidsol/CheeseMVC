using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Delete { get; set; }

        public Cheese()
        {
            Delete = false;
        }

        public Cheese(string name, string description)
        {
            Name = name;
            Description = description;
            Delete = false;
        }
    }
}

