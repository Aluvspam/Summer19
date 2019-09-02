using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class InternalCombustionEngine
    {
        public string Manufacturer;
        public int NumberOfCylinders;
        public double CylinderCapacity;
        public enum CylinderDisplacement
        {
            InlineCylinders,
            VConfiguration
        }


        public InternalCombustionEngine(string manufacturer, int numberOfCylinders, double cylinderCapacity)
        {
            manufacturer = Manufacturer;
            numberOfCylinders = NumberOfCylinders;
            cylinderCapacity = CylinderCapacity;
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
