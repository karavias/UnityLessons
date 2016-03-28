using UnityEngine;
using System.Collections;

public class DestroyCube : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
	
	}

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
