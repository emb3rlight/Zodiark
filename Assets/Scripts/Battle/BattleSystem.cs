using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit1; 
    [SerializeField] BattleHud playerHud; 
    [SerializeField] BattleUnit enemyUnit1; 
    [SerializeField] BattleUnit enemyUnit2; 

    [SerializeField] BattleHud playerHud123456789;

private void Start ()
{
    SetupBattle();
}

private void SetupBattle ()
{
    playerUnit1.Setup();
    enemyUnit1.Setup();
    enemyUnit2.Setup();

    playerHud.SetData1(playerUnit1.Char);
    playerHud.SetData2(enemyUnit1.Char);
    playerHud.SetData3(enemyUnit2.Char);


    Debug.Log($"str = {playerUnit1.Char.Strength}");
    Debug.Log($"magic = {playerUnit1.Char.Magic}");

    Debug.Log($"str = {enemyUnit1.Char.Strength}");
    Debug.Log($"magic = {enemyUnit1.Char.Magic}");

    Debug.Log($"str = {enemyUnit2.Char.Strength}");
    Debug.Log($"magic = {enemyUnit2.Char.Magic}");

}

}
