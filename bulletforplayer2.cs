using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletforplayer2 : MonoBehaviour
{
    public Transform firePoint;  // Точка выпуска пули
    public GameObject bulletPrefab;  // префаб пули
    private bool canShoot = true;  // флаг, разрешающий стрельбу

    private void Update()
    {
   
            if (Input.GetKeyDown(KeyCode.P))
            {
                Shoot();
                
            }

    }

    public void Shoot()
    {
        // Проверка, разрешена ли стрельба
        if (canShoot)
        {
            // Создание пули
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


            

            // отключение возможности стрельбы на некоторое время
            canShoot = false;
            Invoke("ResetShoot", 0.7f);
        }
    }

    public void ResetShoot()
    {
        canShoot = true;
    }

}
