using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge5 : MonoBehaviour
{
    public Vector2 Position;

    public GameObject MasiveBigBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("6"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(MasiveBigBall, Position, Quaternion.identity);
        }
    }
}