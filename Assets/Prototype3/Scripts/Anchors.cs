using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anchors : MonoBehaviour
{
    public Player player;
    public float timeleft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider Floor)
    {
        if (gameObject.tag == "Sub")
        {
            player.Sub = true;
        }
        else if (gameObject.tag == "Dom")
        {
            player.Dom = true;
        }
    }

     private void OnTriggerExit(Collider other)
     {
        if (gameObject.tag == "Sub")
        {
            player.Sub = false;
        }
        else if (gameObject.tag == "Dom")
        {
            player.Dom = false;
        }
    }
}
