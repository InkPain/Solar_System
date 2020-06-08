using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCamera : MonoBehaviour
{
    public Transform target;
    Vector3 _position;
    // Start is called before the first frame update
    void Start()
    {
        _position = target.InverseTransformPoint(transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var currentPosition = target.TransformPoint(_position);
        transform.position = currentPosition;
        transform.LookAt(target);
    }
}
