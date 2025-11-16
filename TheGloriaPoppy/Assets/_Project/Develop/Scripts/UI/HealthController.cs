using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class HealthController : MonoBehaviour
    {
        public GameConfig config;
        
        [SerializeField] private ScoreController scoreController;

        public Action PlayerIsDead;
        
        private int _healthValue;
        private Text _healthText;

        private void Start()
        {
            _healthText = gameObject.GetComponent<Text>();

            _healthValue = config.playerHealth;
            
            _healthText.text = _healthValue.ToString();
        }

        public void AddHealth()
        {
            _healthValue++;
            
            _healthText.text = _healthValue.ToString();
        }

        public void RemoveHealth()
        {
            _healthValue--;
            
            _healthText.text = _healthValue.ToString();
            
            if (_healthValue < 1)
            {
                scoreController.SaveScore();

                scoreController.ChangeRecord();
                
                PlayerIsDead?.Invoke();
            }
        }
    }
}