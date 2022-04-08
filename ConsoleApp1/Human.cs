using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Human
    {
        private int counter = 0;

        readonly int id;


        internal string name;
        internal string surname;

        public Human()
        {
            counter++;
            this.id = counter;
        }

        public override string ToString()
        {
            return $"#: {id}\n"; 
            $"name: {name}\n"; 
            $"surname: {surname}\n";
        }
    }
}
