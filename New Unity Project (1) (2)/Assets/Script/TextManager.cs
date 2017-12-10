using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public GameObject 건물설명;
	void OnTriggerEnter(Collider other)
	{
		건물설명.SetActive (true);
	}
}
