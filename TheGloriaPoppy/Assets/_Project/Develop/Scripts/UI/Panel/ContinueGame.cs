using UnityEngine;

namespace _Project.Scripts.Panel
{
    public class ContinueGame : MonoBehaviour
    {
        public void OnContinueGame()
        {
            Time.timeScale = 1f;
            
            Destroy(gameObject);
        }
    }
}