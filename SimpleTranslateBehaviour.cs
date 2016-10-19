using UnityEngine;
using System.Collections;

public class SimpleTranslateBehaviour : MonoBehaviour {

	public Vector3 Movement;

	private float spendTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.spendTime += Time.deltaTime;
		if (this.spendTime >= 1f) {
			this.transform.Translate (this.Movement);
			Destroy (this);
		}

	}
}
