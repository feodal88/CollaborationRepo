using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour
{

    public float speed = 3.0f;
    public Transform endPoint;
     Vector3 startPoint;
    public Dir direction = Dir.left;
    // Use this for initialization
    void Start()
    {
        startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == Dir.left)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, Time.deltaTime * speed);
            if (transform.position == endPoint.position)
                direction = Dir.right;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint, Time.deltaTime * speed);
            if (transform.position == startPoint)
                direction = Dir.left;
        }
    }

    public enum Dir
    {
        right,
        left
    }
}
