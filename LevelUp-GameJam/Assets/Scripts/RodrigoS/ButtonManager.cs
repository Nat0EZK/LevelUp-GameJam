using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject tarjeta;
    public GameObject panel;
    
    public void SpawnTarjeta(){
        panel.SetActive(false);
        Instantiate(tarjeta);
    }
}
