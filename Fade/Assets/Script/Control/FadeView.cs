using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeView : MonoBehaviour
{
    //キャンバスグループの取得
    [SerializeField]
    private CanvasGroup _CanvasGroup;

    public CanvasGroup CanvasG { get { return _CanvasGroup; } }

    //イメージの取得(イメージに存在する raycast を操作するため)
    [SerializeField]
    private Image _fadeImage;

    public Image FadeImage { get { return _fadeImage; } }

}
