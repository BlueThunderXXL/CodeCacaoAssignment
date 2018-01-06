
ASSIGNMENT

This project was intended to serve as a small show-case of an assignment for a company Code Cacao which was made in 8 hours to show my capability in that given time.


CODE EXAMPLE

using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using 
UnityEngine.UI;



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


MOTIVATION

Motivation behind the project was to showcase what kind of development work was able to be created within the 8 working hours (with documentation) as a follow-up to a job interview for a company Code Cacao.

GENERAL IDEA

General idea of this app is to carry the ball over the moving platform to the panel which includes 80 collectibles.

INSTALATION

Engine in which this app was created was Unity 2017.2.0f3

This application comes as a standalone without any particular needs of instalation. It runs on a double-click to the .exe file

LICENCE

This application falls under the public domain and is available on-demand. Author grants every right to use and modify this software in their own liking.

