using UnityEngine;
using UnityEngine.UI;

public class AudioOnClickPauseMenu : MonoBehaviour
{
    [SerializeField] private Button resume;
    [SerializeField] private Button settings;
    [SerializeField] private Button credits;
    [SerializeField] private Button exit;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        resume.onClick.AddListener(OnResumeClicked);
        settings.onClick.AddListener(OnSettingsClicked);
        credits.onClick.AddListener(OnCreditsClicked);
        exit.onClick.AddListener(OnExitClicked);
    }


    private void OnDestroy()
    {
        resume.onClick.RemoveListener(OnResumeClicked);
        settings.onClick.RemoveListener(OnSettingsClicked);
        credits.onClick.RemoveListener(OnCreditsClicked);
        exit.onClick.RemoveListener(OnExitClicked);
    }

    private void OnExitClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnCreditsClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnSettingsClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
    private void OnResumeClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
