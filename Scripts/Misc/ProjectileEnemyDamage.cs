using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemyDamage : MonoBehaviour
{
    float projectileDamage;
    // Start is called before the first frame update
    void Start()
    {
        projectileDamage = GameObject.FindWithTag("Player").GetComponent<EntityStats>().collisionDamage;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("Enemy") || other.tag.Equals("Boss"))
        {
            other.GetComponent<EntityStats>().health -= projectileDamage;
            Destroy(this.gameObject);
        }

        if (other.tag.Equals("Cenario"))
        {
            Destroy(this.gameObject);
        }
    }
}
