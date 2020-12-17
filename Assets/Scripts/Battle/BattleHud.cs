using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleHud : MonoBehaviour
{
   
    [SerializeField] Text Player1NameText; 
    [SerializeField] Text Enemy1NameText; 
    [SerializeField] Text Enemy2NameText; 
    [SerializeField] Text levelText; 
    [SerializeField] Text ATKText;




    public void SetData(Char Char)
    {

        //test 123
        Player1NameText.text = Char.Base.Name;
        Enemy1NameText.text = Char.Base.Name;
        Enemy2NameText.text = Char.Base.Name;
        levelText.text = "Level " + Char.Level;
        ATKText.text = "ATK " + Char.Attack;
    }


}
