using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenRes : MonoBehaviour
{
    // [SerializeField] Toggle toggle;
    // public void QuitGame()
    // {
    //     Application.Quit();
    // }

   private void Awake()
   {
        //set screen for standalone
    #if UNITY_STANDALONE
            Screen.SetResolution(720, 1280, false);
            Screen.fullScreen = false;
    #endif
   }
    // public void SetFullscreen(bool _fullscreen)
    // {
    //     Screen.fullScreen = _fullscreen;
    //     if (toggle.isOn == true)
    //         Debug.Log("Screen Maximize");
    //     else
    //         Debug.Log("Screen Minimize");
    // }
}
