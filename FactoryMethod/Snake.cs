using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Snake : IAnimal
    {
        public string Render() => "Snake!";
    }
}
