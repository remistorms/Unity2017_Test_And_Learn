using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DogPanel : MonoBehaviour {

	public Button SendButton;
	public string name, breed, age, size, notes;
	public TMP_InputField text_name, text_breed, text_age, text_notes;
	public TMP_Dropdown drop_size;

	void FixedUpdate()
	{
		FillAllString ();

		if (name == "" || breed == "" | age == "" || notes == "") {
			SendButton.interactable = false;
		} 
		else 
		{
			SendButton.interactable = true;
		}
	}

	public void FillAllString()
	{
		name = text_name.text;
		breed = text_breed.text;
		age = text_age.text;
		notes = text_notes.text;

		switch (drop_size.value) {
			case 0:
			size = "chico";
			break;

			case 1:
			size = "mediano";
			break;

			case 3:
			size = "grande";
			break;
		}
	}

	public void SendNewDog()
	{
		perros_spreadsheet.instance.SendDogData (name, breed, age, size, notes);
		text_name.text = "";
		text_breed.text = "";
		text_age.text = "";
		text_notes.text = "";
	}


}
