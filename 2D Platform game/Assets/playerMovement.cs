using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame
    void Update()
    {
        horizontalMove=Input.GetAxisRaw("Horizontal")*runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;animator.SetBool("jump",jump);
        }

        if (Input.GetButtonDown("Crouch"))
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
}
