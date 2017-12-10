using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
	public GameObject Player;
	static Vector3 SavePoint =new Vector3(-1173,5,-143);
	public void Save()
	{
		SavePoint = Player.transform.position;
	}

	public void LoadPosition()
	{
		Player.transform.position = SavePoint;
	}
}
