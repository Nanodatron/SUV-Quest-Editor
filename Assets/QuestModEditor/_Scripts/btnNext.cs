using UnityEngine;
using System.Collections;

public class btnNext : MonoBehaviour {

	public GameObject nextPage;
	private GameObject root;
	private GameObject pageParent;
	private GameObject character;

	private randomAudioPlayer _scriptRandomAudioPlayer;

	void Start()
	{
		root = transform.parent.parent.parent.gameObject; // pointe "ROOT"
		pageParent = transform.parent.gameObject; // pointe "page"
		character = root.transform.Find ("MOBILE_pos/character_scl/character_sprite").gameObject; // pointe "character"
		_scriptRandomAudioPlayer = character.GetComponent<randomAudioPlayer>();
	}

	public void Next()
	{
		if (nextPage)
		{
			_scriptRandomAudioPlayer.AudioPlayNext();
			nextPage.SetActive(true);
			pageParent.SetActive(false);
		}
		else
		{
			Debug.Log("pas de page suivante à lire");
		}

	}
}
