using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarjetaPrincipal : MonoBehaviour
{
    public TarjetaManager tarjetaManager;
    public TarjetaComp tarjetacomp;
    private void Start()
    {
        tarjetacomp.tarjeta = tarjetaManager.getCurrentTarjeta();
    }

    private void OnDestroy()
    {
        tarjetaManager.nextTarjeta();
    }
}
