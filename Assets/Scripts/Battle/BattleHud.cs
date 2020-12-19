using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleHud : MonoBehaviour
{


    [SerializeField] Text Player1NameText; 
    [SerializeField] Text Player2NameText; 
    [SerializeField] Text Player3NameText; 
    [SerializeField] Text Player4NameText; 
    [SerializeField] Text Enemy1NameText; 
    [SerializeField] Text Enemy2NameText;
    [SerializeField] Text Enemy3NameText;  
    [SerializeField] Text levelText; 
    [SerializeField] Text ATKText;

    public void SetDataPlayer1(Char Char)
    {
        Player1NameText.text = Char.Base.Name;
        // levelText.text = "Level " + Char.Level;
    }
        public void SetDataPlayer2(Char Char)
    {
        Player2NameText.text = Char.Base.Name;
        // levelText.text = "Level " + Char.Level;
    }
        public void SetDataPlayer3(Char Char)
    {
        Player3NameText.text = Char.Base.Name;
        // levelText.text = "Level " + Char.Level;
    }
        public void SetDataPlayer4(Char Char)
    {
        Player4NameText.text = Char.Base.Name;
        // levelText.text = "Level " + Char.Level;
    }
public void SetDataEnemy1(Char Char)
    {
        Enemy1NameText.text = Char.Base.Name;
    }
public void SetDataEnemy2(Char Char)
    {
        Enemy2NameText.text = Char.Base.Name;
       // ATKText.text = "ATK " + Char.Strength;
    }

    public void SetDataEnemy3(Char Char)
    {
        Enemy3NameText.text = Char.Base.Name;
       // ATKText.text = "ATK " + Char.Strength;
    }
}
