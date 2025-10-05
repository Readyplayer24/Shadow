using UnityEngine;

public class BusController : MonoBehaviour
{

    public float busSpeed = 10f;
    public float destroyZPosition = -15f;
    public float respawnZPosition = 40f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.back * busSpeed * Time.deltaTime);

        if(transform.position.z < destroyZPosition)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, respawnZPosition);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PlayerController"))
        {
            PlayerHealth playerhealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerhealth != null)
            {
                playerhealth.Die();
            }
            else
            {
                Debug.LogError("¡El Player colisionó con el Bus, pero le falta el script 'PlayerHealth'!");
            }
        }
    }
}
