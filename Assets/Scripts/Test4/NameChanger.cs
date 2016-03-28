using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NameChanger : MonoBehaviour {

    public List<string> possibleNames;
    public TextMesh label;

    float timeToChange = 5;
    float currentTime = 0;
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime > timeToChange)
        {
            currentTime = 0;
            gameObject.name = possibleNames[Random.Range(0, possibleNames.Count)];
            label.text = gameObject.name;
        }
	}
}
