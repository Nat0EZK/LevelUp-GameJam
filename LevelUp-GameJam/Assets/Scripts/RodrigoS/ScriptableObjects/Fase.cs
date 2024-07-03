using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fase", menuName = "ScriptableObjects/Fase", order = 1)]
public class Fase : ScriptableObject
{
    public string fase;
    public List<Tarjeta> tarjetas = new List<Tarjeta>();
}
