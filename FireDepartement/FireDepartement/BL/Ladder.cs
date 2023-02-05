using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartement.BL
{
    internal class Ladder
    {
        private int length;
        private string color;

        public Ladder(int length, string color)
        {
            this.length = length;
            this.color = color;
        }

        public int getLength()
        {
            return length;
        }
        public string getColor()
        {
            return color;
        }

        public void setLength(int length)
        {
            this.length = length;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
    }
}
