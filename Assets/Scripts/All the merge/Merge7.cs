using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Merge7 : MonoBehaviour
{
    public Vector2 Position;
    public AudioSource Merge;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("8"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Win");
            Merge.Play();
            Text count2048 = FindObjectOfType<Text>();
            count2048.Add8();
        }
    }
}
