using UnityEngine;

public class MoveDown : MonoBehaviour
{
    Rigidbody Rb;

    public float speed = 5.0f;
    private float zBound = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zBound)
        {
            Destroy(gameObject);
        }
    }
}
