using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private HealthController healthController;

        [SerializeField] private GameObject boneEffect;

        [SerializeField] private GameObject addLifeAnim;
        [SerializeField] private GameObject loseLifeAnim;
        
        
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
                
                        var anim = Instantiate(loseLifeAnim, Vector3.zero, Quaternion.identity);
                        StartCoroutine(LifeTimeAnimation(anim));
                    }
                    else
                    {
                        Destroy(other.gameObject);

                        Instantiate(boneEffect, transform.position, Quaternion.identity);
                
                        healthController.AddHealth();
                        
                        var anim = Instantiate(addLifeAnim, Vector3.zero, Quaternion.identity);
                        StartCoroutine(LifeTimeAnimation(anim));
                    }
                }
            }
        }

        IEnumerator LifeTimeAnimation(GameObject currentAnimation)
        {
            yield return new WaitForSeconds(1);
            Destroy(currentAnimation);
        }
    }
}