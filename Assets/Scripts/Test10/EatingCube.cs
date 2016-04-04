using UnityEngine;
using System.Collections;

public class EatingCube : MonoBehaviour {

    int cubePoints;    
    public TextMesh textmesh;
    public GameObject stars;
    public float speed;
    //int starPoints;
    public int force;
    Rigidbody rigiddbody;


    
    // Use this for initialization
    void Start () {
        Vector3 randomPosition = new Vector3(Random.Range(-3.50f, 3.50f), Random.Range(0.98f, 2f), Random.Range(-3.50f, 3.50f));
        Instantiate(stars, randomPosition, Quaternion.identity);

        transform.position = new Vector3(0f, 0.98f, 0f);          
        rigiddbody = GetComponent<Rigidbody>();
        //starPoints = Random.Range(1, 10);

    }
	
	// Update is called once per frame
	void Update () {

        
        textmesh.text = cubePoints.ToString() + " points"; 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigiddbody.AddForce(Vector3.up * force);
       
        }
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;

	
	}

    void OnCollisionEnter(Collision col)
    {
        //print("Collited with: " + col.gameObject.name);
        if (col.gameObject.tag == "star")
        {
            Destroy(col.gameObject);
            //cubePoints += starPoints;
            cubePoints += col.gameObject.GetComponent<Star>().points;
            Vector3 randomPosition = new Vector3(Random.Range(-3.50f, 3.50f), Random.Range(0.98f, 2f), Random.Range(-3.50f, 3.50f));
            Instantiate(stars, randomPosition, Quaternion.identity);
            //starPoints = Random.Range(1, 10);
        }
        

    }
}
