using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
 
    [SerializeField] BattleUnit playerUnit1; 
    [SerializeField] BattleHud playerHud; 
    [SerializeField] BattleUnit enemyUnit1; 
    [SerializeField] BattleUnit enemyUnit2; 

private void Start ()
{
    SetupBattle();
}

private void SetupBattle ()
{
    playerUnit1.Setup();
    enemyUnit1.Setup();
    enemyUnit2.Setup();
    
    playerHud.SetData(playerUnit1.Char);
    playerHud.SetData(enemyUnit1.Char);
    playerHud.SetData(enemyUnit2.Char);

    Debug.Log($"str = {playerUnit1.Char.Strength}");
    Debug.Log($"magic = {playerUnit1.Char.Magic}");

}

}
