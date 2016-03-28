using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour {
    float totalTime;
    float passedTime = 0f;
    public GameObject cubePrefab;

    // Use this for initialization
    void Start () {
	
	}

 
    // Update is called once per frame
    void Update () {
        totalTime = Random.Range(0.5f, 1.5f); 
        passedTime += Time.deltaTime;
        if (passedTime > totalTime)
        {
            Debug.Log(passedTime);
            passedTime = 0f;
            //execute code every 1 second.
            Instantiate(cubePrefab, new Vector3(Random.Range(-4f, 4f), 7.6f,0), Quaternion.identity);
            
        }
	}
}
