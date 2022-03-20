using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolllow : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPos;

    [SerializeField] private float minX, maxX;


    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindWithTag("Player").transform;
        // Debug.Log("The selected Index: " + GameManager.instance.CharIndex);
    } 

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;     
        // Assigning Player's x position to camera
        tempPos = transform.position;
        tempPos.x = player.position.x;

        if (tempPos.x < minX)
            tempPos.x = minX;

        if (tempPos.x > maxX)
            tempPos.x = maxX;

        transform.position = tempPos;
    }
}