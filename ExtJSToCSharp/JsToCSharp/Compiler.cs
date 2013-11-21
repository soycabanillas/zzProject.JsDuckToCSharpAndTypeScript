using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zzProject.ExtJSToCSharp.JsToCSharp {
    public class Compiler {
        private static Helpers.TypeAndDefault GetTypeAndDefault(string @type/*, string defaultValue*/) {
            int arrayMarkPosition = @type.LastIndexOf("[]");
            bool isArray;
            if (arrayMarkPosition >= 0) {
                @type = @type.Substring(0, arrayMarkPosition);
                isArray = true;
            } else {
                isArray = false;
            }

            Type netType;
            string TypeUppercase = @type.ToUpperInvariant();
            bool isKnownType;
            switch (TypeUppercase) {
                case "ARRAY":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<object>);
                    else netType = typeof(List<object>);
                    break;
                case "BOOLEAN":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<bool>);
                    else netType = typeof(bool);
                    break;
                case "DATE":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<DateTime>);
                    else netType = typeof(DateTime);
                    break;
                case "FUNCTION":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<string>);
                    else netType = typeof(string);
                    break;
                case "NUMBER":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<double>);
                    else netType = typeof(double);
                    break;
                case "OBJECT":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<object>);
                    else netType = typeof(object);
                    break;
                case "REGEXP":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<System.Text.RegularExpressions.Regex>);
                    else netType = typeof(System.Text.RegularExpressions.Regex);
                    break;
                case "STRING":
                    isKnownType = true;
                    if (isArray) netType = typeof(List<string>);
                    else netType = typeof(string);
                    break;
                default:
                    isKnownType = false;
                    if (isArray) netType = typeof(List<object>);
                    else netType = typeof(object);
                    break;
            }

            //object valueObject = Newtonsoft.Json.JsonConvert.DeserializeObject(defaultValue, netType);
            //string resultValue;
            //if (valueObject == null) {
            //    resultValue = "";
            //} else {
            //    resultValue = valueObject.ToString();
            //}
            Helpers.TypeAndDefault result;
            if (isKnownType) {
                result = new Helpers.TypeAndDefault(netType/*, resultValue*/);
            } else {
                result = new Helpers.TypeAndDefault(netType.FullName/*, resultValue*/);
            }

            return result;
        }

        //private Helpers.TypeAndDefault GenerateFromType(string @type/*, string defaultValue*/) {
        //    //Test: "prueba"/"test"/object/"arroz/marisco"/"otro"
        //    //Expresion: \G(?<const>"[^"]*")(/|\z)|\G(?<type>[^"][^/"]*)(/|\z)
        //    System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(@type, @"\G(?<const>""[^""]*"")(/|\z)|\G(?<type>[^""][^/""]*)(/|\z)", System.Text.RegularExpressions.RegexOptions.Multiline);
        //    var types = new List<Helpers.TypeAndDefault>();
        //    var constants = new System.Collections.Generic.SortedSet<string>();
        //    for (int i = 0; i < matches.Count; i++) {
        //        var match = matches[i];
        //        var typeValue = match.Groups["type"].Value;
        //        if (!string.IsNullOrEmpty(typeValue)) {
        //            //types.Add(GenerateFromSingleType(match.Groups["type"].Value));
        //            Helpers.TypeAndDefault typeAndDefault = GetTypeAndDefault(typeValue/*, defaultValue*/);
        //            if (!types.Any(t => t.Type == typeAndDefault.Type)) {
        //                types.Add(typeAndDefault);
        //            }
        //            //var assignables = types.Where(t => t.Type == typeAndDefault.Type);
        //            //{
        //            //    types.Add(typeAndDefault);
        //            //}
        //            //defaultValue = typeAndDefault.Default;
        //        } else if (!string.IsNullOrEmpty(match.Groups["const"].Value)) {
        //            constants.Add(match.Groups["const"].Value);
        //        }
        //    }
        //    return new JsDuckJsonParser.Class.Helpers.TypesAndConstants(types, constants.ToList(), null);
        //}

        //http://msdn.microsoft.com/en-us/library/ms404245%28v=vs.110%29.aspx
        public static CodeCompileUnit GenerateCSharpCode(JsDuckJsonParser.Class.ClassDefinition cd, Func<string, string> idProvider) {

            JsType typeConverter = new JsToCSharp.JsType("zzProject.ExtJSNet.ExtJS.Classes");
            string classNamespace = typeConverter.GetNetTypeNamespace(cd.Name);
            string className = typeConverter.GetNetTypeName(cd.Name);
            string extendsClassFullName = null;
            if (!string.IsNullOrWhiteSpace(cd.Extends)) {
                extendsClassFullName = typeConverter.GetNetTypeFullName(cd.Extends);
            }


            CodeCompileUnit targetUnit;
            CodeTypeDeclaration targetClass;
            targetUnit = new CodeCompileUnit();
            CodeNamespace @namespace = new CodeNamespace(classNamespace);
            @namespace.Imports.Add(new CodeNamespaceImport("System"));
            targetClass = new CodeTypeDeclaration(idProvider(className));
            targetClass.IsClass = true;
            targetClass.IsPartial = true;
            targetClass.TypeAttributes = TypeAttributes.Public;
            if (extendsClassFullName != null) {
                targetClass.BaseTypes.Add(new CodeTypeReference(extendsClassFullName));
            }
            @namespace.Types.Add(targetClass);
            targetUnit.Namespaces.Add(@namespace);


            foreach (var config in cd.GetMembers(JsDuckJsonParser.Class.MemberTypeEnum.cfg)) {
            if (config.Owner == cd.Name && config.Private.GetValueOrDefault(false) == false)
            {
                if (config.Default != null) {
                    // Declare the widthValue field.
                    CodeMemberField defaultValueField = new CodeMemberField();
                    defaultValueField.Attributes = MemberAttributes.Public;
                    defaultValueField.Name = idProvider("_" + config.Name + "_default");
                    defaultValueField.Type = new CodeTypeReference(typeof(System.String));
                    defaultValueField.InitExpression = new CodePrimitiveExpression(config.Default);
                    //defaultValueField.Comments.Add(new CodeCommentStatement("The width of the object."));
                    targetClass.Members.Add(defaultValueField);
                }
                var types = config.GetTypes();

                var innerClassName = "MultiType_" + config.Name;
                CodeTypeDeclaration innerClass;
                innerClass = new CodeTypeDeclaration(idProvider(innerClassName));
                innerClass.IsClass = true;
                innerClass.TypeAttributes = TypeAttributes.Public;
                if (types.Constants.Count() > 0) {
                    //TODO: Create enumerator
                }
                foreach (var type in types.Types) {
                    var typeAndDefault = GetTypeAndDefault(type);

                    CodeMemberField innerMemberField = new CodeMemberField();
                    innerMemberField.Attributes = MemberAttributes.Public;
                    innerMemberField.Name = idProvider("_" + typeAndDefault.TypeName + "_type");
                    innerMemberField.Type = new CodeTypeReference(typeAndDefault.TypeName);
                    //innerMemberField.InitExpression = new CodePrimitiveExpression(config.Default);
                    //defaultValueField.Comments.Add(new CodeCommentStatement("The width of the object."));
                    innerClass.Members.Add(innerMemberField);

                    CodeMemberProperty innerProperty = new CodeMemberProperty();
                    innerProperty.Attributes =
                        MemberAttributes.Public | MemberAttributes.Final;
                    innerProperty.Name = idProvider("As" + type);
                    innerProperty.HasGet = true;
                    innerProperty.HasSet = true;
                    innerProperty.Type = new CodeTypeReference(typeAndDefault.TypeName);
                    //widthProperty.Comments.Add(new CodeCommentStatement(
                    //    "The Width property for the object."));
                    innerProperty.GetStatements.Add(new CodeMethodReturnStatement(
                            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), innerMemberField.Name)
                        )
                    );
                    innerProperty.SetStatements.Add(new CodeAssignStatement(
                            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), innerMemberField.Name),
                            new CodePropertySetValueReferenceExpression()
                        )
                    );
                    //property.GetStatements.Add(new CodeMethodReturnStatement(
                    //    new CodeFieldReferenceExpression(
                    //    new CodeThisReferenceExpression(), "attributes")));
                    innerClass.Members.Add(innerProperty);
                }
                //innerClass.BaseTypes.Add(new CodeTypeReference(""));
                targetClass.Members.Add(innerClass);
                //            <text>
                //public class @propTypeName {
                //    public new Type GetType()
                //    {
                //        return _value.GetType();
                //    }

                //                @foreach (var type in types)
                //                {
                //                    var subTypeName = typeConverter.GetNetTypeFullName(type);
                //                    <text>
                //    public static explicit operator @subTypeName (@propTypeName m)
                //    {
                //        if (m._value.GetType() == typeof(@subTypeName)) return (@subTypeName)m._value;
                //        else return default(@subTypeName);
                //    }
                //    public static implicit operator @propTypeName (@subTypeName m) {
                //        return new @propTypeName { _value = m };
                //    }
                //                    </text>
                //                }

                //    private object _value;
                //    public object @@object  { get { return _value; } set { _value = value; } }
                //    public int @@int { get { return (int) _value; } set { _value = value; } }
                //    public string @@function { get { return (string) _value; } set { _value = value; } }
                //}

                //[JsonIgnore]
                //public @propTypeName @config.Name { get { return this.attributes.GetOrDefault<@propTypeName>("@config.Name" @if (!string.IsNullOrWhiteSpace(@config.Default)) { @(", " + @config.Default) }); } set { this.attributes["@config.Name"] = value; } }                

                CodeMemberProperty property = new CodeMemberProperty();
                property.Attributes =
                    MemberAttributes.Public | MemberAttributes.Final;
                property.Name = idProvider(config.Name);
                property.HasGet = true;
                property.HasSet = true;
                property.Type = new CodeTypeReference(typeof(System.Object));
                //widthProperty.Comments.Add(new CodeCommentStatement(
                //    "The Width property for the object."));
                property.GetStatements.Add(new CodeMethodReturnStatement(
                        new CodeArrayIndexerExpression(
                            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "attributes"),
                            new CodePrimitiveExpression(config.Name)
                        )
                    )
                );
                property.SetStatements.Add(new CodeAssignStatement(
                        new CodeArrayIndexerExpression(
                            new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "attributes"),
                            new CodePrimitiveExpression(config.Name)
                        ),
                        new CodePropertySetValueReferenceExpression()
                    )
                );
                //property.GetStatements.Add(new CodeMethodReturnStatement(
                //    new CodeFieldReferenceExpression(
                //    new CodeThisReferenceExpression(), "attributes")));
                targetClass.Members.Add(property);

        //        var types = config.Type.Split('/');
        //        //if (types.Count() == 1)
        //        if (types2.Types.Count() == 1)
        //        {
        //            var typeName = @types2.Types[0].TypeName;
        //            <text>
        //[JsonIgnore]
        //public @typeName @config.Name { get { return this.attributes.GetOrDefault<@typeName>("@config.Name"); } set { this.attributes["@config.Name"] = value; } }
        //@*public @typeName @config.Name { get { return this.attributes.GetOrDefault<@config.Type>("@config.Name" @if (!string.IsNullOrWhiteSpace(@config.Default)) { @(", " + @config.Default) }); } set { this.attributes["@config.Name"] = value; } }                *@
        //            </text>
        //        } 
        //        //else if (types.Count() > 1)
        //        else if (false)
        //        {

                }
            }

            //CodeMemberProperty widthProperty = new CodeMemberProperty();
            //widthProperty.Attributes =
            //    MemberAttributes.Public | MemberAttributes.Final;
            //widthProperty.Name = "Width";
            //widthProperty.HasGet = true;
            //widthProperty.Type = new CodeTypeReference(typeof(System.Double));
            ////widthProperty.Comments.Add(new CodeCommentStatement(
            ////    "The Width property for the object."));
            //widthProperty.GetStatements.Add(new CodeMethodReturnStatement(
            //    new CodeFieldReferenceExpression(
            //    new CodeThisReferenceExpression(), "widthValue")));
            //targetClass.Members.Add(widthProperty);


            return targetUnit;
        }

        //http://stackoverflow.com/questions/16466380/get-user-friendly-name-for-generic-type-in-c-sharp

        //static string GetTypeName(Type type) {
        //    var codeDomProvider = CodeDomProvider.CreateProvider("C#");
        //    var typeReferenceExpression = new CodeTypeReferenceExpression(new CodeTypeReference(type));
        //    using (var writer = new StringWriter()) {
        //        codeDomProvider.GenerateCodeFromExpression(typeReferenceExpression, writer, new CodeGeneratorOptions());
        //        return writer.GetStringBuilder().ToString();
        //    }
        //}
    }
}
