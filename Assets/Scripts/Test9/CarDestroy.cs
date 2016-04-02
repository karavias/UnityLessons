using UnityEngine;
using System.Collections;

public class CarDestroy : MonoBehaviour {
    public GameObject point3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position == point3.transform.position)
        {
            Destroy(gameObject);
        }
	
	}
}
