using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpinningGround : MonoBehaviour
{
    public GameObject spinningGround;
    public EdgeCollider2D collSnow1;
    public EdgeCollider2D collSnow2;
    
    public float xAngle, yAngle, zAngele;
    // Start is called before the first frame update
    void Awake()
    {
        Transform transformSG = spinningGround.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      spinningGround.transform.Rotate(xAngle,yAngle,zAngele);  
    }

    void Rotate()
    {
        spinningGround.transform.Rotate(0.0f,0.0f,90.0f,Space.Self);
    }

    void SlideAndJump(GameObject other)  //on snow surface, move faster like sliding
    {
        float updatedMoveSpeed = other.GetComponent<PlayerController>().moveSpeed;
        updatedMoveSpeed = updatedMoveSpeed * 2f;
        other.GetComponent<PlayerController>().moveSpeed = updatedMoveSpeed;
        
        float updatedJumpSpeed = other.GetComponent<PlayerController>().jumpSpeed;
        float updatedJumpFreq = other.GetComponent<PlayerController>().jumpFreq;
        updatedJumpFreq = 10f;
        other.GetComponent<PlayerController>().jumpFreq = updatedJumpFreq;
        updatedJumpSpeed = updatedJumpSpeed * 2f;
        other.GetComponent<PlayerController>().jumpSpeed = updatedJumpSpeed;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        SlideAndJump(other.gameObject);
    }
}
