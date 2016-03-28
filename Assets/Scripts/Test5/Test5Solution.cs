using UnityEngine;
using System.Collections;

public class Test5Solution : MonoBehaviour {
    public GameObject clown;
    public GameObject[] cubePositions;
    int k;

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        
        if (k < 5)
        {
            Instantiate(clown, cubePositions[k].transform.position, Quaternion.identity);
            k += 1;
        }
        else if (k > 4 || k < 10)
        {
            Destroy(cubePositions[k]);
            k += 1;
        }
    }
}
