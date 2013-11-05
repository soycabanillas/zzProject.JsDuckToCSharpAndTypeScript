using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public class ClassTemplateHelper {
        public static Type JavascriptTypeToNetType(string jsType)
        {
            switch (jsType) {
                    case "Boolean":
                        return typeof(Boolean);
                    case "Date":
                        return typeof(DateTime);
                    case "Function":
                        return typeof(String);
                    case "Number":
                        return typeof(Double);
                    case "Object":
                        return typeof(Object);
                    case "RegExp":
                        return typeof(System.Text.RegularExpressions.Regex);
                    case "String":
                        return typeof(String);
                   
                    default:
                        throw new NotImplementedException();
                }
        }

        public static string JavascriptTypeToNetTypeName(string jsType) {
            switch (jsType) {
                case "Boolean":
                    return typeof(Boolean).Name;
                case "Date":
                    return typeof(DateTime).Name;
                case "Function":
                    return typeof(String).Name;
                case "Number":
                    return typeof(Double).Name;
                case "Object":
                    return typeof(Object).Name;
                case "RegExp":
                    return typeof(System.Text.RegularExpressions.Regex).Name;
                case "String":
                    return typeof(String).Name;
                default:
                    return jsType;
            }
        }

        internal string ObtainGetterSetter(string name, string type, string @default) {
            return "";
            string propertyName;
            string propertyType;
            string propertyDefault;

            if (@default != null) propertyDefault = String.Format("private _{0}_default = {1}", name, @default);

            var types = type.Split('/');
            if (types.Count() == 1)
            {
                propertyName = name;
                switch (type) {
                    case "Boolean":
                        propertyType = "bool";
                        break;
                    case "Number":
                        propertyType = "double";
                        break;
                    case "String":
                        propertyType = "string";
                        break;
                    default:
                        throw new NotImplementedException();
                }
            } else if (types.Count() > 1) {
                propertyName = "MultiType_Weight" + name;
            } else {
                throw new NotImplementedException();
            }
        }
    }
}
