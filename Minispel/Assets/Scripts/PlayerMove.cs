using Unity.Burst.CompilerServices;
using UnityEngine;
public class PlayerMove : MonoBehaviour
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

    //Kollar om spelaren hoppar och från vilken yta
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded() && isGravityInverted == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        else if (Input.GetButtonDown("Jump") && IsGrounded() && isGravityInverted == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * -1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleGravity();
        }
    }
    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    //Växlar mellan normal och inverterad gravitation
    private void ToggleGravity()
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

    //Tittar om spelaren är på marken
    public bool IsGrounded()
    {
        Vector2 castDirection;
        if (isGravityInverted == true)
        {
             castDirection = Vector2.up;
        }
        else
        {
            castDirection = Vector2.down;
        }

        //Gör en BoxCast för att veta om spelaren är  på marken eller i taket
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, boxSize, 0, castDirection, castDistance, groundLayer);

        return hit.collider != null;
    }
}
