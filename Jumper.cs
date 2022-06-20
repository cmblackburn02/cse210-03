using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Jumper
    {
      // this class gives us the parachute, and determines what is lost when the user guesses wrong
     private List<string> jumperLines = new List<string>();

     public Jumper()
     {
        this.jumperLines.Add("  ___");
        this.jumperLines.Add(@" /___\");
        this.jumperLines.Add(@" \   /");
        this.jumperLines.Add(@"  \ /");
     }   
     public List<string> GetJumper()
     {
        return this.jumperLines;
     }
     public void LosePoint()
     {
        jumperLines.RemoveAt(0);
     }
     public bool StillExists()
     {
        if (jumperLines.Count > 0)
            return true;
        else
            return false;
     }
    }
}
