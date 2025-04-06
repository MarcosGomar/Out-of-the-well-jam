using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa;
    public Cronometro cronometro;
    public MonoBehaviour scriptCamara;

    private bool estaPausado = false;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        panelPausa.SetActive(false);
        if (scriptCamara != null) scriptCamara.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (estaPausado)
                Continuar();
            else
                Pausar();
        }
    }

    public void Pausar()
    {
        estaPausado = true;
        Time.timeScale = 0f;
        panelPausa.SetActive(true);
        cronometro.PausarCronometro();

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        if (scriptCamara != null) scriptCamara.enabled = false;
    }

    public void Continuar()
    {
        estaPausado = false;
        Time.timeScale = 1f;
        panelPausa.SetActive(false);
        cronometro.ReanudarCronometro();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        if (scriptCamara != null) scriptCamara.enabled = true;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void VolverAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir del juego (solo en build)");
    }
}
