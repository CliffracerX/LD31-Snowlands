using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour
{
	public int timeBetweenSpawns;
	public GameObject itemPrefab;
	public int timeTillSpawn;

	void Update()
	{
		timeTillSpawn-=1;
		transform.rotation = new Quaternion(0, 0, 0, transform.rotation.w);
		if(timeTillSpawn<1)
		{
			timeTillSpawn=timeBetweenSpawns;
			Instantiate(itemPrefab, transform.position, transform.rotation);
		}
	}
}
