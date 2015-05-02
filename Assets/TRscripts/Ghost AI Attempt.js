
//By Brendon Cocom

var waypoint: Transform[];
var speed : float = 70;
private var currentWaypoint: int;


function Update () {
	
	
	if(currentWaypoint < waypoint.Length)
	{
		var target : Vector3 = waypoint[currentWaypoint].position;
		var moveDirection: Vector3 = target - transform.position;
		var velocity = GetComponent.<Rigidbody>().velocity;
	
	if(moveDirection.magnitude < 1) 
		{
			currentWaypoint++;
		}
	else
		{
			velocity = moveDirection.normalized * speed;
		}
	}
	
	GetComponent.<Rigidbody>().velocity = velocity;
}