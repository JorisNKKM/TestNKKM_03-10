using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject Pointer;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Pointer.transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if(Pointer.transform.position.x>=8.6f)
        {
            Pointer.transform.position = new Vector2(8.5f, 3.5f);
        }
        if(Pointer.transform.position.x <= -8.6f)
        {
            Pointer.transform.position = new Vector2(-8.5f, 3.5f);
        }
    }
}
