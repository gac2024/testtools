﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using Cottbus_3000CR.UserCodeCollections;

namespace Cottbus_3000CR.Modules.STANDARD.Papierrollenverwaltung.Barcodeverfolgung
{
    public partial class Barcodeverfolgung_validieren
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ValidationOverAllBarcodes()
        {

        	string ProjectName=TestSuite.Current.Parameters["ProjectName"];
            string HGSmeldungsPfad = TestSuite.Current.Parameters["HGSmeldungsPfad"];       
            string xmlFilePath = HGSmeldungsPfad+"\\TRANSFER\\transfer_"+ProjectName+".xml";

               
            
            Report.Info("path: " + xmlFilePath);


			try
	        {
	        	 // Laden der XML-Datei
	        	XmlDocument xmlDoc = new XmlDocument();
	            xmlDoc.Load(xmlFilePath);
	            XmlNodeList nodeList;
        	
        	// ####################################################
        	// ###   Hier geht es los  
        	// ####################################################

        	        	
        	string automatenNr = xmlDoc.SelectSingleNode("//automatenNr").InnerText;
        	string abrechnungsNr = xmlDoc.SelectSingleNode("//auftragsNr").InnerText;
        	
        	// hole die Produktinfos raus
        	
        	nodeList = xmlDoc.SelectNodes("//produktausgaben");
        	
        	
        	// #########################
        	// ### Filterobjekte
        	// n########################
        	
        	var FilterGeraetenummerInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Filter.FilterGeraetenummerInfo;
	        var FilteErsterBarcodeInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Filter.FilteErsterBarcodeInfo;
        	
        	
        	
        	foreach (XmlNode product in nodeList)
        	{
        		
        		
        		
        		string papierBahn = product.SelectSingleNode("./ausgabeVorratsbehaelter").InnerText;
				string ersterBarcode = product.SelectSingleNode("./medienkennung").InnerText;
				string letztererBarcode = product.SelectSingleNode("./medienkennung").InnerText;
				string papierrolle = product.SelectSingleNode("./seriennummerPapier").InnerText;
        		string verwendungsArt ="Ticket";
        			
        			
        		Report.Log(ReportLevel.Info, "Validation","Barcodeverfolgung fuer "+ersterBarcode );	
        			
        		// Filtern
        			
				DPlusLibrary.Fill_textfilter(FilterGeraetenummerInfo, automatenNr);
	        	DPlusLibrary.Fill_textfilter(FilteErsterBarcodeInfo, ersterBarcode);        	
	        	Delay.Milliseconds(300);
        			
        		
	        	
	        	// validieren
	        	
	        	// objekte hiolden
	        	
        	    var CellPapierrolleInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Zeile1.CellPapierrolleInfo;
	        	var CellGeraetenummerInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Zeile1.CellGeraetenummerInfo;
	        	var CellPapierbahnInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Zeile1.CellPapierbahnInfo;
	    		var CellErsterBarcodeInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Zeile1.CellErsterBarcodeInfo;
	    		var CellLetzterBarcodeInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Zeile1.CellLetzterBarcodeInfo;
	    		var CellVerwendungsartInfo=repo.TicketingInside_DImasPlus.ContentPage.Papierrollenverwaltung.Barcodeverfolgung.Tabelle.Zeile1.CellVerwendungsartInfo;	      
        		
        		
        		
				Validate.AttributeEqual(CellPapierrolleInfo,"InnerText",papierrolle);
				Validate.AttributeEqual(CellGeraetenummerInfo,"InnerText",automatenNr);
				Validate.AttributeEqual(CellPapierbahnInfo,"InnerText",papierBahn);
				Validate.AttributeEqual(CellErsterBarcodeInfo,"InnerText",ersterBarcode);
				Validate.AttributeEqual(CellLetzterBarcodeInfo,"InnerText",letztererBarcode);
        		Validate.AttributeEqual(CellVerwendungsartInfo,"InnerText",verwendungsArt);
        		
        		
        		
        	}
        	
        	
        	
        
	        }catch(Exception ex){	     
	            Report.Error("Fehler beim Verarbeiten der XML-Datei: " + ex.Message);
	        }
			
        }

    }
}