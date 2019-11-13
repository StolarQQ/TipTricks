using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using FriendlyAssembly;

namespace TipTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //CallerInfoRegion
            var examapleCallerInfo = new Examaple2();
            examapleCallerInfo.CallerInfo();
            Console.WriteLine(examapleCallerInfo.CallerInfo());

            //FriendlyAssemblyInteractionWithInternalClasses
            // [assembly: InternalsVisibleTo("TipTricks")]
            var friendAssembly = new Friend1();
            Console.WriteLine(friendAssembly.RandomString);



            //


        }
    }

    #region DebuggerDisplay
    [DebuggerDisplay("Our object is {FirstName} and he is {Age} old.")]
    class Human
    {
        public int Age { get; set; }
        [DebuggerDisplay("This is {FirstName}")]
        public string FirstName { get; set; }
    }

    #endregion

    #region DebuggerBrowsable
    class Human2
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Age { get; set; }
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<string> FaveColors { get; set; }
    }
    #endregion

    #region NullCoalescingOperator

    class Examaple
    {
        public void NullCoalescingOperator()
        {
            var name = "Cristiano";
            var result = name ?? "No name provider";

            name = null;
            var result2 = name ?? "No name provider";
        }
    }
    #endregion

    #region CallerInfo

    public class Examaple2
    {
        public string CallerInfo([CallerMemberName] string callerMember = null, [CallerLineNumber] int lineNumber = 0)
        {
            return $"We are called by '{callerMember}' on line '{lineNumber}'.'";
        }

    }
    #endregion

    #region FriendlyAssembly


    internal class FriendlyAssembly
    {
        //[assembly: InternalsVisibleTo("AssemblyName")]
    }

    #endregion

    #region ContinionalCompilation

#if DEBUG
    public class TEST1
    {

    }

#endif

#if RELEASE
    
       public class TEST2
    {

    }

#endif

    #endregion

    #region UniCodeValidationTest
    public class UniCodeValidation
    {
        public void UniCode()
        {

            var validCharacter = 'q';

            var invalidCharacter = (char) 888;

            var category = char.GetUnicodeCategory(invalidCharacter);
            var category2 = char.GetUnicodeCategory(validCharacter);

            var isValid = category != UnicodeCategory.OtherNotAssigned ? true : false;

        }
    }

    #endregion

}
