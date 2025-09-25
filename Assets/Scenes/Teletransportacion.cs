using UnityEngine;

public class Teletransportacion : MonoBehaviour
{
    public float cronometro;
    public int modo;
    public Transform cubo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Teletransporte();
    }
    public void Teletransporte()
    {
        IInterfaz _Cambio_Modo = GetComponent<IInterfaz>();
        cronometro += 1 * Time.deltaTime;
        if (cronometro >= 10)
        {
            modo = Random.Range(0, 3);
            cronometro = 0;
        }
        switch (modo)
        {
            case 0:
                transform.position = new Vector3(0, 1, 0);
                break;
            case 1:
                int pos = Random.Range(-10, 10);
                transform.position = new Vector3(Random.Range(cubo.position.x + 2, pos), 0, Random.Range(cubo.position.z + 2, pos));
                _Cambio_Modo.Cambio_modo("tp");
                modo++;
                break;
            case 2:
                break;
        }
    }
}
