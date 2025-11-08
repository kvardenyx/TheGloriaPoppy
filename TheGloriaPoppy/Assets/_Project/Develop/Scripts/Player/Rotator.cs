using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField, Range(100f, 300f)]
        private float speed = 150f;
        private void Update()
        {
            gameObject.transform.Rotate(0, 0, speed * Time.deltaTime);
        }
    }
}