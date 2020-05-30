using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace EncapsulationPractice
{
    class json
    {

        public void writeJson(List<Animal> ls)
        {
            var dj = new DataContractJsonSerializer(typeof(Animal));

            using (Stream stream = File.Open("AnimalData.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                dj.WriteObject(stream, ls);
            }
        }
    }
}
