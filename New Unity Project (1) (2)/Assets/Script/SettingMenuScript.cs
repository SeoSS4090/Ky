using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class SettingMenuScript : MonoBehaviour {

	public GameObject audiopanel;
	public GameObject TeleportPanel;
	int Audiocount = 0;
	int TeleportCount = 0;
	public Slider audioslider;
	public AudioSource audiosource;


	public void ClickQuitButton()
	{
		Debug.Log ("QUIT");
		Application.Quit ();
	}

	public void ClickAudioButton()
	{
		audioslider.value = audiosource.volume;
		if (Audiocount%2 != 1)
			audiopanel.SetActive (true);
		else
			audiopanel.SetActive (false);

		Audiocount++;
	}

	public void ClickTeleportButton()
	{

		if (TeleportCount%2 != 1)
			TeleportPanel.SetActive (true);
		else
			TeleportPanel.SetActive (false);

		TeleportCount++;
	}

	public void ClickDirectByButton()
	{
		SceneManager.LoadScene ("DirectBy");
	}



}
