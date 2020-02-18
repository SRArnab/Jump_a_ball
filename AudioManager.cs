using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public bool musicMuted;
    public static AudioManager instance;
    public void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void Playmusic(int id)
    {
        if (!musicMuted)
        {
            AudioSource _pm = GetComponent<AudioSource>();
            if (_pm.enabled)
            {
                _pm.PlayOneShot(audioClips[id]);
            }
            else
            {
                GameObject AudioManager = GameObject.Find("Audio Manager");
                AudioSource _newpm = AudioManager.gameObject.GetComponent<AudioSource>();

            }
            Debug.Log("Working");
        }

    }
        public void AudioMuteControl(int id)
        {
            AudioSource pm = GetComponent<AudioSource>();
            if (id == 0)
            {
                pm.enabled = true;
            }
            else if (id == 1)
            {
                pm.enabled = false;
            }

        }
    }
