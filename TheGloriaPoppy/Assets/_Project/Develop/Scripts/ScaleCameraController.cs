using System;
using UnityEngine;

public class ScaleCameraController : MonoBehaviour
{
    private Camera _camera;
    
    private float _targetAspect = 9f / 16f;
    private float _baseOrthographicSize = 5f;
    
    private void Start()
    {
        _camera = Camera.main;

        AdjustCamera();
    }
    
    private void AdjustCamera()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        
        _camera.orthographicSize = _baseOrthographicSize / (currentAspect / _targetAspect);
        
    }
}
