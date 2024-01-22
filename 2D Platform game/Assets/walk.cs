using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float speed;
    public float dirX;
    public SpriteRenderer birdRender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(dirX * speed,0,0);
        transform.Translate(Vector3.right * dirX * speed);
        birdRender.flipX = dirX < 0?true:dirX==0?birdRender.flipX:false;
    }
}
