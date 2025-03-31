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

  
}
