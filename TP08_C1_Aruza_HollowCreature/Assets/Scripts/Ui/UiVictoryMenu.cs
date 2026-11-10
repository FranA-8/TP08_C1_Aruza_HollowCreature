using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiVictoryMenu : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button exitButton;
    bool isPaused = false;
    bool canPause = false;
    private float playerSpawnPointX = -4f;
    private float playerSpawnPointY = -4f;

    private void Awake()
    {
        playAgainButton.onClick.AddListener(OnPlayAgainButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    private void OnDestroy()
    {
        playAgainButton.onClick.RemoveListener(OnPlayAgainButtonClicked);
        exitButton.onClick.RemoveListener(OnExitButtonClicked);
    }

    private void OnExitButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 0f;
    }

    private void OnPlayAgainButtonClicked()
    {
        victoryPanel.SetActive(false);
        isPaused = false;
        player.transform.position = new Vector2(playerSpawnPointX, playerSpawnPointY);
        canPause = true;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canPause == true)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
