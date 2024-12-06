using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;

    private float horizontal;
    public float speed = 4;
    public float jumpForce = 7;
    private bool isGravityInverted = false;

    public Vector2 direction = Vector2.right;

    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ToggleGravity();
        }
    }

    //Flyttar spelaren konstant
    public void Move(float horizontalInput)
    {
        /*
        transform.Translate(direction * speed * Time.deltaTime);
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        */
    }

    //Växlar mellan normal och inverterad gravitation
    public void ToggleGravity()
    {
        if (isGravityInverted)
        {
            rb.gravityScale = 1;
            isGravityInverted = false;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else
        {
            rb.gravityScale = -1;
            isGravityInverted = true;
            transform.rotation = Quaternion.Euler(new Vector3(180, 0, 0));
        }
    }


    public bool IsGrounded()
    {
        Vector2 castDirection;

        //Inverterar raycasten om gravitationen är inverterad
        if (isGravityInverted == true)
        {
            castDirection = Vector2.up;
        }
        else
        {
            castDirection = Vector2.down;
        }

        //Raycast för att titta om spelaren är på marken
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, boxSize, 0, castDirection, castDistance, groundLayer);
        return hit.collider != null;
    }

    //Gör så att manh kan hoppa om man står på marken eller i taket
    private void Jump()
    {
        if (isGravityInverted)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * -1);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void FixedUpdate()
    {
        Move(horizontal);
    }

    public interface IMovement
    {
        void Move(float horizontalInput);
    }

    public interface IGravity
    {
        void ToggleGravity();
    }

    public interface IGroundCheck
    {
        bool IsGrounded();
    }

    /*
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position - transform.up * castDistance, boxSize);
    }
    */
}
