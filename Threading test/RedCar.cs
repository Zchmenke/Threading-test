using System;
using System.Collections.Generic;
using System.Text;

namespace Threading_test
{
    public class RedCar
    {
        string _name;

        public string Name { get { return _name; } }

        public RedCar(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
