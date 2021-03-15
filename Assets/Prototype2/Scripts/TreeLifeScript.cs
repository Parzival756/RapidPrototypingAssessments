using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


//The idea of this is that the player will press a button and it will refil their timer/health, in small amounts.
//the tree will also open the door for a certain time allowing the player to enter the next area. (Remanded to a button object)

public class TreeLifeScript : MonoBehaviour
{

    public GameObject player;
    public GameObject TreeTrigger1; 
    public GameObject TreeTrigger2; 
    public GameObject TreeTrigger3; 
    public GameObject TreeTrigger4;
    public float timeleft = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0)
        {
            GameOver();
        }
        TreeTime();
    }

    private void GameOver()
    {
        SceneManager.LoadScene(1);
    }

    private void TreeTime()
    {
        if (TreeTrigger1.gameObject.tag == "player")
        {
            timeleft =+ 60f;
        }
        else if (TreeTrigger2.gameObject.tag == "player")
        {
            timeleft = +60f;
        }
        else if (TreeTrigger3.gameObject.tag == "player")
        {
            timeleft = +60f;
        }
        else if (TreeTrigger4.gameObject.tag == "player")
        {
            timeleft = +60f;
        }
    }
}
