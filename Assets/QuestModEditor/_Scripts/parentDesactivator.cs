using UnityEngine;
using System.Collections;

public class parentDesactivator : MonoBehaviour {

	private GameObject parent;

	void Start () 
	{
		parent = transform.parent.gameObject; // pointe le parent
	}
	
	// Update is called once per frame
	public void DesactivateParent()
	{
		parent.SetActive (false);
	}
}
