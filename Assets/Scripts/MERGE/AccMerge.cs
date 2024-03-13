using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccMerge : MonoBehaviour
{
    public bool isMerging;
    public GameObject Ball2;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("1")) return;
        if (isMerging) return;

        other.gameObject.GetComponent<AccMerge>().isMerging = true;
        Destroy(gameObject);
            
            Destroy(other.gameObject);
        Instantiate(Ball2, transform.position, Quaternion.identity);
    }
}
