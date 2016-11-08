using UnityEngine;
using System.Collections;

public class EnableUI : MonoBehaviour {

	public GameObject UI;

	void Update() 
	{
		if (Input.GetButtonDown ("Cancel"))
			UI.SetActive (true);
	}
}