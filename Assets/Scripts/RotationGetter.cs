using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
Take a link from ffxivrotations.com and check the html for the correct rotation
Then output it graphically in unity

Compare class "SkillIcon" in [class "row", label "Sequence"] 

and 

class "SkillSelectorItem" in [class "row", label "Class Skills"/"Summon Skills"/Cross Class Skills"/"Misc"]

if [style="background-image: url("icons/000000.png");"] match up in both, check the latter's class "miniInfo truncate" for name

If the png name doesn't match to anything known, it looks for the miniInfo and/or throws an error

 */
public class RotationGetter : MonoBehaviour {
    string RotationURL = "";
    int DropdownChoice = 0;
    // Use this for initialization
    void Start () {
   
	}
    
    public void StartApplication()
    {
        if (!(RotationURL.Equals(""))) // If URLInput is empty, instead get the dropdown choice
        {
            Debug.Log("RotationURL is currently: " + RotationURL);
        }
        else if (DropdownChoice != 0)
        {
            // If dropdown choice is not 0 and RotationURL is not empty
            Debug.Log("DropChoice is currently: " + DropdownChoice);
        }
        else
        {
            // Print an error message
        }
    }
	public void SetURLInput(string URLInput)
    {
        RotationURL = URLInput;
        Debug.Log("RotationURL is currently: " + RotationURL);
    }
    public void SetDropdown(int DropChoice)
    {
        DropdownChoice = DropChoice;
        Debug.Log("DropChoice is currently: " + DropdownChoice);
    }
}
