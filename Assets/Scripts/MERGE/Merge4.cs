using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge4 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball5;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("4")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<Merge4>().isMerging = true;
        Destroy(gameObject);

        Destroy(other.gameObject);
        Instantiate(Ball5, transform.position, Quaternion.identity);
    }
}