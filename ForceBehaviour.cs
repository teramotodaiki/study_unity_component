using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class ForceBehaviour : MonoBehaviour {

	public float IntervalTime = 1f;
	public Vector3[] Forces;

	private float spendTime = 0;
	private int seek = 0;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		this.rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		this.spendTime += Time.deltaTime;
		if (this.spendTime >= this.IntervalTime * (this.seek + 1)) {

			if (this.Forces.Length > this.seek) {
				this.rb.AddForce (this.Forces [this.seek], ForceMode.VelocityChange);
			} else {
				Destroy (this);
			}
			this.seek++;

		}

	}
}
