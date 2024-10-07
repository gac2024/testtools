﻿///////////////////////////////////////////////////////////////////////////////
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

namespace Cottbus_3000CR.Browser
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OEffnen recording.
    /// </summary>
    [TestModule("34b522fc-9740-4354-a23d-085ca4b6cbef", ModuleType.Recording, 1)]
    public partial class OEffnen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Cottbus_3000CR.HGS repository.
        /// </summary>
        public static global::Cottbus_3000CR.HGS repo = global::Cottbus_3000CR.HGS.Instance;

        static OEffnen instance = new OEffnen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OEffnen()
        {
            DplusUrl = "https://uestra.dev.ti-ica.de/mp/login";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OEffnen Instance
        {
            get { return instance; }
        }

#region Variables

        string _DplusUrl;

        /// <summary>
        /// Gets or sets the value of variable DplusUrl.
        /// </summary>
        [TestVariable("9086d5c7-962f-422a-8811-3c2d4f47e2b4")]
        public string DplusUrl
        {
            get { return _DplusUrl; }
            set { _DplusUrl = value; }
        }

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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $DplusUrl in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(DplusUrl, "Chrome", "", false, true, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}