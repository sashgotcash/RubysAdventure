using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = GetComponent<rigidbody2D>();
    }

    voidUpdate()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject0);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyContyroller>();
        if (e != null)
        {
            e.Fix();
        }

        Destroy(gameObject);
    }
}