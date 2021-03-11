using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUIscript : MonoBehaviour
{
    public Texture icon;
    bool display = false;

        private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            display = !display;
    }

    public void OnGUI()
    {
        if (display == false)
            return;

        GUI.Box(new Rect(10, 10, 100, 90), "Loader Menu");

        if (GUI.Button(new Rect(20, 40, 80, 20), "Button"))
        {
            Debug.Log("Button pressed at: + " + Time.time);
        }
        if (GUI.Button(new Rect(20, 40, 80, 20), "Button"))
        {
            Debug.Log("Pressed Button 2");
        }



        if (GUI.Button(new Rect(200, 300, 100, 10), icon))
        {
            print("you clicked the icon!");
        }


        if (GUI.Button(new Rect(200, 300, 100, 10),
            new GUIContent("This has words!", icon)))
        {
            print("you clicked the words and the icon!");
        }

        GUI.Button(new Rect(300, 400, 150, 50),
            new GUIContent("Click me!", "This is a tooltip!"));

        GUI.Label(new Rect(300, 450, 150, 20), GUI.tooltip);

    }




}
