using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviousRotations : MonoBehaviour
{
    List<string> names = new List<string>() { "Code + Description if available", "Code2", "Code3", "Code4" };

    public Dropdown dropdown;
    public RotationGetter linkedNum;
    /* TODO: Write a getter to be run when Continue or Enter is pressed, which sends the name of the selected dropdown option 
     * to the RotationGetter.
     * 
    */
    public void GetIndexOfDropdown()
    {
        linkedNum.SetDropdown(dropdown.value);
    }
    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        // TODO: Read these values from a file containing information about previous rotations used

        dropdown.AddOptions(names);
    }
}
