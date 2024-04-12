using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;

//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    public Animator animator;
    public GameObject bullet;
    public Transform firePoint;
    public Transform centerPoint;
    public GameObject fist;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }

        if (Input.GetButtonDown("hit"))
        {
            fist.SetActive(true);
        }
        else fist.SetActive(false);

        horizontalMove =Input.GetAxisRaw("Horizontal")*runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;animator.SetBool("jump",jump);
        }

        if (Input.GetButtonDown("Crouch") && GameObject.FindGameObjectsWithTag("ladder").Where(x => x.GetComponent<climb_ladder>().ladder).Count()==0)
        {
            crouch = true;
            
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false; 

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
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        jump= false;animator.SetBool("jump", jump);



    }


    public void fire()
    {
        Vector2 direction;
        direction=firePoint.position-centerPoint.position;
        GameObject _bullet = Instantiate(bullet, firePoint.position,firePoint.rotation);
        _bullet.GetComponent<Rigidbody2D>().velocity = transform.right * direction * 50f;
        //Debug.Log("resta: " + (MousePosition - CannonPosition));
        //Debug.Log(Vector2.Distance(MousePosition, CannonPosition));
    }

}
