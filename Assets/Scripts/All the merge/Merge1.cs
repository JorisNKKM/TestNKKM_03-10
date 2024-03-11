using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge1 : MonoBehaviour
{
    public Vector2 Position;

    public GameObject MediumBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("2"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(MediumBall, Position, Quaternion.identity);
        }
    }
}
