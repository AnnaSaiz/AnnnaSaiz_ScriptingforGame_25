using UnityEngine;
using System.Collections.Generic;

public class SpawnIn : MonoBehaviour
{
public GameObject West;

public int minWests = 20;
public int maxWests = 40;

public Vector3 minEdge;
public Vector3 maxEdge;

public float moveSpeed = 1f;

private List<MovingWest> movingWests = new List<MovingWest>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int westCount = Random.Range(minWests, maxWests);
        for (int i = 0; i < westCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(minEdge.x, maxEdge.x),
                Random.Range(minEdge.y, maxEdge.y),
                Random.Range(minEdge.z, maxEdge.z)
            );

            GameObject westInstance = Instantiate(West, randomPosition, Quaternion.identity);

            Vector3 randomDirection = new Vector3(
                Random.Range(-1f, 1f),
                Random.Range(-1f, 1f),
                Random.Range(-1f, 1f)
            ).normalized;

            movingWests.Add(new MovingWest(westInstance, randomDirection));
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var movingWest in movingWests)
        {
            movingWest.Move(moveSpeed);
        }
    }

    public class MovingWest
    {
        public GameObject objectToMove;
        public Vector3 direction;

        public MovingWest(GameObject targetObject, Vector3 dir)
        {
            objectToMove = targetObject;
            direction = dir;
        }
        public void Move(float speed)
        {
            objectToMove.transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
