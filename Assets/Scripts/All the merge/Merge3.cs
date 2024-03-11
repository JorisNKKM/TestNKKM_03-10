using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge3 : MonoBehaviour
{
    public Vector2 Position;

    public GameObject ReallyBigBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("4"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(ReallyBigBall, Position, Quaternion.identity);
        }
    }
}
