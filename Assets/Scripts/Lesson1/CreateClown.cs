using UnityEngine;
using System.Collections;

public class CreateClown : MonoBehaviour {

    public GameObject clown;

    void OnMouseDown()
    {
        Instantiate(clown, transform.position, transform.rotation);
    }
}
