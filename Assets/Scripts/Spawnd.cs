using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnd : MonoBehaviour
{
    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;
    public Vector2 SpawnPosition=new Vector2(0,4);
    public float GetMouseX;

    void Start()
    {
        RadomSpawn();
        InvokeRepeating(nameof(RadomSpawn), 0f,1f);
    }

    
    public void Update()
    {
        GetMouseX = Input.mousePosition.x;
    }
    public void RadomSpawn()
    {
        int rnd=Random.Range(0, 100);
        if(rnd<=60)
        {
            Instantiate(Ball1, SpawnPosition, Quaternion.identity);
            Ball1.GetComponent<Rigidbody2D>().isKinematic = false;
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Ball1.transform.position=new Vector2(GetMouseX,4);
                Ball1.GetComponent<Rigidbody2D>().isKinematic = true;
            }
        }
        if(rnd<=90)
        {
            Instantiate(Ball2, SpawnPosition, Quaternion.identity);
        }
        if(rnd>90)
        {
            Instantiate(Ball3, SpawnPosition, Quaternion.identity);
        }
    }
}
