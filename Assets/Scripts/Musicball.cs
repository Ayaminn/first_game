using UnityEngine;
using System.Collections;

public class Musicball : MonoBehaviour {
    private float timer = 0f;
    public Transform target;
    public float speed;
    public float destroytimer = 5f;
	// Use this for initialization
	void Start () {
        transform.LookAt(target);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > destroytimer)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            if (Input.GetKeyDown("space")) {
                if (Vector3.Distance(other.transform.position, transform.position) < 1.0f)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
