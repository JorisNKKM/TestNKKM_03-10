using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Pointer;
    public GameObject SmallBallPrefab;
    public GameObject MediumSmallBallPrefab;
    public GameObject MediumBallPrefab;

    public Vector2 PointerPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PointerPosition = Pointer.transform.position;
            SpawnRandomBall();
        }
    }

    public void SpawnRandomBall()
    {
        float rndFloat = Random.Range(0f, 100f);
        Vector2 spawnPosition = new Vector3(PointerPosition.x, PointerPosition.y);

        if (rndFloat <= 60f)
        {
            Instantiate(SmallBallPrefab, spawnPosition, Quaternion.identity);
        }
        else if (rndFloat <= 85f)
        {
            Instantiate(MediumSmallBallPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(MediumBallPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
