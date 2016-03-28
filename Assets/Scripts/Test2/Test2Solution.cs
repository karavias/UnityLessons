using UnityEngine;
using System.Collections;


public class Test2Solution : MonoBehaviour
{


    public GameObject marriedWith;

    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        Debug.Log(marriedWith.name);
    }

}