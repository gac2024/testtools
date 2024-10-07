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

namespace Cottbus_3000CR.Modules.STANDARD.Geraeteverwaltung.Baugruppen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Baugruppenuebersicht_pruefen recording.
    /// </summary>
    [TestModule("692b7f33-bc40-4876-9138-7aa87586c0d3", ModuleType.Recording, 1)]
    public partial class Baugruppenuebersicht_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Cottbus_3000CR.HGS repository.
        /// </summary>
        public static global::Cottbus_3000CR.HGS repo = global::Cottbus_3000CR.HGS.Instance;

        static Baugruppenuebersicht_pruefen instance = new Baugruppenuebersicht_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Baugruppenuebersicht_pruefen()
        {
            AutomatenNr = "999000";
            Seriennummer = "99009901";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Baugruppenuebersicht_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _AutomatenNr;

        /// <summary>
        /// Gets or sets the value of variable AutomatenNr.
        /// </summary>
        [TestVariable("927c87f9-3be5-49d8-bbbc-2bbda99fee81")]
        public string AutomatenNr
        {
            get { return _AutomatenNr; }
            set { _AutomatenNr = value; }
        }

        string _Seriennummer;

        /// <summary>
        /// Gets or sets the value of variable Seriennummer.
        /// </summary>
        [TestVariable("763df19a-a391-4cb9-904d-172de358fbe5")]
        public string Seriennummer
        {
            get { return _Seriennummer; }
            set { _Seriennummer = value; }
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

            // Navigation
            Report.Log(ReportLevel.Info, "Section", "Navigation", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TicketingInside_DImasPlus.Menue.Baugruppen' at Center.", repo.TicketingInside_DImasPlus.Menue.BaugruppenInfo, new RecordItemIndex(1));
            repo.TicketingInside_DImasPlus.Menue.Baugruppen.Click();
            Delay.Milliseconds(0);
            
            // Filterung
            Report.Log(ReportLevel.Info, "Section", "Filterung", new RecordItemIndex(2));
            
            UserCodeCollections.DPlusLibrary.Fill_textfilter(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenFilter.FilterSeriennummerInfo, Seriennummer);
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.Fill_textfilter(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenFilter.FilterGeraetenummerInfo, AutomatenNr);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            // Prüfungen
            Report.Log(ReportLevel.Info, "Section", "Prüfungen", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Seriennummer) on item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellSeriennummer'.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellSeriennummerInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellSeriennummerInfo, "InnerText", Seriennummer);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$AutomatenNr) on item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellGeraetenummer'.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellGeraetenummerInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellGeraetenummerInfo, "InnerText", AutomatenNr);
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellBaugruppentypInfo, "baugruppentyp");
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellStatusInfo, "status");
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellBaugruppenkategorieInfo, "baugruppenkategorie");
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellBaugruppenherstellerInfo, "baugruppenhersteller");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Automatisch') on item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellBaugruppenquelle'.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellBaugruppenquelleInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellBaugruppenquelleInfo, "InnerText", "Automatisch");
            Delay.Milliseconds(0);
            
            // Baugruppe Details
            Report.Log(ReportLevel.Info, "Section", "Baugruppe Details", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellSeriennummer' at Center.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellSeriennummerInfo, new RecordItemIndex(15));
            repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Tabelle.TabellenInhalt.Zeile_1.CellSeriennummer.Click();
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valBaugruppentypInfo, "baugruppentyp");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Seriennummer) on item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valSeriennummer'.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valSeriennummerInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valSeriennummerInfo, "InnerText", Seriennummer);
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valBaugruppenherstellerInfo, "baugruppenhersteller");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Automatisch') on item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valBaugruppenquelle'.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valBaugruppenquelleInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valBaugruppenquelleInfo, "InnerText", "Automatisch");
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valLetzterVorgangInfo, "status");
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valBaugruppenkategorieInfo, "baugruppenkategorie");
            Delay.Milliseconds(0);
            
            UserCodeCollections.DPlusLibrary.validateInnertextWithXMLtag(repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.Details.valGeldspeichertypInfo, "geldspeichertyp");
            Delay.Milliseconds(0);
            
            // Zurück
            Report.Log(ReportLevel.Info, "Section", "Zurück", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.btnZurueck' at Center.", repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.btnZurueckInfo, new RecordItemIndex(24));
            repo.TicketingInside_DImasPlus.ContentPage.Geraeteverwaltung.Baugruppen.Baugruppendetails.btnZurueck.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
