using System.Collections;
using System.Collections.Generic;
using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersSafetySystems : MonoBehaviour
{
    string QuizName;
    public int score = 0;
    public SafetySystemsQuiz SafetySystemsQuiz;
    public Text m_Text;
    void Start()
    {
        QuizName = this.name;
    }

    //SafetySystemsKnowledgeCheck
    public void _CheckAnswers(int answer){
        score = score + answer;
        SafetySystemsQuiz._ChangeQuestion();
    }
}
