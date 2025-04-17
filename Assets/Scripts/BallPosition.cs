using UnityEngine;

public class BallPosition : MonoBehaviour
{
    [SerializeField]
    float velocidadInicial = 5f;

    int direccionActualX = 0;

    private Rigidbody2D rb;
    private float velocidadActual;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocidadActual = velocidadInicial;
        IniciarPelota();
    }

    public void IniciarPelota()
    {
        Invoke("LanzarPelota", 1f);
    }

    void LanzarPelota()
    {
        this.gameObject.transform.position = new Vector2(0, 0);
        direccionActualX = Random.value < 0.5f ? -1 : 1;
        Vector2 direccion = new Vector2(direccionActualX, Random.Range(-0.5f, 0.5f)).normalized;
        rb.linearVelocity = direccion * velocidadActual;
    }

   

}
