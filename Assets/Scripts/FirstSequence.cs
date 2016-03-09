using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Vuforia;

public class FirstSequence : MonoBehaviour
{
    public string nextScene;
    public GameObject scenario;
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
        yield return new WaitForSeconds(2f);
        scenario.SetActive(false);
        Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.Hidden);
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        SceneManager.LoadScene(nextScene);
    }

}
