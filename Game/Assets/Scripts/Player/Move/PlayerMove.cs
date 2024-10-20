using UnityEngine;

namespace Move
{
    public class PlayerMove : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private Vector2 moveVector;

        [SerializeField] private float moveSpeed = 5;

        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            moveVector.x = Input.GetAxis("Horizontal");
            moveVector.y = Input.GetAxis("Vertical");

            _rb.velocity = (moveVector * moveSpeed);
        }
    }
}