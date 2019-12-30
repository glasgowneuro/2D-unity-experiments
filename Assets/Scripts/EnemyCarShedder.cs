using UnityEngine;
using System.Collections;

public class EnemyCarShedder: MonoBehaviour {

    public GameObject carToSpawn;
    private float maxPos = 2.5f;

    void OnCollisionEnter2D(Collision2D enemyCar){
		GameObject enemyCarCollided = enemyCar.gameObject as GameObject;
		if (enemyCarCollided.GetComponent<EnemyCar> ()) {
			Destroy (enemyCar.gameObject);
            Vector3 carSpawnPoint = new Vector3(Random.Range(-maxPos, maxPos), 6.8f, transform.position.z);
            Instantiate(carToSpawn, carSpawnPoint, transform.rotation);
        }
    }
}
