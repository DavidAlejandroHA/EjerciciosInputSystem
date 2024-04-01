using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public float tiempoEspera = 3.0f;

    private void Start()
    {
        StartCoroutine(SpawnPrefabAtIntervals());
    }

    IEnumerator SpawnPrefabAtIntervals()
    {
        while (true)
        {
            SpawnPrefab();
            yield return new WaitForSeconds(tiempoEspera);
        }
    }

    void SpawnPrefab()
    {
        // Este metodo lo que hace es coger un valor viewport y lo pasa a un punto del mundo.
        // El sistema Viewport asocia el 0,0 a la esquena inferior izquierda de la cámara, y el 1,1 la esquina superior derecha,
        Vector2 posicionSpawneo = Camera.main.ViewportToWorldPoint(new Vector2(Random.Range(0f,1f), 1.1f));
 

        Instantiate(prefab, posicionSpawneo, Quaternion.identity);
    }
}
