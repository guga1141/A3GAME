using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpFuck : StateMachineBehaviour
{ [SerializeField]
    public Button JumpButton;
    public Rigidbody2D rb;
    private Animator anim;
    public LayerMask groundLayer;

    [Header("Collision")]
    public bool onGround = true;
    public float groundline = 2;

    [Header("Movement")]
    public float movePower = 10f;
    public float jumpPower = 15f;
    public int direction = 1;

    Vector3 movement;

   



    

        public void SheJump()
    {

        if (JumpButton == true && onGround == false)
        {
            anim.SetBool("isJump", true);
            rb.velocity = Vector2.zero;
            Vector2 jumpVelocity = new Vector2(0, jumpPower);
            rb.AddForce(jumpVelocity, ForceMode2D.Impulse);
            Debug.Log("Jump");
            onGround = false;
        }

        else
        { anim.SetBool("isJump", false); }

    }
}
