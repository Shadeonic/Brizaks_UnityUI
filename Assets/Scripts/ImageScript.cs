using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    //Komponentes, kas atbilda par bruņām
    //Daedalus bruņas
    public GameObject DaedHelm;
    public GameObject DaedPlate;
    public GameObject DaedLeg;
    //God bruņas
    public GameObject GodHelm;
    public GameObject GodPlate;
    public GameObject GodLeg;
    //StarDust bruņas
    public GameObject StarHelm;
    public GameObject StarPlate;
    public GameObject StarLeg;
    //Zobeņi
    public GameObject Sword1;
    public GameObject Sword2;
    public GameObject Sword3;

    //Komponentes, kas atbilda par character
    public GameObject imageField;
    public Sprite[] spriteArray;
    public GameObject HeightSlider;
    public GameObject WidthSlider;
    public GameObject scrollViewContent;
    
    //Komponentes, kas atbilda par mūziku atbilstošam character
    public AudioScriptCharacter audioScriptCharacter; // Reference to audio script
    public AudioClip[] audioClipsBoy;  //vīriešu skaņas
    public AudioClip[] audioClipsGirl; //sieviešu skaņas
    
    //Komponentes, kas atbilda par bruņu lielumu
    public GameObject HeightSliderArmor;
    public GameObject WidthSliderArmor;
    public ObjectScript objectScript;

    //Pielieto vīrieša tēla mūziku, tikko sākās speles skats
    private void Start()
    {
        audioScriptCharacter.audioClips = audioClipsBoy; //Pārejot uz skatu, automātiski būs vīrieša skaņa
    }
    //Slaideri galvenajam tēlam
    //Maina augstumu
    public void ChangeHeight()
    {
        float currentHeight = HeightSlider.GetComponent<Slider>().value;
        Vector2 newScale = imageField.transform.localScale;
        newScale.y = currentHeight; 
        imageField.transform.localScale = newScale;
    }
    //Maina platumu
    public void ChangeWidth()
    {
        float currentHeight = WidthSlider.GetComponent<Slider>().value;
        Vector2 newScale = imageField.transform.localScale;
        newScale.x = currentHeight; 
        imageField.transform.localScale = newScale;
    }

    //Slaideri, kas maina bruņu lielumu
    //Maina augstumu
    public void ChangeHeightArmor()
    {
        if (objectScript.lastDragged != null)
        {
            float currentHeight = HeightSliderArmor.GetComponent<Slider>().value;
            Vector2 newScale = objectScript.lastDragged.transform.localScale;
            newScale.y = currentHeight; 
            objectScript.lastDragged.transform.localScale = newScale;
        }
    }
    
    //Maina platumu
    public void ChangeWidthArmor()
    {
        if (objectScript.lastDragged != null)
        {
            float currentWidth = WidthSliderArmor.GetComponent<Slider>().value;
            Vector2 newScale = objectScript.lastDragged.transform.localScale;
            newScale.x = currentWidth; 
            objectScript.lastDragged.transform.localScale = newScale;
        }
    }

    //Dropdows, kas nomaina tēlu, aprakstu un mūziku
    public void Dropdown (int index)
    {
        if (index == 0)
        {
            imageField.GetComponent<Image>().sprite = spriteArray[0];
            scrollViewContent.GetComponent<Text>().text = "I've spent years mastering the art of survival in this unpredictable world. " +
                "Whether I'm exploring deep caverns or battling hordes of zombies at dusk, I never back down. My armor may be dented, and " +
                "my sword might be chipped, but every scar tells a story. Treasure hunting fuels my spirit, and the sound of crafting new gear " +
                "is my anthem. If you're looking for a fearless companion who thrives in danger, I'm your guy. Just don't expect me to build a house I " +
                "prefer the thrill of adventure over settling down!";
            audioScriptCharacter.audioClips = audioClipsBoy;
            }

        else if (index == 1)
        {
            imageField.GetComponent<Image>().sprite = spriteArray[1];
            scrollViewContent.GetComponent<Text>().text = "Magic flows through my veins like the wind through the trees. Ever since I uncovered" +
                " my first enchanted staff, I knew my destiny was to harness the elements and explore the world beyond the surface. Whether soaring" +
                " through the skies or delving into ancient ruins, my curiosity knows no bounds. I believe every hidden chest holds a story, every" +
                " spell whispers a secret, and every challenge is a step toward greatness. I might look peaceful in my floating island retreat, but" +
                " make no mistake when battle calls, the stars themselves answer my command.";
           audioScriptCharacter.audioClips = audioClipsGirl;
           }
           audioScriptCharacter.StopSound();
    }
    //Toggle pogas, kuras parāda un paslēpj bruņas
    public void ToggleDaedalus(bool value)
    {
        DaedHelm.SetActive(value);
        DaedPlate.SetActive(value);
        DaedLeg.SetActive(value);
    }

    public void ToggleGod(bool value)
    {
        GodHelm.SetActive(value);
        GodPlate.SetActive(value);
        GodLeg.SetActive(value);
    }

    public void ToggleStardust(bool value)
    {
        StarHelm.SetActive(value);
        StarPlate.SetActive(value);
        StarLeg.SetActive(value);
    }

    public void ToggleSword(bool value)
    {
        Sword1.SetActive(value);
        Sword2.SetActive(value);
        Sword3.SetActive(value);
    }

    public void UpdateSliders()
    {
        if (objectScript.lastDragged != null)
        {
            // Iegūst pēdējā priekšmeta lieklumu
            Vector2 currentScale = objectScript.lastDragged.transform.localScale;

            // Atjaunina slaideri, kas atbilst esošam priekšmetam
            HeightSliderArmor.GetComponent<Slider>().value = currentScale.y;
            WidthSliderArmor.GetComponent<Slider>().value = currentScale.x;
        }
    }
}
