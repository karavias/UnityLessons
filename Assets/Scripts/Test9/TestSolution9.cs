using UnityEngine;
using System.Collections;

public class TestSolution9 : MonoBehaviour
{
    public GameObject[] points;
    Vector3 target;
    public int speed = 2;


    // Use this for initialization
    void Start()
    {
        transform.position = points[0].transform.position;
        target = points[1].transform.position;

    }

    // Update is called once per frame
    void Update()
    {



        if (Vector3.Distance(transform.position, points[1].transform.position) < 0.05f)
        {
            transform.position = points[1].transform.position;
            target = points[2].transform.position;
            

        }
        if (Vector3.Distance(transform.position, points[2].transform.position) < 0.1f)
        {
            //transform.position = points[2].transform.position;
            Destroy(gameObject);
        }
        Vector3 direction = target - transform.position;
        direction = direction.normalized;
        transform.position += direction * Time.deltaTime * speed;



    }
}
