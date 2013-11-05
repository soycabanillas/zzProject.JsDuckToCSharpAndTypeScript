using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.picker.Date : Ext.Component {
                    
        private _ariaTitle_default = 'Date Picker: {0}';
                    
                    
        [JsonIgnore]
        public String ariaTitle { get { return this.attributes.GetOrDefault<String>("ariaTitle", 'Date Picker: {0}'); } set { this.attributes["ariaTitle"] = value; } }                
                    
                    
        private _ariaTitleDateFormat_default = 'F d, Y';
                    
                    
        [JsonIgnore]
        public String ariaTitleDateFormat { get { return this.attributes.GetOrDefault<String>("ariaTitleDateFormat", 'F d, Y'); } set { this.attributes["ariaTitleDateFormat"] = value; } }                
                    
                    
        private _baseCls_default = 'x-datepicker';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-datepicker'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _border_default = true;
                    
                    
        public class MultiType_border {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_border border { get { return this.attributes.GetOrDefault<MultiType_border>("border", true); } set { this.attributes["border"] = value; } }                

                    
                    
        [JsonIgnore]
        public String[] dayNames { get { return this.attributes.GetOrDefault<String[]>("dayNames", ); } set { this.attributes["dayNames"] = value; } }                
                    
                    
        private _disableAnim_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disableAnim { get { return this.attributes.GetOrDefault<Boolean>("disableAnim", false); } set { this.attributes["disableAnim"] = value; } }                
                    
                    
        private _disabledCellCls_default = 'x-datepicker-disabled';
                    
                    
        [JsonIgnore]
        public String disabledCellCls { get { return this.attributes.GetOrDefault<String>("disabledCellCls", 'x-datepicker-disabled'); } set { this.attributes["disabledCellCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] disabledDates { get { return this.attributes.GetOrDefault<String[]>("disabledDates", ); } set { this.attributes["disabledDates"] = value; } }                
                    
                    
        private _disabledDatesRE_default = null;
                    
                    
        [JsonIgnore]
        public RegExp disabledDatesRE { get { return this.attributes.GetOrDefault<RegExp>("disabledDatesRE", null); } set { this.attributes["disabledDatesRE"] = value; } }                
                    
                    
        private _disabledDatesText_default = 'Disabled';
                    
                    
        [JsonIgnore]
        public String disabledDatesText { get { return this.attributes.GetOrDefault<String>("disabledDatesText", 'Disabled'); } set { this.attributes["disabledDatesText"] = value; } }                
                    
                    
        private _disabledDays_default = null;
                    
                    
        [JsonIgnore]
        public Number[] disabledDays { get { return this.attributes.GetOrDefault<Number[]>("disabledDays", null); } set { this.attributes["disabledDays"] = value; } }                
                    
                    
        private _disabledDaysText_default = 'Disabled';
                    
                    
        [JsonIgnore]
        public String disabledDaysText { get { return this.attributes.GetOrDefault<String>("disabledDaysText", 'Disabled'); } set { this.attributes["disabledDaysText"] = value; } }                
                    
                    
        private _focusOnShow_default = false;
                    
                    
        [JsonIgnore]
        public Boolean focusOnShow { get { return this.attributes.GetOrDefault<Boolean>("focusOnShow", false); } set { this.attributes["focusOnShow"] = value; } }                
                    
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", ); } set { this.attributes["format"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object keyNavConfig { get { return this.attributes.GetOrDefault<Object>("keyNavConfig", ); } set { this.attributes["keyNavConfig"] = value; } }                
                    
                    
        private _longDayFormat_default = 'F d, Y';
                    
                    
        [JsonIgnore]
        public String longDayFormat { get { return this.attributes.GetOrDefault<String>("longDayFormat", 'F d, Y'); } set { this.attributes["longDayFormat"] = value; } }                
                    
                    
        private _maxDate_default = null;
                    
                    
        [JsonIgnore]
        public Date maxDate { get { return this.attributes.GetOrDefault<Date>("maxDate", null); } set { this.attributes["maxDate"] = value; } }                
                    
                    
        private _maxText_default = 'This date is after the maximum date';
                    
                    
        [JsonIgnore]
        public String maxText { get { return this.attributes.GetOrDefault<String>("maxText", 'This date is after the maximum date'); } set { this.attributes["maxText"] = value; } }                
                    
                    
        private _minDate_default = null;
                    
                    
        [JsonIgnore]
        public Date minDate { get { return this.attributes.GetOrDefault<Date>("minDate", null); } set { this.attributes["minDate"] = value; } }                
                    
                    
        private _minText_default = 'This date is before the minimum date';
                    
                    
        [JsonIgnore]
        public String minText { get { return this.attributes.GetOrDefault<String>("minText", 'This date is before the minimum date'); } set { this.attributes["minText"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] monthNames { get { return this.attributes.GetOrDefault<String[]>("monthNames", ); } set { this.attributes["monthNames"] = value; } }                
                    
                    
        private _monthYearFormat_default = 'F Y';
                    
                    
        [JsonIgnore]
        public String monthYearFormat { get { return this.attributes.GetOrDefault<String>("monthYearFormat", 'F Y'); } set { this.attributes["monthYearFormat"] = value; } }                
                    
                    
        private _monthYearText_default = 'Choose a month (Control+Up/Down to move years)';
                    
                    
        [JsonIgnore]
        public String monthYearText { get { return this.attributes.GetOrDefault<String>("monthYearText", 'Choose a month (Control+Up/Down to move years)'); } set { this.attributes["monthYearText"] = value; } }                
                    
                    
        private _nextText_default = 'Next Month (Control+Right)';
                    
                    
        [JsonIgnore]
        public String nextText { get { return this.attributes.GetOrDefault<String>("nextText", 'Next Month (Control+Right)'); } set { this.attributes["nextText"] = value; } }                
                    
                    
        private _prevText_default = 'Previous Month (Control+Left)';
                    
                    
        [JsonIgnore]
        public String prevText { get { return this.attributes.GetOrDefault<String>("prevText", 'Previous Month (Control+Left)'); } set { this.attributes["prevText"] = value; } }                
                    
                    
        private _renderTpl_default = '{%this.renderContent(out,values)%}';
                    
                    
        public class MultiType_renderTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (String[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String[] (int m) {
                return new String[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", '{%this.renderContent(out,values)%}'); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _selectedCls_default = 'x-datepicker-selected';
                    
                    
        [JsonIgnore]
        public String selectedCls { get { return this.attributes.GetOrDefault<String>("selectedCls", 'x-datepicker-selected'); } set { this.attributes["selectedCls"] = value; } }                
                    
                    
        private _showToday_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showToday { get { return this.attributes.GetOrDefault<Boolean>("showToday", true); } set { this.attributes["showToday"] = value; } }                
                    
                    
        private _startDay_default = undefined;
                    
                    
        [JsonIgnore]
        public Number startDay { get { return this.attributes.GetOrDefault<Number>("startDay", undefined); } set { this.attributes["startDay"] = value; } }                
                    
                    
        private _todayText_default = 'Today';
                    
                    
        [JsonIgnore]
        public String todayText { get { return this.attributes.GetOrDefault<String>("todayText", 'Today'); } set { this.attributes["todayText"] = value; } }                
                    
                    
        private _todayTip_default = '{0} (Spacebar)';
                    
                    
        [JsonIgnore]
        public String todayTip { get { return this.attributes.GetOrDefault<String>("todayTip", '{0} (Spacebar)'); } set { this.attributes["todayTip"] = value; } }                
                    
    }
}
