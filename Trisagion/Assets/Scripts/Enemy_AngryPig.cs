using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AngryPig : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public Transform leftpoint, rightpoint;

    private float leftx, rightx;

    public float speed, runningSpeed, interval;

    private bool faceleft = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        leftx = leftpoint.position.x;
        rightx = rightpoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (faceleft)
        {
            rigidbody.velocity = new Vector2(-speed * Time.deltaTime, rigidbody.velocity.y);
            if (transform.position.x < leftx)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                faceleft = false;
            }
        }
        else
        {
            rigidbody.velocity = new Vector2(speed * Time.deltaTime, rigidbody.velocity.y);
            if (transform.position.x > rightx)
            {
                transform.localScale = new Vector3(1, 1, 1);
                faceleft = true;
            }
        }
    }
}
