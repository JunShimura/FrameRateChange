using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LowerFramerateCamera : MonoBehaviour
{
    public float targetFramerate = 12; // �J�����̃^�[�Q�b�g�t���[�����[�g

    private void Start()
    {
        Application.targetFrameRate = (int)targetFramerate;
    }

    private void OnDisable()
    {
        // �J�����������ɂȂ�Ƃ��Ɍ��̃t���[�����[�g�ɖ߂�
        Application.targetFrameRate = -1;
    }
}

