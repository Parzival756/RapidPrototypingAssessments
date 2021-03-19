using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


//The idea of this is that the player will press a button and it will refil their timer/health, in small amounts.
//the tree will also open the door for a certain time allowing the player to enter the next area. (Remanded to a button object)

public class TreeLifeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnTriggerEnter(Collider other)
    {
        Timer timer = other.GetComponent<Timer>();
        if (timer != null)
        {
            timer.TimeLeft();
        }
        Debug.Log("HEYYYYLO");
    }

}
