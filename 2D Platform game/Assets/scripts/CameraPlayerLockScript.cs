using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerLockScript : MonoBehaviour
{
    // Setting up variables to control the speed of the the camera following the player
    public float SpeedOfCamera = 3f;
    // To get the position of the player
    public Transform PlayerPos;

    // Update is called once per frame
    void Update()
    {
        // to get players position xy
        Vector3 newPos = new Vector3(PlayerPos.position.x, PlayerPos.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, SpeedOfCamera*Time.deltaTime);
    }
}
