using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascript : MonoBehaviour {

	public GameObject CameraObject;
	void Update( )
	{
		if( Input.GetKeyDown( KeyCode.M))
			CameraObject.SetActive(false);

		if( Input.GetKeyUp( KeyCode.M))
			CameraObject.SetActive(true);
	}
}
