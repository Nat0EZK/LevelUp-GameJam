using System;
using UnityEditor;
using UnityEngine;
using  System.Collections;
class SpawnerManager : MonoBehaviour
{

        [SerializeField] private GameObject[] spawners; // Array de los GameObjects de spawners
    
        private void Start() {
            StartCoroutine(ActivateSpawnersRandomly());
        }
    
        IEnumerator ActivateSpawnersRandomly() {
            while (true) {
                int randomIndex = UnityEngine.Random.Range(0, spawners.Length); // Selecciona un spawner aleatorio
                spawners[randomIndex].SetActive(true); // Activa el spawner seleccionado
                yield return new WaitForSeconds(0.5f); // Espera 0.5 segundos antes de activar otro spawner
            }
        }
    }

