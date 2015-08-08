using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AsteroidManagement : MonoBehaviour
{
	//public List<GameObject> spawnPoints;
	//private List<GameObject> Asteroids;
	private GameObject asteroid;
	public GameObject spawnPoint;
	private AsteroidMovement astroMove; 

//	public int asteroidCount;
//	public int childrenAsteroidsToSpawn = 2; 
//	public bool spawning; 
//	public RaycastHit hitInfo;
//	public float collisionDistance;
//	public float energyLoss;
//	public int rayLength;

	public float xMinVelocity;
	public float xMaxVelocity;
	public float yMinVelocity; 
	public float yMaxVelocity;

//	private bool destroyed = false;
//	private bool split = false;
	
	// Use this for initialization
	void Start ()
	{
		asteroid = (GameObject)Resources.Load("Assets/Astroids Assets/Prefabs/Asteroid");
		//asteroids = new List<GameObject>();

		spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

		asteroid = Instantiate(asteroid,spawnPoint.transform.position, Quaternion.identity) as GameObject;

		astroMove = asteroid.GetComponent(typeof(AsteroidMovement)) as AsteroidMovement;		
		astroMove.xMinVelocity = xMinVelocity;
		astroMove.xMaxVelocity = xMaxVelocity;
		astroMove.yMinVelocity = yMinVelocity;
		astroMove.yMaxVelocity = yMaxVelocity;

		//asteroid.SetActive(false);

		/*foreach(GameObject child in Asteroids)
		{
			CastRay(child);
		}*/		
	}
	
	// Update is called once per frame
	void Update ()
	{
//		RaycastHit hit;
//		Ray newRay;
//		foreach (GameObject asteroid in Asteroids) {
//			newRay = new Ray(asteroid.transform.position, asteroid.transform.forward);
//		
//			if(!split)
//			{
//				if(!destroyed){
//					
//					if(Physics.Raycast(newRay, out hit, collisionDistance))
//					{
//						if(hit.collider.tag == "asteroids")
//						{
//							SplitAsteroid();
//						}
//						
//						if(hit.collider.tag == "environment")
//						{
//							DestroyAsteroid();
//						}
//					}
//				}
//			}
//
//		}
	}

//	void CastRay(GameObject child)
//	{
//		Ray asteroidRay = new Ray(child.transform.position, child.transform.forward);
//		Physics.Raycast(asteroidRay, out hitInfo, rayLength);
//		Debug.DrawRay(child.transform.position, child.transform.forward, Color.green);
//	}
//
//	void SplitAsteroid()
//	{
//		split = true;
//	}
//	
//	void OnCollisionEnter()
//	{
//		
//	}
//	
//	void DestroyAsteroid()
//	{
//		
//	}

}

