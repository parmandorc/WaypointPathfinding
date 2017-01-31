using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {

	// The list of waypoints this waypoints connects to
	public Waypoint[] adjacents;

	// If this flag is set to true, the system will generate the edges for this node automatically,
	//	by using raycasts to test what other waypoints can this waypoint connect to. In this case,
	//	the 'adjacents' array will be obviously ignored.
	public bool autogenerateEdges = false;
}
