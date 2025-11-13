using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatesManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void PauseGame()
    {
        panel.SetActive(true);

        Time.timeScale = 0f;
    }
    
    public void ContinueGame()
    {
        panel.SetActive(false);

        Time.timeScale = 1f;
    }

    public void ReloadGame()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("Core");
    }
}
