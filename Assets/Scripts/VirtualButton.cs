/*
 * Andrea Arguello 17801  
 * VirtualButton.cs
 * 9/5/18
 * Configuracion del boton virtual de vuforia
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

//Implementa la interfaz IVirtualButtonEventHandler
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    //Atributos
    VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        //Le da play al audio al presionar el boton
        birdAnim.SetTrigger("sing");
        //Comprobar si si esta reaccionando
        Debug.Log("Boton");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        //Obtiene el componente VirtualButtonBehavior
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        //Registra el script como manejador de eventos del bo´ton
        virtualBtn.RegisterEventHandler(this);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
