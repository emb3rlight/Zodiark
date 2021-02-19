using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using System;

//Battle State ENGINE START
public enum BattleState {Start, PlayerAction, PlayerMove, EnemyMove, Busy}
//Battle State ENGINE END




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
    [SerializeField] NotificationBox NotificationBox;
    public event Action<bool> OnBattleOver; 
    BattleState state;
    int currentAction; 
    int currentMove;
public void StartBattle()
{
    
    StartCoroutine(SetupBattle());
}

private IEnumerator SetupBattle ()
{
    //BattleUnit.Setup for each field Unit
    playerUnit1.Setup();
    playerUnit2.Setup();
    playerUnit3.Setup();
    playerUnit4.Setup();
    enemyUnit1.Setup();
    enemyUnit2.Setup();
    enemyUnit3.Setup();

// Sets Dynamic object data inside hud for each object
    playerHud.SetDataPlayer1(playerUnit1.Char);
    playerHud.SetDataPlayer2(playerUnit2.Char);
    playerHud.SetDataPlayer3(playerUnit3.Char);
    playerHud.SetDataPlayer4(playerUnit4.Char);
    playerHud.SetDataEnemy1(enemyUnit1.Char);
    playerHud.SetDataEnemy2(enemyUnit2.Char);
    playerHud.SetDataEnemy3(enemyUnit3.Char);

    playerHud.SetMoveNames(playerUnit1.Char.Moves);

//controls encounter-notifcation text
    yield return (NotificationBox.TypeDialog($"A Wild {enemyUnit1.Char.Base.Name}, {enemyUnit2.Char.Base.Name} and {enemyUnit3.Char.Base.Name} appeared"));
    yield return new WaitForSeconds(1f);

    //moves Engine to state PlyaerAction
    PlayerAction();

}

    //moves Engine to state PlyaerAction
    void PlayerAction()
    {
        //disables notficatin box
        playerHud.EnableNotificationText(false);

        //moves state to PlayerAction and turns on SelectMenu
        state = BattleState.PlayerAction;
        playerHud.EnableActionSelector(true);
    }

    void PlayerMove()
    {
        state = BattleState.PlayerMove;
        playerHud.EnableActionSelector(false);
        playerHud.EnableMoveSelector(true);
        

    }

IEnumerator PerformPlayerMove()
{

    state = BattleState.Busy; 

    var move = playerUnit1.Char.Moves[currentMove];
    playerHud.EnableNotificationText(true);
    yield return NotificationBox.TypeDialog($"{playerUnit1.Char.Base.Name} used {move.Base.CharMoveName}");    
    yield return new WaitForSeconds(1f);

    bool isFainted = enemyUnit1.Char.TakeDamage(move, playerUnit1.Char);
    playerHud.UpdateHP();

    if (isFainted)
    {
        yield return NotificationBox.TypeDialog($"{enemyUnit1.Char.Base.Name} is dead");
        yield return new WaitForSeconds(2f);
        OnBattleOver(true);
    }
    else
    {
        StartCoroutine(EnemyMove());
    }

}

    IEnumerator EnemyMove()
    {
        state = BattleState.EnemyMove;

        var move = enemyUnit1.Char.GetRandonMove();
        playerHud.EnableNotificationText(true);
        yield return NotificationBox.TypeDialog($"{enemyUnit1.Char.Base.Name} used {move.Base.CharMoveName}");    
        yield return new WaitForSeconds(1f);

        bool isFainted = playerUnit1.Char.TakeDamage(move, playerUnit1.Char);
        playerHud.UpdateHP();

        if (isFainted)
        {
        yield return NotificationBox.TypeDialog($"{playerUnit1.Char.Base.Name} is dead");
        yield return new WaitForSeconds(2f);
        OnBattleOver(false);


        } 
        else
        {
        PlayerAction();
        }
    }

public void HandleUpdate() 
    {
        if (state == BattleState.PlayerAction)
        {
        HandleActionSelection();
        }   
        else if (state == BattleState.PlayerMove)
        {
            HandleMoveSelection();
        }
    }
void HandleActionSelection()
    {
    Keyboard kb = InputSystem.GetDevice<Keyboard>();
    //move down in array of actions using S key
    if (kb.sKey.wasPressedThisFrame)
    {
        if (currentAction < 3 ) 
        ++currentAction;  
    }
    //move up in array of actions using S key
    else if (kb.wKey.wasPressedThisFrame)
    {
        
        if (currentAction > 0)
        --currentAction;
    }

    playerHud.UpdateActionSelection(currentAction);

    if (kb.jKey.wasPressedThisFrame)
    {
        if (currentAction == 0)
        {
            //fight selected

        }
        else if (currentAction ==1)
        {
            //magic selected
            
        }
        else if (currentAction ==2)
        {
            //skill selected
            PlayerMove();
        }
        else if (currentAction ==3)
        {
            //item selected
        }
    }
}
    void HandleMoveSelection()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
    //move down in array of actions using S key
    if (kb.dKey.wasPressedThisFrame)
    {
        if (currentMove < playerUnit1.Char.Moves.Count -1 ) 
        ++currentMove;  
    }
    //move up in array of actions using S key
    else if (kb.aKey.wasPressedThisFrame)
    {
        
        if (currentMove > 0)
        --currentMove;
    }
    else if (kb.sKey.wasPressedThisFrame)
    {
        
        if (currentMove < playerUnit1.Char.Moves.Count - 4)
            currentMove += 4;
    }
    else if (kb.wKey.wasPressedThisFrame)
    {
        
        if (currentMove > 1)
        currentMove -= 4;
    }
    playerHud.UpdateMoveSelection(currentMove, playerUnit1.Char.Moves[currentMove]);

    if (kb.jKey.wasPressedThisFrame)
    {
        playerHud.EnableMoveSelector(false);
        StartCoroutine(PerformPlayerMove());
        
    }

    }   
}
