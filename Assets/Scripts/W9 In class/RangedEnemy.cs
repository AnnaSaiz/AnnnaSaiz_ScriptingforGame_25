using UnityEngine;

public class RangedEnemy : Enemy
{
    public GameObject projectilePrefab;

    public Transform projectileSpawnPosition;
    public float projectileForce = 500f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    

    protected override void Attack()
    {
        GameObject go = Instantiate(projectilePrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * projectileForce);
    }

    protected override void Update()
    {
        this.transform.LookAt(player.transform.position);
        base.Update();
    }
}
