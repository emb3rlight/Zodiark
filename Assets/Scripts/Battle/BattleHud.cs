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



    public void SetData(Char playerUnit1,Char enemyUnit1, Char enemyUnit2)
    {

        
        Player1NameText.text = playerUnit1.Base.Name;
        Enemy1NameText.text = enemyUnit1.Base.Name;
        Enemy2NameText.text = enemyUnit2.Base.Name;
    }


}
