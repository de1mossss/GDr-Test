using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] List<Vector3> paths = new List<Vector3>();

	public void AddPath(Vector2 newPath)
	{
		paths.Add(newPath);
		Trajectory.updateTrajectory(paths);
	}
	public void RemovePath(Vector2 path)
	{
		paths.Remove(path);
	}
	public void RemoveAllPath()
	{
		paths.Clear();
	}
	public List<Vector3> GetPaths()
	{
		return paths;
	}
}
