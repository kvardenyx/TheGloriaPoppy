using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private HealthController healthController;

        [SerializeField] private GameObject boneEffect;
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

                Instantiate(boneEffect, transform.position, Quaternion.identity);
                
                healthController.AddHealth();
            }
        }
    }
}