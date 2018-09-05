using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{


    public KeyCode takeScreenshotKey = KeyCode.S;
    public int screenshotCount = 0;

    private void Start()
    {

    }

    int i = 0;

    private void Update()
    {
        
        if (Input.GetKeyDown(takeScreenshotKey))
        {
            ScreenCapture.CaptureScreenshot("Screenshots/"
                 + "_" + screenshotCount + "_" + Screen.width + "X" + Screen.height + "_" + i +  ".png");
            Debug.Log("Screenshot taken.");
            i++;
        }
    }
}