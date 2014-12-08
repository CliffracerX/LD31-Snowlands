using UnityEngine;
using System.Collections;

public class RestartDeath : MonoBehaviour
{
	public Vector3 startingPos;
	void Start()
	{
		startingPos=transform.position;
	}

	void OnTriggerEnter(Collider other)
	{
		transform.rotation=new Quaternion(0, 0, 0, transform.rotation.w);
		if(other.tag=="Death")
		{
			transform.position=startingPos;
			audio.Play();
		}
		if(other.tag=="LevelAdvance")
		{
			LevelTP lTP = other.gameObject.GetComponent<LevelTP>();
			lTP.complete=true;
		}
	}
}
