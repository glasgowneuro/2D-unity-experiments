using UnityEngine;
using System.Collections;

public class EnemyCarShedder: MonoBehaviour {

    public GameObject carToSpawn;
    private float maxPos = 2.5f;

    void OnCollisionEnter2D(Collision2D enemyCar){
		GameObject enemyCarCollided = enemyCar.gameObject as GameObject;
		if (enemyCarCollided.GetComponent<EnemyCar> ()) {
			Destroy (enemyCar.gameObject);
            GameObject temp = GameObject.Find("EnemyCarSpawner");
            Transform spTransform = temp.GetComponent<Transform>();
            Vector3 carSpawnPoint = new Vector3(Random.Range(-maxPos, maxPos), spTransform.position.y, spTransform.position.z);
            Instantiate(carToSpawn, carSpawnPoint, spTransform.rotation);
        }
    }
}
