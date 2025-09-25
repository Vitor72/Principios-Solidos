using UnityEngine;

public class Moverse : MonoBehaviour
{
    public int modo;
    public float cronometro;
    private float grado;
    private Quaternion angulo;
    public int velocidad;

    private void Update()
    {
        Mover_Enemigo();
    }

    public void Mover_Enemigo()
    {
        IInterfaz _Cambio_Modo = GetComponent<IInterfaz>();
        cronometro += 1 * Time.deltaTime;
        if (cronometro >= 2)
        {
            modo = Random.Range(0, 3);
            cronometro = 0;
        }
        switch (modo)
        {
            case 0:
                transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 1.5f);
                transform.Translate(Vector3.forward * 1 * Time.deltaTime * (velocidad = 2));
                break;
            case 1:
                grado = Random.Range(0, 360);
                angulo = Quaternion.Euler(0, grado, 0);
                _Cambio_Modo.Cambio_modo("Giro un poco.");
                modo++;
                break;
            case 2:
                transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 1.5f);
                transform.Translate(Vector3.forward * 1 * Time.deltaTime * (velocidad = 5));
                break;
        }
    }
}
