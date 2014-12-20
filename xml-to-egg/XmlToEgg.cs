/// <summary>
/// XmlToEgg
/// Created by chenjd
/// http://www.cnblogs.com/murongxiaopifu/
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace EggToolkit
{
	public static class XmlToEgg<T> where T : class
	{
		private static string path;
		private static T target;
		
		static XmlToEgg()
		{
		}
		/// <summary>
		/// Sets the xml path.
		/// </summary>
		public static void SetXmlPath(string p)
		{
			path = p;
		}
		/// <summary>
		/// Loads the XML Files.
		/// </summary>
		private static XElement LoadXML()
		{
			if(path == null)
				return null;
			XElement xml = XElement.Load(path);
			return xml;
		}
		/// <summary>
		/// Creates the class initiate.
		/// </summary>
		private static void CreateInitiate()
		{
			Type t = typeof(T);
			ConstructorInfo ct = t.GetConstructor(System.Type.EmptyTypes);
			target = (T)ct.Invoke(null);
		}
		/// <summary>
		/// attribute assignment,
		/// 由于反射中设置字段值的方法会涉及到赋值的目标类型和当前类型的转化，
		/// 所以需要使用Convert.ChangeType进行类型转化
		/// </summary>
		public static T ToEgg()
		{
			if(target != null)
			{
				target = null;
			}
			CreateInitiate();
			XElement xml = LoadXML();
			Type t = target.GetType();
			FieldInfo[] fields = t.GetFields();
			string fieldName = string.Empty;
			foreach(FieldInfo f in fields)
			{
				fieldName = f.Name;
				if(xml.Element(fieldName) != null)
				{
					f.SetValue(target, Convert.ChangeType(xml.Element(fieldName).Value, f.FieldType));
				}
			}
			return target;
		}
	}
	
	public class TestClass
	{
		public string name;
		public int	age;
	}
}
