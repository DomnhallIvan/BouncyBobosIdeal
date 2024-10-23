using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : Character
{
    [SerializeField] string axisNameVertical;
    [SerializeField] string axisNameHorizontal;
    

    private void Start()
    {
        dir = (positions[1] - positions[0]).normalized;
    }

    public override void Move()
    {
        moveVector.x = dir.x * Input.GetAxisRaw(axisNameHorizontal);
        moveVector.z = dir.z * Input.GetAxisRaw(axisNameVertical);
        // moveVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position += moveVector * Time.deltaTime * speed;
        alphaLerp+= Input.GetAxisRaw(axisNameHorizontal)*Time.deltaTime*speed;
        //REGRESA UN VALOR DICIENDO UN MINIMO O UN MAXIMO, CUANDO EL VALOR ES MAYOR AL MAXIMO REGRESA MAXIMO Y VICEVERSA
        alphaLerp = Mathf.Clamp(alphaLerp,0,1); 
        transform.position = Vector3.Lerp(positions[0], positions[1], alphaLerp);
        /*
        float xInput = Input.GetAxisRaw("Horizontal");
        if(xInput>0)
        {
           
        }*/
    }
}
