using System;
using NUnit.Framework;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    public float timer;
    private float currentTimer;
    public float distance;
    private Rigidbody[] allRigidbodies;
    public int power;
    void Start()
    {
        allRigidbodies = FindObjectsByType<Rigidbody>(FindObjectsSortMode.None);
    }
    

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer > timer) 
        {
            currentTimer = 0;
            Boom();
        }
    }

    private void Boom()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
        foreach (var b in allRigidbodies) 
        {
            float currentDistance = Vector3.Distance(transform.position, b.position);
            if (currentDistance <= distance)
            {
                b.AddForce((b.position - transform.position).normalized * power * (distance - currentDistance), ForceMode.Impulse);
            }
        }
    }
}
