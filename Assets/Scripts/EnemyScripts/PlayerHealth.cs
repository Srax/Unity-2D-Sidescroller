using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 1f;
    public int worth = 10;
    //public Image healthBar;
    private bool isDead = false;

    public void TakeDamage(float amount)
    {
        health -= amount;
        //healthBar.fillAmount = health / startHealth;
        if (health <= 0 && !isDead)
        {
            Die();
        }
    }


    void Die()
    {
        Debug.Log("Enemy died!");
        isDead = true;
        Destroy(gameObject);

    }
}
