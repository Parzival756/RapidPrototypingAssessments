using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
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
    }
    private void GameOver()
    {
        SceneManager.LoadScene(1);
    }
    public void TimeLeft()
    {
        timeleft = 60f;
    }
}
