using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class SimpleForceBehaviour : MonoBehaviour {

	public Vector3 Force = Vector3.zero;

	private float spendTime = 0;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		this.rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		this.spendTime += Time.deltaTime;
		if (this.spendTime >= 1f) {
			rb.AddForce (this.Force, ForceMode.VelocityChange);
			Destroy (this);
		}
	
	}
}
