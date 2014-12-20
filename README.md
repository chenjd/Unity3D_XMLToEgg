###Unity3D_XMLToEgg(Unity3D_XML2O)
===
**Unity3D_XMLToEgg** 基于C#编写的Unity3D工具,利用反射和泛型通过读取XML文件创建新的实例并且为实例赋值。		
但是我更喜欢Unity3D_XML2O这个名字，O意味着object也象征着鸡蛋。

***XMLToEgg or called XML2O can convert your XML files into objects.Used reflect && T***

####用法 Usage
===
`XmlToEgg<YourClass>.SetXmlPath(YourXMLPath);`

`Yourclass instance = XmlToEgg<Yourclass>.ToEgg();`

很简单就能生成一个我们需要且从XML文件中读取数据的类。
详细内容参见**xml-to-egg-test**中的内容。

***You can get values from xml files more easily.More details see xml-to-egg-test***