using Builder.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Cars
{
    internal class RegularCar : ICar
    {
        private List<ICarPart> _carParts = new List<ICarPart>();
        public RegularCar(List<ICarPart> parts)
        {
            _carParts = parts;
        }
        public string Name => "Regular Car";
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
