using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climb_ladder : MonoBehaviour
{
    public bool ladder = false;
    public CharacterController2D controller;
    public GameObject player;
    public Animator animator;
    float vertMov = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {vertMov = Input.GetAxisRaw("Vertical");
        if (ladder)
        {
            //Debug.Log("escalera");
            if (vertMov!=0)
            {
                controller.climb(vertMov*.35f);animator.SetBool("climb", true);
            }
            else
            {
                animator.SetBool("climb", false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ladder = true;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ladder = false;
    }
}
