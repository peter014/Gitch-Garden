﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 4f;
    [SerializeField] GameObject attackerPrefab;
    bool spawn = true;

	// Use this for initialization
	IEnumerator Start () {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay,maxSpawnDelay));
            SpawnAttacker();
        }
	}

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
