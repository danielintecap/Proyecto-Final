using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Stats : MonoBehaviour
{
    public Text textoVida;
    public Text textoPuntos;

    public Image barraVida;
    public float vidaActual;
    public float vidaMaxima = 100f;

    public Text CantEnemigos;


    void Start()
    {
        
    }

    void Update()
    {
        //vida con texto
        textoVida.text ="Vida: " + Stats_Player.vida;
        textoPuntos.text = "Puntos: " + Stats_Player.puntos;

        //vida con imagen de barra
        vidaActual = Stats_Player.vida;
        barraVida.fillAmount = vidaActual / vidaMaxima;


        CantEnemigos.text = "Enemigos: " + Stats_Player.Enemigos; 
    }
}
