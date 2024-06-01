using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletforplayers : MonoBehaviour
{
    public Transform firePoint;  // ����� ������� ����
    public GameObject bulletPrefab;  // ������ ����

    private bool canShoot = true;  // ����, ����������� ��������

    private void Update()
    {
        // ��������, ��� ������ ���

            // ���� ������
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // ��������
                Shoot();
            }

    }

    public void Shoot()
    {
        // ��������, ��������� �� ��������
        if (canShoot)
        {
            // �������� ����
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            // ��������� ��������� �������� ����
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 1000);

            // ���������� ����������� �������� �� ��������� �����
            canShoot = false;
            Invoke("ResetShoot", 0.3f);
        }
    }

    public void ResetShoot()
    {
        canShoot = true;
    }

}
