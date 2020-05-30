using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using 

namespace EncapsulationPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> lsanimal = new List<Animal>
            {
                new Animal("Cat", 60, 30),
                new Animal("Mouse", 10, 11)
            };

            Animal dog = new Animal("Fido", 51, 11);

            lsanimal.Add(dog);

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

            //var dcx = new DataContractSerializer(typeof(List<Animal>));
                        

            //using (Stream fs = new FileStream("animals.xml", FileMode.Create))
            //{
            //    XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
            //    dcx.WriteObject(fs, lsanimal);
            //    //serializer2.Serialize(fs, lsanimal);
            //}

            //lsanimal = null;

            //foreach(var i in lsanimal)
            //{
            //    switch(i.Name)
            //    {
            //        case i.Name when (i.Name == "Fido"):
            //            Console.WriteLine("Fido");
            //            break;
            //    }
            //}

            XmlSerializer s3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead("animals.xml"))
            {
                lsanimal = (List<Animal>)dcx.ReadObject(fs2);
                //lsanimal = (List<Animal>)s3.Deserialize(fs2);
            }

            foreach(Animal a in lsanimal)
            {
                Console.WriteLine(a.ToString());
            }


                Console.ReadLine();
        }
    }
}
