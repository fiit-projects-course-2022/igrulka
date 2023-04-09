using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Component
{
    public readonly int Damage;
    public readonly float Speed;
    public readonly Rigidbody2D Ship;
    public Enemy(int damage, float speed, Rigidbody2D ship)
    {
        Damage = damage;
        Speed = speed;
        Ship = ship;
    }
    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
