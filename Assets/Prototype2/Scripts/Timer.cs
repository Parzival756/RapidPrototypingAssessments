using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeleft;
    public float AdditionalTime;

    //TimeLeft and Added Time if this idea is pushed further could be related to the level, as in the first level would have a larger timer, allowing the player to get used to the mechanics and as the game progresses there would be less time.
    //in addition it could also be related to how large a tree root is (as in having multiple variants that give differing amounts of additional time/Life.

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
        timeleft = AdditionalTime;
    }
}
