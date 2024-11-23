using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartLVL()
    {
        SceneManager.LoadScene("FirstLvl");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting..."); // for testing
    }
}