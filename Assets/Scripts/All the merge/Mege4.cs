using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mege4 : MonoBehaviour
{
    public Vector2 Position;

    public GameObject SupperBigBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("5"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(SupperBigBall, Position, Quaternion.identity);
        }
    }
}