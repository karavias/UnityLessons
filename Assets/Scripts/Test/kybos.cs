using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class kybos : MonoBehaviour
{

    static List<kybos> cubeList = new List<kybos>();
    public int cube;
    //public GameObject prwtosKivos;

    // Use this for initialization
    void Start()
    {
        cubeList.Add(this);

    }

    void OnMouseDown()
    {
        //Debug.Log(gameObject.name);
        if (cube == 1)
        {
            Debug.Log(gameObject.name);
        }
        else if (cube == 2)
        {
            //Debug.Log(prwtosKivos.name);
            Debug.Log(GameObject.FindWithTag("prwtos").name);
        }
        else if (cube == 3)
        {
            for (int index = 0; index < cubeList.Count; index++)
            {
                Debug.Log(cubeList[index]);
            }
                    
            //Debug.Log("cool cube", "whatever cube", "all cube");
        }

    }


    void OnMouseUp()
    {



    }
}
