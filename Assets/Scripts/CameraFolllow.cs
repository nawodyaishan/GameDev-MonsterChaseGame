using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolllow : MonoBehaviour
{

    private Transform player;

    private Vector3 tempPos;
    
        
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        // Assigning Player's x position to camera
        tempPos = transform.position;
        tempPos.x = player.position.x;

        transform.position = tempPos;
        
        

    }
}
