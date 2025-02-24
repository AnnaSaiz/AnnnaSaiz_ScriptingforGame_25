using UnityEngine;
using System.Linq;
using System.Collections.Generic;
public class Cannon : MonoBehaviour
{
    public GameObject westPrefab;
    public Transform westSpawnPostition;
    public float forcePower = 1000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();

        }

    }

    public void FireCannon()
    {
        GameObject go = Instantiate(westPrefab, westSpawnPostition.position, westSpawnPostition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower);
    }
}
