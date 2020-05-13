using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace EncapsulationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Fido", 51, 11);

            Stream stream = File.Open("AnimalData.dat", FileMode.Create);

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

            XmlSerializer s = new XmlSerializer(typeof(Animal));

            using (TextWriter tw = new StreamWriter("dog.xml"))
            {
                s.Serialize(tw, dog);
            }

            dog = null;

            XmlSerializer ds = new XmlSerializer(typeof(Animal));
            TextReader tr = new StreamReader("dog.xml");

            object obj = ds.Deserialize(tr);
            dog = (Animal)obj;

            tr.Close();

            Console.WriteLine(dog.ToString());



            Console.ReadLine();
        }
    }
}
