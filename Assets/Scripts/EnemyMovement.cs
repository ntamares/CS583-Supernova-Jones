using UnityEngine;
using System.Collections;


public class EnemyMovement : MonoBehaviour {

    Transform target;
    NavMeshAgent nav;
    public int hitpoints = 3;
    public AudioClip scream;
    AudioSource screamSrc;
    public AudioClip die;
    AudioSource dieSrc;
    public AudioClip explode;
    AudioSource explodeSrc;
   // float aggroDistance = 7.5f;
    float distanceFromPlayer;
    public GameObject explosion;
    //MeshRenderer rend;
    // public int num_aliens = 20;
    //private SerializeField explosion; ParticleSystem;
	// Use this for initialization
	void Awake () {

        // Sets the player as the target
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        nav = GetComponent<NavMeshAgent>();

    }

	void Start(){
        //rend.enabled = true;
       // gameObject.GetComponent<ParticleSystem>().enableEmission = false;
	}
	// Update is called once per frame
	void Update () {

        // Enemy follows the player
        //if (distanceFromPlayer < aggroDistance)
        nav.SetDestination(target.position);
	}

    void FixedUpdate()
    {
        distanceFromPlayer = Vector3.Distance(target.position, transform.position);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullets")
        {
            screamSrc = gameObject.AddComponent<AudioSource>();
            screamSrc.clip = scream;
            screamSrc.PlayOneShot(scream, 2f);
            hitpoints--;
           // Debug.Log(hitpoints);
			//Blink (10);
            if (hitpoints < 2)
            {
                PlayDieSound();
                explodeSrc = gameObject.AddComponent<AudioSource>();
                explodeSrc.clip = explode;
                explodeSrc.PlayOneShot(explode, 1f);
            }
            if (hitpoints < 1)
            {

                Instantiate(explosion, transform.position, transform.rotation);
               
               
                //PlayDieSound();
                Destroy(gameObject);
              
               
                // gameObject.GetComponent<ParticleSystem>().enableEmission = false;
                // Debug.Log("Destroyed");
            }
        }
    }

   
    void PlayDieSound()
    {
        dieSrc = gameObject.AddComponent<AudioSource>();
        dieSrc.clip = die;
        dieSrc.Play();
    }
/*	void Blink(int numBlinks){
		StartCoroutine (startBlink (numBlinks, 0.2f));
	}

	IEnumerator startBlink(int numBlinks, float seconds){
		for(int i=0; i<numBlinks*2; i++){
			rend.enabled = !rend.enabled;

			yield return new WaitForSeconds(seconds);
		}

		rend.enabled = true;
	}
    */
}
