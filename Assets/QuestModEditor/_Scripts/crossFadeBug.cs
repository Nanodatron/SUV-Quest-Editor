using UnityEngine;
using System.Collections;

public class crossFadeBug : MonoBehaviour {

	private Animation anim;

	void Start()
	{
		anim = GetComponent<Animation> ();
	}

	void AnimDebug()
	{
		anim.CrossFade ("idle");
	}
}
