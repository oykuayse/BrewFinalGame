using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    public float fadeDuration = 60.0f;
    public float fadeResetDelay = 10.0f;
    public Material fadeMaterial;

    private bool isFading = false;
    private bool isResetting = false;
    private float fadeTimer = 0.0f;
    private float resetTimer = 0.0f;

    void Start()
    {
        StartCoroutine(FadeOut());
    }

    void Update()
    {
        if (isResetting)
        {
            resetTimer += Time.deltaTime;
            if (resetTimer >= fadeResetDelay)
            {
                resetTimer = 0.0f;
                isResetting = false;
                StartCoroutine(FadeOut());
            }
        }
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (isFading)
        {
            fadeMaterial.SetFloat("_FadeAmount", Mathf.Clamp01(fadeTimer / fadeDuration));
            Graphics.Blit(src, dest, fadeMaterial);
        }
        else
        {
            Graphics.Blit(src, dest);
        }
    }

    IEnumerator FadeOut()
    {
        isFading = true;
        while (fadeTimer < fadeDuration)
        {
            fadeTimer += Time.deltaTime;
            yield return null;
        }
        isFading = false;
        isResetting = true;
    }

    public void CollectMushroom()
    {

        StopAllCoroutines();
        isFading = false;
        isResetting = false;
        fadeTimer = 0.0f;
        resetTimer = 0.0f;
        StartCoroutine(FadeOut());
    }
}
