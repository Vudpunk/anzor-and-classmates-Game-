using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletforplayer2 : MonoBehaviour
{
    public Transform firePoint;  // ����� ������� ����
    public GameObject bulletPrefab;  // ������ ����
    private bool canShoot = true;  // ����, ����������� ��������

    private void Update()
    {
   
            if (Input.GetKeyDown(KeyCode.P))
            {
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


            

            // ���������� ����������� �������� �� ��������� �����
            canShoot = false;
            Invoke("ResetShoot", 0.7f);
        }
    }

    public void ResetShoot()
    {
        canShoot = true;
    }

}
