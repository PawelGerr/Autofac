﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autofac.Component.Activation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ReflectionActivatorResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReflectionActivatorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Autofac.Component.Activation.ReflectionActivatorResources", typeof(ReflectionActivatorResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The component &apos;{0}&apos; does not support the service &apos;{1}&apos;..
        /// </summary>
        internal static string ComponentDoesNotSupportService {
            get {
                return ResourceManager.GetString("ComponentDoesNotSupportService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reflective.
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to parameter &apos;{0}&apos; of type &apos;{1}&apos; is not resolvable.
        /// </summary>
        internal static string MissingParameter {
            get {
                return ResourceManager.GetString("MissingParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The component &apos;{0}&apos; has no public constructors..
        /// </summary>
        internal static string NoPublicConstructor {
            get {
                return ResourceManager.GetString("NoPublicConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The component &apos;{0}&apos; has no resolvable constructors. Unsuitable constructors included:{1}.
        /// </summary>
        internal static string NoResolvableConstructor {
            get {
                return ResourceManager.GetString("NoResolvableConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter names cannot be null or empty (component &apos;{0}&apos;)..
        /// </summary>
        internal static string ParameterNameNotNullOrEmpty {
            get {
                return ResourceManager.GetString("ParameterNameNotNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; has been specified multiple times for component &apos;{1}&apos;..
        /// </summary>
        internal static string ParameterSpecifiedMultipleTimes {
            get {
                return ResourceManager.GetString("ParameterSpecifiedMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property names cannot be null or empty (component &apos;{0}&apos;)..
        /// </summary>
        internal static string PropertyNameNotNullOrEmpty {
            get {
                return ResourceManager.GetString("PropertyNameNotNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No property named &apos;{0}&apos; exists on component &apos;{1}&apos;..
        /// </summary>
        internal static string PropertyNotFound {
            get {
                return ResourceManager.GetString("PropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; has been specified multiple times for component &apos;{1}&apos;..
        /// </summary>
        internal static string PropertySpecifiedMultipleTimes {
            get {
                return ResourceManager.GetString("PropertySpecifiedMultipleTimes", resourceCulture);
            }
        }
    }
}
