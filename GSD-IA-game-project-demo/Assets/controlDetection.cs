using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlDetection : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;

    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.1f, layer))
        {
 
            Vector3 movementDirection = (transform.position - previousPos).normalized;

            if (Vector3.Angle(movementDirection, hit.transform.up) > 130)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position;
    }
}