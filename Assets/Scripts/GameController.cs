using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button okButton;
    public InputField answerField;
    public Text displayText;
    public Text storyplay;

    string[] answers;
    string[] questions;
    int currentQuestionNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        answers = new string[3];
        questions = new string[] { 
            "What's your name?",
            "What's animal do you like?",
            "What's your favorite food?" 
        };
        displayText.text = questions[currentQuestionNumber];
    }
    public void printName()
    {
            answers[currentQuestionNumber] = answerField.text;
            answerField.text = "";

            currentQuestionNumber = currentQuestionNumber + 1;

        if (currentQuestionNumber <= 2)
        {
            displayText.text = questions[currentQuestionNumber];
        }
        else
        {
            displayText.text = "My name is " + answers[0] + "." +
                            " I like " + answers[1] + 
                            " and " + answers[2];


            okButton.gameObject.SetActive(false);
            answerField.gameObject.SetActive(false);
        }

        
    }
    // Update is called once per frame
    void Update()
    {
        //  print(answerField.text);
        //answer2 = answerField.text;
        //answer3 = answerField.text;
        /* string answer1 = "";
        string answer2 = ""; 
        string answer3 = "";*/
    }
}
