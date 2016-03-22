using UnityEngine;
using System.Collections;

public class BottleShake : MonoBehaviour
{
    [Range(-15f, 15f)]
    public float maxAngle, minAngle;

    void Start()
    {
        GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, maxAngle);
        StartCoroutine("Shake");
    }

    public void PlayShake()
    {
        StartCoroutine("Shake");
    }

    IEnumerator Shake()
    {
        for (int i = 0; i < 85; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, 0f), (float)i / 85f);
            yield return null;
        }

        for (int i = 0; i < 12; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, minAngle), (float)i / 12f);
            yield return null;
        }

        for (int i = 0; i < 9; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, maxAngle), (float)i / 9f);
            yield return null;
        }

        for (int i = 0; i < 10; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, minAngle), (float)i / 10f);
            yield return null;
        }

        for (int i = 0; i < 9; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, maxAngle), (float)i / 9f);
            yield return null;
        }

        for (int i = 0; i < 10; i++)
        {
            GetComponent<RectTransform>().rotation = Quaternion.Lerp(GetComponent<RectTransform>().rotation, Quaternion.Euler(0f, 0f, minAngle), (float)i / 10f);
            yield return null;
        }

        for (int i = 0; i < 170; i++)
        {
            yield return null;
        }

        GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
        StartCoroutine("Shake");
    }
}
