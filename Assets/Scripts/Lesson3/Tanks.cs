using UnityEngine;
using System.Collections;

public class Tanks : MonoBehaviour {

    public Transform point1;
    public Transform point2;
    public float speed = 2;

    Vector3 target;
	// Use this for initialization
	void Start () {
        transform.position = point1.position;
        target = point2.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            if (target == point1.position)
            {
                target = point2.position;
            } else
            {
                target = point1.position;
            }
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

        Vector3 direction = target - transform.position;
        direction = direction.normalized;
        transform.position += direction * Time.deltaTime * speed;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(direction * 360f), Time.deltaTime * speed);

    }
}
