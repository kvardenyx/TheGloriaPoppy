using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void LoadScene(string nameScene)
    {
        switch (nameScene)
        {
            case "StartScene":
                SceneManager.LoadScene("StartScene");
                break;
            
            case "GameScene":
                SceneManager.LoadScene("GameScene"); 
                break;
            
            case "LoseScene":
                SceneManager.LoadScene("LoseScene");  
                break;
        }
    }
}
