public class MonoBehaviour Script: MonoBehaviour{
    Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
        controller.Config.SetFloat("Gesture.Swipe.MinLength", 200.0f);
        controller.Config.SetFloat("Gesture.Swipe.Minvelocity", 750f);
        controller.Config.Save();
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = controller.Frame();
        GestureList gestures = frame.Gestures();
        for (int i = 0; i < gestures.Count; i++)
        {
            Gesture gesture = gestures[i];
            if (gesture.Type == gesture.Gesture.GestureType.TYPESWIPE)
            {
                SwipeGesture Swipe = new SwipeGesture(gesture);
                Vector swipDirection = Swipe.Direction;
                if (swipeDirection.x < 0)
                {
                    Debug.Log("Left");
                }
                else if (swipDirection.x > 0)
                {
                    Debug.Log("Right");
                }
            }
        }

    }
}
