using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlPlayerBattle : MonoBehaviour
{
    
    PlayerControls controls; 
    Vector2 move;
    public float speed;

    void Awake()
    {

        controls = new PlayerControls();

        controls.Gameplay.PlayerAction.performed += ctx => PlayerAction();
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
        void PlayerAction()
        {
            Debug.Log("PressedAction");
        }

    }

void Update()
        {
            Vector2 m = new Vector2(move.x, move.y) * speed * Time.deltaTime ;
            transform.Translate(m, Space.World);
            
        }

void OnEnable()
        {
            controls.Gameplay.Enable();
        }

void OnDisable()
        {
            controls.Gameplay.Disable();
        }

}
