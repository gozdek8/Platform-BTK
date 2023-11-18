using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    
    public float moveSpeed = 1f;
    public float jumpSpeed = 1f;
    public float jumpFreq = 1f;
    public float nextJumpTime;
    
    private bool facingRight = true;
    
    public bool isGrounded = false;
    public Transform groundCheckPos;
    public float groundCheckRad;
    public LayerMask groundCheckLay;
    
    Animator playerAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove();
        OnGroundCheck();
        
        if (playerRB.velocity.x < 0 && facingRight)
        {   // flipFace
            FlipFace();
        } else if (playerRB.velocity.x > 0 && !facingRight)
        {   // flipFace
            FlipFace();
        }


        if (Input.GetAxis("Vertical") > 0 && isGrounded && (nextJumpTime < Time.timeSinceLevelLoad) ) //If user presses w or up && if character is on ground && next jump time is less then time since game started
        {                                                    //L-> should be less so CANT jump more then once
            nextJumpTime = Time.timeSinceLevelLoad + jumpFreq; //overall for player to not jump twice per frame, which is to prevent player jumping higher sometimes --> wait for last jump to finish (0.1sec)
            Jump();
        }
        
    }

    void HorizontalMove()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
        playerAnimator.SetFloat("playerSpeed",Mathf.Abs(playerRB.velocity.x));
    }
    
    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }

    void Jump()
    {
        playerRB.AddForce(new Vector2(0f,jumpSpeed));
    }

    void OnGroundCheck()
    {   //does collider of child object of player touch the layer ground
        isGrounded = Physics2D.OverlapCircle(groundCheckPos.position,groundCheckRad,groundCheckLay);
        playerAnimator.SetBool("isGroundedAnim",isGrounded);
    }
    
}
