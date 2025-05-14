using UnityEngine;
using UnityEngine.UIElements;
public class MainUI :MonoBehaviour
 {

[SerializeField] UIDocument myUI;

    private Button myButton;

    void OnEnable()
    {
        // Get the UIDocument component attached to the same GameObject
       // var uiDocument = myUI GetComponent<UIDocument>();

        // Get the root VisualElement
        VisualElement root = myUI.rootVisualElement;

        // Query the Button by name
        myButton = root.Q<Button>("topButton");

        // Register a callback
        if (myButton != null)
        {
            myButton.clicked += OnMyButtonClick;
        }
    }

    private void OnMyButtonClick()
    {
        Debug.Log("Button clicked!");
    }
}
