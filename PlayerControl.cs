using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    //public bool ply=true;
    // Start is called before the first frame update
    public bool swipeMove;
    public static PlayerControl instance;

    public float maxPos;

    //test
 //   public Text touchText;
    //test
    void Start()
    {

        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
      // transform.Translate(0, 0, 50* Time.smoothDeltaTime);
        //transform.Rotate(100, 0, 0);
        GameManager.instance.scoreCounter += Time.deltaTime * 10;
        GameManager.instance.SpeedCounter += Time.deltaTime * 10;

        if (swipeMove==true)
        {
            transform.Translate(-12.99f, 0, 0);
            
        }
        else { }

      //  transform.Translate(Input.acceleration.x*110f * Time.smoothDeltaTime, 0f, 0f );
        if (transform.position.y< 10)
        {
            gameOver();
            // SceneManager.LoadScene(0);
        }
        if (transform.position.x == 20 || transform.position.x==-20)
        {
            gameOver();
            // SceneManager.LoadScene(0);
        }
        

        if (Input.GetKey("a"))
        {
            //  transform.Translate(-50 * Time.smoothDeltaTime, 0, 0);
                MoveLeft();
            //MovePlayer();

        }

        if (Input.GetKey("d")) 
        {

            //transform.Translate(50 * Time.smoothDeltaTime, 0,0);
            MoveRight();
        }


        if (Input.GetKey("s"))
        {

           // transform.Translate(0, 50 * Time.smoothDeltaTime, 0);
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.position.x < Screen.width/2)
            {
           //     touchText.text = "Move Left " + touch.position.x;
                MoveLeft();
            }
            else
            {
             //   touchText.text = "Move Right " + touch.position.x;
                MoveRight();
            }
        }

       
    }


    public void MovePlayer()
    {
        if (transform.position.x > 0f)
        {
            transform.position = new Vector3(-12f,transform.position.y,transform.position.z);
        }
        else
        {
            transform.position = new Vector3(12f, transform.position.y, transform.position.z);
        }
    }

    public void MoveRight()
    {
        transform.Translate(50 * Time.smoothDeltaTime, 0, 0);

    }

    public void MoveLeft()
    {
        transform.Translate(-50 * Time.smoothDeltaTime, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
       if( collision.gameObject.CompareTag("enemy"))
        {
            AudioManager.instance.Playmusic(2);
            gameOver();
        }
    }


    public void gameOver()
    {
        GameManager.instance.GameOver();
        GameManager.instance.ParticleInstFun(this.transform);
        //AudioManager.instance.destroy();
        //AudioManager.instance.bg = true;
        EnviromentPartical.instance.destroyPratical();
        //Handheld.Vibrate();
        Destroy(this.gameObject);

    }
}
