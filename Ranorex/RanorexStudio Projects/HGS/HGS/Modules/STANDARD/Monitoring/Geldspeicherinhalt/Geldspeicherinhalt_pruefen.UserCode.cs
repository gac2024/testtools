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

namespace Cottbus_3000CR.Modules.STANDARD.Monitoring.Geldspeicherinhalt
{
    public partial class Geldspeicherinhalt_pruefen
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public Dictionary<string, int>  map = new Dictionary<string, int>();

        public void validateGeldspeicherinhalt(RepoItemInfo tablerow)
        {
            string ProjectName=TestSuite.Current.Parameters["ProjectName"]; 
            string HGSmeldungsPfad = TestSuite.Current.Parameters["HGSmeldungsPfad"];       
            string xmlFilePath = HGSmeldungsPfad+"\\TRANSFER\\transfer_"+ProjectName+".xml";

           
            
            
            //prepare Map
            
            putIntoMap("MEK",0);
            putIntoMap("ZGS",0);
            putIntoMap("BNV",0);
            putIntoMap("WGR",0);
            
            
        	try
	        {
	        	 // Laden der XML-Datei
				 XmlDocument xmlDoc = new XmlDocument();	           
	        	 xmlDoc.Load(xmlFilePath);
	        	 
	        	 	        	 // get anzahltransaktionen
	        	XmlNode validNode = xmlDoc.SelectSingleNode("//geldlogistik");
				if (validNode == null)
					return;
		        
				
				string AutomantenNr=xmlDoc.SelectSingleNode("//automatenNr").InnerText;
				string AbrechnungsNr=xmlDoc.SelectSingleNode("//abrechnungsnr").InnerText;
	        	 
	        	 
	        	 
				// hier koennen wir zusammenrechnen.  
				// dafür erstellen wir eine Map typ <String> <int>
				int AnzGL=xmlDoc.SelectNodes("//geldlogistik").Count;
			//	int AnzahlGeldtLogistik=int.Parse(AnzGL);
				
				for (int i=1;i<=AnzGL;i++){
					string geldspeichertyp=xmlDoc.SelectSingleNode("//geldlogistik["+i+"]/geldspeichertyp").InnerText;
														
					string geldbetrag=xmlDoc.SelectSingleNode("//geldlogistik["+i+"]/geldbetrag").InnerText;				
					int  wert=int.Parse( geldbetrag.Split('#')[0] );
					
					
					
					Report.Info("geldspeichertyp",geldspeichertyp);
					Report.Info("geldbetrag",wert+"");
					
					
					putIntoMap(geldspeichertyp,wert);

				}
			
			
		
				// zeile1 objekte   
	        	
	        	var cellGeraetenummerInfo=repo.TicketingInside_DImasPlus.ContentPage.Monitoring.Geldspeicherinhalt.Tabelle.Zeile1.cellGeraetenummerInfo;      	
	        	
				var cellAbrechnungNrInfo=repo.TicketingInside_DImasPlus.ContentPage.Monitoring.Geldspeicherinhalt.Tabelle.Zeile1.cellAbrechnungNrInfo;
				var cellSummeMEKInfo=repo.TicketingInside_DImasPlus.ContentPage.Monitoring.Geldspeicherinhalt.Tabelle.Zeile1.cellSummeMEKInfo;				
				var cellSummeZGSInfo=repo.TicketingInside_DImasPlus.ContentPage.Monitoring.Geldspeicherinhalt.Tabelle.Zeile1.cellSummeZGSInfo;      	
				var cellSummeBNVInfo=repo.TicketingInside_DImasPlus.ContentPage.Monitoring.Geldspeicherinhalt.Tabelle.Zeile1.cellSummeBNVInfo;      	
				var cellSummeWGRInfo=repo.TicketingInside_DImasPlus.ContentPage.Monitoring.Geldspeicherinhalt.Tabelle.Zeile1.cellSummeWGRInfo;      	
			
			
				// validate
				
				 Report.Log(ReportLevel.Info, "Validation","start check");
				 Validate.AttributeEqual(cellGeraetenummerInfo,"InnerText",AutomantenNr);
				 Validate.AttributeEqual(cellAbrechnungNrInfo,"InnerText",AbrechnungsNr);
				 Validate.AttributeContains(cellSummeMEKInfo,"InnerText", DPlusLibrary.PreisConverter(this.map["MEK"]+"#EUR") );
				 Validate.AttributeContains(cellSummeZGSInfo,"InnerText", DPlusLibrary.PreisConverter(this.map["ZGS"]+"#EUR") );
				 Validate.AttributeContains(cellSummeBNVInfo,"InnerText", DPlusLibrary.PreisConverter(this.map["BNV"]+"#EUR") );
				 Validate.AttributeContains(cellSummeWGRInfo,"InnerText", DPlusLibrary.PreisConverter(this.map["WGR"]+"#EUR") );
				
				
			
			

	        }catch(Exception ex){	     
	            Report.Warn("Fehler beim Verarbeiten der XML-Datei: " + ex.Message);
	        }	 
        }
        public void putIntoMap(string geldspeichertyp, int geldbetrag){
        	

        	if (this.map.ContainsKey(geldspeichertyp) ){
        		// aufaddieren
        		int old = this.map[geldspeichertyp];
        		this.map.Remove(geldspeichertyp);
        		geldbetrag=old+geldbetrag;
        		
        	}
        	
        	map.Add(geldspeichertyp,geldbetrag);
        	
        }

    }
}