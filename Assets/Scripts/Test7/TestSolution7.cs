using UnityEngine;
using System.Collections;

public class TestSolution7 : MonoBehaviour {
    public GameObject[] poionAgapaei;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnMouseDown()
    {
        Debug.Log(" H Sonia agapaei ton " + poionAgapaei[Random.Range(0, 3)].name);
        
    }
	
    
    // Update is called once per frame
	void Update () {
	
	}
}
