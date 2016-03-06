//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FakeItEasy {
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionMessages {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FakeItEasy.ExceptionMessages", typeof(ExceptionMessages).Assembly);
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
        ///   Looks up a localized string similar to The Apply method of the ExpressionInterceptor may no be called before the Applicator property has been set..
        /// </summary>
        internal static string ApplicatorNotSetExceptionMessage {
            get {
                return ResourceManager.GetString("ApplicatorNotSetExceptionMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified argument name does not exist in the ArgumentList..
        /// </summary>
        internal static string ArgumentNameDoesNotExist {
            get {
                return ResourceManager.GetString("ArgumentNameDoesNotExist", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Arguments for constructor was specified when generating proxy of interface type..
        /// </summary>
        internal static string ArgumentsForConstructorOnInterfaceType {
            get {
                return ResourceManager.GetString("ArgumentsForConstructorOnInterfaceType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An argument validation was not configured correctly..
        /// </summary>
        internal static string ArgumentValidationDefaultMessage {
            get {
                return ResourceManager.GetString("ArgumentValidationDefaultMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; was called too few times, expected #{1} times but was called #{2} times..
        /// </summary>
        internal static string CalledTooFewTimesMessage {
            get {
                return ResourceManager.GetString("CalledTooFewTimesMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; was called too many times, expected #{1} times but was called #{2} times..
        /// </summary>
        internal static string CalledTooManyTimesMessage {
            get {
                return ResourceManager.GetString("CalledTooManyTimesMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Can not create fake of the type &apos;{0}&apos;, it&apos;s not registered in the current container and the current IProxyGenerator can not generate the fake.
        ///
        ///The following constructors failed:
        ///{1}.
        /// </summary>
        internal static string CanNotGenerateFakeMessage {
            get {
                return ResourceManager.GetString("CanNotGenerateFakeMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error when accessing FakeObject, the specified argument is of the type &apos;{0}&apos; which is not faked..
        /// </summary>
        internal static string ConfiguringNonFakeObjectExceptionMessage {
            get {
                return ResourceManager.GetString("ConfiguringNonFakeObjectExceptionMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An ExpressionCallMatcher can only be created for expressions that represents a method call or a property getter..
        /// </summary>
        internal static string CreatingExpressionCallMatcherWithNonMethodOrPropertyExpression {
            get {
                return ResourceManager.GetString("CreatingExpressionCallMatcherWithNonMethodOrPropertyExpression", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to
        ///
        ///  The current proxy generator failed to create a proxy with the specified arguments for the constructor:
        ///
        ///  Reason for failure:
        ///    - {0}
        ///
        ///.
        /// </summary>
        internal static string FailedToGenerateFakeWithArgumentsForConstructorPattern {
            get {
                return ResourceManager.GetString("FailedToGenerateFakeWithArgumentsForConstructorPattern", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to FakeItEasy failed to create fake object of type &quot;{0}&quot;.
        ///
        ///1. The type is not registered in the current IFakeObjectContainer.
        ///2. The current IProxyGenerator failed to generate a proxy for the following reason:
        ///
        ///{1}.
        /// </summary>
        internal static string FailedToGenerateProxyPattern {
            get {
                return ResourceManager.GetString("FailedToGenerateProxyPattern", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to create fake object..
        /// </summary>
        internal static string FakeCreationExceptionDefaultMessage {
            get {
                return ResourceManager.GetString("FakeCreationExceptionDefaultMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The fake manager was initialized for a different proxy..
        /// </summary>
        internal static string FakeManagerWasInitializedWithDifferentProxyMessage {
            get {
                return ResourceManager.GetString("FakeManagerWasInitializedWithDifferentProxyMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Only abstract classes can be faked using the A.Fake-method that takes an enumerable of objects as arguments for constructor, use the overload that takes an expression instead..
        /// </summary>
        internal static string FakingNonAbstractClassWithArgumentsForConstructor {
            get {
                return ResourceManager.GetString("FakingNonAbstractClassWithArgumentsForConstructor", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The member accessor expression must be a lambda expression with a MethodCallExpression or MemberAccessExpression as its body..
        /// </summary>
        internal static string MemberAccessorNotCorrectExpressionType {
            get {
                return ResourceManager.GetString("MemberAccessorNotCorrectExpressionType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified method can not be configured since it can not be intercepted by the current IProxyGenerator..
        /// </summary>
        internal static string MemberCanNotBeIntercepted {
            get {
                return ResourceManager.GetString("MemberCanNotBeIntercepted", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The method of the call did not match the method of the recorded call, the recorded sequence is no longer valid..
        /// </summary>
        internal static string MethodMissmatchWhenPlayingBackRecording {
            get {
                return ResourceManager.GetString("MethodMissmatchWhenPlayingBackRecording", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No constructor matching the specified arguments was found on the type {0}..
        /// </summary>
        internal static string NoConstructorMatchingArguments {
            get {
                return ResourceManager.GetString("NoConstructorMatchingArguments", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Can not generate fake object for the class since no usable default constructor was found, specify a constructor call..
        /// </summary>
        internal static string NoDefaultConstructorMessage {
            get {
                return ResourceManager.GetString("NoDefaultConstructorMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to All the recorded calls has been applied, the recorded sequence is no longer valid..
        /// </summary>
        internal static string NoMoreRecordedCalls {
            get {
                return ResourceManager.GetString("NoMoreRecordedCalls", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Only expression of the type ExpressionType.New (constructor calls) are accepted..
        /// </summary>
        internal static string NonConstructorExpressionMessage {
            get {
                return ResourceManager.GetString("NonConstructorExpressionMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The Now-method on the event raise is not meant to be called directly, only use it to register to an event on a fake object that you want to be raised..
        /// </summary>
        internal static string NowCalledDirectly {
            get {
                return ResourceManager.GetString("NowCalledDirectly", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The number of values for out and ref parameters specified does not match the number of out and ref parameters in the call..
        /// </summary>
        internal static string NumberOfOutAndRefParametersDoesNotMatchCall {
            get {
                return ResourceManager.GetString("NumberOfOutAndRefParametersDoesNotMatchCall", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified call is not made on a fake object..
        /// </summary>
        internal static string SpecifiedCallIsNotToFakedObject {
            get {
                return ResourceManager.GetString("SpecifiedCallIsNotToFakedObject", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The current fake proxy generator can not create proxies of the type {0}..
        /// </summary>
        internal static string TypeCanNotBeProxied {
            get {
                return ResourceManager.GetString("TypeCanNotBeProxied", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to FakeItEasy was unable to create dummy of type &quot;{0}&quot;, register it in the current IFakeObjectContainer to enable this..
        /// </summary>
        internal static string UnableToCreateDummyPattern {
            get {
                return ResourceManager.GetString("UnableToCreateDummyPattern", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected to find call {0} the number of times specified by the predicate &apos;{1}&apos; but found it {2} times among the calls:.
        /// </summary>
        internal static string WasCalledWrongNumberOfTimes {
            get {
                return ResourceManager.GetString("WasCalledWrongNumberOfTimes", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Supplied constructor is for type {0}, but must be for {1}..
        /// </summary>
        internal static string WrongConstructorExpressionTypeMessage {
            get {
                return ResourceManager.GetString("WrongConstructorExpressionTypeMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The number of argument names does not match the number of arguments..
        /// </summary>
        internal static string WrongNumberOfArgumentNamesMessage {
            get {
                return ResourceManager.GetString("WrongNumberOfArgumentNamesMessage", resourceCulture);
            }
        }
    }
}
