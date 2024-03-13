using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge3 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball4;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("3")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<Merge3>().isMerging = true;
        Destroy(gameObject);

        Destroy(other.gameObject);
        Instantiate(Ball4, transform.position, Quaternion.identity);
    }
}