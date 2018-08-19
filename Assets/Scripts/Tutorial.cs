using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    public Transform player;
    public Text tutorialText;

    void Update () 
    {
        if (player.position.z > 130)
        {
            tutorialText.text = "Pay attention to the blacks: they can kill you!";
        }

        if (player.position.z > 190)
        {
            tutorialText.text = "Blue obstacles are bouncing walls!";
        }

        if (player.position.z > 280)
        {
            tutorialText.text = "Use yellows in order to jump!";
        }
	}
}