using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour
{
    public Animator animator;
    public float speed = 5.0f;
    private bool facingRight = true; //� ����� ������� ������� ������ ����
    

    private void Update()
    {
        
        //��������� �����
        float horizontal = Input.GetAxisRaw("Horizontal");

        float Move = horizontal * speed;
        animator.SetFloat("Speed", Mathf.Abs(Move));


        //�������� �������
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);

        // ������������ ����������� ������� � ����������� �� ����������� ��������
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
        // ���������� ����������� ������� �� ��� X
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}