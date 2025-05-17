using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public GameObject PowerupPrefab;

    private float spawnPosX = 7f;
    private float spawnEnemyPosZ = 6f;
    private float spawnPowerupPosZ = 3f;
    private float spawnPosY = 1f;
    private float delayTime = 2f;
    private float repeatTime = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", delayTime, repeatTime);
        InvokeRepeating("SpawnPowerup", delayTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, EnemyPrefabs.Length);
        float rangePosX = Random.Range(-spawnPosX, spawnPosX);
        float rangePosZ = Random.Range(-spawnEnemyPosZ, spawnEnemyPosZ);
        Instantiate(EnemyPrefabs[enemyIndex], new Vector3(rangePosX, spawnPosY, rangePosZ), EnemyPrefabs[enemyIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float rangePosX = Random.Range(-spawnPosX, spawnPosX);
        float rangePosZ = Random.Range(-spawnPowerupPosZ, spawnPowerupPosZ);
        Instantiate(PowerupPrefab, new Vector3(rangePosX, spawnPosY, rangePosZ), PowerupPrefab.gameObject.transform.rotation);
    }
}
