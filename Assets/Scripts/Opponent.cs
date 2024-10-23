using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : Character
{
    //Stack -Pila que le da prioridad al último que entro
    //Queue- Fila que le da prioridad al primero que entro
    public Queue<Transform> currentBalls;

    private void OnDisable()
    {
        SphereManager.Instance.SphereSpawn -= SphereSpawn;
    }

    public override void Move()
    {
        
    }

    private void SphereSpawn(Transform transformSphere)
    {
        currentBalls.Enqueue(transformSphere);

    }
}
