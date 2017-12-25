using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class XMLController : MonoBehaviour {

    public void LoadXmlPart(string XmlPath,string Chapter_name, string part, GameObject text)
    {
        XmlDocument xml = new XmlDocument();
        XmlReaderSettings settings = new XmlReaderSettings
        {
            IgnoreComments = true  //这个设置是忽略xml注释文档的影响。有时候注释会影响到xml的读取
        };
        xml.Load(XmlReader.Create((Application.dataPath + XmlPath), settings));
        XmlNodeList xmlNodeList = xml.SelectSingleNode(Chapter_name).ChildNodes;
        XmlElement rootElem = xml.DocumentElement;
        foreach (XmlElement xl in xmlNodeList)
        {
            if (xl.GetAttribute("part") == part)
            {
                try
                {
                    text.GetComponent<Text>().text = xl.InnerText;
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.StackTrace);
                }
            }
        }
    }
}
