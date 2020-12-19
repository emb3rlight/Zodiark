using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit1; 
    [SerializeField] BattleUnit playerUnit2; 
    [SerializeField] BattleUnit playerUnit3; 
    [SerializeField] BattleUnit playerUnit4; 
    [SerializeField] BattleUnit enemyUnit1; 
    [SerializeField] BattleUnit enemyUnit2; 
    [SerializeField] BattleUnit enemyUnit3; 

    [SerializeField] BattleHud playerHud;


private void Start ()
{
    SetupBattle();
}

private void SetupBattle ()
{
    playerUnit1.Setup();
    playerUnit2.Setup();
    playerUnit3.Setup();
    playerUnit4.Setup();
    enemyUnit1.Setup();
    enemyUnit2.Setup();
    enemyUnit3.Setup();


    playerHud.SetDataPlayer1(playerUnit1.Char);
    playerHud.SetDataPlayer2(playerUnit2.Char);
    playerHud.SetDataPlayer3(playerUnit3.Char);
    playerHud.SetDataPlayer4(playerUnit4.Char);
    playerHud.SetDataEnemy1(enemyUnit1.Char);
    playerHud.SetDataEnemy2(enemyUnit2.Char);
    playerHud.SetDataEnemy3(enemyUnit3.Char);

    Debug.Log($"str = {playerUnit1.Char.Strength}");
    Debug.Log($"magic = {playerUnit1.Char.Magic}");

    Debug.Log($"str = {enemyUnit1.Char.Strength}");
    Debug.Log($"magic = {enemyUnit1.Char.Magic}");

    Debug.Log($"str = {enemyUnit2.Char.Strength}");
    Debug.Log($"magic = {enemyUnit2.Char.Magic}");

}

}
