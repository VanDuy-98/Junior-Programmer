using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnManagerX;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        spawnManagerX = FindFirstObjectByType<SpawnManagerX>();
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");

        speed = spawnManagerX.enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        EnemyMoveToPlayerGoal();
    }

    // Set enemy direction towards player goal and move there
    void EnemyMoveToPlayerGoal()
    {
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal" || other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
