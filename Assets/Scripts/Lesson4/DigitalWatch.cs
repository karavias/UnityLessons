using UnityEngine;
using System.Collections;

public class DigitalWatch : MonoBehaviour {


    public TextMesh textMesh;

    float seconds = 0f;

	// Update is called once per frame
	void Update () {
        seconds += Time.deltaTime;
        textMesh.text = (int)(seconds / 60) + ":" + (int)(seconds % 60);
	}
}
