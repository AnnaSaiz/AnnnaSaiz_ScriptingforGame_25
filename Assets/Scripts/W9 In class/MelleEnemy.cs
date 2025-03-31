using UnityEngine;

public class MelleEnemy : Enemy
{
    public float attackSpeed;

    private float attackTimer;
    private GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
      if(Vector3.Distance(this.transform.position, Player.transform.position) ,< attackRange) 
        {
            Attack();
        }
           
       
    }
}
