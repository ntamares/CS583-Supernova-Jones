using UnityEngine;
using System.Collections;

public class FP_shoot : MonoBehaviour {
    public GameObject bullet;
   // public GameObject gun;
    public float bulletImpulse = 20f;
    public AudioClip gunshot;
    AudioSource gunshotSrc;
   // public int enemy_hits = 3;
   // public int num_enemy = 20;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V)){
            gunshotSrc = gameObject.AddComponent<AudioSource>();
            gunshotSrc.clip = gunshot;
            gunshotSrc.Play();
            Camera cam = Camera.main;
            GameObject thebullet = (GameObject) Instantiate(bullet, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
           

        }
	}
}
