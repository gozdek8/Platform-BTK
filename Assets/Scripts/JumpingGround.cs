using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpingGround : MonoBehaviour
{
    public GameObject player;
    public Vector3 jumpVector;
    
    public void MakeMeJump() //adds jumping vector to make the trampoline jumping effect
    {
        player.gameObject.transform.position += jumpVector;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        MakeMeJump();
    }

}
