using Builder.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Cars
{
    internal class ElectroCar : ICar
    {
        private List<ICarPart> _carParts = new List<ICarPart>();
        public ElectroCar(List<ICarPart> parts)
        {
            _carParts = parts;
        }
        public string Name => "Electro Car";
        public string Description
        {
            get
            {
                string result = "Included parts: ";
                foreach (ICarPart part in _carParts)
                { result += part.Name + ";"; }
                return result;
            }
        }
    }
}
