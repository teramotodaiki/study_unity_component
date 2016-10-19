using UnityEngine;
using System.Collections;

public class TranslateBehaviour : MonoBehaviour {

	public float IntervalTime = 1f;
	public Vector3[] Movements;

	private float spendTime = 0;
	private int seek = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.spendTime += Time.deltaTime;
		if (this.spendTime >= this.IntervalTime * (this.seek + 1)) {
			
			if (this.Movements.Length > this.seek) {
				this.transform.Translate (this.Movements [this.seek]);
			} else {
				Destroy (this);
			}
			this.seek++;

		}

	}
}
