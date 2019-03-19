using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    int[] highscores = new int[10];
    public int highscore;
    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public Text fifth;
    public Text sixth;
    public Text seventh;
    public Text eighth;
    public Text ninth;
    public Text tenth;
    public int i;
    public string highScoreKey;
    public int score;

    // Start is called before the first frame update
    void Start()
    {

        score = PlayerPrefs.GetInt("score");

    }

    // Update is called once per frame
    void Update()
    {


        for (i = 0; i < highscores.Length; i++)
        {

            //Get the highScore from 1 - 5
            highScoreKey = "HighScore" + (i + 1).ToString();
            highscore = PlayerPrefs.GetInt(highScoreKey, 0);

            if (score > highscore)
            {
                int temp = highscore;
                PlayerPrefs.SetInt(highScoreKey, score);
                score = temp;
            }


        }


        /*    ranks.Add(PlayerPrefs.GetInt("Highscore"));

            ranks.Sort();

            ranks.Remove(ranks[0]);

            */

        first.text = "First: " + PlayerPrefs.GetInt("HighScore1");
        second.text = "Second: " + PlayerPrefs.GetInt("HighScore2");
        third.text = "Third: " + PlayerPrefs.GetInt("HighScore3");
        fourth.text = "Fourth: " + PlayerPrefs.GetInt("HighScore4");
        fifth.text = "Fifth: " + PlayerPrefs.GetInt("HighScore5");
        sixth.text = "Sixth: " + PlayerPrefs.GetInt("HighScore6");
        seventh.text = "Seventh: " + PlayerPrefs.GetInt("HighScore7");
        eighth.text = "Eighth: " + PlayerPrefs.GetInt("HighScore8");
        ninth.text = "Ninth: " + PlayerPrefs.GetInt("HighScore9");
        tenth.text = "Tenth: " + PlayerPrefs.GetInt("HighScore10");


    }



}
