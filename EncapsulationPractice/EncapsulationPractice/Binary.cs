using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace EncapsulationPractice
{
    class Binary
    {
        public void writeBinary(Animal dog) { 
        Stream stream = File.Open("AnimalData.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

        BinaryFormatter bf = new BinaryFormatter();

        bf.Serialize(stream, dog);

        stream.Close();

        dog = null;

        stream = File.Open("AnimalData.dat", FileMode.Open);

        bf = new BinaryFormatter();

        dog = (Animal)bf.Deserialize(stream);

        stream.Close();

        Console.WriteLine(dog.ToString());

        dog.Weight = 40;

    }
}
