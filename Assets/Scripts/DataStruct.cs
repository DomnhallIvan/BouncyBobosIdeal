using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se almacena en Stack
//Stack solo almacena valores sencillas
[System.Serializable]
public struct DataStruct
{
    public int numEntero;
    public float numFloat;

    public void FuncionStruct()
    {

    }

}

//Se almacena en el Heap
//Heap almacena char, string y otros valores más complejos
[System.Serializable]
public class ClassBase
{
    public int numEntero;
    public float numFloat;

    public void FuncionStruct()
    {

    }

}

//Ejemplo donde structs pueden ser más útiles
[System.Serializable]
public struct WaveSystem
{
    public Wave[] waves;
}

[System.Serializable]
public struct Wave
{
    public int enemyType;
    public int enemyCount;
    public float timeBetweenSpawns;
}

