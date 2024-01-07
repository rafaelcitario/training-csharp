using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{

    public GameObject projectile;
    bool playerCanAtack = true;
    float playerCoolDown;
    EntityStats playerEntityStats;



    // Start is called before the first frame update
    void Start()
    {
        playerEntityStats = this.GetComponent<EntityStats>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAtackCoolDown();
    }

    void FixedUpdate()
    {
        GetInstanciateProjectile();
    }

    public void GetInstanciateProjectile()
    {
        if (Input.GetMouseButton(0) && playerCanAtack)
        {
            GameObject projectileInstanciate = GameObject.Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 projectileDirectionDispair = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            projectileDirectionDispair.Normalize();
            float projectileVelocityDispair = playerEntityStats.atackSpeed;
            projectileInstanciate.GetComponent<Rigidbody2D>().AddForce(projectileDirectionDispair * projectileVelocityDispair, ForceMode2D.Impulse);



            playerCanAtack = false;
            playerCoolDown = 0;

        }
    }


    public void PlayerAtackCoolDown()
    {
        if (playerCoolDown > playerEntityStats.playerCoolDownStats && playerCanAtack == false)
        {
            playerCanAtack = true;
            return;
        }

        playerCoolDown += Time.deltaTime;
    }

}
