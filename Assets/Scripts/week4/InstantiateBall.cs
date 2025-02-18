using UnityEngine;

public class InstantiateBall : MonoBehaviour
{
    public GameObject ballPrefab;

    public GameObject ballSpawnPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = Instantiate(ballPrefab, ballSpawnPosition.transform.position, ballPrefab.transform.rotation);
        
        go.GetComponent<MeshRenderer>().material.color = Color.black;

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(ballPrefab, ballSpawnPosition.transform.position, ballPrefab.transform.rotation);

    }
}
