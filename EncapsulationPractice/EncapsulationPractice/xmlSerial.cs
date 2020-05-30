using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace EncapsulationPractice
{
    class xmlSerial
    {
        public void writeXml(List<Animal> ls)
        {
            var dcx = new DataContractSerializer(typeof(Animal));

            using (FileStream fs = new FileStream("Animal.xml", FileMode.OpenOrCreate))
            {
                dcx.WriteObject(fs, ls);
            }
        }
    }
}
