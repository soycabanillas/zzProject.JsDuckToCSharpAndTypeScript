using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzProject.ExtJSToCSharp.JsToCSharp {
    public class JsType {

        private string _namespacePrefix;
        private string _namespacePrefixWithDot;

        public JsType(string namespacePrefix = "") {
            _namespacePrefix = namespacePrefix;
            _namespacePrefixWithDot = _namespacePrefix != "" ? _namespacePrefix + "." : "";
        }

        public Type GetNetType(string jsType)
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
                        return Type.GetType(_namespacePrefixWithDot + jsType);
                }
        }

        public string GetNetTypeName(string jsType) {
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
                    var dotPosition = jsType.LastIndexOf(".");
                    if (dotPosition < 0) return jsType;
                    else return jsType.Substring(dotPosition + 1);
            }
        }

        public string GetNetTypeNamespace(string jsType) {
            switch (jsType) {
                case "Boolean":
                    return typeof(Boolean).Namespace;
                case "Date":
                    return typeof(DateTime).Namespace;
                case "Function":
                    return typeof(String).Namespace;
                case "Number":
                    return typeof(Double).Namespace;
                case "Object":
                    return typeof(Object).Namespace;
                case "RegExp":
                    return typeof(System.Text.RegularExpressions.Regex).Namespace;
                case "String":
                    return typeof(String).Namespace;
                default:
                    var dotPosition = jsType.LastIndexOf(".");
                    if (dotPosition < 0) return _namespacePrefix;
                    else return _namespacePrefixWithDot + jsType.Substring(0, dotPosition);
            }
        }

        public string GetNetTypeFullName(string jsType) {
            switch (jsType) {
                case "Boolean":
                    return typeof(Boolean).FullName;
                case "Date":
                    return typeof(DateTime).FullName;
                case "Function":
                    return typeof(String).FullName;
                case "Number":
                    return typeof(Double).FullName;
                case "Object":
                    return typeof(Object).FullName;
                case "RegExp":
                    return typeof(System.Text.RegularExpressions.Regex).FullName;
                case "String":
                    return typeof(String).FullName;
                default:
                    return _namespacePrefixWithDot + jsType;
            }
        }


    }
}
