using System;
using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
class SpawnerKeys : MonoBehaviour
{
    public GameObject[] gameObjects;  // Array de los GameObjects que se pueden spawnear
    private List<GameObject> spawnedObjects; // Lista para trackear los GameObjects ya spawnados
    private GameObject lastSpawned = null; // Almacena el último GameObject instanciado

    void Start()
    {
        spawnedObjects = new List<GameObject>();
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        int maxSpawns = 5;  // Máximo de GameObjects a spawnear
        int count = 0;

        while (count < maxSpawns)
        {
            yield return new WaitForSeconds(2);  // Espera de 2 segundos

            GameObject toSpawn = GetRandomGameObject();
            if (toSpawn != null)
            {
                GameObject spawned = Instantiate(toSpawn, transform.position, Quaternion.identity);  // Spawnea el GameObject en la posición del spawner
                spawnedObjects.Add(spawned);  // Añade al listado de control
                lastSpawned = spawned; // Actualiza el último objeto spawnado
                count++;
            }
        }
    }

    GameObject GetRandomGameObject()
    {
        List<GameObject> availableObjects = new List<GameObject>(gameObjects);
        // Remueve el último objeto spawnado para no repetirlo inmediatamente
        if (lastSpawned != null && gameObjects.Length > 1)
        {
            availableObjects.Remove(lastSpawned);
        }

        availableObjects.RemoveAll(item => spawnedObjects.Contains(item)); // Remueve los ya spawnados

        if (availableObjects.Count > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, availableObjects.Count);
            return availableObjects[randomIndex];
        }

        return null; // Retorna null si todos los GameObjects ya fueron spawnados
    }
}