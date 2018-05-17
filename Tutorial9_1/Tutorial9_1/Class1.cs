using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9_1
{
    class Coin
    {
        //field to represent the side facing up;
        private string sideUp;
        Random rand = new Random();

        //constructor
        public Coin()
        {
            sideUp = "Heads";
        }
        //the toss method simulates tossing the coin
        public void Toss()
        {
            //create random object
            //Random rand = new Random();

            //Use a random number to determine the side of the coin is facing up
            //0 = heads, 1 = tails
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }
        //the getsideup method returns the value of the sideup field
        public string GetSideUp()
        {
            return sideUp;
        }


    }
}
