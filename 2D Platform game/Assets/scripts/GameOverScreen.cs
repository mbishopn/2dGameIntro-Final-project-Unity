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
        SceneManager.LoadScene("Intro_level");
    }

    public void headToMainMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
