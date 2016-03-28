using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour {

	
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
