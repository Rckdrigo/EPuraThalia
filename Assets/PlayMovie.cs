using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour
{
    void Start()
    {
        //Handheld.PlayFullScreenMovie("Secuencia01b.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
        Handheld.PlayFullScreenMovie("https://www.youtube.com/watch?v=nhPaWIeULKk", Color.black, FullScreenMovieControlMode.CancelOnInput);
    }

}
