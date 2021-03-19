using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    //FIRST PASS OF CODE!

    public Transform target;

    public Vector3 offset;

    public bool useOffsetValues;

    public float rotateSpeed;

    public Transform pivot;
    // Start is called before the first frame update
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

        pivot.position = target.position;
        pivot.transform.parent = target.transform;

        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        float Vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-Vertical, 0, 0);

        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;


        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        // transform.position = target.position - offset;
        if (transform.position.y < target.position.y)
        {
            transform.position = new Vector3(transform.position.x, target.position.y - .2f, transform.position.z);
        }

        transform.LookAt(target);

        //for the purposes of the assignment i have changed my used code back to the working original.

        //Second Pass of Code.
        /*
        [SerializeField]
        private float distanceAway;             //fixed distance from back of player
        [SerializeField]
        private float distanceUp;               //fixed distance up from player
        [SerializeField]
        private float smooth;                   //how long the camera takes to move from it's current position
        [SerializeField]
        private Transform follow;               //how the camera follows the player
        private Vector3 targetPosition;         //player's positioning

        private void Start()
        {
            follow = GameObject.FindWithTag ("Player").transform;
        }

        private void LateUpdate()
        {
            targetPosition = follow.position + follow.up * distanceUp - follow.forward * distanceAway;          //this sets the target position by taking the follow position moving it up and back to the values set.

            //Using the Debug Ray and Lines to show the offset in the game editor.
            Debug.DrawRay(follow.position, Vector3.up * distanceUp, Color.red);
            Debug.DrawRay(follow.position, -1f * follow.forward * distanceAway, Color.blue);
            Debug.DrawLine(follow.position, targetPosition, Color.magenta);

            //This code creates a smooth transition between the current position and the position it wants to be at.
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);

            //makes sure the camera is following the follow empty   .
            transform.LookAt(follow);
        }
        */

    }
}

