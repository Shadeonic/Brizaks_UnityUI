using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject boy;
    public GameObject girl;
    public GameObject left;
    public GameObject right;
    public GameObject imageField;
    public Sprite[] spriteArray;
    public GameObject HeightSlider;
    public GameObject WidthSlider;


    public void ChangeHeight()
    {
        float currentHeight = HeightSlider.GetComponent<Slider>().value;
        Vector2 newScale = imageField.transform.localScale;
        newScale.y = currentHeight; // Modify only the height
        imageField.transform.localScale = newScale;
    }

    public void ChangeWidth()
    {
        float currentHeight = WidthSlider.GetComponent<Slider>().value;
        Vector2 newScale = imageField.transform.localScale;
        newScale.x = currentHeight; // Modify only the height
        imageField.transform.localScale = newScale;
    }

    public void Dropdown (int index)
    {
        if(index == 0) 
            imageField.GetComponent<Image>().sprite = spriteArray[0];

        else if (index == 1)
            imageField.GetComponent<Image>().sprite = spriteArray[1];
    }

    // public void ToggleBean(bool value)
    // {
    //     bean.SetActive(value);
    //     left.GetComponent<Toggle>().interactable = value;
    //     right.GetComponent<Toggle>().interactable = value;
    // }

    // public void ToggleTeddy(bool value)
    // {
    //     teddy.SetActive(value);
    // }

    // public void ToggleCar(bool value)
    // {
    //     car.SetActive(value);
    // }

    // public void ToggleLady(bool value)
    // {
    //     lady.SetActive(value);
    // }

    // public void ToLeft()
    // {
    //     bean.transform.localScale = new Vector2 (1, 1);
    // }

    // public void ToRight()
    // {
    //     bean.transform.localScale = new Vector2(-1, 1);
    // }
}
