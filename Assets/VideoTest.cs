using UnityEngine;
using System.Collections;

public class VideoTest : MonoBehaviour
{

    void Start()
    {

        Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.Hidden);
        //StartCoroutine("PlayVideo");
    }

    IEnumerator PlayVideo()
    {

        Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.Hidden);
        yield return new WaitForEndOfFrame();
        print("HOla");
    }
}
