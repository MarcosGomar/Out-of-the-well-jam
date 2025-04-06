using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaVictoria : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            float tiempoFinal = FindObjectOfType<Cronometro>().ObtenerTiempo();
            PlayerPrefs.SetFloat("TiempoFinal", tiempoFinal);

            if (!PlayerPrefs.HasKey("MejorTiempo") || tiempoFinal < PlayerPrefs.GetFloat("MejorTiempo"))
            {
                PlayerPrefs.SetFloat("MejorTiempo", tiempoFinal);
            }

            Time.timeScale = 1f;

            SceneManager.LoadScene("FinDelPozo");
        }
    }
}
