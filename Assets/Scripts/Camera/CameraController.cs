using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
       
            player = GameObject.Find("Player");
            transform.position = player.transform.position + offset;
        
        
    }
}