using System;
using System.Collections.Generic;
using System.Text;

namespace Threading_test
{
    public class BlueCar
    {
        string _name;

        public string Name { get { return _name; } }

        public BlueCar(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
