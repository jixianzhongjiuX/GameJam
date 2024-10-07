using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField]private string sceneName;
    //��ó�����
    private void Awake()
    {
        sceneName = "SampleScene";
    }
    public void GetSceneName(string name)
    {
        if (SceneManager.GetSceneByName(name).IsValid())
            Debug.LogError(name + " is not a scene!");
        sceneName = name;
    }
    //������
    public void SwitchToScene()
    {
        if (SceneManager.GetSceneByName(name).IsValid())
            Debug.LogError("missing a scene!");
        //��ʱ�������ظ����볡����player�Ӹ�dontdestroyonload
        SceneManager.LoadScene(sceneName);
    }
}