using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Merge7 : MonoBehaviour
{
    public Vector2 Position;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("8"))
        {
            Position = collision.transform.position;
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Win");
        }
    }
}
