using UnityEngine;
using System.Collections;

public class Loot : MonoBehaviour {

	private GameObject loot;
	private GameObject hover;
	private GameObject quest;
	private LootQuest _lootQuest;

	void Start ()
	{
		loot = transform.parent.gameObject;
		hover = loot.transform.Find("hover_root").gameObject;
		quest = transform.parent.parent.parent.parent.gameObject;
		_lootQuest = quest.GetComponent<LootQuest>();
	}

	void OnMouseEnter()
	{
		hover.SetActive(true);
	}

	private void OnMouseExit()
	{
		hover.SetActive(false);
	}

	void OnMouseDown()
	{
		_lootQuest.CounterPlus();
		loot.SetActive(false);
	}
}
