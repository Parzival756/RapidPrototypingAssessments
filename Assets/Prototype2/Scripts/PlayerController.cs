using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

namespace Prototype2
{

public class PlayerController : MonoBehaviour
{

    //FIRST CODE!
    
        public float moveSpeed;
        public float jumpForce;
        public CharacterController controller;

        private Vector3 moveDirection;
        public float gravityScale;

        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();   //getting the charactercontroller component from player
        }

    // Update is called once per frame
    void Update()
    {
        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);    //allowing player to move on the X and Y and Z axis.

        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = moveDirection.normalized * moveSpeed;
        moveDirection.y = yStore;

        if (controller.isGrounded)  //if the player is on the ground then they can jump, if not they can't, also when they 
                                    //are grounded the y direction is set to 0, to prevent sudden drops after failing a jump.
        {
            moveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }
        //this enables gravity and gives a deltaTime for slowing down the fall and gives values for moving a player
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }

        //NEW CODE.
        /*
        [SerializeField]
        private Animator animator;
        [SerializeField]
        private float DirectionDampTime = .25f;

        private float speed = 0.0f;
        private float h = 0.0f;
        private float v = 0.0f;

        private void Start()
        {
            animator = GetComponent<Animator>();

            if (animator.layerCount >= 2)
            {
                animator.SetLayerWeight(1, 1);
            }
        }

        private void Update()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            speed = h * h + v * v;

            animator.SetFloat("Speed", speed);
            animator.SetFloat("Direction", h, DirectionDampTime, Time.deltaTime);
        }
        */
    
}

}