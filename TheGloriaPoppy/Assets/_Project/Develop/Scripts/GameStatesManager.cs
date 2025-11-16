using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatesManager : MonoBehaviour
{
    private static bool _created;

    
    private void Awake()
    {
        if (_created)
        {
            Destroy(gameObject);
            return;
        }

        _created = true;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    
    public void ContinueGame()
    {
        Time.timeScale = 1f;
    }

    public void ReloadGame()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("Core");
    }

    public void LosseGame()
    {
        Time.timeScale = 0f;
    }
}
