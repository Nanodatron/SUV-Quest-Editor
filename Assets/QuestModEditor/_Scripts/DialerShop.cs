using UnityEngine;
using System.Collections;

public class DialerShop : MonoBehaviour {

	public GameObject pageToRead;
	private GameObject root;
	private GameObject header;
	private GameObject bubble;
	private GameObject collisions;
	private GameObject statusInfo;
	private GameObject statusShop;
	private GameObject statusTravel;
	private GameObject statusNewQ;
	private GameObject statusQup;
	private GameObject statusQinfo;
	private GameObject statusEndQ;
	private GameObject character;
	private randomAudioPlayer _scriptRandomAudioPlayer;
	private Animation anim;

	void Awake ()
	{
		root = transform.parent.parent.parent.gameObject; // pointe "ROOT"
		header = root.transform.Find("GUI/HEADER").gameObject; // pointe "HEADER"
		bubble = root.transform.Find("MOBILE_pos/bubble_pos").gameObject;
		collisions = root.transform.Find("MOBILE_pos/STATUS_trm").gameObject; // pointe "Collisions"
		statusInfo = root.transform.Find("MOBILE_pos/icons_pos/info_trm").gameObject;
		statusShop = root.transform.Find("MOBILE_pos/icons_pos/shop_trm").gameObject;
		statusTravel = root.transform.Find("MOBILE_pos/icons_pos/travel_trm").gameObject;
		statusNewQ = root.transform.Find("MOBILE_pos/icons_pos/Qnew_trm").gameObject;
		statusQup = root.transform.Find("MOBILE_pos/icons_pos/Qup_trm").gameObject;
		statusQinfo = root.transform.Find("MOBILE_pos/icons_pos/Qinfo_trm").gameObject;
		statusEndQ = root.transform.Find("MOBILE_pos/icons_pos/Qend_trm").gameObject;
		character = root.transform.Find("MOBILE_pos/character_scl/character_sprite").gameObject; // pointe "character_sprite"
		_scriptRandomAudioPlayer = character.GetComponent<randomAudioPlayer>(); // cherche l'audio de "character"
		anim = character.GetComponent<Animation>(); // cherche l'animation de "character"
	}

	void OnEnable ()
	{
		statusInfo.SetActive(false);
		statusShop.SetActive(true);
		statusTravel.SetActive(false);
		statusNewQ.SetActive(false);
		statusQup.SetActive(false);
		statusQinfo.SetActive(false);
		statusEndQ.SetActive(false);
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
