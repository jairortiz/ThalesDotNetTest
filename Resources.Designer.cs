﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThalesDotNetTest {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ThalesDotNetTest.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://dummy.restapiexample.com/api/v1/employees.
        /// </summary>
        public static string API_URL {
            get {
                return ResourceManager.GetString("API_URL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;status&quot;:&quot;success&quot;,&quot;data&quot;:[{&quot;id&quot;:1,&quot;employee_name&quot;:&quot;Tiger Nixon&quot;,&quot;employee_salary&quot;:320800,&quot;employee_age&quot;:61,&quot;profile_image&quot;:&quot;&quot;},{&quot;id&quot;:2,&quot;employee_name&quot;:&quot;Garrett Winters&quot;,&quot;employee_salary&quot;:170750,&quot;employee_age&quot;:63,&quot;profile_image&quot;:&quot;&quot;},{&quot;id&quot;:3,&quot;employee_name&quot;:&quot;Ashton Cox&quot;,&quot;employee_salary&quot;:86000,&quot;employee_age&quot;:66,&quot;profile_image&quot;:&quot;&quot;},{&quot;id&quot;:4,&quot;employee_name&quot;:&quot;Cedric Kelly&quot;,&quot;employee_salary&quot;:433060,&quot;employee_age&quot;:22,&quot;profile_image&quot;:&quot;&quot;},{&quot;id&quot;:5,&quot;employee_name&quot;:&quot;Airi Satou&quot;,&quot;employee_salary&quot;:162700,&quot;employee_age&quot;: [rest of string was truncated]&quot;;.
        /// </summary>
        public static string EmployeeData {
            get {
                return ResourceManager.GetString("EmployeeData", resourceCulture);
            }
        }
    }
}