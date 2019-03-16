using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 1.0f;
    public float moveLeftUnits, moveRightUnits = 1;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= startPos.x + moveRightUnits)
        {
            Flip();
            dirRight = false;
        }

        if (transform.position.x <= startPos.x - moveLeftUnits)
        {
            Flip();
            dirRight = true;
        }
    }

    void Flip()
    {
        dirRight = !dirRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
