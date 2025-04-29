using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float spawnRange = 0;
    private float spawnRange2 = 1000;
    public float spawnCap;
    private static float spawned = 1;
    public static float score = 0;
    public GameObject og;
    public GameObject timer;

    void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(og == null)
        {
            gameStart();
            timer.SetActive(true);
        }
    }
    void gameStart()
    {
        while(spawned < spawnCap)
        {
            float spawnPosX = Random.Range(-1188, 65);
            float spawnPosY = Random.Range(-24, 200);
            float spawnPosZ = Random.Range(-246, 631);
            float rotateY = Random.Range(-180, 180);
            Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
            Quaternion rotation = new Quaternion(0, rotateY, 0, 1);

            Instantiate(enemyPrefab, randomPos, rotation);
            spawned++;
        }
    }

    public void ringDestroy()
    {
        spawned--;
        Debug.Log("potato");
        score++;
    }
}
