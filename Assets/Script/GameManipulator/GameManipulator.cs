using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameManipulator : MonoBehaviour
{
    public GameObject Cube;
    
    [SerializeField] float value = 2;
    [SerializeField] Vector3 sizeChangeValue;
    private Vector3 startPosition;
    public void Start()
    {
        startPosition= new Vector3(Cube.transform.position.x , Cube.transform.position.y, Cube.transform.position.z);
    }

    public void MoveRight()
    {
        Cube.transform.position = new Vector3(Cube.transform.position.x + value, Cube.transform.position.y, Cube.transform.position.z);

    }
    public void MoveLeft()
    {
        Cube.transform.position = new Vector3(Cube.transform.position.x - value, Cube.transform.position.y, Cube.transform.position.z);

    }
    public void Up()
    {
        Cube.transform.position = new Vector3(Cube.transform.position.x, Cube.transform.position.y + value, Cube.transform.position.z);

    }
    public void Down()
    {
        Cube.transform.position = new Vector3(Cube.transform.position.x, Cube.transform.position.y - value, Cube.transform.position.z);

    }
    public void RotateCube()
    {
        Cube.transform.Rotate(0, 20f, 0);

    }

    public void GrowCube()
    {
        Cube.transform.localScale = Cube.transform.localScale + sizeChangeValue;

    }

    public void Reset()
    {
        Cube.transform.position=startPosition ;
        Cube.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Cube.transform.localScale = Vector3.one;
    }
}
