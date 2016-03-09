using UnityEngine;
using System.Collections;
using Vuforia;

public class SecondSequence : MonoBehaviour
{
    public GameObject thalia, epura;
    public GameObject button;
    bool started;

    void Start()
    {
        DefaultTrackableEventHandler.Found += () =>
        {
            if (!started)
            {
                started = true;
                StartCoroutine("VideoSequence");
            }
        };

    }

    IEnumerator VideoSequence()
    {
        yield return new WaitForSeconds(5f);
        thalia.SetActive(false);
        epura.SetActive(true);
        button.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
