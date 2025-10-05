using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        Debug.Log("Player a muerto, reinicia el nivel");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
