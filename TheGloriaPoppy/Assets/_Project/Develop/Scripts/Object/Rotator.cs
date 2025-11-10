using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public GameConfig config;
        
        private void Update()
        {
            gameObject.transform.Rotate(0, 0, config.bonusRotateSpeed * Time.deltaTime);
        }
    }
}