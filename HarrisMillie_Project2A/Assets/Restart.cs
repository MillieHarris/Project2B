using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    { SceneManager.LoadScene("SampleScene"); }

    public void Quit()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void leaderboard()
    { SceneManager.LoadScene("HighScores"); }

}
