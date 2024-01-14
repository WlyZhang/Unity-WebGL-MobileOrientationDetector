using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API : MonoBehaviour
{
    /// <summary>
    /// 设置屏幕转向
    /// </summary>
    /// <param name="isPortrait">【true竖屏】【false横屏】</param>
    public static void SetScreen(bool isPortrait)
    {
        Screen.orientation = ScreenOrientation.AutoRotation;//设置方向为自动(根据需要自动旋转屏幕朝向任何启用的方向。)
        Screen.autorotateToLandscapeRight = !isPortrait;           //自动旋转到右横屏
        Screen.autorotateToLandscapeLeft = !isPortrait;            //自动旋转到左横屏
        Screen.autorotateToPortrait = isPortrait;                //自动旋转到纵向
        Screen.autorotateToPortraitUpsideDown = isPortrait;      //自动旋转到纵向上下
        Screen.sleepTimeout = SleepTimeout.NeverSleep;      //睡眠时间为从不睡眠
        Screen.fullScreen = true;

        CanvasScaler canvasScaler = GameObject.FindObjectOfType<CanvasScaler>();

        if (canvasScaler)
        {
            if (isPortrait)
            {
                Screen.SetResolution(1080, 1920, true);
                canvasScaler.referenceResolution = new Vector2(1080, 1920);
            }
            else
            {
                Screen.SetResolution(1920, 1080, true);
                canvasScaler.referenceResolution = new Vector2(1920, 1080);
            }
        }
    }
}
