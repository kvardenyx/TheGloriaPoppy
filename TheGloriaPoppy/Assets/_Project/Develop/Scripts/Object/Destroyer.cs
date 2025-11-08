using UnityEngine;

namespace _Project.Scripts
{
    public class Destroyer : MonoBehaviour
    {
        [SerializeField] private ScoreController scoreController;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                scoreController.AddScore();
            }
            
            Destroy(other.gameObject);
        }
    }
}