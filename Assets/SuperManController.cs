using UnityEngine;

public class SuperManController : MonoBehaviour
{
    public int power;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(0,0,2); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 vec = collision.transform.position - transform.position;
        collision.rigidbody.AddForce(vec.normalized * power, ForceMode.Impulse);
    }
}
