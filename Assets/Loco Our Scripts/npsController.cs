using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npsController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;

    public GameObject PATH;
    private Transform[] PathPoints;

    public float minDistance = 10;

    public int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        PathPoints = new Transform[PATH.transform.childCount];
        for (int i = 0; i < PathPoints.Length; i++)
        {
            PathPoints[i] = PATH.transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        roam();
    }

    void roam()
    {
        if (Vector3.Distance(transform.position ,PathPoints[index].position) < minDistance)
        {
            if (index > 0 && index < PathPoints.Length)
            {
                index += 1;
            }
            else
            {
                index = 0;
            }
        }
        agent.destination = PathPoints[index].position;
        //agent.SetDestination(PathPoints[index].position);
    }
}
