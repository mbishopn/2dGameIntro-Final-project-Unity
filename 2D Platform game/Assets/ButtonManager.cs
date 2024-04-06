using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void goingNextScene()
    {
        SceneManager.LoadScene("Intro_level");
    }
}
