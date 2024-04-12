using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update


    public float health;
    public float maxHealth;
    public Image healthBar;
    public GameObject player;
    //public GameObject gameOverScreen;
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount =Mathf.Clamp(health / maxHealth, 0,1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            health -= 35;
        }
    }
}
