using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{

    public Rigidbody2D birdBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdBody.velocity = Vector2.up * 5;
            //birdBody.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }

    }
}
