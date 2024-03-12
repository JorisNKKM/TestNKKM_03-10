using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Pointer;
    public GameObject SmallBallPrefab;
    public GameObject MediumSmallBallPrefab;
    public GameObject MediumBallPrefab;

    public Vector2 PointerPosition;
    public float CurrentBall;
    public float NextBall;

    public GameObject FakeSmallBall;
    public GameObject FakeMediumSmallBall;
    public GameObject FakeMediumBall;

    public GameObject NextSmallBall;
    public GameObject NextMediumSmallBall;
    public GameObject NextMediumBall;


    private void Start()
    {
        FakeSmallBall.SetActive(false);
        FakeMediumSmallBall.SetActive(false);
        FakeMediumBall.SetActive(false);

        CurrentBall = Random.Range(0f, 100f);
        NextBall= Random.Range(0f, 100f);
        ShowBall();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PointerPosition = Pointer.transform.position;
            
            SpawnRandomBall();
            ShowBall();
        }
    }

    public void SpawnRandomBall()
    {

        
        Vector2 spawnPosition = new Vector3(PointerPosition.x, PointerPosition.y);
        

        if (CurrentBall <= 60f)
        {
            Instantiate(SmallBallPrefab, spawnPosition, Quaternion.identity);
        }
        else if (CurrentBall <= 85f)
        {
            Instantiate(MediumSmallBallPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(MediumBallPrefab, spawnPosition, Quaternion.identity);
        }
        CurrentBall = NextBall;
        NextBall = Random.Range(0f, 100f);
    }
    void ShowBall()
    {
        if (CurrentBall <= 60f)
        {
            FakeSmallBall.SetActive(true);
            FakeMediumSmallBall.SetActive(false);
            FakeMediumBall.SetActive(false);
        }
        else if (CurrentBall <= 85f)
        {
            FakeSmallBall.SetActive(false);
            FakeMediumSmallBall.SetActive(true);
            FakeMediumBall.SetActive(false);
        }
        else if (CurrentBall > 85f)
        {
            FakeSmallBall.SetActive(false);
            FakeMediumSmallBall.SetActive(false);
            FakeMediumBall.SetActive(true);

        }
        //next ball
        if (NextBall <= 60f)
        {
            NextSmallBall.SetActive(true);
            NextMediumSmallBall.SetActive(false);
            NextMediumBall.SetActive(false);
        }
        else if (NextBall <= 85f)
        {
            NextSmallBall.SetActive(false);
            NextMediumSmallBall.SetActive(true);
            NextMediumBall.SetActive(false);
        }
        else if(NextBall > 85f)
        {   
            NextSmallBall.SetActive(false);
            NextMediumSmallBall.SetActive(false);
            NextMediumBall.SetActive(true);
        }

    }
}
