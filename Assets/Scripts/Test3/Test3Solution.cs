using UnityEngine;
using System.Collections;


public class Test3Solution : MonoBehaviour {

    public GameObject[] vagoni;

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        for (int index = 0; index < vagoni.Length; index++)
        {
            Debug.Log(vagoni[index].name);
        }
    }
}
