using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private float speed = 30f;
    private float lifeTime = 3f;
    private Rigidbody rocketRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rocketRb = GetComponent<Rigidbody>();
        shoot(transform.position, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shoot(Vector3 direction, float force)
    {
        rocketRb.AddForce(direction * force);
        Destroy(gameObject, lifeTime);
    }
}
