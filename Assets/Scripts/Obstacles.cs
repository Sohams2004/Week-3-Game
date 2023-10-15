using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private float platformSpeed;

    [SerializeField] private int startPoint;
    [SerializeField] private int pointIndex;

    [SerializeField] private Transform[] points;

    private void Start()
    {
        //transform.position = points[startPoint].position;
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, points[pointIndex].position) < 0.01f)
        {
            pointIndex += 1;

            if(pointIndex ==  points.Length)
            {
                pointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].position, platformSpeed * Time.deltaTime);
    }
}
