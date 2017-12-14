using UnityEngine;
using System.Collections;

public class Temoin : MonoBehaviour {

	public GameObject[] activerGo;
	public GameObject[] desactiverGo;

	void Start()
	{
		if (activerGo.Length > 0)
		{
			Activer();
		}
		if (desactiverGo.Length > 0)
		{
			Desactiver();
		}
	}

	void Activer()
	{
		for (int i = 0; i < activerGo.Length; i++)
		{
			activerGo[i].SetActive(true);
		}
	}

	void Desactiver()
	{
		for (int j = 0; j < desactiverGo.Length; j++)
		{
			desactiverGo[j].SetActive(false);
		}
	}

}
