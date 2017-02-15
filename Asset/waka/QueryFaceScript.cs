using UnityEngine;
using System.Collections;

public class QueryFaceScript : MonoBehaviour {

    public GameObject head;

    public Material[] eyeOpen;
    public Material[] eyeClose;

    private int counter;
    private bool eyeOpenFlag;

    private const int eyeOpenFrame = 120;
    private const int eyeCloseFrame = 3;

    // Use this for initialization
    void Start () {
        counter = eyeOpenFrame;
        eyeOpenFlag = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        counter--;
        if (counter <= 0)
        {
            if (eyeOpenFlag)
            {
                head.GetComponent<Renderer>().materials = eyeClose;
                counter = eyeCloseFrame;
                eyeOpenFlag = false;
            }
            else
            {
                head.GetComponent<Renderer>().materials = eyeOpen;
                counter = eyeOpenFrame + (int)((float)eyeOpenFrame * Random.value);
                eyeOpenFlag = true;
            }
        }
    }
}
