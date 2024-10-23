using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DataStruct structSample;
    public ClassBase classBase;

    public DataStruct structCopy;
    public ClassBase classCopy;

    public WaveSystem waveSystem;
    public string savePATH;

    //Es importante dominar estas estructuras de datos
    private int index = 0;
    public Stack pilaEjemplo;
    public Queue colaEjemplo;

    public Dictionary<string,int> puntuaciones;

    private void Start()
    {
        pilaEjemplo = new Stack();
        colaEjemplo = new Queue();

        puntuaciones=new Dictionary<string, int>();
        puntuaciones.Add("Jugador 1", 0);
        puntuaciones.Add("Jugador 2", 0);
        puntuaciones.Add("Jugador 3", 0);
        puntuaciones.Add("Jugador 4", 0);

        structSample =new DataStruct();
        structSample.numEntero = 5;
        structSample.numFloat = 1.3f;
        structCopy = structSample;
        structSample.numEntero = 10;

        classBase = new ClassBase();
        classBase.numEntero = 10;
        classBase.numFloat = 1.4f;
        classCopy=classBase;
        classBase.numFloat = 2.8f;


        savePATH = Path.Combine(Application.persistentDataPath, "WaveProgress.json");
        if (File.Exists(savePATH))
        {
            JsonUtility.FromJson<WaveSystem>(File.ReadAllText(savePATH));
        }

        File.WriteAllText(savePATH,JsonUtility.ToJson(waveSystem,true));
        Debug.Log(JsonUtility.ToJson(waveSystem));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Agrega a la pila algo
            pilaEjemplo.Push(index);
            Debug.Log($"Ingrese el numero {index}");
            index++;

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Saca el elemento ultimo en entrar a la pila 
            var num = pilaEjemplo.Pop();
            Debug.Log($"Saque el numero {num}");

        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            puntuaciones["Jugador 1"]++;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            puntuaciones["Jugador 2"]++;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (puntuaciones.ContainsKey("Jugador 3"))
                puntuaciones["Jugador 3"]++;
            else
                puntuaciones["Jugador 3"] = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            puntuaciones["Jugador 4"]++;
        }

        foreach( var element in puntuaciones)
        {
            Debug.Log("El jugador " + element.Key + "tiene" + element.Value);
        }
    }
}
