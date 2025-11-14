using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerMovment : MonoBehaviour
    {
        public GameConfig config;
        
        [SerializeField] private GameObject playerCenter;
        [SerializeField] private SpriteRenderer playerSprite;

        [SerializeField] private Rigidbody2D _rb;
        
        private float _playerSpeed;
        
        [SerializeField] private ScoreController scoreController;

        private void Start()
        {
            _playerSpeed = config.basePlayerSpeed;
        }

        private void OnEnable()
        {
            scoreController.LevelUp += AddPlayerSpeed;
        }

        private void OnDisable()
        {
            scoreController.LevelUp -= AddPlayerSpeed;
        }

        public void ChangeDirection()
        {
            if (Time.timeScale > 0)
            {
                playerSprite.flipY = !playerSprite.flipY;
                
                _playerSpeed = -_playerSpeed;
            }
        }

        private void FixedUpdate()
        {
            Movement();
        }

        void AddPlayerSpeed()
        {
            if (_playerSpeed < 0f)
            {
                _playerSpeed -= config.increasePlayerSpeed;
            } 
            else if (_playerSpeed > 0f && _playerSpeed < config.maxPlayerSpeed)
            {
                _playerSpeed += config.increasePlayerSpeed;
            }
        }

        void Movement()
        {
            _rb.angularVelocity = _playerSpeed;
        }
    }
}
