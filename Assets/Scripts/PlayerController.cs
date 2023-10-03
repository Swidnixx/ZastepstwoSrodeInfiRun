using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask groundMask;
    public float jumpHeight = 1;
    Rigidbody2D rb;
    BoxCollider2D col;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        bool click = Input.GetMouseButtonDown(0);
        bool grounded = Physics2D.Raycast(transform.position, Vector2.down, 1, groundMask);
        if(click && grounded)
        {
            //jump
            rb.velocity = new Vector2(0, jumpHeight);
        }

        //Testowanie Raycasta
        Color c = grounded ? Color.green : Color.red;
        Debug.DrawRay(transform.position, Vector2.down, c);
    }
}
