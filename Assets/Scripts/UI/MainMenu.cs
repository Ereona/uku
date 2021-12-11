using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private InputField _textInput;
    [SerializeField]
    private Button _nextButton;

    private void Start()
    {
        _textInput.text = GameVariables.TextFieldValue;
        _textInput.onValueChanged.AddListener(OnTextInputValueChanged);
        _nextButton.onClick.AddListener(OnNextButtonClick);
    }

    private void OnTextInputValueChanged(string value)
    {
        GameVariables.TextFieldValue = value;
    }

    private void OnNextButtonClick()
    {
        MenuNavigation.OpenModule(ModuleType.Game);
    }

    private void OnDestroy()
    {
        _textInput.onValueChanged.RemoveListener(OnTextInputValueChanged);
        _nextButton.onClick.RemoveListener(OnNextButtonClick);
    }
}
