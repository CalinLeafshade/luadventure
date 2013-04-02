using System;
using System.IO;
using System.Reflection;
using System.Collections;

namespace luadventure
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NonLuaSerializedAttribute : System.Attribute
    {

    }

    public class LuaSerializer
    {

        private int indentLevel = 0;

        public LuaSerializer()
        {
        }

        private void indent(StreamWriter sw)
        {
            for (int i = 0; i < indentLevel; i++) 
            {
                sw.Write("  ");
            }
        }

        private void writeValue(StreamWriter sw, Object obj)
        {
            writeValue(sw, obj, null, 0);
        }

        private void writeValue(StreamWriter sw, Object obj, int index)
        {
            writeValue(sw, obj, null, index);
        }


        private void writeValue(StreamWriter sw, Object obj, PropertyInfo propInfo, int index)
        {
            Type t = obj.GetType();

            if (!Attribute.IsDefined(t, typeof(SerializableAttribute))) 
            {
                return;
            }

            if ((t.IsClass && t != typeof(String)) || t.GetInterface("IList") != null) 
            {
                if (propInfo != null)
                {
                    indent(sw);
                    sw.WriteLine("{0} = {{", propInfo.Name);
                    indentLevel++;
                }

                if (t.GetInterface("IList") != null)
                {
                    IList ie = (IList)obj;
                    for (int i = 0; i < ie.Count; i++) 
                    {
                        writeValue(sw, ie[i], i);
                    }
                }
                else // a normal class
                {
                    foreach (var pi in obj.GetType().GetProperties()) 
                    {
                        if (!Attribute.IsDefined(pi, typeof(NonLuaSerializedAttribute)))
                        {
                            writeValue(sw, pi.GetValue(obj,null), pi, 0);
                        }
                    }
                }

                if (propInfo != null)
                {
                    indentLevel--;
                    indent(sw);
                    sw.WriteLine("},");

                }
            }
            else
            {
                indent(sw);
                string writeVal = t == typeof(String) ? String.Format("\"{0}\"", obj.ToString()) : obj.ToString();
                if (propInfo != null)
                {
                    sw.WriteLine(String.Format("{0} = {1},", propInfo.Name, writeVal));
                }
                else
                {
                    sw.WriteLine(String.Format("[{0}] = {1},", index, writeVal));
                }
            }

        }

        public void Serialize(Stream stream, object obj)
        {
            StreamWriter sw = new StreamWriter(stream);
            sw.WriteLine("return {");
            indentLevel ++;
            writeValue(sw, obj);
            sw.WriteLine("}");
            sw.Flush();
        }

        public object Deserialize(Stream stream)
        {

            return null;
        }


    }
}

