using UnityEngine;
using UnityEngine.SceneManagement;

public class Hotspot_Navegacion : MonoBehaviour
{
    public string nombreDeLaEscenaDestino;

    public void IrANuevaEstacion()
    {
        SceneManager.LoadScene(nombreDeLaEscenaDestino);
    }
}