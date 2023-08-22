using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchManager : MonoBehaviour
{
    private static Vector3 playerPosition;

    // Save the player's position when switching scenes
    public static void SavePlayerPosition(Vector3 position)
    {
        playerPosition = position;
    }

    // Load the other scene and set the player's position
    public static void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Set the player's position on scene start
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = playerPosition;
        }
    }
}
