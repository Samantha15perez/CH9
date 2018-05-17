using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9_2
{
    class Cellphone
    {
        //fields
        private string _brand; //the phone's brand
        private string _model; //the phone's model
        private decimal _price; //retail price

        //constructor
        public Cellphone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }
        //brand property
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //price property 
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
