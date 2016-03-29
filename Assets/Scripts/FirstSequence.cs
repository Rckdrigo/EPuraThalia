using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Vuforia;

public class FirstSequence : MonoBehaviour
{
    public GameObject scenario, thalia, epura, bottle, button;
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
        yield return new WaitForSeconds(3f);
        Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.Hidden);
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        Destroy(scenario);
        thalia.SetActive(true); 
        yield return new WaitForSeconds(7f);
        thalia.SetActive(false);
        epura.SetActive(true);
        bottle.SetActive(true);
        button.SetActive(true);
    }

    public void Quit()
    {
        SceneManager.LoadScene(1);
    }
}
