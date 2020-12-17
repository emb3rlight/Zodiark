using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove 
{

//I dont understand the below code. I get that it gets the variables of MoveBase
// wtf is that function and PP?? WTF is that
  public MoveBase Base {get; set; }
  public int PP {get; set; }

  public CharMove(MoveBase cBase)
  {
      Base = cBase;
      //PP = cBase.PP;
  }

}
