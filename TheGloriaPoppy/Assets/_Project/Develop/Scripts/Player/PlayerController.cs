using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private ScenesManager scenesManager;
        [SerializeField] private HealthController healthController;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                healthController.RemoveHealth();
                
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
                
                healthController.AddHealth();
            }
        }
    }
}