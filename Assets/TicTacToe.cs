using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    InputField chatbox;
    Button restartButton, replayButton, leaveButton, sendButton;
    Button button0, button1, button2, button3, button4, button5, button6, button7, button8;

    public bool[] buttonPressed = new bool[9];

    private void Start()
    {
        for(int i = 0; i < buttonPressed.Length; i++)
        {
            buttonPressed[i] = false;
        }

    }

    private void OnEnable()
    {
        InputField[] allInputfields = UnityEngine.Object.FindObjectsOfType<InputField>();

        foreach (InputField Inf in allInputfields)
        {
            if (Inf.name == "ChatBox")
                chatbox = Inf;
        }

        Button[] allButtons = UnityEngine.Object.FindObjectsOfType<Button>();

        foreach (Button Bu in allButtons)
        {
            if (Bu.name == "Restart")
                restartButton = Bu;
            else if (Bu.name == "Replay")
                replayButton = Bu;
            else if (Bu.name == "Leave")
                leaveButton = Bu;
            else if (Bu.name == "Send")
                sendButton = Bu;
            //tictactoe board
            else if (Bu.name == "0")
                button0 = Bu;
            else if (Bu.name == "1")
                button1 = Bu;
            else if (Bu.name == "2")
                button2 = Bu;
            else if (Bu.name == "3")
                button3 = Bu;
            else if (Bu.name == "4")
                button4 = Bu;
            else if (Bu.name == "5")
                button5 = Bu;
            else if (Bu.name == "6")
                button6 = Bu;
            else if (Bu.name == "7")
                button7 = Bu;
            else if (Bu.name == "8")
                button8 = Bu;
        }

        button0.GetComponent<Button>().onClick.AddListener(button0_pressed);
        button1.GetComponent<Button>().onClick.AddListener(button1_pressed);
        button2.GetComponent<Button>().onClick.AddListener(button2_pressed);
        button3.GetComponent<Button>().onClick.AddListener(button3_pressed);
        button4.GetComponent<Button>().onClick.AddListener(button4_pressed);
        button5.GetComponent<Button>().onClick.AddListener(button5_pressed);
        button6.GetComponent<Button>().onClick.AddListener(button6_pressed);
        button7.GetComponent<Button>().onClick.AddListener(button7_pressed);
        button8.GetComponent<Button>().onClick.AddListener(button8_pressed);
    }

    private void button0_pressed()
    {
        buttonPressed[0] = true;
    }

    private void button1_pressed()
    {
        buttonPressed[1] = true;
    }

    private void button2_pressed()
    {
        buttonPressed[2] = true;
    }

    private void button3_pressed()
    {
        buttonPressed[3] = true;
    }

    private void button4_pressed()
    {
        buttonPressed[4] = true;
    }

    private void button5_pressed()
    {
        buttonPressed[5] = true;
    }

    private void button6_pressed()
    {
        buttonPressed[6] = true;
    }

    private void button7_pressed()
    {
        buttonPressed[7] = true;
    }

    private void button8_pressed()
    {
        buttonPressed[8] = true;
    }
}
