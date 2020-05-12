using System;
using System.Reflection;
using System.Linq;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new Clock();
            var guy = new Person("Guy", tower);

            tower.ChimeStart();
            tower.ChimeEnd();

            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();

            foreach(var i in types)
            {

                Console.WriteLine("Type: " + i.Name);
                
                var x = i.GetProperties();
                foreach(var n in x)
                {
                    Console.WriteLine("Property: " + n.Name + " " + n.PropertyType);
                    
                }

                var y = i.GetFields();
                foreach(var u in y)
                {
                    Console.WriteLine("Field: " + u.Name);
                }

                var m = i.GetMethods();
                foreach(var h in m.Where(v => v.IsPublic == false))
                {
                    Console.WriteLine("Methods: " + h.Name);
                }
            }
            


        }
    }
}
