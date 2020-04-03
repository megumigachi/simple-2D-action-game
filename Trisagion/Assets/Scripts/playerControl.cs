using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody2D Rb2D;
    public Collider2D coll;
    public Animator anim;
    public float speed;
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask ground;


    public bool isGround;
    bool jumpPressed;
    public int jumpCount = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //使动作更加平滑
    void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.1f, ground);

        playerMove();
        playerJump();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPressed = true;
        }
    }

    //角色移动
    void playerMove()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        Rb2D.velocity = new Vector2(horizontalMove * speed, Rb2D.velocity.y);
        anim.SetFloat("running", Mathf.Abs(horizontalMove));
        if (horizontalMove != 0)
        {
            transform.localScale = new Vector3(horizontalMove, 1, 1);
        }
    }

    //角色跳跃
    void playerJump()
    {
        if(isGround)
        {
            jumpCount = 2;
            isGround =true;
        }
        if(jumpPressed && isGround)
        {
            isGround = false;
            Rb2D.velocity = new Vector2(Rb2D.velocity.x, jumpForce);
            jumpCount--;
            jumpPressed = false;
        }
        else if(jumpPressed && jumpCount>0 && !isGround)
        {
            Rb2D.velocity = new Vector2(Rb2D.velocity.x, jumpForce);
            jumpCount--;
            jumpPressed = false;
        }
    }
}
