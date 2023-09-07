using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    public static string GetDefineName<T>(T type)
    {
        return System.Enum.GetName(typeof(T) , type);
    }
    public static T GetOrAddComponent<T>(GameObject go) where T : UnityEngine.Component
    {
        T component = go.GetComponent<T>();
        if (component == null)
            component = go.AddComponent<T>();
        return component;
    }
    public static GameObject FindChild(GameObject go , string name = null , bool recursive = false)
    {
        Transform transform = FindChild<Transform>(go , name , recursive);
        if (transform == null)
            return null;
        return transform.gameObject;
    }
    public static T FindChild<T>(GameObject go , string name = null , bool recursive = false) where T : UnityEngine.Object
    {
        if (go == null)
            return null;

        //리커시브는 재귀적으로 찾을건지(자식들의 자식들에서도 찾을건지)
        if (!recursive)
        {
            for (int i = 0 ; i < go.transform.childCount ; ++i)
            {
                //트랜스폼은 컴포넌트나 다름이 없다... 일단 객체를 만들면 트랜스폼이랑 컴포넌트가 있으니까 이런식으로 하는느낌?
                Transform transform = go.transform.GetChild(i);
                if (string.IsNullOrEmpty(name) || transform.name == name)
                {
                    T component = transform.GetComponent<T>();
                    if (component != null)
                        return component;
                }
            }
        }
        else
        {
            foreach (T component in go.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(name) || component.name == name)
                    return component;
            }
        }

        return null;
    }

    //게임오브젝트 뭐든 가능하지만 일단 루트용으로만 쓰기위해 루트라고만 지어놨음
    public static void InputRoot(string name , GameObject go)
    {
        GameObject root = GameObject.Find(name);
        if (root == null)
        {
            root = new GameObject { name = name };
        }

        go.transform.SetParent(root.transform);

        return;
    }

}
