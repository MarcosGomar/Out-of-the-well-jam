using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    private float tiempoTranscurrido = 0f;
    private bool corriendo = true;

    void Update()
    {
        if (corriendo)
        {
            tiempoTranscurrido += Time.deltaTime;
            int minutos = Mathf.FloorToInt(tiempoTranscurrido / 60);
            int segundos = Mathf.FloorToInt(tiempoTranscurrido % 60);
            textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }
    }

    public void PausarCronometro()
    {
        corriendo = false;
    }

    public void ReanudarCronometro()
    {
        corriendo = true;
    }

    public void ReiniciarCronometro()
    {
        tiempoTranscurrido = 0f;
    }
    public float ObtenerTiempo()
    {
        return tiempoTranscurrido;
    }

}
