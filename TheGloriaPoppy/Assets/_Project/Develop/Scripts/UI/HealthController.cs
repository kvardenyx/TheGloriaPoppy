using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class HealthController : MonoBehaviour
    {
        [SerializeField] private ScenesManager scenesManager;
        
        [SerializeField] private ScoreController scoreController;
        
        [SerializeField, Range(1, 3)]private int healthValue = 1;
        private Text _healthText;

        private void Start()
        {
            _healthText = gameObject.GetComponent<Text>();
            
            _healthText.text =healthValue.ToString();
        }

        public void AddHealth()
        {
            healthValue++;
            
            _healthText.text =healthValue.ToString();
        }

        public void RemoveHealth()
        {
            healthValue--;
            
            _healthText.text =healthValue.ToString();
            
            if (healthValue < 1)
            {
                scoreController.ChangeRecord();
                
                scenesManager.LoadScene("LoseScene");
            }
        }
    }
}