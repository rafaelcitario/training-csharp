using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EntityStats : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float basicSpeedMoviment;
    public float collisionDamage;
    public float atackSpeed;
    public float playerCoolDownStats;
    public float speedDash;


    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        destroyObjectDeath();
    }


    public void destroyObjectDeath()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<EntityStats>().health -= collisionDamage;
    }


}
