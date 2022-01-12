using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemLoader : MonoBehaviour
{
    

public GameObject battleMan;
public GameObject gameMan;
public GameObject audioMan;
public GameObject UIScreen;


void Start () 
    {	
        if(BattleSystem.instance == null)
        {
            BattleSystem.instance = Instantiate(battleMan).GetComponent<BattleSystem>();
        }
        if (GameManager.instance == null)
        {
            GameManager.instance = Instantiate(gameMan).GetComponent<GameManager>();
        }

        if(AudioManager.instance == null)
        {
            AudioManager.instance = Instantiate(audioMan).GetComponent<AudioManager>();
        }

}

}