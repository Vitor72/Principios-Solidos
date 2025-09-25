using UnityEngine;

public class Controlador_interfaz : MonoBehaviour, IInterfaz
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cambio_modo(string modo)
    {
        Debug.Log(modo);
    }

}

