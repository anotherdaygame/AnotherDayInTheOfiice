using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    /****VARIABLES GLOBALES******/



    /****BUCLE PRINCIPAL*******/
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetButton("Fire2"))
        {
            if(Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.CompareTag("interactive"))
                {
                    Debug.Log(hit.collider.tag);
                }
                else
                {
                    Debug.Log("NOTHING");

                }
            }
        }
	}
}
