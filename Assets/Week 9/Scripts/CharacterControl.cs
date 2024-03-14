using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }

    public static TextMeshProUGUI characterSelected;

    void Start()
    {
        characterSelected = GetComponent<TextMeshProUGUI>();
    }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
            characterSelected.text = "Non Selected";
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        

    }



}
