using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlPlayer : MonoBehaviour
{
    
    PlayerControls controls; 
    Vector2 move;
    public float speed;

    public LayerMask EncounterLayer;

    public event Action OnEncountered; 
    [SerializeField] Camera worldCamera;

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

private void Update() {
    
    if (worldCamera.gameObject.activeSelf == true)
    {
       CheckForEncounters(); 
    }
    
}
public void HandleUpdate()
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

        private void CheckForEncounters()
        {
            if (Physics2D.OverlapCircle(transform.position, 0.2f, EncounterLayer) != null)
            {
                if (UnityEngine.Random.Range(1, 10001) <= 10)
                {
                    OnEncountered();
                    Debug.Log("OnEncountered");
                }
            }
        }

}
