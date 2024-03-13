using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge2 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball3;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("2")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<Merge2>().isMerging = true;
        Destroy(gameObject);

        Destroy(other.gameObject);
        Instantiate(Ball3, transform.position, Quaternion.identity);
    }
}