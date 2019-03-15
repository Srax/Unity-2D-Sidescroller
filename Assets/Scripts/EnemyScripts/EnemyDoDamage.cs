using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoDamage : MonoBehaviour
{
    public float damage = 1f;
    public GameObject Player;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Damage(Player.transform);
        }
    }

    void Damage(Transform enemy)
    {
        EnemyHP e = enemy.GetComponent<EnemyHP>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }
}
