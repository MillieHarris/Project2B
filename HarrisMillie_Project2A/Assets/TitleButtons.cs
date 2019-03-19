
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleButtons : MonoBehaviour
{
    public GameObject start;
    public GameObject options;

    // Start is called before the first frame update
    void Start()
    {
        
       // musicobj.volume = PlayerPrefs.GetFloat("musicvolume");

    }

    // Update is called once per frame
    void Update()
    {
        Volume volscript = GetComponent<Volume>();

        
        // if (volscript.music.isPlaying == true)
        // { Object.Destroy(music); }

    }

    public void Begin()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void Options()
    { SceneManager.LoadScene("Options"); }

    public void scores()
    { SceneManager.LoadScene("HighScores"); }
}
