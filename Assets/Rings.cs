using System;
using Oculus.Interaction;
using Unity.VisualScripting;
using UnityEngine;

public class Rings : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public spawner pot;
    private Boolean timer = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        Debug.Log("Object that collided with me: " + other.gameObject.name);
        Destroy(this.gameObject);
        pot.ringDestroy();
    }

    public void over()
    {
        timer = true;
    }
}
