using UnityEngine;
using System.Collections;

public class randomAudioPlayer : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip[] audiosHello;
	public AudioClip[] audiosBye;
	public AudioClip audioNext;
	public AudioClip audioQuestStart;
	public AudioClip audioQuestFinish;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void RandomAudioPlayHello()
	{
		int random = Random.Range (0, audiosHello.Length);
		audioSource.clip = audiosHello [random];
		audioSource.Play ();
	}

	public void RandomAudioPlayBye()
	{
		int random = Random.Range (0, audiosBye.Length);
		audioSource.clip = audiosBye [random];
		audioSource.Play ();
	}

	public void AudioPlayNext()
	{
		audioSource.clip = audioNext;
		audioSource.Play ();
	}

	public void AudioPlayQuestStart()
	{
		audioSource.clip = audioQuestStart;
		audioSource.Play ();
	}

	public void AudioPlayQuestFinish()
	{
		audioSource.clip = audioQuestFinish;
		audioSource.Play ();
	}
}