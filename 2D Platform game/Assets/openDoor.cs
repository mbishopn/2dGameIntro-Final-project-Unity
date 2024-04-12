using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class openDoor : MonoBehaviour
{
    public GameObject gameoverscreen;
    private bool door;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("hit") && door)
        {
            gameoverscreen.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        door = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        door = false;
    }
}
