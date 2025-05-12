using UnityEngine;

public class VehicleObstacleController : MonoBehaviour
{
    public float speed = 30.0f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + Vector3.back * speed * Time.fixedDeltaTime);
    }
}
