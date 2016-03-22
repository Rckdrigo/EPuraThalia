using UnityEngine;
using System.Collections;

public class BottleShake : MonoBehaviour
{

    void Start()
    {
        GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
        StartCoroutine("Shake");
    }

    public void PlayShake()
    {
        StartCoroutine("Shake");
    }

    IEnumerator Shake()
    {
        for (int i = 0; i < 42; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, 6f), (float)i / 42f);
            yield return null;
        }

        for (int i = 0; i < 43; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, 0f), (float)i / 43f);
            yield return null;
        }

        for (int i = 0; i < 12; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, -11.64f), (float)i / 12f);
            yield return null;
        }

        for (int i = 0; i < 9; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, 8.97f), (float)i / 9f);
            yield return null;
        }

        for (int i = 0; i < 10; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, -10.69f), (float)i / 10f);
            yield return null;
        }

        for (int i = 0; i < 9; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, 12.64f), (float)i / 9f);
            yield return null;
        }

        for (int i = 0; i < 10; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, -4.46f), (float)i / 10f);
            yield return null;
        }

        for (int i = 0; i < 170; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, 0), (float)i / 70f);
            yield return null;
        }

        GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
        StartCoroutine("Shake");
    }
}
