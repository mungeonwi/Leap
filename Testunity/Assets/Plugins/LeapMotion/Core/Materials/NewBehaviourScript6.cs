using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
public class NewBehaviourScript6 : MonoBehaviour
{
    Controller controller;
    float HandPalmPitch;
    float HandPalmRoll;
    float HandPalmYam;
    float HandWristRot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        controller = new Controller();
        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;
        if (frame.Hands.Count > 0)
        {
            Hand fristHand = hands[0];
        }

        HandPalmPitch = hands[0].PalmNormal.Pitch;
        HandPalmRoll = hands[0].PalmNormal.Roll;
        HandPalmYam = hands[0].PalmNormal.Yaw;

        HandWristRot = hands[0].WristPosition.Pitch;

        Debug.Log("Pitch : " + HandPalmPitch);
        Debug.Log("Roll : " + HandPalmRoll);
        Debug.Log("Yam : " + HandPalmYam);

        if (HandPalmYam > -2f && HandPalmYam < 3.5f)
        {
            Debug.Log("¾Õ");
           // this.transform.Translate(0, 0, 1 * Time.deltaTime);
            //Application.OpenURL("https://www.naver.com/");
        }
        else if (HandPalmYam < -2.2f)
        {
            Debug.Log("µÚ");
            //this.transform.Translate(0, 0, -1 * Time.deltaTime);
            Application.OpenURL("https://map.kakao.com/");
        }
    }
}
