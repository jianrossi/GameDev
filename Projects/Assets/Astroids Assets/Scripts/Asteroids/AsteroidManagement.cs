using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AsteroidManagement : MonoBehaviour
{
	public GameObject asteroid;
	public GameObject[] spawnPoints;
	public GameObject particle;
	public List<GameObject> Asteroids;
	public int spawnAmount = 1;
	public int childrenAsteroidsToSpawn = 2; 
	public bool spawning; 

	public RaycastHit hitInfo;

	public float collisionDistance;
	public float energyLoss;
	public int rayLength;
	
	private bool destroyed;
	private bool split;
	
	// Use this for initialization
	void Start ()
	{
		Asteroids = new List<GameObject>(spawnAmount);
		spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

		particle.SetActive(false);

		foreach(GameObject child in Asteroids)
		{
			CastRay(child);
		}		
	}
	
	// Update is called once per frame
	void Update ()
	{
		RaycastHit hit;
		Ray newRay;
		foreach (GameObject asteroid in Asteroids) {
			newRay = new Ray(asteroid.transform.position, asteroid.transform.forward);
		
			if(!split)
			{
				if(!destroyed){
					
					if(Physics.Raycast(newRay, out hit, collisionDistance))
					{
						if(hit.collider.tag == "asteroids")
						{
							SplitAsteroid();
						}
						
						if(hit.collider.tag == "environment")
						{
							DestroyAsteroid();
						}
					}
				}
			}

		}
	}

	void CastRay(GameObject child)
	{
		Ray asteroidRay = new Ray(child.transform.position, child.transform.forward);
		Physics.Raycast(asteroidRay, out hitInfo, rayLength);
		Debug.DrawRay(child.transform.position, child.transform.forward, Color.green);
	}

	void SplitAsteroid()
	{
		split = true;
	}
	
	void OnCollisionEnter()
	{
		
	}
	
	void DestroyAsteroid()
	{
		
	}
}

