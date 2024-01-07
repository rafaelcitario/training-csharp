using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovimentTowards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        MovimentationEnemyTowards();
    }


    public void MovimentationEnemyTowards()
    {
        GameObject playerLocation = GameObject.FindGameObjectWithTag("Player");
        EntityStats speedTowards = GetComponent<EntityStats>();
        gameObject.transform.position = Vector3.MoveTowards(transform.position, playerLocation.transform.position, speedTowards.basicSpeedMoviment * Time.deltaTime);
    }
}
