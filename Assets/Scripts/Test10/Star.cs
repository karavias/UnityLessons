using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
    public int points;

    

	// Use this for initialization
	void Start () {
        points = Random.Range(1, 10);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
