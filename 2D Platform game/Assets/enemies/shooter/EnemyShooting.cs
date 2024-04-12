using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform wizzard_hand;

    private float timer;
    public GameObject player;
    public float distance;


    // Update is called once per frame
    void Update()
    {
       

        float playerPosition = Vector2.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);

        if(playerPosition < distance)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }
    }

    void shoot()
    {
        Instantiate(bullet, wizzard_hand.position, Quaternion.identity);
    }
}
