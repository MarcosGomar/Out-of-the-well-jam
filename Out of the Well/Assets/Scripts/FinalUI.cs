using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalUI : MonoBehaviour
{
    public TextMeshProUGUI textoTituloTiempoActual;
    public TextMeshProUGUI textoValorTiempoActual;

    public TextMeshProUGUI textoTituloMejorTiempo;
    public TextMeshProUGUI textoValorMejorTiempo;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        float tiempoActual = PlayerPrefs.GetFloat("TiempoFinal", 0f);
        float mejorTiempo = PlayerPrefs.GetFloat("MejorTiempo", tiempoActual);

        textoTituloTiempoActual.text = "Your Time:";
        textoValorTiempoActual.text = FormatearTiempo(tiempoActual);

        textoTituloMejorTiempo.text = "Best Time:";
        textoValorMejorTiempo.text = FormatearTiempo(mejorTiempo);
    }

    string FormatearTiempo(float t)
    {
        int minutos = Mathf.FloorToInt(t / 60);
        int segundos = Mathf.FloorToInt(t % 60);
        return string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir del juego");
    }
}
