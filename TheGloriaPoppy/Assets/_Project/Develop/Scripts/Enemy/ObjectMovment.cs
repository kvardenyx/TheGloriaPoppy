using UnityEngine;

namespace _Project.Scripts
{
    public class ObjectMovment : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private Transform _transform;

        public bool isTrigger = false;
        
        public float speed;
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _transform = transform;
        }

        private void FixedUpdate()
        {
            _rb.linearVelocity = _transform.right * speed;
        }

        public void ChangeDirectoryMove()
        {
            float rotateValue = 0;
            
            while (rotateValue > -15f && rotateValue < 15f)
            {
                rotateValue = Random.Range(-50f, 50f);
            }

            _transform.Rotate(0,0, rotateValue);
        }
    }
}