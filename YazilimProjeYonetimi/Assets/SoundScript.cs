using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip healSound, walkSound;
    static AudioSource audiosrc;
    void Start()
    {
        healSound = Resources.Load<AudioClip>("heal");
        walkSound = Resources.Load<AudioClip>("walk");

        audiosrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "heal":
                if (!audiosrc.isPlaying)
                {
                    audiosrc.PlayOneShot(healSound);
                }
                break;
            case "walk":
                if (!audiosrc.isPlaying)
                {
                    audiosrc.PlayOneShot(walkSound);
                }
                break;
        }
    }
}
