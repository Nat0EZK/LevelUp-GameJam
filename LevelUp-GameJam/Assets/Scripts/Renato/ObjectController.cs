using System;
using UnityEngine;
using System.Collections;

class ObjectController : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab1; // El primer prefab
    [SerializeField] private GameObject objectPrefab2; // El segundo prefab
    [SerializeField] private float height; // Altura a la que se instanciarán los prefabs
    [SerializeField] private float[] intervals = new float[] { 0.5f, 1f, 1.5f }; // Intervalos específicos

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            GameObject selectedPrefab;
            float probability = UnityEngine.Random.Range(0f, 1f); // Genera un número aleatorio entre 0 y 1
            if (probability < 0.6) // 60% de probabilidad
            {
                selectedPrefab = objectPrefab1;
            }
            else // 80% de probabilidad
            {
                selectedPrefab = objectPrefab2;
            }

            Instantiate(selectedPrefab, new Vector3(10, height, 0), Quaternion.identity, transform);
            float interval = intervals[UnityEngine.Random.Range(0, intervals.Length)]; // Selecciona un intervalo de manera aleatoria
            yield return new WaitForSeconds(interval);
        }
    }
}