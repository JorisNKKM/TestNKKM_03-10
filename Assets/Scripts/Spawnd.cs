using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnd : MonoBehaviour
{
    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;
    public GameObject Pointer;
    public Vector2 SpawnPosition=new Vector2(0,4);
    public float GetMouseX;

    /*void Start()
    {
        
        
    }

    
    public async void Update()
    {
        GetMouseX = Input.mousePosition.x-500;
        print(GetMouseX);
        Pointer.transform.position = new Vector2(GetMouseX, 4);
        SpawnPosition =new Vector2 (GetMouseX, 4);
        if (Input.GetKey(KeyCode.Space))
        {
            RadomSpawn();
        }
        //wait 2 secundes help with that
    }
    public void RadomSpawn()
    {
        int rnd=Random.Range(0, 100);
        if(rnd<=60)
        {
            Instantiate(Ball1, SpawnPosition, Quaternion.identity);
            
            if(Input.GetKey(KeyCode.Mouse0))
            {
                Ball1.transform.position=new Vector2(GetMouseX,3);
            }
        }
        if(rnd<=90)
        {
            Instantiate(Ball2, SpawnPosition, Quaternion.identity);
        }
        if(rnd>90)
        {
            Instantiate(Ball3, SpawnPosition, Quaternion.identity);
        }*/
}


