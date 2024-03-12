using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge2 : MonoBehaviour
{
    public Vector2 Position;
    public AudioSource Merge;
    
    public GameObject BigBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("3"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(BigBall, Position, Quaternion.identity);
            Merge.Play();
        }
    }
}
