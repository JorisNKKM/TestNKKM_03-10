using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMerge : MonoBehaviour
{
    public Vector2 Position;
    public AudioSource Merge;
    
    public GameObject MediumSmallBall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("1"))
        {
            Position=collision.transform.position;
            Destroy(collision.gameObject);
            Instantiate(MediumSmallBall, Position, Quaternion.identity);
            Merge.Play();
            Text count2048 = FindObjectOfType<Text>();
            count2048.Add1();
        }
    }
}
