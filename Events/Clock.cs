using System;
namespace Events
{
  public delegate void ChimeEventHandler(object sender, ClockTowerEvents args);
  public class ClockTowerEvents : EventArgs
  {
    public int Time{ get; set; }
  }
  public class Clock
  {
    public event ChimeEventHandler Chime;
    public void ChimeEnd()
    {
      Chime(this, new ClockTowerEvents { Time = 17 });
    }

    public void ChimeStart()
    {
      Chime(this, new ClockTowerEvents { Time = 6 });
    }
  }
}