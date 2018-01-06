using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    public Slider Volume;
    public AudioSource Music;
	
	// Update is called once per frame
	void Update ()
    {
        //volume will be the value on the slider
        Music.volume = Volume.value;
	}
}
