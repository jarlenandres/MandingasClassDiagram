using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Core
{
    internal class Product
    {
        private int _idProduct;
        private string _name;
        private decimal _price;
        private string _description;

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        
        private string GetAdd()
        {
            throw new NotImplementedException();
        }
        private string GetUpdate()
        {
            throw new NotImplementedException();
        }
        private string GetDelete()
        {
            throw new NotImplementedException();
        }
    }
}
