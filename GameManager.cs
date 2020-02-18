using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public int highPoint;
    public Text point;
    public Text YourScore;
    public int score;
    public float scoreCounter = 0;
    public float SpeedCounter = 0;
    public int speed;
    public static GameManager instance;
    public GameObject destroyParticleEffect;
    public Transform particlePostion;
    public Text HighPoint;
    public string firstEntry;
    // Start is called before the first frame update
    void Start()
    {
     //   hightPoint = PlayerPrefs.GetInt("h");
        instance = this;

        if (PlayerPrefs.HasKey(firstEntry))
        {
            //   Debug.Log("1 " + firstEntry + " " + PlayerPrefs.GetInt(firstEntry));
            LoadPlayerData();
        }
        else
        {
            Debug.Log("2");
            PlayerPrefs.SetInt(firstEntry, 1);


        }
    }
    public void LoadPlayerData()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        //  Debug.Log("H score: " + highScore);
        highPoint = data.highScore;
        //  highScore = 0;

        //  Debug.Log("Hi score: " + highScore);
    }


    public void SavePlayerData()
    {
        if (score >= highPoint)
        {
            highPoint = score;
           
        }

        SaveSystem.SavePlayer(this);
    }
    // Update is called once per frame
    void Update()
    {
        SavePlayerData();
        /* if (score > hightPoint)
          {
              PlayerPrefs.SetInt("h", score);

          }
          */
        HighPoint.text ="High :"+ highPoint.ToString();
      //  hightPoint = PlayerPrefs.GetInt("h");
        point.text = score.ToString();
        YourScore.text = "Score :"+ score.ToString();
        // scoreCounter += Time.deltaTime * 10;
        score = (int)scoreCounter;
        speed = (int)SpeedCounter;

        if (speed == 100)
        {
            EnemyManager.instance.Zspeed +=100;
            EnviromentPartical.instance.speed += 0.50f;
            BallRotate.instance.RotateSpeed += 5;
           // CameraControl.instance.color = Random.Range(0, 7);
            SpeedCounter = 0;
        }

        
        if (score == 750)
        {
           
            EnemyManager.instance.TimeSpeed = 1;
        }


    }

    public void GameOver()
    {
      //  point.gameObject.SetActive(false);
        EnemyManager.instance.destry = false;
        //  restart.gameObject.SetActive(true);
        // home.gameObject.SetActive(true);
        point.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(true);
       // Gameover.text = "Game Over";
      //  CameraControl.instance.destroy = false;
        
       // Time.timeScale = 0;
    }

    public void ParticleInstFun(Transform particlePos)
    {
        Instantiate(destroyParticleEffect, particlePos.position, Quaternion.identity);
      
    }

 
    
}
