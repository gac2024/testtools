﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Cottbus_3000CR.Modules.STANDARD.HauptDisplay
{
    public partial class ExpandiertMenue
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void expandtree(RepoItemInfo menue)
        {
        	
        	// AList : Menuepunkte   DIVList : das Sammelfeld der untermenuepunkte
        	
            // returniert alle ndirekten Kinder eienr Art
        	var Alist=menue.FindAdapter<UlTag>().FindChildren<ATag>();
        	var DIVlist=menue.FindAdapter<UlTag>().FindChildren<DivTag>();
        	
     		// zwei indizes  j: index der Divs , i : index der Menuepunkte   es kann mehr Meneuepunkte als Divs geben.
            int j=0;
            for (int i=0; i<Alist.Count;i++){

            	string menueItem=Alist[i].FindSingle<PTag>("?/?/p").GetAttributeValue<string>("innerText");
        	 	Report.Log(ReportLevel.Info, "Check ","Menue["+i+"] '"+ menueItem+  "'." );
        	    Alist[i].EnsureVisible();

            	// pruefung ob der Menuepunkt überhaupt subs zum aufklappen hat.
            	DivTag el=null;        
       			if (Alist[i].TryFindSingle<DivTag>("div",out el) == false) continue;
				
       			// pruefung ob das untermenue schon aufgeklappt ist.
        	 	if (DIVlist[j].Visible == false){
        	 		Report.Log(ReportLevel.Info, "Action ","Menue '"+ menueItem+  "' expanded." );
        	 		Alist[i].Click();        	 		
        	 	}
       			
				//auch der Div Index muss hochgezählt werden
        	 	j=j+1;
            }

		}

    }
}