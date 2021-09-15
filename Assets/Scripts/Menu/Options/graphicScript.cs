using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphicScript : MonoBehaviour
{
    List<int> widths = new List<int>() { 1920, 1280, 960, 800 };
    List<int> heights = new List<int>() { 1080,800,540,600 };
    List<bool> screenSet = new List<bool>() {true,false };
    public void SetScreenSize(int index)
    {
        Screen.SetResolution(widths[index], heights[index], Screen.fullScreen);
    }
    public void SetFullScreen(int index)
    {
        Screen.fullScreen = screenSet[index];
    }
}
