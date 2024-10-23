using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    

    public Vector3[] positions;
    public float speed = 10;
    public int lifeCount;
    protected float alphaLerp=0-5f;
    protected Vector3 moveVector;
    public Vector3 dir;

    private void FixedUpdate()
    {
        Move();
    }

    public virtual void Move()
    {

    }

    private void Die()
    {

    }
}
