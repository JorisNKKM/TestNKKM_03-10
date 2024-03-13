using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge7 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball8;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("7")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<Merge7>().isMerging = true;
        Destroy(gameObject);

        Destroy(other.gameObject);
        Instantiate(Ball8, transform.position, Quaternion.identity);
    }
}
