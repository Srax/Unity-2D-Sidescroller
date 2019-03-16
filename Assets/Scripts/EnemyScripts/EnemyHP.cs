using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public GameObject GameMaster;
    public GameObject enemy_ghost;
    public GameObject enemy_corpse;

    public Vector3 enemy_corpse_offset;

    public float health = 1f;
    public int worth = 10;
    private bool isDead = false;


    private void Start()
    {
    }

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

        GameMaster.GetComponent<GameControllerScript>().AddScore(worth);

        GameObject theGhost = (GameObject)Instantiate(enemy_ghost, transform.position, transform.rotation); //Spawn a bullet shatter effect
        GameObject theToombstone = (GameObject)Instantiate(enemy_corpse, transform.position + enemy_corpse_offset, transform.rotation); //Spawn a bullet shatter effect

        Destroy(theGhost, 2f);
        Destroy(gameObject);
        
    }
}
