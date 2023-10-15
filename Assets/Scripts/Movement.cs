using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    [SerializeField] private Rigidbody2D playerRb;

    [SerializeField] private bool firsClick;
    [SerializeField] private bool secondClick;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); ;

        if(Input.GetMouseButton(0)) 
        {
            Debug.Log("Moved");
            Vector2 moveDirection = new Vector2(horizontal * movementSpeed, 0);
            playerRb.velocity = moveDirection;            
        }


    }
}
