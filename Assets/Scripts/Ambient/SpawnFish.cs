using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    public GameObject fishSpot;

    private int currentFish;

    public int minFish;
    public int maxFish;
    public float spawntime;
    public float spawnProbability;
    public GameObject raft;
    private float time;

    private void Start()
    {
        minFish = 0; //Potentially no fish
        maxFish = 10; //3 fish at once
        spawntime = 2f;
        spawnProbability = 30f;
    }
    // Update is called once per frame
    void Update()
    {
        if(currentFish < maxFish)
        {
            time += Time.deltaTime;
            if (time > spawntime)
            {            
                if (Random.Range(0f,100f) < spawnProbability)
                {
                    currentFish++;
                    time = 0f;
                    Instantiate(fishSpot,new Vector3(raft.transform.position.x,-1f,raft.transform.position.z),Quaternion.identity);
                }
                else
                {
                    time = 0f;
                }
                Debug.Log("There are currently " + currentFish + " fish nearby");
            }
        }
    }
}
