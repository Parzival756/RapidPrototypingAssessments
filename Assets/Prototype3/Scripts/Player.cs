using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update

    public GameObject Pivot1;
    public GameObject Pivot2;
    private Rigidbody Thebod;
    private bool touchie;
    public bool Sub, Dom;
    void Start()
    {
       Thebod = GetComponent<Rigidbody>() ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 && Sub)
        {
            transform.RotateAround(Pivot1.transform.position, Vector3.forward, -speed * Time.deltaTime);
            Thebod.useGravity = false;
        }
        else if (Input.GetAxis("Horizontal") < 0 && Dom)
        {
            transform.RotateAround(Pivot2.transform.position, Vector3.back, speed * Time.deltaTime);
            Thebod.useGravity = false;
        }
        else
        {
            Thebod.useGravity = true;
            //touchie = false;
        }
    }

   /* private void OnTriggerStay(Collider other)
    {
        touchie = true;
        Debug.Log(touchie);
    }

    private void OnTriggerExit(Collider other)
    {
             
        touchie = false;
        
        Debug.Log(touchie);
    }*/
}
