using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Volume : MonoBehaviour
{

    public int val;
    public Slider volume;
    public Toggle musictog;
    public Slider SFXvolume;
    public Toggle SFXtog;

    // Start is called before the first frame update
    void Start()
    {

        musictog.isOn = false;
        SFXtog.isOn = false;

    }

    // Update is called once per frame
    void Update()
    {
        TitleButtons titlescript = GetComponent<TitleButtons>();

        if (musictog.isOn == false)
        { PlayerPrefs.SetFloat("musicvolume", volume.value); }


        if (SFXtog.isOn == false)
        { PlayerPrefs.SetFloat("SFXvolume", SFXvolume.value); }

    }


    
    public void lowermusic()
    {

        PlayerPrefs.SetFloat("musicvolume", volume.value);

    }

    public void mutemusic()
    {

        PlayerPrefs.SetFloat("musicvolume", 0);

    }

    public void lowersfx()
    {
        PlayerPrefs.SetFloat("SFXvolume", SFXvolume.value);

    }

    public void mutesfx()
    {
        PlayerPrefs.SetFloat("SFXvolume", 0);

    }

   /* public void StopMusic()
    {
        if (SceneManager.GetActiveScene().name == "Title Screen")
        { Object.Destroy(music1); }
    } */
}
