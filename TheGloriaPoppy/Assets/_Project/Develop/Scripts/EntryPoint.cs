using _Project.Develop.Scripts.Camera;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryPoint : MonoBehaviour
{
    public GameConfig config;
    public CameraScale cameraScale;
    public string nextSceneName = "Meta";

    private void Awake()
    {
        cameraScale.CalculateCameraScale(config);
        
        SceneManager.LoadScene(nextSceneName);
    }
}
