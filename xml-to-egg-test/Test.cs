using UnityEngine;
using System.Collections;
using EggToolkit;
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		XmlToEgg<TestClass>.SetXmlPath("./Assets/xml-to-egg/xml-to-egg-test/Test.xml");
		TestClass test = XmlToEgg<TestClass>.ToEgg();
		Debug.Log ("test.name:" + test.name);
		Debug.Log ("test.blog:" + test.blog);
		Debug.Log ("test.orgnization:" + test.organization);
		Debug.Log ("test.age:" + test.age);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class TestClass
{
	public string name;
	public string blog;
	public string organization;
	public int age;
}