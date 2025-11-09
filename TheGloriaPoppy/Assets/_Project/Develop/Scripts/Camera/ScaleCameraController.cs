using UnityEngine;

public class ScaleCameraController : MonoBehaviour
{
    public GameConfig config;
    
    private Camera _camera;
    
    private void Start()
    {
        _camera = Camera.main;

        AdjustCamera();
    }
    
    private void AdjustCamera()
    {
        _camera.orthographicSize = config.cameraSize / (config.currentAspectRatio / config.baseAspectRatio);
    }
}
