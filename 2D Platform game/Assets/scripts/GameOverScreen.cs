using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public void restartbutton()
    {
        Debug.Log("boton picado");
        //GameOverScreen.FindAnyObjectByType<GameOverScreen>().gameObject.SetActive(false);
        SceneManager.LoadScene("Intro_level");
       
    }

    public void headToMainMenu()
    {
        Debug.Log("segundo boton");
        //GameOverScreen.FindAnyObjectByType<GameOverScreen>().gameObject.SetActive(false);
        SceneManager.LoadScene("menu");
        
    }
}
