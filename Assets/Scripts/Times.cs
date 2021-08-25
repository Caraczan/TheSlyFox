using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Times : MonoBehaviour
{
    public Text times;
    // Start is called before the first frame update
    void Start()
    {
     times.text = PlayerPrefs.GetString("Times");
    }

    // Update is called once per frame
    void Update()
    {
        times.text= PlayerPrefs.GetString("Times");
        //PlayerPrefs.SetFloat("Times", times);


    }
}
