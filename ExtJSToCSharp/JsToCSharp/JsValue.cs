using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Use the functions of well tested projects like the one that generates C# classes from Json or from a Json Parser.
namespace zzProject.ExtJSToCSharp.JsToCSharp {

    public class JsValueArrayType {
        public string JsTypeName { get; set; }
    }

    public class JsValue {

        public static string ToTypeAndValue(string jsValue) {
            try {
                var jsonReader = new Newtonsoft.Json.JsonTextReader(new System.IO.StringReader(jsValue));

                object prueba1 = null;
                Newtonsoft.Json.JsonConvert.PopulateObject(jsValue, prueba1);
                object prueba2 = Newtonsoft.Json.JsonConvert.DeserializeObject(jsValue);
                jsValue = "['test1', 'test2']";
                object prueba3 = Newtonsoft.Json.JsonConvert.DeserializeObject(jsValue);
                string prueba4 = Newtonsoft.Json.JsonConvert.DeserializeObject<String>(jsValue);
                return "";
            } catch {
                System.Diagnostics.Debug.Assert(true);
                return "";
            }
        }

        public static bool IsString(string jsValue) {
            if (jsValue.Length > 1) {
                if ((jsValue.StartsWith("'") && jsValue.EndsWith("'")) || 
                    (jsValue.StartsWith("\"") && jsValue.EndsWith("\""))) {
                        return true;
                }
            }
            return false;
        }

        public static bool IsNumber(string jsValue) {
            double value;
            return double.TryParse(jsValue, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out value);
        }

        public static bool IsArray(string jsValue) {
            if (jsValue.Trim().EndsWith("[]")) {
                return true;
            } else {
                return false;
            }
        }

        public static string ConvertToString(string jsValue) {
            jsValue = jsValue.Trim();
            if (jsValue.Length > 1 && jsValue.StartsWith("'") && jsValue.EndsWith("'")) {
                jsValue = "\"" + jsValue.Substring(1, jsValue.Length -2) + "\"";
            }
            return jsValue;
        }

        public static double ConvertToDouble(string jsValue) {
            double value;
            if (double.TryParse(jsValue, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out value)) {
                return value;
            } else {
                return default(double);
            }
        }

        public static JsValueArrayType GetArrayType(string jsValue) {
            int arrayDefPosition = jsValue.LastIndexOf("[]");
            string arrayName;
            if (arrayDefPosition < 0) {
                arrayName = "";
            } else {
                arrayName = jsValue.Substring(0, arrayDefPosition);
            }
            return new JsValueArrayType() {
                JsTypeName = arrayName
            };
        }

        //public static IEnumerable<> ConvertToArray(string jsValue) {
        //    double value;
        //    if (double.TryParse(jsValue, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out value)) {
        //        return value;
        //    } else {
        //        return default(double);
        //    }
        //    return new List<>
        //}

        public static string ToCSharpValue(string jsValue)
        {
            //if (JsValue.IsArray(jsValue)) {
                
            //    return JsValue.conver";
            //} else
            if (JsValue.IsString(jsValue)) {
                return JsValue.ConvertToString(jsValue);
            }
            else if (JsValue.IsNumber(jsValue)) {
                return jsValue;
            }
            else {
                return jsValue;
            }
        }
    }
}
