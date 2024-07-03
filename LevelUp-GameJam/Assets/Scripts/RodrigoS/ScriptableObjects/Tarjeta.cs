using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

[CreateAssetMenu(fileName = "Tarjeta", menuName = "ScriptableObjects/Tarjeta", order = 1)]
public class Tarjeta : ScriptableObject
{
    public int id;
    public int aumentoL;
    public int restaL;
    public string txtInteligente;
    public string txtLoco;
}
