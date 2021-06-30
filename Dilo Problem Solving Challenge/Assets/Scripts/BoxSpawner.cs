using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject boxPrefab;    
    public int maxBoxCount;
    public int minBoxCount;

    int boxCount;

    // Start is called before the first frame update
    void Start()
    {        
        boxCount = Mathf.RoundToInt(Random.Range(minBoxCount, maxBoxCount));
        SpawnBox(boxCount);
    }   
    
    public void SpawnBox(int count)
    {
        for(int i = 0; i < count; i++)
        {
            float posX = Random.Range(-8, 8);
            float posZ = Random.Range(-4, 4);
            Vector3 pos = new Vector3(posX, 0.25f, posZ);

            Instantiate(boxPrefab, pos, Quaternion.identity, this.transform);
        }
    }
}
