using UnityEngine;
using UnityEngine.UI;

public class UISceneSwitch : MonoBehaviour
{
    public string targetSceneName;

    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(SwitchToTargetScene);
        }
    }

    public void SwitchToTargetScene()
    {
        // Save the player's position before switching scenes
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            SceneSwitchManager.SavePlayerPosition(player.transform.position);
        }

        // Switch to the target scene
        SceneSwitchManager.SwitchScene(targetSceneName);
    }
}
