using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiccontrol : MonoBehaviour
{

    private GameObject[] music;
    public AudioSource musicsource;

    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectsWithTag("gameMusic");
        Destroy(music[1]); 
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(transform.gameObject);

        

        if (PlayerPrefs.HasKey("musicvolume"))
            { musicsource.volume = PlayerPrefs.GetFloat("musicvolume"); }
        
        
        
    }
}
