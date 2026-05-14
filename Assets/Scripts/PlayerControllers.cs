using UnityEngine;
using UnityEngine.UI;

public class PlayerControllers : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed;
    public bool MoveRight;
    public bool MoveLeft;
    public bool jump;
    public float JumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-MoveSpeed, rb.linearVelocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(MoveSpeed, rb.linearVelocity.y);

        }

        if (MoveRight)
        {
            rb.linearVelocity = new Vector2(MoveSpeed, rb.linearVelocity.y);
        }
        if (MoveLeft)
        {
            rb.linearVelocity = new Vector2(-MoveSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpHeight);
        }

        if (jump)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpHeight);
            jump = false;
        }

    }

}