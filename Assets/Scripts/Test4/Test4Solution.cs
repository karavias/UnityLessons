using UnityEngine;
using System.Collections;

public class Test4Solution : MonoBehaviour
{
    public GameObject[] link;
    private int k = 0;

    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        Debug.Log(link[k % 2].name);
        k += 1;
    }

    void Update()
    {
        Debug.Log(k);
    }
}
