using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class OptionMenu : MonoBehaviour
{

    [SerializeField] AudioMixer mixer;


    void OnMusicSliderChange(float value)
    {
        float volume = RangeToDecibel(value);
        mixer.SetFloat("MusicVolume", volume);
    }
    void OnSfxSliderChange(float value)
    {
        float volume = RangeToDecibel(value);
        mixer.SetFloat("SfxVolume", volume);
    }
     public static float RangeToDecibel(float range)
    {
        if (range == 0)
        {
            return -80f;
        }
        return Mathf.Log(range, 5) * 20;
    }
    public static float DecibelToRange(float db)
    {
        if (db == -80f)
        {
            return 0;
        }
        return Mathf.Pow(5, db / 20);
    }
}
