using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge6 : MonoBehaviour
{
    public Vector2 Position;
    public AudioSource Merge;
    
    public GameObject InsaneBigBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("7"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(InsaneBigBall, Position, Quaternion.identity);
            Merge.Play();
        }
    }
}
