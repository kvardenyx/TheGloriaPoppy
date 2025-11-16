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
        Time.timeScale = 1f;
        
        SceneManager.LoadScene(nameScene);
    }

    public void ReloadGame()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("Core");
    }
}
