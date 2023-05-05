using UnityEngine;
using UnityEngine.UI;


namespace Philia
{
    public class SimplePlayerController : MonoBehaviour
    {
        [Header("Components")]
        public LayerMask groundLayer;
        public LayerMask jumpableGround;
        public Button JumpButton;
        public Rigidbody2D rb;
        public DynamicJoystick Joystick;
        public CapsuleCollider2D coll;

        [Header("GroundParameters")]
        public bool onGround = true;
        public float groundline = 2;
        public int direction = 1;

        [Header("Movement")]
        public float nextJumpTime = 0f;
        public float JumpRate = 2f;
        public float movePower = 10f;
        public float jumpPower = 15f;
        public bool alive = false;

        private Animator anim;
        Vector3 movement;

        
        


        void Start()
        {
          coll = GetComponent<CapsuleCollider2D>();
          rb = GetComponent<Rigidbody2D>();
          anim = GetComponent<Animator>();
        }
        


        void FixedUpdate()
        {
            onGround = Physics2D.Raycast(transform.position, Vector2.down, distance: groundline, groundLayer);
            Restart();
            if (alive)
            {
                Run();
            }
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
           anim.SetBool("jump", false);
        }        

            public void Run()
            {
                Vector3 moveVelocity = Vector2.zero;
                anim.SetBool("isRun", false);


                if (Joystick.Horizontal < 0)
                {
                    direction = -1;
                    moveVelocity = Vector2.left;
                    
                    transform.localScale = new Vector3(direction, 1, 1);
                    if (!anim.GetBool("jump"))
                        anim.SetBool("isRun", true);
                         
                }
                if (Joystick.Horizontal > 0)
                {
                    direction = 1;
                    moveVelocity = Vector2.right;
                    
                    transform.localScale = new Vector3(direction, 1, 1);
                    if (!anim.GetBool("jump"))
                        anim.SetBool("isRun", true);
                        
                }
                transform.position += moveVelocity * movePower * Time.deltaTime;
            }
            public void SheJump()
            {

            if (JumpButton == true && onGround == true && !anim.GetBool("jump") )
            {
                anim.SetBool("jump", true);
                nextJumpTime = Time.time + 1f / JumpRate;
                onGround = false;
            }


            if(onGround==true)
               {
                anim.SetBool("jump", false);
                return;}
                rb.velocity = new Vector3(direction,movePower,0);

                Vector2 jumpVelocity = new Vector2(1, jumpPower);
                rb.AddForce(jumpVelocity, ForceMode2D.Impulse);

                Debug.Log("Jump");
                onGround = true;
            }
           
            public void Hurt()
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    anim.SetTrigger("hurt");
                    if (direction == 1)
                        rb.AddForce(new Vector2(-5f, 1f), ForceMode2D.Impulse);
                    else
                        rb.AddForce(new Vector2(5f, 1f), ForceMode2D.Impulse);
                }
            }
            public void Die()
            {
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    anim.SetTrigger("die");
                    alive = false;
                }
            }
            public void Restart()
            {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                anim.SetTrigger("idle");
                alive = true;
            }
            }
    }
         
}