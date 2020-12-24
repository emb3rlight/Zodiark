using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove 
{

//I dont understand the below code. I get that it gets the variables of MoveBase
// wtf is that function and PP?? WTF is that
  public MoveBase Base {get; set; }

  public int MOVECOST {get; set; }

 // public int Attackpower {get; set; }

  public CharMove(MoveBase cBase)
  {
      Base = cBase;
      MOVECOST = cBase.MoveCost; 
      
  }

}
