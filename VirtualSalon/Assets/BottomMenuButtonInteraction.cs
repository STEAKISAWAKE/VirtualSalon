using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomMenuButtonInteraction : MonoBehaviour
{

    [Header("Feed Variables")]
    public GameObject FeedButton;
    public Sprite FeedButtonSprite;
    public Sprite FeedButtonPressedSprite;

    [Header("Blog Variables")]
    public GameObject BlogButton;
    public Sprite BlogButtonSprite;
    public Sprite BlogButtonPressedSprite;

    [Header("Virtual Salon Variables")]
    public GameObject VSalonButton;
    public Sprite VSalonButtonSprite;
    public Sprite VSalonButtonPressedSprite;

    [Header("Other1 Variables")]
    public GameObject Other1Button;
    public Sprite Other1ButtonSprite;
    public Sprite Other1ButtonPressedSprite;

    [Header("Other2 Variables")]
    public GameObject Other2Button;
    public Sprite Other2ButtonSprite;
    public Sprite Other2ButtonPressedSprite;


    //Determines which screen we are at and which sprite to display as 
    public enum Menu { Feed, Blog, VSalon, Other1, Other2 };

    public Menu CurrentMenu = Menu.Feed;

    public void FeedButtonPressed()
    {

        if (CurrentMenu != Menu.Feed)
        {
            CurrentMenu = Menu.Feed;

            ClearBoldButtons();

            //VSalonButton.transform.GetChild(0).GetComponent<Image>().sprite = VSalonButtonPressedSprite;
        }
    }

    public void BlogButtonPressed()
    {
        if (CurrentMenu != Menu.Blog)
        {
            CurrentMenu = Menu.Blog;

            ClearBoldButtons();

            //VSalonButton.transform.GetChild(0).GetComponent<Image>().sprite = VSalonButtonPressedSprite;
        }
    }

    //Clears all of the sprites back to their original non bold versions
    public void VirtualSalonButtonPressed()
    {
        Debug.Log("Pressed VSalon Button.");

        if (CurrentMenu != Menu.VSalon)
        {
            CurrentMenu = Menu.VSalon;

            ClearBoldButtons();

            VSalonButton.transform.GetChild(0).GetComponent<Image>().sprite = VSalonButtonPressedSprite;
        }
    }

    public void Other1ButtonPressed()
    {
        if (CurrentMenu != Menu.Other1)
        {
            CurrentMenu = Menu.Other1;

            ClearBoldButtons();

            //VSalonButton.transform.GetChild(0).GetComponent<Image>().sprite = VSalonButtonPressedSprite;
        }
    }
    public void Other2ButtonPressed()
    {
        if (CurrentMenu != Menu.Other2)
        {
            CurrentMenu = Menu.Other2;

            ClearBoldButtons();

            //VSalonButton.transform.GetChild(0).GetComponent<Image>().sprite = VSalonButtonPressedSprite;
        }
    }

    void ClearBoldButtons()
    {
        //FeedButton.transform.GetChild(0).GetComponent<Image>().sprite = FeedButtonSprite;
        //BlogButton.transform.GetChild(0).GetComponent<Image>().sprite = BlogButtonSprite;
        VSalonButton.transform.GetChild(0).GetComponent<Image>().sprite = VSalonButtonSprite;
        //Other1Button.transform.GetChild(0).GetComponent<Image>().sprite = Other1ButtonSprite;
        //Other2Button.transform.GetChild(0).GetComponent<Image>().sprite = Other2ButtonSprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        FeedButtonPressed();
    }

    // Update is called once per frame
    void Update()
    {
           
    }

}
