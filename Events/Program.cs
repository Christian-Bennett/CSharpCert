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

            var types = assembly.GetTypes().Where(x => x.GetCustomAttributes<ClockTowerAttribute>().Count() > 0);

            foreach(var i in types)
            {
                System.Console.WriteLine(i.Name);

                var methods = i.GetMethods().Where(x => x.GetCustomAttributes<ClockTowerChimeAttribute>().Count() > 0);

                foreach(var n in methods)
                {
                    System.Console.WriteLine(n.Name);
                }
                
            }
            

        }
    }
}


// Console.WriteLine("Type: " + i.Name);
                
//                 var x = i.GetProperties();
//                 foreach(var n in x)
//                 {
//                     Console.WriteLine("Property: " + n.Name + " " + n.PropertyType);
                    
//                 }

//                 var y = i.GetFields();
//                 foreach(var u in y)
//                 {
//                     Console.WriteLine("Field: " + u.Name);
//                 }

//                 var m = i.GetMethods();
//                 foreach(var h in m)
//                 {
//                     Console.WriteLine("Methods: " + h.Name);
//                 }

//                 var t = i.GetCustomAttributes();
//                 foreach(var r in t)
//                 {
//                     System.Console.WriteLine("Custom Attributes: " + r.TypeId);
//                 }