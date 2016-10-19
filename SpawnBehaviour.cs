using UnityEngine;
using System.Collections;

public class SpawnBehaviour : MonoBehaviour {

	public GameObject Prefab;
	public bool IsLoop = false;
	public float IntervalTime = 1f;

	private float spendTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.spendTime += Time.deltaTime;
		if (this.spendTime >= this.IntervalTime) {
			GameObject.Instantiate (Prefab);

			if (this.IsLoop) {
				this.spendTime -= this.IntervalTime;
			} else {
				Destroy (this);
			}
		}
	
	}
}
