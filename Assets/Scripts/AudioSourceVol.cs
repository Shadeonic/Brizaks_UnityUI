using UnityEngine;
using UnityEngine.UI;

public class AudioSourceVol : MonoBehaviour
{
    //Skaņas, slidera un pogas komponentes
    public AudioSource musicSource;
    public Slider volumeSlider; 
    public Toggle toggleButton;

    void Start()
    {
        //Maina skaņu atkarībā no slaidera un parāda/slēpj slaideri
        volumeSlider.value = musicSource.volume;//saņem lielumu
        volumeSlider.onValueChanged.AddListener(ChangeVolume);//iestata lielumu
        toggleButton.onValueChanged.AddListener(ToggleSoundSlider);
    }
    //Maina skaņu atkarībā no slaidera
    void ChangeVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void ToggleSoundSlider(bool value)
    {
        volumeSlider.gameObject.SetActive(value);
 
    }

}
