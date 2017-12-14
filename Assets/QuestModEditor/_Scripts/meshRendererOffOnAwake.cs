using UnityEngine;
using System.Collections;

public class meshRendererOffOnAwake : MonoBehaviour {

	private MeshRenderer meshRend;

	void Start ()
	{
		meshRend = GetComponent<MeshRenderer>();
		meshRend.enabled = false;

	}
}
