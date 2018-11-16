using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cronometro : MonoBehaviour {

    // Use this for initialization
    public float minutos;               //MINUTOS QUE HAY
    public float segundos;              //SEGUNDOS QUE HAU
    private Text cronometro;            //EL TEXTOOOO!!!
	void Start () {
        //COGE EL COMPREMENTO DE TEXTO!
        cronometro = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //SI ES MAYOR O IGUAL QUE 0, SE RESTA
        //SINO, COMPRUEBA SI LOS MINUTOS SON 0 Y SINO LO SON RESTA Y PONE 59 SEGUNDOS
        if (segundos >= 0)
        {
            segundos -= Time.deltaTime;

        }
        else
        {
           
            if (minutos != 0)
            {
                --minutos;
                segundos = 59;
            }
        }
        cronometro.text =minutos.ToString("00") + ":" + segundos.ToString("00");//Escribe el texto

	}
}
