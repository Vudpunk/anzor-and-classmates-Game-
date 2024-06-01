using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public int Health;
    public UnityEvent Dead;
    private void Update() 
    {
        if (Health <= 0) 
        {
            Dead?.Invoke();
            Destroy(gameObject);
            
        }
    }
    public void TakeDamage(int damage) 
    {
        Health -= damage;
    }
}
