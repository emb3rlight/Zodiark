using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Battle}

public class GameController : MonoBehaviour
{

    [SerializeField] ControlPlayer playerController;
    [SerializeField] BattleSystem battleSystem;
    [SerializeField] Camera worldCamera;
    GameState state; 

 public static GameController instance;
private void Awake()
{
    worldCamera.gameObject.SetActive(true);
   
}

private void Start()
{
    
    playerController.OnEncountered += StartBattle; 
    battleSystem.OnBattleOver += EndBattle;
    
}
void StartBattle()
{
    state = GameState.Battle; 
    battleSystem.gameObject.SetActive(true);
    worldCamera.gameObject.SetActive(false);
    battleSystem.StartBattle();

}

void EndBattle(bool won)
    {
        state = GameState.FreeRoam;
        battleSystem.gameObject.SetActive(false);
        worldCamera.gameObject.SetActive(true);
    }

   private void Update() 
   {    
       if (state == GameState.FreeRoam)
       {
           playerController.HandleUpdate();
       }
       if (state == GameState.Battle)
       {
           battleSystem.HandleUpdate();
       }
   }
}
