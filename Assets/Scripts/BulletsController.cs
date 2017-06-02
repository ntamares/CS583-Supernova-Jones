using UnityEngine;
using System.Collections;

public class BulletsController : MonoBehaviour {

	float bulletSpeed = 2;
   // public GameObject player;
	// Use this for initialization
	void Start () {
		//Destroy (this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, bulletSpeed);
	}

    void LateUpdate()
    {
        Destroy(this.gameObject, 1);
    }
}
