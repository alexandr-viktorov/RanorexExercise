///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Ranorex_exercise.PageModules.HomeTabPanel
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Click_Button_Reply recording.
    /// </summary>
    [TestModule("bd025c79-8c14-4d48-8489-f04ade388445", ModuleType.Recording, 1)]
    public partial class Click_Button_Reply : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Ranorex_exercise.Ranorex_exerciseRepository repository.
        /// </summary>
        public static global::Ranorex_exercise.Ranorex_exerciseRepository repo = global::Ranorex_exercise.Ranorex_exerciseRepository.Instance;

        static Click_Button_Reply instance = new Click_Button_Reply();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Button_Reply()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Button_Reply Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MarkAttelerikdomainComMyApplication.HomeTab.button_Reply' at Center.", repo.MarkAttelerikdomainComMyApplication.HomeTab.button_ReplyInfo, new RecordItemIndex(0));
            repo.MarkAttelerikdomainComMyApplication.HomeTab.button_Reply.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
