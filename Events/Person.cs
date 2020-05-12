using System;

namespace Events
{
  public class Person
  {
    private string _name;

    private Clock _tower;

    public Person(string name, Clock tower)
    {
      _name = name;
      _tower = tower;

      tower.Chime += (object sender, ClockTowerEvents args) => {
        Console.WriteLine("{0} heard noises", _name);
        switch(args.Time)
        {
          case 6: Console.WriteLine("{0} is waking up.", _name);
            break;
          case 17: Console.WriteLine("{0} is home", _name);
            break;
        }
      };
    }
  }
}