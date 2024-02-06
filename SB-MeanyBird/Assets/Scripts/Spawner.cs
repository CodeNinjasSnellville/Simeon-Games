//object that we will attach to the script for spawning object
[Header("Spikes Object for contolling the game")]
public GameObject spikes
//height position of the spikes
[Header("Default Height")]
public float height;

//Start is called bafore the first frame update
void Start()
{
    //Start function repeating every 4 seconds
    InvokeRepeating("InstantiateObjects", 1f, 4f);
}

//Update is called once per frame
void Update()
{
    //Position for the gameobjects
    transform.position = new Vector3(5, Random.Range(-height, height), 0);
}

//InstantiateObjects Function
void InstantiateObjects()
{
    //Spawn object ny postion and rotation
    InstantiateObjects(spikes, transform.position, transform,rotation)
}