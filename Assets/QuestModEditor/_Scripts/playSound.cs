using UnityEngine;
using System.Collections;

public class playSound : MonoBehaviour {

	private AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void AudioPlay()
	{
		audioSource.Play ();
	}
}
