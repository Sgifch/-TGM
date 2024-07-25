using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCat : MonoBehaviour
{
    public GameObject toy;
    public GameObject spawn;
    public float timer = 0f;

    private float time = 0f;
    private Vector2 sp;

    private void Start()
    {
        sp = transform.position;
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timer)
        {
            Instantiate(toy, spawn.transform);
            time = 0f;
        }
        
    }
}
