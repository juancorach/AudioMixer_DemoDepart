using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;

    private float volume;

    [SerializeField]
    private Slider glissiereVolumeMusique;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("MusiqueVolume", ConvertToLogarithmique(volume) );
    }

    public void AjusteVolumeFX(float volume){
        audioMixer.SetFloat("FXVolume", ConvertToLogarithmique(volume));
        audioSource.Play();
    }

    private float ConvertToLogarithmique(float volume){
            return Mathf.Log10(volume) * 20;
    }
}
