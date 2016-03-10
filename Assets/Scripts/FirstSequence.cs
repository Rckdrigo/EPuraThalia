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
        Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.Hidden);
        //yield return new WaitForEndOfFrame();
        AsyncOperation async = Application.LoadLevelAsync(nextScene);
        yield return async;
        Debug.Log("Loading complete");
    }

}
