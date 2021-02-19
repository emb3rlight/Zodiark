using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char 
{
    public CharBase Base {get; set; }
    public int Level {get; set; }

    public int CurrentHP {get; set;}
    public int CurrentMP {get; set;}
    
    public List<CharMove> Moves {get; set;}
    public Char(CharBase charBase, int clevel)
    {
        Base = charBase;
        Level = clevel;
        CurrentHP = MaxHP;
        CurrentMP = MaxMP;

        Moves = new List<CharMove>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
                Moves.Add(new CharMove(move.Base));
            if (Moves.Count >= 99)
            break;
        }
    }
//forumlas for level up's using properties of CharBase
    public int Attack {
        get { return Mathf.FloorToInt((Base.Strength / 4 + Level / 4)); }
    }

    public int Strength {
        get { return Mathf.FloorToInt((Base.Strength * Level) / 100f) + 5; }
    }

    public int Defence {
        get { return Mathf.FloorToInt((Base.Defence * Level) / 100f) + 5; }
    }

    public int Magic {
        get { return Mathf.FloorToInt((Base.Magic * Level) / 100f) + 5; }
    }

    public int MagicDefence {
        get { return Mathf.FloorToInt((Base.MagicDefence * Level) / 100f) + 5; }
    }

    public int Speed {
        get { return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 5; }
    }

    public int Luck {
        get { return Mathf.FloorToInt((Base.Luck * Level) / 100f) + 5; }
    }

    public int Evasion {
        get { return Mathf.FloorToInt((Base.Evasion * Level) / 100f) + 5; }
    }

    public int Accuracy {
        get { return Mathf.FloorToInt((Base.Accuracy * Level) / 100f) + 5; }
    }
    public int Agility {
        get { return Mathf.FloorToInt((Base.Agility * Level) / 100f) + 5; }
    }
    public int MaxHP {
        get { return Mathf.FloorToInt((Base.MaxHP * Level) / 100f) + 20; }
    }

    public int MaxMP {
        get { return Mathf.FloorToInt((Base.MaxMP * Level) / 100f) + 10; }
    }

    public bool TakeDamage(CharMove move, Char attacker)
    {
       float modifiers = Random.Range(0.85f, 1f); 
       float a = (2 * attacker.Level + 10) / 250f;
       float d = a * move.Base.Attackpower * ((float)attacker.Attack / Defence) + 2; 
       int damage = Mathf.FloorToInt(d * modifiers); 

       CurrentHP -= damage;
       if (CurrentHP <= 0)
       {
           CurrentHP = 0;
           return true;
       }

       return false; 

    }

    public CharMove GetRandonMove()
    {
        int r = Random.Range(0, Moves.Count);
        return Moves[r];
    }

}
