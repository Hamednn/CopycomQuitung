using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOQuitung
{
    class Artikel
    {
        private string name;
        private string discription;
        private int amounts;
        private double price;

        public string get_name() {
            return this.name;
        }
        public void set_name(string name) {
            if (name.Length >= 3)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
            }
        }
        public string get_dicription() { 
            return this.discription;
        }
        public void set_discription(string input) {
            this.discription = input;
        }
        public int get_amounts()
        {
            return this.amounts;
        }
        public void set_amounts(int input)
        {
            if (input >= 0) {
                this.amounts = input;
            }
            this.amounts = 0;
        }
        
        public double get_price()
        {
            return this.price;
        }
        public void set_price(double input)
        {
            if (input>= 0)
            {
                this.price = input;
            }
            else
            {
                this.price = 0;
            }
        }
    }
}
