using UnityEngine;
using System.Collections;

public class DialerEndQ : MonoBehaviour {

	public GameObject pageToRead;
	private GameObject root;
	private GameObject header;
	private GameObject bubble;
	private GameObject collisions;
	private GameObject statusInfo;
	private GameObject statusNewQ;
	private GameObject statusQup;
	private GameObject statusEndQ;
	private GameObject character;
	private GameObject notifQup;
	private randomAudioPlayer _scriptRandomAudioPlayer;
	private Animation anim;

	void Awake ()
	{
		root = transform.parent.parent.parent.gameObject; // pointe "ROOT"
		header = root.transform.Find("GUI/HEADER").gameObject; // pointe "HEADER"
		bubble = root.transform.Find("MOBILE_pos/bubble_pos").gameObject;
		collisions = root.transform.Find("MOBILE_pos/STATUS_trm").gameObject; // pointe "Collisions"
		statusInfo = root.transform.Find("MOBILE_pos/icons_pos/info_trm").gameObject; // pointe "info_trm"
		statusNewQ = root.transform.Find("MOBILE_pos/icons_pos/newQ_trm").gameObject; // pointe "newQ_trm"
		statusQup = root.transform.Find("MOBILE_pos/icons_pos/Qup_trm").gameObject; // pointe "Qup_trm"
		statusEndQ = root.transform.Find("MOBILE_pos/icons_pos/endQ_trm").gameObject; // pointe "endQ_trm"
		character = root.transform.Find("MOBILE_pos/character_scl/character_sprite").gameObject; // pointe "character_sprite"
		notifQup = root.transform.Find("GUI/NOTIFICATIONS/quest_update").gameObject; // pointe la notif "new_quest"
		_scriptRandomAudioPlayer = character.GetComponent<randomAudioPlayer>(); // cherche l'audio de "character"
		anim = character.GetComponent<Animation>(); // cherche l'animation de "character"
	}

	void Start()
	{
		notifQup.SetActive(true);
	}

	void OnEnable ()
	{
		statusInfo.SetActive(false);
		statusNewQ.SetActive(false);
		statusQup.SetActive(false);
		statusEndQ.SetActive(true);
	}

	void OnMouseEnter()
	{
		bubble.SetActive(true);
	}

	void OnMouseExit()
	{
		bubble.SetActive(false);
	}

	void OnMouseDown()
	{
		if (pageToRead)
		{
			pageToRead.SetActive(true);
			header.SetActive(true);
			collisions.SetActive(false);
			bubble.SetActive(false);
			anim.CrossFade("hello");
			_scriptRandomAudioPlayer.RandomAudioPlayHello();
		}
		else
		{
			Debug.Log("pas de page à lire");
		}
	}
}
