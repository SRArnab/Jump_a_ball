using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl  : MonoBehaviour
{
    public static CameraControl instance;
  //  public GameObject Player;
    //public Vector3 offset;
   // public bool destroy = true;
    public int colour = 0;

   
    //  public Camera cam7;
    /*  public Color backgroundColor { get; private set; }
      public Color color1 = Color.red;
      public Color color2 = Color.blue;
      public Color color3 = Color.blue;
      public Color color4 = Color.blue;
      public Color color5 = Color.blue;
      public Color color6 = Color.blue;
      public Color color7 = Color.blue;
  */

    public GameObject[] bg;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
       // offset = transform.position - Player.transform.position;

     //   cam = GetComponent<Camera>();
       
        colour = Random.Range(0, 3);
       



    }

    // Update is called once per frame
    void Update()
    {
        
/*
        if (null != Player)
        {
            transform.position = Player.transform.position + offset;
        }

      if (destroy==false)
        {
            if (tim < 0)
            {
                GameManager.instance.GamePanel();
                transform.Translate(-13, 0, 0);
                destroy = true;
            }
            else
            {
                tim --;
            }
        }
        */
    }

    private void FixedUpdate()
    {
        ColourChange();
    }
    void ColourChange ()
    {
        switch (colour)
        {
            case 0:
               // cam.gameObject.SetActive(true);
                bg[0].gameObject.SetActive(true);
                Road.instance.colour = 0;
                break;
            case 1:
                //cam1.gameObject.SetActive(true);
                Road.instance.colour = 1;
                bg[1].gameObject.SetActive(true);
                break;
            case 2:
               // cam2.gameObject.SetActive(true);
                Road.instance.colour = 2;
                bg[2].gameObject.SetActive(true);
                break;
            case 3:
              //  cam3.gameObject.SetActive(true);
                break;
            case 4:
                //cam4.gameObject.SetActive(true);
                break;
            case 5:
                //cam5.gameObject.SetActive(true);
                break;
            case 6:
                //cam6.gameObject.SetActive(true);
                break;

        }

    }
}
