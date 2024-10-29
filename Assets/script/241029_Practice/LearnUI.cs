using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearnUI : MonoBehaviour
{
    [SerializeField]
    private Text  _text;
    [SerializeField]
    private Image  _image;   
    
    [SerializeField]
    private Sprite _spriteToChange;
    [SerializeField]
    private Button _button;
    [SerializeField]
    private InputField _inputField;
    void Start()
    {
        _text.text = "HelloGUI";
        _text.color = Color.red;
        _image.sprite = _spriteToChange;
        _button.onClick.AddListener(OnGUIButtonClicked);
    }

    public void OnGUIButtonClicked()
    {
        string inputContent =_inputField.text;
        Debug.Log("剛剛已被點擊"+inputContent);
    }
    // private void OnGUI() 
    // {
    //  GUI.Label(new Rect(30,30,300,100),"這是IMGUI顯式的文字");
    //  if(GUI.Button(new Rect(30,80,150,30),"這是IMGUI的按鈕"))
    //  {
    //     Debug.Log("");
    //  }

    // }
}
