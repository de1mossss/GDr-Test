using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void UpdateTrajectory(List<Vector3> paths);
public class Trajectory : MonoBehaviour
{
	[SerializeField] private LineRenderer trajectory;

	public static UpdateTrajectory updateTrajectory;
	private void Start()
	{
		updateTrajectory += SetTrajectory;
	}

	private void OnDestroy()
	{
		updateTrajectory -= SetTrajectory;
	}

	public void SetTrajectory(List<Vector3> paths)
	{
		trajectory.positionCount = paths.Count;
		trajectory.SetPositions(paths.ToArray());
	}
}
