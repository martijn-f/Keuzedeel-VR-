using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Toggle musicToggle;
    public Slider volumeSlider;
    public AudioSource musicSource;

    private void Start()
    {
        // Add listeners to the toggle's value changed event and the slider's value changed event
        musicToggle.onValueChanged.AddListener(OnToggleValueChanged);
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderValueChanged);

        // Set the initial state of the toggle and slider based on the music source
        musicToggle.isOn = musicSource.isPlaying;
        volumeSlider.value = musicSource.volume;
    }

    private void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            // Turn on the music
            musicSource.Play();
        }
        else
        {
            // Turn off the music
            musicSource.Pause();
        }
    }

    private void OnVolumeSliderValueChanged(float volume)
    {
        // Set the volume of the music source
        musicSource.volume = volume;
    }
}

