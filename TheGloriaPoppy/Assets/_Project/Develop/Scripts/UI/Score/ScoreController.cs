using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class ScoreController : MonoBehaviour
    {
        private int _scoreValue = 0;
        private Text _scoreText;

        public Action PowerUp;

        private void Start()
        {
            _scoreText = gameObject.GetComponent<Text>();
            
            _scoreText.text = _scoreValue.ToString();
            
            PlayerPrefs.SetInt("Score", _scoreValue);
        }

        public void AddScore()
        {
            _scoreValue++;
            
            PlayerPrefs.SetInt("Score", _scoreValue);

            _scoreText.text = _scoreValue.ToString();
            
            if (_scoreValue % 10 == 0)
            {
                PowerUp?.Invoke();
            }
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