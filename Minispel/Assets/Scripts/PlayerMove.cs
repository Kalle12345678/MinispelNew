using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector2 boxSize;
    public float castDistacnce;

    private float horizontal;
    public float speed = 8f;
    public float jumpForce = 16;
    public bool isGravityInverted = false;
    public Vector2 direction = Vector2.right;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.E) && isGravityInverted == false)
        {
            rb.gravityScale = -1;
            isGravityInverted = true;
            transform.rotation = Quaternion.AxisAngle(new Vector3(1, 0, 0), 3.14f);
        }
        else if (Input.GetKeyDown(KeyCode.E) && isGravityInverted == true)
        {
            rb.gravityScale = 1;
            isGravityInverted = false;
            transform.rotation = Quaternion.AxisAngle(new Vector3(1, 0, 0), 0f);
        }

    }
    void FixedUpdate()
    {
        // transform.Translate(direction * speed * Time.deltaTime);
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    //Skapar en osynlig cirkel under spelaren som skickar tillbaka en bool när den nuddar ground lagret
    /* private bool IsGrounded()
     {
         return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
     }
    */

    public bool IsGrounded()
    {
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistacnce, groundLayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position - transform.up * castDistacnce, boxSize);
    }
}
