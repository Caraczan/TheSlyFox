using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioMixer mixer;
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("GameVol", Mathf.Log10(sliderValue)*20);
    }
}
