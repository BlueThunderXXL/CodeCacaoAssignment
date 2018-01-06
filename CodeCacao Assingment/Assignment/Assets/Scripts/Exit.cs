using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
   public void DoQuit()
    {
        Debug.Log("Has Quit");
        Application.Quit();
    }
}
