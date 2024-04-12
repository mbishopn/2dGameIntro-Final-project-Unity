using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{

    [SerializeField] private LayerMask m_WhatIsGround;
    public GameObject bullet;
    Vector2 initPoint;

    // Start is called before the first frame update
    void Start()
    {
        initPoint = bullet.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (System.Math.Abs(initPoint.x-bullet.transform.position.x)>10|| Physics2D.OverlapCircle(transform.position, .005f, m_WhatIsGround) /*Physics2D.IsTouchingLayers(bullet.GetComponent<CircleCollider2D>(), m_WhatIsGround)*/) 
         
        {
            Destroy(bullet);
        }

        
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Destroy(bullet);
    //}
}
