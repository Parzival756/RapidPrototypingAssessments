using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Door;
    public GameObject Button;
    public GameObject Buttonbox;
    public GameObject ButtonTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Buttonbox.gameObject.tag == "player")
        {
            Button.transform.position = new Vector3(0, -5, 0);
            Door.SetActive(false);
            Debug.Log("HEYA");
        }
    }
}
