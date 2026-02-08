using Unity.VisualScripting;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private HealthController healthController;

        [SerializeField] private GameObject boneEffect;
        
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out ObjectMovment objectMovment))
            {
                if (!objectMovment.isTrigger)
                {
                    objectMovment.isTrigger = true;
                    
                    if (objectMovment.CompareTag("Enemy"))
                    {
                        healthController.RemoveHealth();

                        objectMovment.ChangeDirectoryMove();
                
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
    }
}