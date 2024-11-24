using UnityEngine;
using UnityEngine.SceneManagement; 

public class TriggerToEndScene : MonoBehaviour
{
    public string endSceneName; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(endSceneName);
        }
    }
}