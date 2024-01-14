using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API : MonoBehaviour
{
    /// <summary>
    /// ������Ļת��
    /// </summary>
    /// <param name="isPortrait">��true��������false������</param>
    public static void SetScreen(bool isPortrait)
    {
        Screen.orientation = ScreenOrientation.AutoRotation;//���÷���Ϊ�Զ�(������Ҫ�Զ���ת��Ļ�����κ����õķ���)
        Screen.autorotateToLandscapeRight = !isPortrait;           //�Զ���ת���Һ���
        Screen.autorotateToLandscapeLeft = !isPortrait;            //�Զ���ת�������
        Screen.autorotateToPortrait = isPortrait;                //�Զ���ת������
        Screen.autorotateToPortraitUpsideDown = isPortrait;      //�Զ���ת����������
        Screen.sleepTimeout = SleepTimeout.NeverSleep;      //˯��ʱ��Ϊ�Ӳ�˯��
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
