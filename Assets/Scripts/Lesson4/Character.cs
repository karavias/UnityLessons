using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public float force = 10f;
    public float speed = 1f;
    Rigidbody rigidBody;

    // Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * force);
        }
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        //if (Input.GetAxis("Horizontal"))
	}

    void OnCollisionEnter(Collision col)
    {

        print("Collided with : " + col.gameObject.name);
        if (col.gameObject.tag == "star")
        {
            //col.gameObject.GetComponent<MyScript>().points;
            Destroy(col.gameObject);
        }
    }

}
