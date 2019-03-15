using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pencol : MonoBehaviour
{
    public Text scoreText;
    public int Score = 0;
    public AudioClip slap;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Score = 0;
        GetComponent<AudioSource>().clip = slap;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true)
        { Time.timeScale = 1; }

        scoreText.text = "Score: " + Score.ToString();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        project2New mainscript = GameObject.Find("penguin").GetComponent<project2New>();



        if (collision.gameObject.tag == "Fish")
        {
            Score += 1;
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();

        }
    }
}