using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleSheetsToUnity;
using UnityEngine.UI;
using TMPro;

public class mySpreadsheet : MonoBehaviour {

	public TextMeshProUGUI label;
	public InputField player_input;

	public TMP_InputField row_input, col_input, new_data;

	SpreadSheetManager spreadSheetManager;
	GS2U_SpreadSheet test_sheet;
	GS2U_Worksheet work_sheet;

	public Vector2 ws_size;
	public List<string> column_titles;
	public List<string> row_titles;

	// Use this for initialization
	void Start () 
	{
		spreadSheetManager = new SpreadSheetManager ();
		test_sheet = spreadSheetManager.LoadSpreadSheet ("Remi Testing Spreadsheed");
		LoadWorkSheetData ("Jugadores");
	}

	public void LoadWorkSheetData(string worksheetName)
	{
		work_sheet = test_sheet.LoadWorkSheet (worksheetName);
		ws_size = work_sheet.GetWorksheetSize ();
		column_titles = work_sheet.GetColumnTitles ();
		row_titles = work_sheet.GetRowTitles ();
	}

	public void GetCellData()
	{
		LoadWorkSheetData ("Jugadores");
		string myString = GetRandomString();
		int myRandomInt = Random.Range (0, 7);

		CellData cell_data = work_sheet.GetCellData (myString, myRandomInt);
		label.text = "<color=#ff0000>Col:</color> " + myString + " <color=#0000ff>Row:</color> " + myRandomInt.ToString () + "\n" +" <color=#00ff00>Value:</color> " + cell_data.value;
	}

	public string GetRandomString()
	{
		string mystring = "";
		int myrandom = Random.Range (0, 4);
		switch (myrandom) 
		{
			case 0:
			mystring = "A";
			break;

			case 1:
			mystring = "B";
			break;

			case 2:
			mystring = "C";
			break;

			case 3:
			mystring = "D";
			break;
		}

		return mystring;
	}

	public void SetWorkSheetSize()
	{
		work_sheet.SetWorksheetSize (8,10);
		LoadWorkSheetData ("Jugadores");
	}

	public void InsertCellData()
	{
		work_sheet.AddRowData(new Dictionary<string, string>
			{
				//NOTE: all data names are in lower case
				{"nombre", "new_name"},
				{"ticket", "new_ticket"},
				{"premio", "new_premio"},
				{"resultado", "new_resultado"}
			});
	}

	public void InsertCell()
	{
		//work_sheet.ModifyCellData (col_input.text, System.Int32.Parse(row_input.text), new_data.text);
	}

	public void InsertRow()
	{
		//SpreadSheetManager manager = new SpreadSheetManager();
		//GS2U_Worksheet worksheet = manager.LoadSpreadSheet("Remi Testing Spreadsheet").LoadWorkSheet("Jugadores");
		work_sheet.AddRowData(new Dictionary<string, string>
			{
				//NOTE: all data names are in lower case
				{"nombre","new_name"},
				{"ticket", "new_ticket" },
				{"premio", "new_premio" },
				{"resultado", "new_resultado"}
			});
	}

		
}
