using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	public GameObject[] thePlatforms;
	private int platformSelector;
	private float[] platformWidths;


	// Use this for initialization
	void Start () {
		platformWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x;

		platformWidths = new float[thePlatforms.Length];
	}

	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector2 (transform.position.x + platformWidth + distanceBetween, transform.position.y);
		
			platformSelector = Random.Range (0, thePlatforms.Length);

			Instantiate /*thePlatform*/ (thePlatforms [platformSelector], transform.position, transform.rotation);


		}
	}
