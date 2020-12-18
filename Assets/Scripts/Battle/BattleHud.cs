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

    public void SetData1(Char Char)
    {


        Player1NameText.text = Char.Base.Name;
        levelText.text = "Level " + Char.Level;
        
    }

public void SetData2(Char Char)
    {

        //test 123
        Enemy1NameText.text = Char.Base.Name;
        
    }


public void SetData3(Char Char)
    {

        //test 123
        Enemy2NameText.text = Char.Base.Name;
        ATKText.text = "ATK " + Char.Strength;

    }

}
