using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public class MultiType_Weight {
        public new Type GetType()
        {
            return _value.GetType();
        }

        public static explicit operator int(MultiType_Weight m)
        {
            if (m._value.GetType() == typeof(int)) return (int)m._value;
            else return default(int);
        }
        public static implicit operator MultiType_Weight(int m) {
            return new MultiType_Weight() { _value = m };
        }
        public static explicit operator string(MultiType_Weight m) {
            return (string)m._value;
        }
        public static implicit operator MultiType_Weight(string m) {
            return new MultiType_Weight() { _value = m };
        }
        private object _value;
        public object @object  { get { return _value; } set { _value = value; } }
        public int @int { get { return (int) _value; } set { _value = value; } }
        public string @function { get { return (string) _value; } set { _value = value; } }
    }

    public class ClassTest {
        private MultiType_Weight _weight;
        public MultiType_Weight weight {
            get {
                if (_weight == null) _weight = new MultiType_Weight() { @int = 3 };
                return _weight;
            }
            set {
                _weight = value;
            }
        }
    }

    public class Test {
        public static void test() {
            ClassTest ct = new ClassTest();
            ct.weight = 3;
            ct.weight = "prueba";
            var prueba = ct.weight;
            prueba.@int = 3;
            prueba.@object = new object();
            int pruebaInt = (int)ct.weight;
            //string pruebaString = (string)ct.weight;
            object pruebaLong = ct.weight.@object;
            Type pruebaType = pruebaLong.GetType();
        }
    }
}
