using UnityEngine;
using System.Collections;

public class RandomCubes : MonoBehaviour {

    public GameObject cubePrefab;

	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 randomPosition = new Vector3(Random.Range(-4, 4), Random.Range(0, 4), Random.Range(-4, 4));
            Instantiate(cubePrefab, randomPosition, Quaternion.identity);
            //cubePrefab.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
	}
}
