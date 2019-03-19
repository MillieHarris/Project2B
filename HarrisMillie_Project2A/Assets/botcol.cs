using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botcol : MonoBehaviour
{
    public int Lives;
    public Text livesText;
    public AudioClip thud;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Lives = 3;
        GetComponent<AudioSource>().clip = thud;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        { Time.timeScale = 1; }
        livesText.text = "Lives: " + Lives.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        project2New otherscript = GetComponent<project2New>();


        if (collision.gameObject.tag == "Fish")
        {   if (PlayerPrefs.HasKey("SFXvolume"))
            { GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXvolume"); }
            Lives -= 1;
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();

        }

    }
}
