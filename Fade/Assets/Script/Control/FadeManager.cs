using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(FadeManager))]
[RequireComponent(typeof(FadeView))]


public class FadeManager : MonoBehaviour
{
    [SerializeField]
    private float fadeTime = 1.0f;

    [SerializeField]
    private FadeManager _fadeManager;

    [SerializeField]
    private FadeView _fadeView;


    private void Awake()
    {
        _fadeManager = GetComponent<FadeManager>();
        _fadeView = GetComponent<FadeView>();
    }


    public async Task SceneChange(string sceneName,bool isFirst = false)
    {
        await Task.Run(() => { });
    }


    /// <summary>
    /// フェードイン
    /// </summary>
    /// <param name="canvasGroup"></param>
    /// <returns></returns>
    IEnumerator FadeIn(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1.0f;
        while(canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime * (1.0f / fadeTime);
            if (canvasGroup.alpha <= 0)
                canvasGroup.alpha = 0f;
            yield return null;
        }
    }

    /// <summary>
    /// フェードアウト
    /// </summary>
    /// <param name="canvasGroup"></param>
    /// <returns></returns>
    IEnumerator FadeOut(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0.0f;
        while (canvasGroup.alpha < 1.0f)
        {
            canvasGroup.alpha -= Time.deltaTime * (1.0f / fadeTime);
            if (canvasGroup.alpha >= 1.0f)
                canvasGroup.alpha = 1.0f;
            yield return null;
        }
    }
}
