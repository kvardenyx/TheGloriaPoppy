using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class ScoreController : MonoBehaviour
    {
        public GameConfig config;
        
        private int _scoreValue = 0;
        private Text _scoreText;

        public Action LevelUp;

        private void Start()
        {
            _scoreText = gameObject.GetComponent<Text>();
            
            _scoreText.text = _scoreValue.ToString();
            
            PlayerPrefs.SetInt("Score", _scoreValue);
        }

        public void AddScore()
        {
            _scoreValue++;

            _scoreText.text = _scoreValue.ToString();
            
            if (_scoreValue % config.bonusLevelUp == 0)
            {
                LevelUp?.Invoke();
            }
        }

        public void SaveScore()
        {
            PlayerPrefs.SetInt("Score", _scoreValue);
        }

        public void ChangeRecord()
        {
            if (_scoreValue >= PlayerPrefs.GetInt("Record"))
            {
                PlayerPrefs.SetInt("Record", _scoreValue);
            }
        }
    }
}