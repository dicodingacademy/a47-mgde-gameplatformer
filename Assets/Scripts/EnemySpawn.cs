using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject Enemy;
    int JumlahEnemy = 0;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        print(JumlahEnemy);

        if (JumlahEnemy == 5)
        {
            StopAllCoroutines();
        }
	}
}
