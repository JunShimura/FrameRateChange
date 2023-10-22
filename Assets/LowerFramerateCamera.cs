using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LowerFramerateCamera : MonoBehaviour
{
    public float targetFramerate = 12; // カメラのターゲットフレームレート

    private void Start()
    {
        Application.targetFrameRate = (int)targetFramerate;
    }

    private void OnDisable()
    {
        // カメラが無効になるときに元のフレームレートに戻す
        Application.targetFrameRate = -1;
    }
}

