using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

	Path paths;
	Camera camera;
    bool isMoving;
	Vector2 currentPath;

	private void Start()
	{
		camera = Camera.main;
		paths = FindObjectOfType<Path>();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (paths.GetPaths().Count == 0)
				paths.AddPath(transform.position);
			paths.AddPath(camera.ScreenToWorldPoint(Input.mousePosition));
		}

		Move();
	}

	private void Move()
	{
		if (!isMoving && paths.GetPaths().Count > 1)
		{
			currentPath = paths.GetPaths()[1];
			isMoving = true;
		}
		else if (isMoving && Vector2.Distance(transform.position, currentPath) < 0.1f)
		{
			isMoving = false;
			paths.RemovePath(paths.GetPaths()[0]);
		}
		if(currentPath != null)
			transform.position = Vector3.MoveTowards(transform.position, currentPath, speed * Time.deltaTime);
	}

}
