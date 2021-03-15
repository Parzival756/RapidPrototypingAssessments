using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject ButtonBox;
    public GameObject Player;
    public GameObject Door;
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
        ButtonBox.transform.localScale = new Vector3(0, -5, 0);
        Door.SetActive(false);
        Debug.Log("HEYA");
    }
}
