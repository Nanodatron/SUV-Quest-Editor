using UnityEngine;
using System.Collections;

public class LootQuest : MonoBehaviour {

	public int quota = 0;
	private int count = 0;
	private AudioSource audioSource;
	public GameObject oldStatusNPC;
	public GameObject nextStatusNPC;
	private GameObject lootablesGo;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		lootablesGo = transform.Find("ROOT/lootables").gameObject;
	}

	public void CounterPlus()
	{
		count++;
		audioSource.Play();
		EndLootCheck();
	}

	void EndLootCheck()
	{
		if (count == quota)
		{
			SetActivesInactives();
		}
		else return;
	}

	void SetActivesInactives()
	{
		print("Quête Mise à Jour");
		nextStatusNPC.SetActive(true);
		oldStatusNPC.SetActive(false);
		lootablesGo.SetActive(false);
		// (modifier le script du bouton quête finie en rajoutant une variable du script, en public et une pour le GO "témoin", puis activer le témoin et lancer la fonction de check() du Qmanager
		// enfin, en tout dernier, il désactive le parent contenant tous les objets à Looter s'il en reste. (lootables)
	}
}
