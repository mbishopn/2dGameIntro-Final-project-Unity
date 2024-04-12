using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private PlayerHealth phealth;
    public float damage;
    private GameObject gameOverScreen;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        phealth=player.GetComponent<PlayerHealth>();
        gameOverScreen = GameObject.FindGameObjectWithTag("gameover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider==player.GetComponent<Collider2D>())
        {
            //Debug.Log("damaging player");
            phealth.health -= damage;
            if (phealth.health <= 0)
            {
                gameOverScreen.SetActive(true);
            }
        }

        
    }

    //void Die()
    //{
    //    Debug.Log("Player has died");
    //    player.SetActive(false);

    //    if(phealth.health == 0)
    //    {
    //        gameOverScreen.SetActive(true);
    //    }
    //}
}
