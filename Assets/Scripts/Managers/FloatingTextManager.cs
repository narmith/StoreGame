using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextManager : MonoBehaviour
{
    public GameObject textPrefab;
    private List<FloatingText> floatingTexts = new List<FloatingText>();

    protected void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        foreach (FloatingText txt in floatingTexts)
        {
            if(txt!=null) txt.UpdateFloatingText();
        }
    }
    
    public void Show(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        FloatingText floatingText = GetFloatingText();
        floatingText.txt.text = msg;
        floatingText.txt.fontSize = fontSize;
        floatingText.txt.color = color;
        floatingText.go.transform.position = Camera.main.WorldToScreenPoint(new Vector3(position.x, position.y + 0.13f, position.z));
        floatingText.motion = motion;
        floatingText.duration = duration;
        floatingText.Show();
    }

    private FloatingText GetFloatingText()
    {
        FloatingText txt = floatingTexts.Find(t => !t.active);

        if(txt == null)
        {
            txt = new FloatingText();
            txt.go = Instantiate(textPrefab);
            txt.go.transform.SetParent(UIMenu.instance.transform);
            txt.txt = txt.go.GetComponent<Text>();

            floatingTexts.Add(txt);
        }

        return txt;
    }
}
