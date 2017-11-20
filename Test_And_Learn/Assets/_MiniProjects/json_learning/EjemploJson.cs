using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EjemploJson : MonoBehaviour {

	string filePath;
	string jsonString;

	void Awake()
	{
		//json file path inside our project
		filePath = Application.dataPath + "/json_learning/Personajes.json";
		//super string of json stuff
		jsonString = File.ReadAllText (filePath);

		ListaPersonajes listaPersonajes = JsonUtility.FromJson<ListaPersonajes> (jsonString);
		listaPersonajes.Listar ();


		try{ // This is to avoid errors
			listaPersonajes.personajes.Find (p => p.nombre == "Arturo").profesion = "Rey de Bretaña";
			jsonString = JsonUtility.ToJson (listaPersonajes);
			File.WriteAllText (filePath, jsonString);
		}

		catch (System.NullReferenceException e)
		{
			print ("Personaje no encontrado: " + e);
		}

	}


		

	[System.Serializable]
	public class Personaje
	{
		public string nombre;
		public string profesion;
		public int nivel;

		public override string ToString ()
		{
			return string.Format ("{0}: {1} nivel {2}", nombre, profesion, nivel);
		}
	}

	[System.Serializable]
	public class ListaPersonajes
	{
		//personajes tiene que coincidir con el archivo json Personajes
		public List<Personaje> personajes;

		public void Listar()
		{
			foreach (var item in personajes) 
			{
				Debug.Log (item);
			}
		}
	}
}
