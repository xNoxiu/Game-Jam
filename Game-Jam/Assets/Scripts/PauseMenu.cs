using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
         if (pauseMenuUI.activeSelf)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false); 
    }
    public void PauseGame()
    {
        Time.timeScale = 0f; 
        pauseMenuUI.SetActive(true); 
    }
    public void ExitToMainMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("MainMenu");
    }
}
