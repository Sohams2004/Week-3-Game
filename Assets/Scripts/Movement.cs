using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Week_3
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 10f;
        [SerializeField] private float jumpForce = 10f;

        [SerializeField] private Rigidbody2D playerRb;

        [SerializeField] private bool jumpLimit = false;

        private void FixedUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal"); ;

            if (Input.GetMouseButton(0))
            {
                Debug.Log("Moved");
                Vector2 moveDirection = new Vector2(horizontal * movementSpeed, 0);
                playerRb.velocity = moveDirection;
            }
        }

        public void Jump()
        {
            if (!jumpLimit)
            {
                Debug.Log("ewfwfw");
                playerRb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                jumpLimit = true;
            }
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Floor"))
            {
                jumpLimit = false;
            }
        }
    }
}
