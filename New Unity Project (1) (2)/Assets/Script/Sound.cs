using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour {

	public AudioSource audio;
	public AudioClip jumpSound;

	void Start () {
		this.audio = this.gameObject.AddComponent<AudioSource> ();
		this.audio.clip = this.jumpSound;
		this.audio.loop = true;
		this.audio.volume = 0.5f;
		this.audio.Play ();
	}
}
