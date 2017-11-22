using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleSheetsToUnity;
using TMPro;
using UnityEngine.UI;

public class perros_spreadsheet : MonoBehaviour {

	public static perros_spreadsheet instance;
	SpreadSheetManager spreadsheet_manager;
 	GS2U_SpreadSheet spreadsheet;
	GS2U_Worksheet worksheet;

	[Header("Spreadsheet Details")]
	public string debug_string;
	public Vector2 ws_size;
	public List<string> worksheets_names;
	public List<string> column_titles;
	//public List<string> row_titles;

	void Start()
	{
		instance = this;
		spreadsheet_manager = new SpreadSheetManager ();
		//GetSpreadsheetData ("Remi Testing Spreadsheed");
	}

	public void GetSpreadsheetData(string spreadsheetName)
	{
		Debug.Log ("Loading " + spreadsheetName);
		spreadsheet = spreadsheet_manager.LoadSpreadSheet (spreadsheetName);
		worksheet = spreadsheet.LoadWorkSheet (0);
		column_titles = worksheet.GetColumnTitles ();
		ws_size = worksheet.GetWorksheetSize ();
	}

	public void GetWorksheetData(string worksheetName)
	{
		Debug.Log ("Loading " + worksheetName);
		worksheet = spreadsheet.LoadWorkSheet (worksheetName);
	}

	public void SendDogData(string name, string breed, string age, string size, string notes)
	{
		worksheet.AddRowData(new Dictionary<string, string>
			{
				//NOTE: all data names are in lower case
				{"nombre", name},
				{"raza", breed},
				{"edad", age},
				{"tamaño", size},
				{"notas", notes}
			});
	}
}
