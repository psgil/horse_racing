using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horse_racing
{
    public class Better
    {
        Random rd = new Random();
        //genreate the number 
        public int genNumber() {
            return rd.Next(1, 50);
        }
    }
}
