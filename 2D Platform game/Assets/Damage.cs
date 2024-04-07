using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject gameOverScreen;
    public PlayerHealth phealth;
    public float damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            phealth.health -= damage;
            if(phealth.health == 0)
            {
                Die();
            }
        }

        
    }

    void Die()
    {
        Debug.Log("Player has died");
        player.SetActive(false);

        if(phealth.health == 0)
        {
            gameOverScreen.SetActive(true);
        }
    }
}
