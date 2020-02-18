using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotate  : MonoBehaviour
{
    public static BallRotate instance ;
    public float RotateSpeed ;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (RotateSpeed < 65)
        {
            transform.Rotate(0, -RotateSpeed, 0);
        }
        else
        {
            transform.Rotate(0, -65, 0);
        }
       
    }
}
