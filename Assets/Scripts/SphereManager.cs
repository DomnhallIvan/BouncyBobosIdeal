using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : PoolManager
{
    public static SphereManager Instance;

    [Header("Variables for Sphere Manager")]
    public Transform[] pointsToSpawn;
    public delegate void OnSphereSpawn(Transform createdBall);
    public OnSphereSpawn SphereSpawn;

    private void Awake()
    {
        Instance = this;
    }

    public override void StartFunction()
    {
        StartCoroutine(RoutineSpawn());
        //Invoke()//Dice el metodo y el tiempo que tendremos para ejeuctar el metodo
        //InvokeRepeating()//Lo mismo pero dice por cuanto tiempo se repite
    }

    IEnumerator RoutineSpawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f); //Es mejor poner esto en vez de null.
            GameObject sphereSpawn=AskForObject(pointsToSpawn[Random.Range(0, pointsToSpawn.Length)].position);
            SphereSpawn?.Invoke(sphereSpawn.transform);
        }
    }

}
