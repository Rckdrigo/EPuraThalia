using UnityEngine;
using System.Collections;
using Vuforia;

public class CommercialSequence : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite second;

    public GameObject button;
    bool started;

    void Start()
    {
        DefaultTrackableEventHandler.Found += () =>
        {
            if (!started)
            {
                started = true;
                StartCoroutine(VideoSequence());
            }
        };
    }

    IEnumerator VideoSequence()
    {
        yield return new WaitForSeconds(2f);
        Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
        yield return new WaitForSeconds(2f);
        renderer.sprite = second; 
        yield return new WaitForSeconds(5f);
        renderer.gameObject.SetActive(false);
        button.SetActive(true);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

}
