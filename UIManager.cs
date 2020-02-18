using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);

    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    
    }

    public void home()
    {
        SceneManager.LoadScene(0);
    }
}
