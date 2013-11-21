using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zzProject.ExtJSToCSharp {
    public class ClassGeneratorHelper {



        //private static string GenerateFromSingleType(string Type) {
        //    int arrayMarkPosition = Type.LastIndexOf("[]");
        //    bool isArray;
        //    if (arrayMarkPosition >= 0) {
        //        Type = Type.Substring(0, arrayMarkPosition);
        //        isArray = true;
        //    } else {
        //        isArray = false;
        //    }
        //    string TypeUppercase = Type.ToUpperInvariant();
        //    switch (TypeUppercase) {
        //        case "ARRAY":
        //            if (isArray) return "List<object>";
        //            else return "List<object>";
        //        case "BOOLEAN":
        //            if (isArray) return "List<bool>";
        //            else return "bool";
        //        case "DATE":
        //            if (isArray) return "List<DateTime>";
        //            else return "DateTime";
        //        case "FUNCTION":
        //            if (isArray) return "List<String>";
        //            else return "String";
        //        case "NUMBER":
        //            if (isArray) return "List<double>";
        //            else return "double";
        //        case "OBJECT":
        //            if (isArray) return "List<object>";
        //            else return "object";
        //        case "REGEXP":
        //            if (isArray) return "List<System.Text.RegularExpressions.Regex>";
        //            else return "System.Text.RegularExpressions.Regex";
        //        case "STRING":
        //            if (isArray) return "List<string>";
        //            else return "string";
        //        default:
        //            if (isArray) return String.Format("List<{0}>", Type);
        //            else return Type;
        //    }
        //}

        //private class TypeAndDefault {
        //    public Type Type { get; private set; }
        //    public string TypeName { get; private set; }
        //    public string Default { get; private set; }

        //    public TypeAndDefault(Type type, string @default) {
        //        this.Type = type;
        //        this.TypeName = type.FullName;
        //        this.Default = @default;
        //    }

        //    public TypeAndDefault(string typeName, string @default) {
        //        this.TypeName = typeName;
        //        this.Default = @default;
        //    }
        //}

        //private static TypeAndDefault GetTypeAndDefault(string @type, string defaultValue) {
        //    int arrayMarkPosition = @type.LastIndexOf("[]");
        //    bool isArray;
        //    if (arrayMarkPosition >= 0) {
        //        @type = @type.Substring(0, arrayMarkPosition);
        //        isArray = true;
        //    } else {
        //        isArray = false;
        //    }

        //    Type netType;
        //    string TypeUppercase = @type.ToUpperInvariant();
        //    bool isKnownType;
        //    switch (TypeUppercase) {
        //        case "ARRAY":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<object>);
        //            else netType = typeof(List<object>);
        //            break;
        //        case "BOOLEAN":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<bool>);
        //            else netType = typeof(bool);
        //            break;
        //        case "DATE":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<DateTime>);
        //            else netType = typeof(DateTime);
        //            break;
        //        case "FUNCTION":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<string>);
        //            else netType = typeof(string);
        //            break;
        //        case "NUMBER":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<double>);
        //            else netType = typeof(double);
        //            break;
        //        case "OBJECT":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<object>);
        //            else netType = typeof(object);
        //            break;
        //        case "REGEXP":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<System.Text.RegularExpressions.Regex>);
        //            else netType = typeof(System.Text.RegularExpressions.Regex);
        //            break;
        //        case "STRING":
        //            isKnownType = true;
        //            if (isArray) netType = typeof(List<string>);
        //            else netType = typeof(string);
        //            break;
        //        default:
        //            isKnownType = false;
        //            if (isArray) netType = typeof(List<object>);
        //            else netType = typeof(object);
        //            break;
        //    }
            
        //    object valueObject = Newtonsoft.Json.JsonConvert.DeserializeObject(defaultValue, netType);
        //    string resultValue;
        //    if (valueObject == null) {
        //        resultValue = "";
        //    } else {
        //        resultValue = valueObject.ToString();
        //    }
        //    TypeAndDefault result;
        //    if (isKnownType) {
        //        result = new TypeAndDefault(netType, resultValue);
        //    }
        //    else {
        //        result = new TypeAndDefault(netType.FullName, resultValue);
        //    }
            
        //    return result;
        //}

        //private static Type GetType(string Type) {
        //    int arrayMarkPosition = Type.LastIndexOf("[]");
        //    bool isArray;
        //    if (arrayMarkPosition >= 0) {
        //        Type = Type.Substring(0, arrayMarkPosition);
        //        isArray = true;
        //    } else {
        //        isArray = false;
        //    }
        //    string TypeUppercase = Type.ToUpperInvariant();
        //    switch (TypeUppercase) {
        //        case "ARRAY":
        //            if (isArray) return typeof(List<object>);
        //            else return typeof(List<object>);
        //        case "BOOLEAN":
        //            if (isArray) return typeof(List<bool>);
        //            else return typeof(bool);
        //        case "DATE":
        //            if (isArray) return typeof(List<DateTime>);
        //            else return typeof(DateTime);
        //        case "FUNCTION":
        //            if (isArray) return typeof(List<string>);
        //            else return typeof(string);
        //        case "NUMBER":
        //            if (isArray) return typeof(List<double>);
        //            else return typeof(double);
        //        case "OBJECT":
        //            if (isArray) return typeof(List<object>);
        //            else return typeof(object);
        //        case "REGEXP":
        //            if (isArray) return typeof(List<System.Text.RegularExpressions.Regex>);
        //            else return typeof(System.Text.RegularExpressions.Regex);
        //        case "STRING":
        //            if (isArray) return typeof(List<string>);
        //            else return typeof(string);
        //        default:
        //            if (isArray) return typeof(List<object>);
        //            else return typeof(object);
        //    }
        //}

        //public static string GenerateFromType(string @type, string defaultValue) {
        //    //Test: "prueba"/"test"/object/"arroz/marisco"/"otro"
        //    //Expresion: \G(?<const>"[^"]*")(/|\z)|\G(?<type>[^"][^/"]*)(/|\z)
        //    System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(@type, @"\G(?<const>""[^""]*"")(/|\z)|\G(?<type>[^""][^/""]*)(/|\z)", System.Text.RegularExpressions.RegexOptions.Multiline);
        //    var types = new List<TypeAndDefault>();
        //    var constants = new System.Collections.Generic.SortedSet<string>();
        //    for (int i = 0; i < matches.Count; i++) {
        //        var match = matches[i];
        //        if (!string.IsNullOrEmpty(match.Groups["type"].Value)) { 
        //            //types.Add(GenerateFromSingleType(match.Groups["type"].Value));
        //            TypeAndDefault typeAndDefault = GetTypeAndDefault(@type, defaultValue);
        //            if (!types.Any(t => t.Type == typeAndDefault.Type))
        //            {
        //                types.Add(typeAndDefault);
        //            }
        //            //var assignables = types.Where(t => t.Type == typeAndDefault.Type);
        //            //{
        //            //    types.Add(typeAndDefault);
        //            //}
        //            defaultValue = typeAndDefault.Default;
        //        } else if (!string.IsNullOrEmpty(match.Groups["const"].Value)) {
        //            constants.Add(match.Groups["const"].Value);
        //        }
        //    }
        //    return "";
        //}
    }
}
