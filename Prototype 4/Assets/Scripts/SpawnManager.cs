using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] powerupPrefabs;
    public PlayerController playerController;

    private int enemyPrefabIndex;
    private int powerupPrefabIndex;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = FindFirstObjectByType<PlayerController>();
        SpawnEnemyWave(waveNumber);
        SpawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver)
        {
            enemyCount = FindObjectsByType<EnemyController>(FindObjectsSortMode.None).Length;

            if (enemyCount == 0)
            {
                waveNumber++;
                SpawnEnemyWave(waveNumber);
                SpawnPowerup();
            }
        }
    }

    void SpawnPowerup()
    {
        powerupPrefabIndex = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[powerupPrefabIndex], GenerateSpawnPosition(), powerupPrefabs[powerupPrefabIndex].transform.rotation);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        enemyPrefabIndex = Random.Range(0, enemyPrefabs.Length);
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefabs[enemyPrefabIndex], GenerateSpawnPosition(), enemyPrefabs[enemyPrefabIndex].transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
