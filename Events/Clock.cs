using System;
namespace Events
{
  public delegate void ChimeEventHandler(object sender, ClockTowerEvents args);
  public class ClockTowerEvents : EventArgs
  {
    public int Time{ get; set; }
  }

  [ClockTower]
  public class Clock
  {
    public event ChimeEventHandler Chime;
    [ClockTowerChime]
    public void ChimeEnd()
    {
      Chime(this, new ClockTowerEvents { Time = 17 });
    }
    [ClockTowerChime]
    public void ChimeStart()
    {
      Chime(this, new ClockTowerEvents { Time = 6 });
    }
  }
  [AttributeUsage(AttributeTargets.Class)]
  public class ClockTowerAttribute : Attribute {}
  [AttributeUsage(AttributeTargets.Method)]
  public class ClockTowerChimeAttribute : Attribute {}
}