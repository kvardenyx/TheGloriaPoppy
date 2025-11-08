using System;
using Unity.VisualScripting;
using UnityEngine;

namespace _Project.Scripts
{
    public class ObjectMovment : MonoBehaviour
    {
        private Rigidbody2D _rb;
        
        [SerializeField, Range(50f, 150f)] 
        private float speed = 100f;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _rb.linearVelocity = Vector2.right * (speed * Time.fixedDeltaTime);
        }
    }
}