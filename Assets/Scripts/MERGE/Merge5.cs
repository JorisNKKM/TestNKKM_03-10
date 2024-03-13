using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge5 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball6;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("5")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<Merge5>().isMerging = true;
        Destroy(gameObject);

        Destroy(other.gameObject);
        Instantiate(Ball6, transform.position, Quaternion.identity);
    }
}