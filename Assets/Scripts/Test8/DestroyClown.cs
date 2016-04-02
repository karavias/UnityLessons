using UnityEngine;
using System.Collections;

public class DestroyClown : MonoBehaviour
{
    
    float totalTime = 3;
    float passedTime;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        passedTime += Time.deltaTime;
        if (passedTime > totalTime)
        {

            passedTime = 0f;
            //execute code every 3 seconds.
            Destroy(gameObject);
            // Debug.Log("destroyed");


        }
    }
}
