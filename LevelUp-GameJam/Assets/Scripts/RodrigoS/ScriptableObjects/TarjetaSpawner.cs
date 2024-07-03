using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarjetaSpawner : MonoBehaviour
{
    public TarjetaManager tarjetaManager;
    public GameObject tarjetaPrefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnearTarjeta();
    }

    public void SpawnearTarjeta(){
        TarjetaComp tarjetaComp = Instantiate(tarjetaPrefab, spawnPoint.position, Quaternion.identity).GetComponent<TarjetaComp>();
        tarjetaComp.tarjeta = tarjetaManager.getCurrentTarjeta();
    }
}
