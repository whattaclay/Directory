using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TransformRotateAround : MonoBehaviour
{
    [SerializeField] private GameObject centerPoint;
    [SerializeField] private Vector3 axis;
    [SerializeField] private float rotationSpeed;
    void Update()
    {
        transform.RotateAround(centerPoint.transform.position, axis , rotationSpeed);         
    }
}
