using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalkerScript : MonoBehaviour
{
    public GameObject cube;
    public float speed = 5f;
    public Transform target;
    private float seeDistance = 10f;
    private float attackDistance = 0.5f;
    void OnTriggerEnter(Collider other)
    {
        target = GameObject.FindWithTag("Person").transform;
    }

    private void Update()
    {
        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
            {
                if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
                {
                    Debug.Log(Vector3.Distance(transform.position, target.transform.position));
                    transform.LookAt(target.transform);
                    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                }
            }

        }

    }
}

