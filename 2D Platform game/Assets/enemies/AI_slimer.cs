using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.UI;
//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;


public class AI_slimer : MonoBehaviour
{
    public Object mySlimer;
    public CharacterController2D controller;
    public float runSpeed = 1f;
    bool jump = false;
    public Animator animator;
    private float timer = 0f;
    public float jump_freq = 5f;
    public float distance = 0f;
    private float init_point;
    [SerializeField] private LayerMask m_hits;
    [SerializeField] private LayerMask m_bullets;
    private int hits_received = 0;
    private int bullets_received = 0;

    void Start()
    {
        init_point = transform.position.x;
    }


    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, .05f, m_hits))
        {
            hits_received++;/*Debug.Log("got a hit");*/
            if (hits_received > 15) { Destroy(mySlimer); }
        }
        if (Physics2D.OverlapCircle(transform.position, .5f, m_bullets))
        {
            bullets_received++; /*Debug.Log("got a bullet");*/
            if (bullets_received > 5) { Destroy(mySlimer); }
        }

    }
    public void Landing()
    {
        animator.SetBool("jump", false);
    }
    public void crouching(bool crouch)
    {
        animator.SetBool("crouch", crouch);
    }

    private void FixedUpdate()
    {



        if (timer < jump_freq)
        { timer += Time.deltaTime; jump = false; animator.SetBool("jump", jump); }
        else
        {
            if ((init_point + distance < transform.position.x && runSpeed>0)|| (init_point - distance > transform.position.x && runSpeed<0))
            {
                
                runSpeed = runSpeed * (-1);
            }
            jump = true; animator.SetBool("jump", jump);
            controller.Move(runSpeed * 2, false, jump);
            timer = 0;

        }

        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //    if (collision.otherCollider.IsTouchingLayers(m_hits))
    //    {
    //        // use this only for killable enemies
    //        hits_received++;
    //        if(hits_received>=5)
    //        Destroy(mySlimer);
    //    }

    //}
}
