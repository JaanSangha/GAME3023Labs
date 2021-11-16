using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject abilitiesPanel;

    [SerializeField]
    private float textPromptSecondsPerCharacter = 0.1f;

    public GameObject BattleScene;
    public Text feedbacktext;

    private IEnumerator animateTextCoroutine = null;

    // Start is called before the first frame update
    void Start()
    {
        IEnumerator animateTextCoroutine = AnimateTextCoroutine("You have encountered a wild enemy! Choose an Ability.", textPromptSecondsPerCharacter);
        StartCoroutine(animateTextCoroutine);
    }
    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    IEnumerator AnimateTextCoroutine(string message, float secondsPerCharacter = 0.1f)
    {
        abilitiesPanel.SetActive(false);
        feedbacktext.text = ("");

        for (int currentChar = 0; currentChar < message.Length; currentChar++)
        {
            feedbacktext.text += message[currentChar];
            yield return new WaitForSeconds(secondsPerCharacter);
        }

        abilitiesPanel.SetActive(true);
        animateTextCoroutine = null;
    }

   public void OnRunButtonPressed()
    {
        //BattleScene.SetActive(false);
        Destroy(this.gameObject);
    }
}
