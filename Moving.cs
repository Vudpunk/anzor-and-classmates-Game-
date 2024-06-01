using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour
{
    public Animator animator;
    public float speed = 5.0f;
    private bool facingRight = true; //в какую сторону смотрит спрайт флаг
    

    private void Update()
    {
        
        //получение ввода
        float horizontal = Input.GetAxisRaw("Horizontal");

        float Move = horizontal * speed;
        animator.SetFloat("Speed", Mathf.Abs(Move));


        //движение спрайта
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);

        // Переключение направления спрайта в зависимости от направления движения
        if (horizontal != 0)
        {
            if (horizontal > 0 && !facingRight)
            {
                FlipSprite();
                facingRight = true;
            }
            else if (horizontal < 0 && facingRight)
            {
                FlipSprite();
                facingRight = false;
            }
        }
    }

    private void FlipSprite()
    {
        // Зеркальное отображение спрайта по оси X
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}