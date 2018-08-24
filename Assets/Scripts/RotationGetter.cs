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
public class RotationGetter : MonoBehaviour
{
    private string RotationURL = "";
    private const string FFXIVLink = "http://ffxivrotations.com/";
    int DropdownChoice = 0;
    public PreviousRotations RotDropDown;
    List<string> currentLink;
    public Text responseText;
    // Use this for initialization
    void Start()
    {

    }
    //private IEnumerator WaitUntilResolved(WWW url)
    //{
    //    var engine = new Engine();
    //    engine.OpenUrl("https://html5test.com");
    //    Debug.Log("skillid = " + tagWithValue.InnerHTML);
    //    yield 
    //    responseText.text = url.text;
    //}
    public void StartApplication()
    {
        if (!(RotationURL.Equals(""))) // If URLInput is not empty, use that
        {

            if (RotationURL.StartsWith("http://ffxivrotations.com") || RotationURL.StartsWith("ffxivrotations.com"))
            {
                var driver = new PhantomJSDriver();

                Debug.Log("This URL starts with http://ffxivrotations.com and is valid.");
            }
            else if (RotationURL.Length >= 1 && RotationURL.Length <= 5)
            {
                Debug.Log("This URL doesn't start with http://ffxivrotations.com, but is a valid code.");
            }
            else
            {
                Debug.Log("URL not valid.");
            }
            Debug.Log("RotationURL is currently: " + RotationURL);
        }
        else if (DropdownChoice != 0) // Otherwise use the dropdown choice as long as it's not set to the default
        {
            if (RotDropDown.GetName().Equals("1dnq SMN"))
            {
                //var html = @"http://ffxivrotations.com/1dnq";
                //Debug.Log("Node Name: " + node.Name + "\n" + node.OuterHtml);
            }
            Debug.Log("DropChoice is currently: " + RotDropDown.GetName());
        }
        else
        {
            // Print an error message
        }
    }

    private void GetWebsite()
    {
        List<string> spells = new List<string>();
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
