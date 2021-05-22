using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeView : MonoBehaviour
{
    //�L�����o�X�O���[�v�̎擾
    [SerializeField]
    private CanvasGroup _CanvasGroup;

    public CanvasGroup CanvasG { get { return _CanvasGroup; } }

    //�C���[�W�̎擾(�C���[�W�ɑ��݂��� raycast �𑀍삷�邽��)
    [SerializeField]
    private Image _fadeImage;

    public Image FadeImage { get { return _fadeImage; } }

}
