using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField] private GameObject playerCenter;
        [SerializeField] private SpriteRenderer playerSprite;

        [SerializeField] private Rigidbody2D _rb;
        
        [SerializeField, Range(60f, 360f)] 
        private float playerSpeed = 180f;
        
        [SerializeField] private ScoreController scoreController;
        
        private void OnEnable()
        {
            scoreController.PowerUp += AddPlayerSpeed;
        }

        private void OnDisable()
        {
            scoreController.PowerUp -= AddPlayerSpeed;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerSprite.flipY = !playerSprite.flipY;
                
                playerSpeed = -playerSpeed;
            }
        }

        private void FixedUpdate()
        {
            Movment();
        }

        void AddPlayerSpeed()
        {
            if (playerSpeed < 0f)
            {
                playerSpeed -= 5f;
            } 
            else if (playerSpeed > 0f && playerSpeed < 200f)
            {
                playerSpeed += 5f;
            }
        }

        void Movment()
        {
            _rb.angularVelocity = playerSpeed;
        }
    }
}
