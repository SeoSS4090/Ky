using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuscript : MonoBehaviour {
	public GameObject mainmenupanel;
	public GameObject LoadPanel;
	public Slider loadingslider;
	public Text progressText;
	public void PlayGame()
	{
		LoadPanel.SetActive (true);
		StartCoroutine (LoadAsynchronously ("main"));
	}
	IEnumerator LoadAsynchronously (string sceneName)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneName);

		while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress / .9f);
			loadingslider.value = progress;
			progressText.text = progress * 100f + "%";

			yield return null;
		}
	}

	public void QuitGame()
	{
		Debug.Log ("Quit");
		Application.Quit ();
	}
}
