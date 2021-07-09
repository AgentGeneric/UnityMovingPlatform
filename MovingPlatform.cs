using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform start;
    public Transform end;
    private Vector3 dir;

    private Transform target;
    public bool Moving;
    public float platformSpeed = 2f;
    private float distance;

    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Moving)
        {
            dir = end.position - transform.position;
            transform.position += dir.normalized * Time.deltaTime * platformSpeed;
            distance = Vector3.Distance(transform.position, end.position);
            if (distance < 1)
            {
                Moving = false;
            }
        }

        if (!Moving)
        {
            dir = start.position - transform.position;
            transform.position += dir.normalized * Time.deltaTime * platformSpeed;
            distance = Vector3.Distance(transform.position, start.position);
            Debug.Log(distance);
            if (distance < 1)
            {
                Moving = true;
            }

        }
    }
}
