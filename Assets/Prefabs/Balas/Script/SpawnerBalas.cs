using UnityEngine;

public class SpawnerBalas : MonoBehaviour
{
    private GameObject BalaPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DispararBala", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispararBala()
    {
        Instantiate(BalaPrefab, transform.position, transform.rotation);
    }
}
