using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicVolumeChange : MonoBehaviour {

	public Slider volume;
	public AudioSource BGM;
	void Start()
	{
		volume.value = 0.5f;
	}
	void Update () {
		BGM.volume = volume.value;
	}
}
