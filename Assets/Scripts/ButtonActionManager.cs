using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActionManager : MonoBehaviour
{
    // Añadir los comportamientos a los botones.

    [SerializeField] private Button play;
    [SerializeField] private Button options;
    [SerializeField] private Button quit;
    [SerializeField] private Button credits;

    private void Awake() //Es una funcion que se ejecuta cjusto antes de el start, es decir de el primer frame.
    {
        play.onClick.AddListener(PlayGame); // Al play, en el onClick añadile la funcion PlayGame. que no es lo mismo cuando apretes, añadile la funcion. 
        options.onClick.AddListener(OptionsMenu);
        quit.onClick.AddListener(QuitGame);
        credits.onClick.AddListener(Credits);
    }

    private void Credits() //esto ya está añadadido al boton.
    {
        SwitchCanvasActiveStatus.SwitchActiveStatusCreditCanvas(); //credit canvas
    }

    private void QuitGame()
    {
        Application.Quit(); //funcion de salir de unity.
    }

    private void OptionsMenu()
    {
        SwitchCanvasActiveStatus.SwitchActiveStatusOptionsCanvas(); //Cambia el estado del option canvas.
    }

    private void PlayGame()
    {
        SceneTransitions._PlayButton();
    }
}