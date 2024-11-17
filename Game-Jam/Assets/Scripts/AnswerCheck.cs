using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnswerCheck : MonoBehaviour
{
    public Movement movement;
    public GameObject canvas;
    public InputField inputField; 
    public Button checkButton;    
    public Text feedbackText;     
    public string correctAnswer = "Unity"; //can change in unity ani answer in any object and this script is something like blueprint
    public GameObject sciana;

    

    void Start()
    {
        canvas.SetActive(false); 
        checkButton.onClick.AddListener(CheckAnswer);
    }
    private void OnTriggerEnter2D(){
        canvas.SetActive(true);
    }

    void CheckAnswer()
    {
        
        string playerAnswer = inputField.text;

        
        if (playerAnswer.Equals(correctAnswer, System.StringComparison.OrdinalIgnoreCase))
        {
            //good answer
            feedbackText.text = "Dobrze!";
            feedbackText.color = Color.green;
            sciana.SetActive(false);
        }
        else
        {
            //bad answer
            feedbackText.text = "Źle! Spróbuj ponownie.";
            feedbackText.color = Color.red;
        }
    }
}

