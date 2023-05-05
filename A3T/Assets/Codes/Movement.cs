using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public FixedJoystick Joystick;


    [Header("Components")]
    public Rigidbody2D Rb;
    public LayerMask groundLayer;

    [Header("Collision")]
    public bool onGround = false;
    public float groundline = 2;

    // Start is called before the first frame update
    void Start() => Rb = GetComponent<Rigidbody2D>();

    // Update is called once per frame
    void Update()
    {

        //Ground Check

        //onGround = Physics2D.Raycast(transform.position, Vector2.down, distance: groundline, groundLayer);



        if (Joystick.Horizontal > 0f)

        {
            Debug.Log("D key pressed");
            Rb.AddForce(Vector2.right, ForceMode2D.Impulse);
        }

        else if (Joystick.Horizontal < 0f)

        {
            Debug.Log("A key pressed");
            Rb.AddForce(Vector2.left, ForceMode2D.Impulse);
        }

       // else if (Joystick.Vertical < 9 );

        //{
          //  Debug.Log("Space key pressed");
            //Rb.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
        //}

       
    }







}
