using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContadorLeones : MonoBehaviour
{
    public int leonesIni;
    public int numLeones;
    public TMP_Text txt;
    public GameObject panel;
    public int aumentoL;
    public int restaL;
    
    // Start is called before the first frame update
    void Start()
    {
        numLeones = leonesIni;
        ActualizarLeones();
    }
    void Update()
    {
        
    }

    public void AumentoL(){
        numLeones += aumentoL;
        ActualizarLeones();
    }

    public void RestaL(){
        numLeones -= restaL;
        ActualizarLeones();
    }

    private void ActualizarLeones(){
        txt.text = numLeones.ToString();
    }

    public void DestroyAfterAnimation()
    {
        panel.SetActive(true);
        Destroy(transform.gameObject);
    }
}
