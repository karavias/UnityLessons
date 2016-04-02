using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateSolution8 : MonoBehaviour {
    public GameObject PrefabClown;
    public GameObject[] cubes;
    public int c;
    public GameObject[] createdClowns;
    int k;
   

    // Use this for initialization
    void Start () {
	
	}
	
    void OnMouseDown()
    {
        //createdClowns[k] = Instantiate(PrefabClown, cubes[Random.Range(0, 2)].transform.position, Quaternion.identity);
        //k+=1;
       Instantiate(PrefabClown, cubes[Random.Range(0, 3)].transform.position, Quaternion.identity);
    }


	// Update is called once per frame
	void Update () {   
     


    }
}
