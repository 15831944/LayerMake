using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerMake
{
    // Layer class to store values to be used for new AutoCAD layers
    class Layer
    {
        private string name, line, red, green, blue;

        public Layer()
        {
            name = "TEMP";
            line = "Continuous";
            red = "255";
            green = "255";
            blue = "255";
        }

        public Layer(string n)
        {
            name = n;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public void SetLine(string l)
        {
            line = l;
        }

        public void SetColor(string r, string g, string b)
        {
            red = r;
            green = g;
            blue = b;
        }

        public string GetName()
        {
            return name;
        }

        public string GetLine()
        {
            return line;
        }

        public string GetRed()
        {
            return red;
        }

        public string GetGreen()
        {
            return green;
        }

        public string GetBlue()
        {
            return blue;
        }
    }
}
