using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float runSpeed;
    public Animator animator;
    float horizontalMove;
    
    [SerializeField] private bool facingRight = true;

    public float jump;

    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(runSpeed * horizontalMove, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
      
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if(horizontalMove<0 && facingRight)
        {
            FlipWithRotation();
        }
        else if (horizontalMove > 0 && !facingRight)
        {
            FlipWithRotation();
        }


         void FlipWithRotation()
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }
    }

    public bool isGrounded()
    {
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistance, groundLayer))
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
        Gizmos.DrawWireCube(transform.position - transform.up * castDistance, boxSize);
    }


}
