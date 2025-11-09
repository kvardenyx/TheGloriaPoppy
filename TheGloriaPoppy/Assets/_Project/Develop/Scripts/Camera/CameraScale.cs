using UnityEngine;

namespace _Project.Develop.Scripts.Camera
{
    public class CameraScale : MonoBehaviour
    {
        public void CalculateCameraScale(GameConfig config)
        {
            float aspect = (float)Screen.width / Screen.height;

            config.currentAspectRatio = aspect;
        }
    }
}