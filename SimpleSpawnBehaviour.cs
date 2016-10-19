using UnityEngine;
using System.Collections;

public class SimpleSpawnBehaviour : MonoBehaviour {

	public GameObject Prefab;

	private float spendTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.spendTime += Time.deltaTime;
		if (this.spendTime >= 1f) {
			GameObject.Instantiate (Prefab);
			Destroy (this);
		}
	}
}
