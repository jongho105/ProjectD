using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
public class ResourceManager : MonoBehaviour
{
    public void Awake()
    {
        Load();
    }

    public void Load()
    {
        // xml File
        XmlDocument xdoc = new XmlDocument();

        string dd = Application.persistentDataPath;

        Debug.Log(dd);
        //XmlNode root = xdoc.CreateElement("Employees");
        //xdoc.AppendChild(root);

        //XmlNode emp1 = xdoc.CreateElement("Employee");
        //XmlAttribute attr = xdoc.CreateAttribute("Id");
        //attr.Value = "1001";
        //emp1.Attributes.Append(attr);

        //xdoc.Load(@"C:\")


    }
}
