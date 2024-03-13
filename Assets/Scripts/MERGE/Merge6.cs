using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge6 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball7;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("6")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<Merge6>().isMerging = true;
        Destroy(gameObject);

        Destroy(other.gameObject);
        Instantiate(Ball7, transform.position, Quaternion.identity);
    }
}
