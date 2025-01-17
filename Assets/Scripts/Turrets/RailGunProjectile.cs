using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailGunProjectile : MonoBehaviour
{    
    [SerializeField] private GameObject hitEffect;
    public Rigidbody2D rb;
    private AudioSource audioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * RailGunTurret.Speed;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        audioSource.volume = PlayerPrefs.GetFloat("soundVolume");
    }
    
    void Update()
    {
        var distance = Vector2.Distance(transform.position, RailGunTurret.ownShip.transform.position);
        if (distance > 150)
            Destroy(gameObject);
        var scale = rb.transform.localScale;
        rb.transform.localScale = new Vector3(scale.x, scale.y * 1.004f, scale.z);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        var enemy = hitInfo.GetComponent<IEnemy>();
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), hitInfo);
        Instantiate(hitEffect, transform.position, Quaternion.identity);
        if (enemy != null)
            enemy.TakeDamage(RailGunTurret.Damage);
    }
}
