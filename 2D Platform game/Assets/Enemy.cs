using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Enemy : MonoBehaviour
{
    public List<Transform> points;

    public int ID=0;

    int idChangeValue = 1;

    public float speed = 2;

    private void Reset()
    {
        init();
    }

    void init()
    {

        GetComponent<BoxCollider2D>().isTrigger = true;

        GameObject root = new GameObject(name + "_Root");

        root.transform.position = transform.position;
        transform.SetParent(transform);
        GameObject waypoints = new GameObject("Waypoints");

        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = Vector3.zero;

        GameObject p1 = new GameObject("Point1"); p1.transform.SetParent(waypoints.transform);p1.transform.position = Vector3.zero;
        GameObject p2 = new GameObject("Point1"); p2.transform.SetParent(waypoints.transform); p2.transform.position = Vector3.zero;

        points = new List<Transform>();
        points.Add(p1.transform);
        points.Add(p2.transform);
    }

    private void Update()
    {
        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        Transform goalPoint = points[ID];

        if (goalPoint.transform.position.x > transform.position.x)
            transform.localScale = new Vector3(-1, 1, 1);
        else
            transform.localScale = new Vector3(1, 1, 1);

        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position,speed*Time.deltaTime);

        if(Vector2.Distance(transform.position, goalPoint.position)<1f)
        {
            if (ID == points.Count - 1)
                idChangeValue = -1;

            if (ID == 0)
                idChangeValue = 1;

            ID += idChangeValue;
        }

    }
}
