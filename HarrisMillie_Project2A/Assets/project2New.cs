using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class project2New : MonoBehaviour
{
    public int Speed;
    public float directionChangeChance = 0.01f;
    public GameObject Container;
    public GameObject Penguin;
    public GameObject Bucket;
    public float screenEdgeL = -3.0f;
    public float screenEdgeR = 12.0f;
    Vector3 MousePosition;
    Vector3 Direction = Vector3.right;
    public GameObject prefabInstance;
    public int counter = 0;

    

    public void SpawnPrefab()
    {

        Instantiate(prefabInstance, Bucket.transform.position, Quaternion.identity);
        //prefabInstance.transform.SetParent(Container.transform); Setting the parent of a transform which resides
        //in a Prefab Asset is disabled to prevent data corruption (GameObject: 'Fish').
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Speed = Random.Range(6, 12);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        { Time.timeScale = 1; }


        counter += 1;
        if (counter % 40 == 0 && Time.timeScale == 1)
        { SpawnPrefab(); }


        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Penguin.transform.position = new Vector3(MousePosition.x, Penguin.transform.position.y, Penguin.transform.position.z);

        

        if (Penguin.transform.position.x < -7)
        {
            Penguin.transform.position = new Vector3(-7, Penguin.transform.position.y, Penguin.transform.position.z);
        }

        if (Penguin.transform.position.x > 7)
        { Penguin.transform.position = new Vector3(7, Penguin.transform.position.y, Penguin.transform.position.z); }

        if (Bucket.transform.position.x <= -7)
         {
             Bucket.transform.position = new Vector3(-7, Bucket.transform.position.y, Bucket.transform.position.z);
             Speed *= -1;
         }

        if (Bucket.transform.position.x >= 7)
        {
            Bucket.transform.position = new Vector3(7, Bucket.transform.position.y, Bucket.transform.position.z);
            Speed *= -1;
        }


        Bucket.transform.Translate(Direction * Speed * Time.deltaTime);

        if (Random.value < directionChangeChance)
        { Speed *= -1; }


        Restart();

    }


   public void Restart()
    {
        botcol botscript = GameObject.Find("bottom").GetComponent<botcol>();
        //pencol penscript = GetComponent<pencol>();

        if (botscript.Lives == 0)
        {
            SceneManager.LoadScene("SampleScene");

            /*botscript.Lives = 3;
            penscript.Score = 0;
            Penguin.transform.position = new Vector3(0, Penguin.transform.position.y, Penguin.transform.position.z);
            //positions to 0*/

        }
    }
}
