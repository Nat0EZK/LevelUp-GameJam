using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TarjetaManager : MonoBehaviour
{
    public List<Tarjeta> tarjetas;
    private int currentIndex = 0;

    public Tarjeta getCurrentTarjeta(){
        return tarjetas[currentIndex];
    }

    public void nextTarjeta(){
        currentIndex = (currentIndex + 1) % tarjetas.Count;
    }
}
