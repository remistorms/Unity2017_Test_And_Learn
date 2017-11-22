using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dogs_UI : MonoBehaviour {


	public static Dogs_UI instance;
	public GameObject[] panels;
	public perros_spreadsheet spreadsheet_ref;

	public TMP_InputField dog_name, dog_breed, dog_age, dog_notes;
	public TMP_Dropdown size_dropdown;

	void Start()
	{
		instance = this;

		foreach (var item in panels) 
		{
			item.GetComponent<RectTransform> ().offsetMax = Vector2.zero;
			item.GetComponent<RectTransform> ().offsetMin = Vector2.zero;
			item.SetActive (false);
		}

		panels [0].SetActive (true);
	}

	public void SwitchUIPanel(int id)
	{
		foreach (var item in panels) 
		{
			item.SetActive (false);	
		}

		panels [id].SetActive (true);
	}
}
