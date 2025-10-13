using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    [Header("UI")]
    public Text textLable;

    [Header("TextContent")]
    public TextAsset textFile;
    public int index;

    List<string> textList = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        GetTextFromFile(textFile);
    }
    private void OnEnable()
    {
        textLable.text = textList[index];
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            textLable.text = textList[index];
            index++;
        }

    }

    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineDate = file.text.Split('\n');
        
        foreach (var line in lineDate)
        {
            textList.Add(line);
        }
    }
}
