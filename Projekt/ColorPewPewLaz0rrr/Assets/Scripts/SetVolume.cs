﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour {

	public AudioMixer mixer;

	public void SetLevel (float sliderWert)
	{
		mixer.SetFloat("MasterVolume", Mathf.Log(sliderWert) * 20);
	}
}