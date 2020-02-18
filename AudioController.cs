using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioController : MonoBehaviour
{
    public GameObject MusicButton;
    public Sprite[] MusicButtonSprites;

    public string MusicKey = "_music";
    public static AudioController instance;
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {

        Debug.Log("Music Key: " + PlayerPrefs.GetInt(MusicKey));
    }

   
    public void OnclickMusicButton()
    {
        if (PlayerPrefs.GetInt(MusicKey) == 1)
        {
            PlayerPrefs.SetInt(MusicKey, 0);
        }
        else
        {
            PlayerPrefs.SetInt(MusicKey, 1);

        }
        Debug.Log("" + PlayerPrefs.GetInt(MusicKey));
        AudioManager.instance.AudioMuteControl(PlayerPrefs.GetInt(MusicKey));
        MusicButton.GetComponent<Image>().sprite = MusicButtonSprites[PlayerPrefs.GetInt(MusicKey)];
    }
}
