using UnityEngine;
using System.Collections;

public class SecondSequence : MonoBehaviour
{
    public GameObject thalia, epura;
    public GameObject button;

    void Start()
    {
        StartCoroutine("VideoSequence");
    }

    IEnumerator VideoSequence()
    {
        yield return new WaitForSeconds(3.5f);
        thalia.SetActive(false);
        epura.SetActive(true);
        button.SetActive(true);
    }

    public void Quit()
    {
        print("SAliendo");
        Application.Quit();
    }
}
