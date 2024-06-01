using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour
{
    public Animator animator;
    public float speed = 5.0f;
    private bool facingRight = true; //в какую сторону смотрит спрайт флаг
    public float jumpForce = 500.0f;
    Rigidbody2D rb;


    public void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
        //получение ввода
        float horizontal = Input.GetAxisRaw("Horizontal2");
        float vertical = Input.GetAxisRaw("Vertical2");

        float Move = horizontal * speed;
        animator.SetFloat("Speed", Mathf.Abs(Move));



        //движение спрайта
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);

        // Переключение направления спрайта в зависимости от направления движения
        if (horizontal != 0)
        {
            if (horizontal < 0 && !facingRight)
            {
                FlipSprite();
                facingRight = true;
            }
            else if (horizontal > 0 && facingRight)
            {
                FlipSprite();
                facingRight = false;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

    }

    private void FlipSprite()
    {
        // Зеркальное отображение спрайта по оси X
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}