using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> spawnpoints;
    [SerializeField] public GameObject player;
    
    public float RespawnHeightThreshold = -50f; //if player falls this much, he will respawn
    
    // Start is called before the first frame update
    void Start()
    {
        //initial position is a spawn point
        var go = GameObject.Instantiate(new GameObject());
        go.name = "master spawn point";
        spawnpoints.Add(go);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < RespawnHeightThreshold)
        {
            DoRespawn();
        }
    }

    private void DoRespawn()
    {
        player.transform.position = spawnpoints[0].transform.position;
        player.transform.rotation = spawnpoints[0].transform.rotation;
    }
}
