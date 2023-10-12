using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizantal;
    private float speed = 4f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    

    void Update()
    {
        horizantal = Input.GetAxisRaw("Horizontal");
        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizantal * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizantal < 0f || !isFacingRight && horizantal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
