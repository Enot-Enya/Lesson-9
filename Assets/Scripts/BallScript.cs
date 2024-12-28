using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Transform target;
    public int power;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce((target.position - transform.position).normalized * power, ForceMode.Impulse);
    }

}
