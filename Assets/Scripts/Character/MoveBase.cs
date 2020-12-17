using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created Unity Menu item for creating object with these vars
[CreateAssetMenu(fileName = "CharacterMove", menuName = "CharMove/Create new charMove")]
public class MoveBase : ScriptableObject
{
    //CharMovevars
    [SerializeField] string Charmovename;
    
    [TextArea]
    [SerializeField] string description; 
    [SerializeField] ElementType element; 
    [SerializeField] int attackpower; 
    [SerializeField] int magicpower; 
    [SerializeField] int accuracy; 
    [SerializeField] int movespeed; 

//properties to expose to other classes instead of using function
public string CharMoveName {
   get {return Charmovename; }
}
public string Description {
   get {return description; }
}
public ElementType Element {
   get {return element; }
}
public int Attackpower {
   get {return attackpower; }
}
public int Magicpower {
   get {return magicpower; }
}
public int Accuracy {
   get {return accuracy; }
}
public int Movespeed {
   get {return movespeed; }

}

}