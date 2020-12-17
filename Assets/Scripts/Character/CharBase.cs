using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created Unity Menu item for creating object with these vars
[CreateAssetMenu(fileName = "Character", menuName = "Char/Create new char")]
public class CharBase : ScriptableObject
{
   [SerializeField] string charname; 

   [TextArea]
   [SerializeField] string description; 

   [SerializeField] Sprite rightsprite; 
   [SerializeField] Sprite leftsprite; 

public Sprite Rightsprite {
   get {return rightsprite; }
}

public Sprite Leftsprite {
   get {return leftsprite; }
}


   //base stats

[SerializeField] int maxHP;
[SerializeField] int maxMP;
[SerializeField] int attack;
[SerializeField] int strength;
[SerializeField] int defence;
[SerializeField] int agi;
[SerializeField] int magic;
[SerializeField] int magicdefence;
[SerializeField] int speed;
[SerializeField] int luck; 
[SerializeField] int evasion; 
[SerializeField] int accuracy; 
[SerializeField] ElementType element1; 
[SerializeField] ElementType element2; 

//Char learnable moves
[SerializeField] List<CharLearnableMoves> learnableMoves;

//properties to expose to other classes instead of using function
public string Name {
   get {return charname; }
}

public string Description {
   get {return description; }
}
public int MaxHP {
   get {return maxHP; }
}
public int MaxMP {
   get {return maxMP; }
   }
public int Attack {
   get {return attack; }
}
public int Strength {
   get {return strength; }
}
public int Defence {
   get {return defence; }
}
public int Agility {
   get {return agi; }
}
public int Magic {
   get {return magic; }
}
public int MagicDefence {
   get {return magicdefence; }
}
public int Speed {
   get {return speed; }
}
public int Luck {
   get {return luck; }
}
public int Evasion {
   get {return evasion; }
}
public int Accuracy {
   get {return accuracy; }
}
public List<CharLearnableMoves> LearnableMoves{
   get { return learnableMoves;}
}

}

[System.Serializable]
public class CharLearnableMoves
{
   [SerializeField] MoveBase moveBase; 
   [SerializeField] int level;

   public int Level {
      get { return level;}
   }
      public MoveBase Base {
      get { return moveBase;}
   }

}
   public enum ElementType
   {
      None, 
      Fire, 
      Thunder,
      Wind,
      Water,
      Earth,
   }

