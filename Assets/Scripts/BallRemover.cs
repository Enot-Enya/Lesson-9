using UnityEngine;

public class BallRemover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            Destroy(gameObject);
        }
    }
}
