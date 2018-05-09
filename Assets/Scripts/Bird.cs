/*
 * Andrea Arguello 17801  
 * Bird.cs
 * 9/5/18
 * Configuracion del pajaro
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    //Atributos
    Animator anim;
    AudioSource audios;


	// Use this for initialization
	void Start () {
        //Obtiene el componente Animator
        anim = GetComponent<Animator>();
        //Obtiene el componente audiosource
        audios = GetComponent<AudioSource>();
	}

    //Settea la animacion
    void ResetHopInt()
    {
        anim.SetInteger("hop", 0);
    }

    //Reproduce el sonido
    void PlaySong()
    {
        audios.Play();
    }

}
