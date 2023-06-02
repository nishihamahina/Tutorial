using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField] private Image fadePanel;
    void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
        StartCoroutine(FadeOut());
}

private IEnumerator FadeOut()
{
    Color c = fadePanel.color;
    float alpha = 0f;

    c.a = alpha;
    fadePanel.color = c;

    for (int i = 0; i < 60; i++)
    {
        alpha += 1 / 60f;
        c.a = alpha;
        fadePanel.color = c;

        yield return new WaitForSeconds(0.01667f);
    }
    alpha = 1f;
    c.a = alpha;
    fadePanel.color = c;
    StartCoroutine(FadeIn());
}

private IEnumerator FadeIn()
{
    Color c = fadePanel.color;
    float alpha = 1f;

    c.a = alpha;
    fadePanel.color = c;

    for (int i = 0; i < 60; i++)
    {
        alpha -= 1 / 60f;
        c.a = alpha;
        fadePanel.color = c;

        yield return new WaitForSeconds(0.01667f);
    }
    Destroy(this.gameObject);
}
}
