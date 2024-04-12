using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class teleport : MonoBehaviour
{
    private bool port;
    public GameObject remotePos;
    public CharacterController2D controller;
    public GameObject player;
    private Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        position = remotePos.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (port)
        {
            controller.teleport((position));
            port = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        port = true;

    }
}
