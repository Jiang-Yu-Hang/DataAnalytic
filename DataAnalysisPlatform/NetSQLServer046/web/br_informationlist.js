/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:7:30.49
*/
gx.evt.autoSkip = false;
gx.define('br_informationlist', false, function () {
   this.ServerClass =  "br_informationlist" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV53tTenantCode=gx.fn.getControlValue("vTTENANTCODE") ;
      this.AV72Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV46IsAuthorized_PatientReTenant=gx.fn.getControlValue("vISAUTHORIZED_PATIENTRETENANT") ;
      this.AV48IsAuthorized_Patient_Entity=gx.fn.getControlValue("vISAUTHORIZED_PATIENT_ENTITY") ;
      this.AV72Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV46IsAuthorized_PatientReTenant=gx.fn.getControlValue("vISAUTHORIZED_PATIENTRETENANT") ;
      this.AV48IsAuthorized_Patient_Entity=gx.fn.getControlValue("vISAUTHORIZED_PATIENT_ENTITY") ;
   };
   this.Validv_View_lpi_br_demographics_birthdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV18VIEW_LPI_BR_Demographics_BirthDate)==0) || new gx.date.gxdate( this.AV18VIEW_LPI_BR_Demographics_BirthDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烿IEW_LPI_BR_Demographics_Birth Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_View_lpi_br_demographics_birthdate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV17VIEW_LPI_BR_Demographics_BirthDate_To)==0) || new gx.date.gxdate( this.AV17VIEW_LPI_BR_Demographics_BirthDate_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烿IEW_LPI_BR_Demographics_Birth Date_To瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tfview_lpi_br_demographics_birthdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV31TFVIEW_LPI_BR_Demographics_BirthDate)==0) || new gx.date.gxdate( this.AV31TFVIEW_LPI_BR_Demographics_BirthDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FVIEW_LPI_BR_Demographics_Birth Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tfview_lpi_br_demographics_birthdate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To)==0) || new gx.date.gxdate( this.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FVIEW_LPI_BR_Demographics_Birth Date_To瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Ddo_view_lpi_br_demographics_birthdateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate)==0) || new gx.date.gxdate( this.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_VIEW_LPI_BR_Demographics_Birth Date Aux Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Ddo_view_lpi_br_demographics_birthdateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo)==0) || new gx.date.gxdate( this.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_VIEW_LPI_BR_Demographics_Birth Date Aux Date To瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus =  ""  ;
   };
   this.e20a02_client=function()
   {
      this.clearMessages();
      this.call("br_informationview.aspx", [this.A520VIEW_LPI_BR_Information_ID, "br_encounter"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e11a02_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12a02_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13a02_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14a02_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15a02_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16a02_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e21a02_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e22a02_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,33,34,36,37,39,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,63,64,65,66,67,69,70,71,72,73,74,75,76,77,78,80,81,82,84,86,88,90,92,93,94,95,96,97,98,99,100,101,102,103,104];
   this.GXLastCtrlId =104;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",68,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_informationlist",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Patientretenant","vPATIENTRETENANT",69,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Patient_entity","vPATIENT_ENTITY",70,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(520,71,"VIEW_LPI_BR_INFORMATION_ID","VIEW_LPI_BR_Information_ID","","VIEW_LPI_BR_Information_ID","int",0,"px",18,18,"right",null,[],520,"VIEW_LPI_BR_Information_ID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(519,72,"VIEW_LPI_BR_INFORMATION_PATIENTNO","","","VIEW_LPI_BR_Information_PatientNo","svchar",0,"px",4000,80,"left","e20a02_client",[],519,"VIEW_LPI_BR_Information_PatientNo",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(522,73,"VIEW_LPI_BR_DEMOGRAPHICS_SEX","","","VIEW_LPI_BR_Demographics_Sex","svchar",0,"px",4000,80,"left",null,[],522,"VIEW_LPI_BR_Demographics_Sex",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(523,74,"VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","","","VIEW_LPI_BR_Demographics_BirthDate","date",0,"px",10,10,"right",null,[],523,"VIEW_LPI_BR_Demographics_BirthDate",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(524,75,"VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","","","VIEW_LPI_BR_Demographics_Ethnic","svchar",0,"px",4000,80,"left",null,[],524,"VIEW_LPI_BR_Demographics_Ethnic",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
   var DVPANEL_TABLEHEADERContainer = this.DVPANEL_TABLEHEADERContainer;
   DVPANEL_TABLEHEADERContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEHEADERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEHEADERContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_TABLEHEADERContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Title", "Title", "閫夐」", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEHEADERContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 79, 23, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
   var GRIDPAGINATIONBARContainer = this.GRIDPAGINATIONBARContainer;
   GRIDPAGINATIONBARContainer.setProp("Enabled", "Enabled", true, "boolean");
   GRIDPAGINATIONBARContainer.setProp("Class", "Class", "PaginationBar", "str");
   GRIDPAGINATIONBARContainer.setProp("ShowFirst", "Showfirst", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowPrevious", "Showprevious", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowNext", "Shownext", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowLast", "Showlast", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("PagesToShow", "Pagestoshow", 5, "num");
   GRIDPAGINATIONBARContainer.setProp("PagingButtonsPosition", "Pagingbuttonsposition", "Right", "str");
   GRIDPAGINATIONBARContainer.setProp("PagingCaptionPosition", "Pagingcaptionposition", "Left", "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridClass", "Emptygridclass", "PaginationBarEmptyGrid", "str");
   GRIDPAGINATIONBARContainer.setProp("SelectedPage", "Selectedpage", "", "char");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageSelector", "Rowsperpageselector", true, "bool");
   GRIDPAGINATIONBARContainer.setDynProp("RowsPerPageSelectedValue", "Rowsperpageselectedvalue", 10, "num");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageOptions", "Rowsperpageoptions", "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50", "str");
   GRIDPAGINATIONBARContainer.setProp("First", "First", "First", "str");
   GRIDPAGINATIONBARContainer.setProp("Previous", "Previous", "WWP_PagingPreviousCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Next", "Next", "WWP_PagingNextCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Last", "Last", "Last", "str");
   GRIDPAGINATIONBARContainer.setProp("Caption", "Caption", "<CURRENT_PAGE>椤?<TOTAL_PAGES>椤?璁板綍锛?TOTAL_RECORDS>鏉?, "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridCaption", "Emptygridcaption", "WWP_PagingEmptyGridCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageCaption", "Rowsperpagecaption", "WWP_PagingRowsPerPage", "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV42GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV42GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV44GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV44GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV43GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV43GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11a02_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12a02_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer = gx.uc.getNew(this, 83, 23, "BootstrapDropDownOptions", "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer", "Ddo_view_lpi_br_information_patientno", "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO");
   var DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer = this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer;
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("DataListProc", "Datalistproc", "BR_InformationListGetFilterData", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData', "vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA",UC.ParentObject.AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData); });
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.addEventHandler("OnOptionClicked", this.e13a02_client);
   this.setUserControl(DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer);
   this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer = gx.uc.getNew(this, 85, 23, "BootstrapDropDownOptions", "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer", "Ddo_view_lpi_br_demographics_sex", "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX");
   var DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer = this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer;
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("DataListProc", "Datalistproc", "BR_InformationListGetFilterData", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.addV2CFunction('AV26VIEW_LPI_BR_Demographics_SexTitleFilterData', "vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26VIEW_LPI_BR_Demographics_SexTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA",UC.ParentObject.AV26VIEW_LPI_BR_Demographics_SexTitleFilterData); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.addEventHandler("OnOptionClicked", this.e14a02_client);
   this.setUserControl(DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer);
   this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer = gx.uc.getNew(this, 87, 23, "BootstrapDropDownOptions", "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer", "Ddo_view_lpi_br_demographics_birthdate", "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
   var DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer = this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer;
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.addV2CFunction('AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData', "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA",UC.ParentObject.AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.addEventHandler("OnOptionClicked", this.e15a02_client);
   this.setUserControl(DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer);
   this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer = gx.uc.getNew(this, 89, 23, "BootstrapDropDownOptions", "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer", "Ddo_view_lpi_br_demographics_ethnic", "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC");
   var DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer = this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer;
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("DataListProc", "Datalistproc", "BR_InformationListGetFilterData", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.addV2CFunction('AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData', "vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA",UC.ParentObject.AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.addEventHandler("OnOptionClicked", this.e16a02_client);
   this.setUserControl(DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 91, 23, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"UNNAMEDTABLEIEW_LPI_BR_INFORMATION_PATIENTNO",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"FILTERTEXTVIEW_LPI_BR_INFORMATION_PATIENTNO", format:0,grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id:23 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_LPI_BR_INFORMATION_PATIENTNO",gxz:"ZV15VIEW_LPI_BR_Information_PatientNo",gxold:"OV15VIEW_LPI_BR_Information_PatientNo",gxvar:"AV15VIEW_LPI_BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15VIEW_LPI_BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15VIEW_LPI_BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("vVIEW_LPI_BR_INFORMATION_PATIENTNO",gx.O.AV15VIEW_LPI_BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15VIEW_LPI_BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("vVIEW_LPI_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"TABLESPLITTEDFILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"FILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE", format:0,grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"TABLEMERGEDVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR",gxz:"ZV16VIEW_LPI_BR_Demographics_BirthDateOperator",gxold:"OV16VIEW_LPI_BR_Demographics_BirthDateOperator",gxvar:"AV16VIEW_LPI_BR_Demographics_BirthDateOperator",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV16VIEW_LPI_BR_Demographics_BirthDateOperator=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV16VIEW_LPI_BR_Demographics_BirthDateOperator=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR",gx.O.AV16VIEW_LPI_BR_Demographics_BirthDateOperator)},c2v:function(){if(this.val()!==undefined)gx.O.AV16VIEW_LPI_BR_Demographics_BirthDateOperator=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR",',')},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_View_lpi_br_demographics_birthdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gxz:"ZV18VIEW_LPI_BR_Demographics_BirthDate",gxold:"OV18VIEW_LPI_BR_Demographics_BirthDate",gxvar:"AV18VIEW_LPI_BR_Demographics_BirthDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[37],ip:[37],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gx.O.AV18VIEW_LPI_BR_Demographics_BirthDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_RANGEMIDDLETEXT_1", format:0,grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_View_lpi_br_demographics_birthdate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO",gxz:"ZV17VIEW_LPI_BR_Demographics_BirthDate_To",gxold:"OV17VIEW_LPI_BR_Demographics_BirthDate_To",gxvar:"AV17VIEW_LPI_BR_Demographics_BirthDate_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[42],ip:[42],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17VIEW_LPI_BR_Demographics_BirthDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17VIEW_LPI_BR_Demographics_BirthDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO",gx.O.AV17VIEW_LPI_BR_Demographics_BirthDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17VIEW_LPI_BR_Demographics_BirthDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO")},nac:gx.falseFn};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"UNNAMEDTABLEIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"FILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC", format:0,grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gxz:"ZV19VIEW_LPI_BR_Demographics_Ethnic",gxold:"OV19VIEW_LPI_BR_Demographics_Ethnic",gxvar:"AV19VIEW_LPI_BR_Demographics_Ethnic",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV19VIEW_LPI_BR_Demographics_Ethnic=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19VIEW_LPI_BR_Demographics_Ethnic=Value},v2c:function(){gx.fn.setComboBoxValue("vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gx.O.AV19VIEW_LPI_BR_Demographics_Ethnic)},c2v:function(){if(this.val()!==undefined)gx.O.AV19VIEW_LPI_BR_Demographics_Ethnic=this.val()},val:function(){return gx.fn.getControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC")},nac:gx.falseFn};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"UNNAMEDTABLEIEW_LPI_BR_DEMOGRAPHICS_SEX",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"FILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_SEX", format:0,grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_LPI_BR_DEMOGRAPHICS_SEX",gxz:"ZV20VIEW_LPI_BR_Demographics_Sex",gxold:"OV20VIEW_LPI_BR_Demographics_Sex",gxvar:"AV20VIEW_LPI_BR_Demographics_Sex",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV20VIEW_LPI_BR_Demographics_Sex=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20VIEW_LPI_BR_Demographics_Sex=Value},v2c:function(){gx.fn.setComboBoxValue("vVIEW_LPI_BR_DEMOGRAPHICS_SEX",gx.O.AV20VIEW_LPI_BR_Demographics_Sex)},c2v:function(){if(this.val()!==undefined)gx.O.AV20VIEW_LPI_BR_Demographics_Sex=this.val()},val:function(){return gx.fn.getControlValue("vVIEW_LPI_BR_DEMOGRAPHICS_SEX")},nac:gx.falseFn};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPATIENTRETENANT",gxz:"ZV45PatientReTenant",gxold:"OV45PatientReTenant",gxvar:"AV45PatientReTenant",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV45PatientReTenant=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45PatientReTenant=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vPATIENTRETENANT",row || gx.fn.currentGridRowImpl(68),gx.O.AV45PatientReTenant,gx.O.AV70Patientretenant_GXI)},c2v:function(){gx.O.AV70Patientretenant_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV45PatientReTenant=this.val()},val:function(row){return gx.fn.getGridControlValue("vPATIENTRETENANT",row || gx.fn.currentGridRowImpl(68))},val_GXI:function(row){return gx.fn.getGridControlValue("vPATIENTRETENANT_GXI",row || gx.fn.currentGridRowImpl(68))}, gxvar_GXI:'AV70Patientretenant_GXI',nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPATIENT_ENTITY",gxz:"ZV47Patient_Entity",gxold:"OV47Patient_Entity",gxvar:"AV47Patient_Entity",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV47Patient_Entity=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV47Patient_Entity=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vPATIENT_ENTITY",row || gx.fn.currentGridRowImpl(68),gx.O.AV47Patient_Entity,gx.O.AV71Patient_entity_GXI)},c2v:function(){gx.O.AV71Patient_entity_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV47Patient_Entity=this.val()},val:function(row){return gx.fn.getGridControlValue("vPATIENT_ENTITY",row || gx.fn.currentGridRowImpl(68))},val_GXI:function(row){return gx.fn.getGridControlValue("vPATIENT_ENTITY_GXI",row || gx.fn.currentGridRowImpl(68))}, gxvar_GXI:'AV71Patient_entity_GXI',nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_INFORMATION_ID",gxz:"Z520VIEW_LPI_BR_Information_ID",gxold:"O520VIEW_LPI_BR_Information_ID",gxvar:"A520VIEW_LPI_BR_Information_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A520VIEW_LPI_BR_Information_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z520VIEW_LPI_BR_Information_ID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("VIEW_LPI_BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(68),gx.O.A520VIEW_LPI_BR_Information_ID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A520VIEW_LPI_BR_Information_ID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("VIEW_LPI_BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(68),',')},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_INFORMATION_PATIENTNO",gxz:"Z519VIEW_LPI_BR_Information_PatientNo",gxold:"O519VIEW_LPI_BR_Information_PatientNo",gxvar:"A519VIEW_LPI_BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A519VIEW_LPI_BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z519VIEW_LPI_BR_Information_PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_LPI_BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(68),gx.O.A519VIEW_LPI_BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A519VIEW_LPI_BR_Information_PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_LPI_BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(68))},nac:gx.falseFn,evt:"e20a02_client"};
   GXValidFnc[73]={ id:73 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_DEMOGRAPHICS_SEX",gxz:"Z522VIEW_LPI_BR_Demographics_Sex",gxold:"O522VIEW_LPI_BR_Demographics_Sex",gxvar:"A522VIEW_LPI_BR_Demographics_Sex",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A522VIEW_LPI_BR_Demographics_Sex=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z522VIEW_LPI_BR_Demographics_Sex=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_LPI_BR_DEMOGRAPHICS_SEX",row || gx.fn.currentGridRowImpl(68),gx.O.A522VIEW_LPI_BR_Demographics_Sex,0)},c2v:function(){if(this.val()!==undefined)gx.O.A522VIEW_LPI_BR_Demographics_Sex=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_LPI_BR_DEMOGRAPHICS_SEX",row || gx.fn.currentGridRowImpl(68))},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gxz:"Z523VIEW_LPI_BR_Demographics_BirthDate",gxold:"O523VIEW_LPI_BR_Demographics_BirthDate",gxvar:"A523VIEW_LPI_BR_Demographics_BirthDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A523VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z523VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",row || gx.fn.currentGridRowImpl(68),gx.O.A523VIEW_LPI_BR_Demographics_BirthDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.A523VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",row || gx.fn.currentGridRowImpl(68))},nac:gx.falseFn};
   GXValidFnc[75]={ id:75 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:68,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gxz:"Z524VIEW_LPI_BR_Demographics_Ethnic",gxold:"O524VIEW_LPI_BR_Demographics_Ethnic",gxvar:"A524VIEW_LPI_BR_Demographics_Ethnic",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A524VIEW_LPI_BR_Demographics_Ethnic=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z524VIEW_LPI_BR_Demographics_Ethnic=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",row || gx.fn.currentGridRowImpl(68),gx.O.A524VIEW_LPI_BR_Demographics_Ethnic,0)},c2v:function(){if(this.val()!==undefined)gx.O.A524VIEW_LPI_BR_Demographics_Ethnic=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",row || gx.fn.currentGridRowImpl(68))},nac:gx.falseFn};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[84]={ id:84 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gxz:"ZV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace",gxold:"OV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace",gxvar:"AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gx.O.AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE",gxz:"ZV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace",gxold:"OV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace",gxvar:"AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE",gx.O.AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[88]={ id:88 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace",gxold:"OV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace",gxvar:"AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE",gx.O.AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[90]={ id:90 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace",gxold:"OV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace",gxvar:"AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE",gx.O.AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[92]={ id:92 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[93]={ id:93 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[94]={ id:94 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_INFORMATION_PATIENTNO",gxz:"ZV23TFVIEW_LPI_BR_Information_PatientNo",gxold:"OV23TFVIEW_LPI_BR_Information_PatientNo",gxvar:"AV23TFVIEW_LPI_BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23TFVIEW_LPI_BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23TFVIEW_LPI_BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_INFORMATION_PATIENTNO",gx.O.AV23TFVIEW_LPI_BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23TFVIEW_LPI_BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[95]={ id:95 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL",gxz:"ZV24TFVIEW_LPI_BR_Information_PatientNo_Sel",gxold:"OV24TFVIEW_LPI_BR_Information_PatientNo_Sel",gxvar:"AV24TFVIEW_LPI_BR_Information_PatientNo_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24TFVIEW_LPI_BR_Information_PatientNo_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24TFVIEW_LPI_BR_Information_PatientNo_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL",gx.O.AV24TFVIEW_LPI_BR_Information_PatientNo_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24TFVIEW_LPI_BR_Information_PatientNo_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL")},nac:gx.falseFn};
   GXValidFnc[96]={ id:96 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX",gxz:"ZV27TFVIEW_LPI_BR_Demographics_Sex",gxold:"OV27TFVIEW_LPI_BR_Demographics_Sex",gxvar:"AV27TFVIEW_LPI_BR_Demographics_Sex",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27TFVIEW_LPI_BR_Demographics_Sex=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27TFVIEW_LPI_BR_Demographics_Sex=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX",gx.O.AV27TFVIEW_LPI_BR_Demographics_Sex,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27TFVIEW_LPI_BR_Demographics_Sex=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX")},nac:gx.falseFn};
   GXValidFnc[97]={ id:97 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL",gxz:"ZV28TFVIEW_LPI_BR_Demographics_Sex_Sel",gxold:"OV28TFVIEW_LPI_BR_Demographics_Sex_Sel",gxvar:"AV28TFVIEW_LPI_BR_Demographics_Sex_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28TFVIEW_LPI_BR_Demographics_Sex_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28TFVIEW_LPI_BR_Demographics_Sex_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL",gx.O.AV28TFVIEW_LPI_BR_Demographics_Sex_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV28TFVIEW_LPI_BR_Demographics_Sex_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL")},nac:gx.falseFn};
   GXValidFnc[98]={ id:98 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfview_lpi_br_demographics_birthdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gxz:"ZV31TFVIEW_LPI_BR_Demographics_BirthDate",gxold:"OV31TFVIEW_LPI_BR_Demographics_BirthDate",gxvar:"AV31TFVIEW_LPI_BR_Demographics_BirthDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[98],ip:[98],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31TFVIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV31TFVIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gx.O.AV31TFVIEW_LPI_BR_Demographics_BirthDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31TFVIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE")},nac:gx.falseFn};
   GXValidFnc[99]={ id:99 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfview_lpi_br_demographics_birthdate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO",gxz:"ZV32TFVIEW_LPI_BR_Demographics_BirthDate_To",gxold:"OV32TFVIEW_LPI_BR_Demographics_BirthDate_To",gxvar:"AV32TFVIEW_LPI_BR_Demographics_BirthDate_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[99],ip:[99],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV32TFVIEW_LPI_BR_Demographics_BirthDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO",gx.O.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO")},nac:gx.falseFn};
   GXValidFnc[100]={ id: 100, fld:"DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATES",grid:0};
   GXValidFnc[101]={ id:101 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_view_lpi_br_demographics_birthdateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATE",gxz:"ZV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate",gxold:"OV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate",gxvar:"AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[101],ip:[101],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATE",gx.O.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[102]={ id:102 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_view_lpi_br_demographics_birthdateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATETO",gxz:"ZV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo",gxold:"OV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo",gxvar:"AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[102],ip:[102],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATETO",gx.O.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATETO")},nac:gx.falseFn};
   GXValidFnc[103]={ id:103 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gxz:"ZV37TFVIEW_LPI_BR_Demographics_Ethnic",gxold:"OV37TFVIEW_LPI_BR_Demographics_Ethnic",gxvar:"AV37TFVIEW_LPI_BR_Demographics_Ethnic",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37TFVIEW_LPI_BR_Demographics_Ethnic=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37TFVIEW_LPI_BR_Demographics_Ethnic=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gx.O.AV37TFVIEW_LPI_BR_Demographics_Ethnic,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37TFVIEW_LPI_BR_Demographics_Ethnic=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC")},nac:gx.falseFn};
   GXValidFnc[104]={ id:104 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL",gxz:"ZV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel",gxold:"OV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel",gxvar:"AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL",gx.O.AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL")},nac:gx.falseFn};
   this.AV15VIEW_LPI_BR_Information_PatientNo = "" ;
   this.ZV15VIEW_LPI_BR_Information_PatientNo = "" ;
   this.OV15VIEW_LPI_BR_Information_PatientNo = "" ;
   this.AV16VIEW_LPI_BR_Demographics_BirthDateOperator = 0 ;
   this.ZV16VIEW_LPI_BR_Demographics_BirthDateOperator = 0 ;
   this.OV16VIEW_LPI_BR_Demographics_BirthDateOperator = 0 ;
   this.AV18VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.ZV18VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.OV18VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.AV17VIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.ZV17VIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.OV17VIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.AV19VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.ZV19VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.OV19VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.AV20VIEW_LPI_BR_Demographics_Sex = "" ;
   this.ZV20VIEW_LPI_BR_Demographics_Sex = "" ;
   this.OV20VIEW_LPI_BR_Demographics_Sex = "" ;
   this.ZV45PatientReTenant = "" ;
   this.OV45PatientReTenant = "" ;
   this.ZV47Patient_Entity = "" ;
   this.OV47Patient_Entity = "" ;
   this.Z520VIEW_LPI_BR_Information_ID = 0 ;
   this.O520VIEW_LPI_BR_Information_ID = 0 ;
   this.Z519VIEW_LPI_BR_Information_PatientNo = "" ;
   this.O519VIEW_LPI_BR_Information_PatientNo = "" ;
   this.Z522VIEW_LPI_BR_Demographics_Sex = "" ;
   this.O522VIEW_LPI_BR_Demographics_Sex = "" ;
   this.Z523VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.O523VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.Z524VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.O524VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.ZV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.OV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = "" ;
   this.ZV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = "" ;
   this.OV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = "" ;
   this.AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = "" ;
   this.ZV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = "" ;
   this.OV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = "" ;
   this.AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = "" ;
   this.ZV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = "" ;
   this.OV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV23TFVIEW_LPI_BR_Information_PatientNo = "" ;
   this.ZV23TFVIEW_LPI_BR_Information_PatientNo = "" ;
   this.OV23TFVIEW_LPI_BR_Information_PatientNo = "" ;
   this.AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = "" ;
   this.ZV24TFVIEW_LPI_BR_Information_PatientNo_Sel = "" ;
   this.OV24TFVIEW_LPI_BR_Information_PatientNo_Sel = "" ;
   this.AV27TFVIEW_LPI_BR_Demographics_Sex = "" ;
   this.ZV27TFVIEW_LPI_BR_Demographics_Sex = "" ;
   this.OV27TFVIEW_LPI_BR_Demographics_Sex = "" ;
   this.AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = "" ;
   this.ZV28TFVIEW_LPI_BR_Demographics_Sex_Sel = "" ;
   this.OV28TFVIEW_LPI_BR_Demographics_Sex_Sel = "" ;
   this.AV31TFVIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.ZV31TFVIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.OV31TFVIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.ZV32TFVIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.OV32TFVIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = gx.date.nullDate() ;
   this.ZV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = gx.date.nullDate() ;
   this.OV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = gx.date.nullDate() ;
   this.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = gx.date.nullDate() ;
   this.ZV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = gx.date.nullDate() ;
   this.OV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = gx.date.nullDate() ;
   this.AV37TFVIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.ZV37TFVIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.OV37TFVIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "" ;
   this.ZV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "" ;
   this.OV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "" ;
   this.AV15VIEW_LPI_BR_Information_PatientNo = "" ;
   this.AV16VIEW_LPI_BR_Demographics_BirthDateOperator = 0 ;
   this.AV18VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.AV17VIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.AV19VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.AV20VIEW_LPI_BR_Demographics_Sex = "" ;
   this.AV42GridCurrentPage = 0 ;
   this.AV40DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = "" ;
   this.AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = "" ;
   this.AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV23TFVIEW_LPI_BR_Information_PatientNo = "" ;
   this.AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = "" ;
   this.AV27TFVIEW_LPI_BR_Demographics_Sex = "" ;
   this.AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = "" ;
   this.AV31TFVIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = gx.date.nullDate() ;
   this.AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = gx.date.nullDate() ;
   this.AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = gx.date.nullDate() ;
   this.AV37TFVIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "" ;
   this.AV45PatientReTenant = "" ;
   this.AV47Patient_Entity = "" ;
   this.A520VIEW_LPI_BR_Information_ID = 0 ;
   this.A519VIEW_LPI_BR_Information_PatientNo = "" ;
   this.A522VIEW_LPI_BR_Demographics_Sex = "" ;
   this.A523VIEW_LPI_BR_Demographics_BirthDate = gx.date.nullDate() ;
   this.A524VIEW_LPI_BR_Demographics_Ethnic = "" ;
   this.AV72Pgmname = "" ;
   this.AV46IsAuthorized_PatientReTenant = false ;
   this.AV48IsAuthorized_Patient_Entity = false ;
   this.Events = {"e11a02_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12a02_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13a02_client": ["DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", true] ,"e14a02_client": ["DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED", true] ,"e15a02_client": ["DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED", true] ,"e16a02_client": ["DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED", true] ,"e21a02_client": ["ENTER", true] ,"e22a02_client": ["CANCEL", true] ,"e20a02_client": ["VIEW_LPI_BR_INFORMATION_PATIENTNO.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'}],[{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_SEX","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Visible")',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Visible")',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_INFORMATION_PATIENTNO","Visible")',ctrl:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL","Visible")',ctrl:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX","Visible")',ctrl:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL","Visible")',ctrl:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","Visible")',ctrl:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO","Visible")',ctrl:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","Visible")',ctrl:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL","Visible")',ctrl:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',prop:'Visible'},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'TitleControlIdToReplace'},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'TitleControlIdToReplace'},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'TitleControlIdToReplace'},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'TitleControlIdToReplace'},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV40DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SelectedValue_set',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SelectedValue_set'},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.FilteredText_set',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'FilteredText_set'},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.FilteredText_set',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'FilteredText_set'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.FilteredTextTo_set',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'FilteredTextTo_set'},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SelectedValue_set',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SelectedValue_set'},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.FilteredText_set',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'FilteredText_set'},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SelectedValue_set',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_set'},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.FilteredText_set',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'FilteredText_set'},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.ActiveEventKey',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.FilteredText_get',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SelectedValue_get',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_SEX","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Visible")',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Visible")',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.ActiveEventKey',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.FilteredText_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'FilteredText_get'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SelectedValue_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_SEX","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Visible")',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Visible")',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.ActiveEventKey',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.FilteredText_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'FilteredText_get'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.FilteredTextTo_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_SEX","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Visible")',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Visible")',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{ctrl:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.ActiveEventKey',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.FilteredText_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'FilteredText_get'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SelectedValue_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'this.DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'this.DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer.SortedStatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_SEX","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC","Title")',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Visible")',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Visible")',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'A520VIEW_LPI_BR_Information_ID',fld:'VIEW_LPI_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''}],[{av:'AV45PatientReTenant',fld:'vPATIENTRETENANT',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Tooltiptext")',ctrl:'vPATIENTRETENANT',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vPATIENTRETENANT","Link")',ctrl:'vPATIENTRETENANT',prop:'Link'},{av:'AV47Patient_Entity',fld:'vPATIENT_ENTITY',pic:''},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Tooltiptext")',ctrl:'vPATIENT_ENTITY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vPATIENT_ENTITY","Link")',ctrl:'vPATIENT_ENTITY',prop:'Link'}]];
   this.EvtParms["VIEW_LPI_BR_INFORMATION_PATIENTNO.CLICK"] = [[{av:'A520VIEW_LPI_BR_Information_ID',fld:'VIEW_LPI_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}],[]];
   this.setVCMap("AV53tTenantCode", "vTTENANTCODE", 0, "svchar", 100, 0);
   this.setVCMap("AV72Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV46IsAuthorized_PatientReTenant", "vISAUTHORIZED_PATIENTRETENANT", 0, "boolean", 4, 0);
   this.setVCMap("AV48IsAuthorized_Patient_Entity", "vISAUTHORIZED_PATIENT_ENTITY", 0, "boolean", 4, 0);
   this.setVCMap("AV72Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV46IsAuthorized_PatientReTenant", "vISAUTHORIZED_PATIENTRETENANT", 0, "boolean", 4, 0);
   this.setVCMap("AV48IsAuthorized_Patient_Entity", "vISAUTHORIZED_PATIENT_ENTITY", 0, "boolean", 4, 0);
   this.setVCMap("AV72Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV46IsAuthorized_PatientReTenant", "vISAUTHORIZED_PATIENTRETENANT", 0, "boolean", 4, 0);
   this.setVCMap("AV48IsAuthorized_Patient_Entity", "vISAUTHORIZED_PATIENT_ENTITY", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[23]);
   GridContainer.addRefreshingVar(this.GXValidFnc[34]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   GridContainer.addRefreshingVar(this.GXValidFnc[42]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[92]);
   GridContainer.addRefreshingVar(this.GXValidFnc[93]);
   GridContainer.addRefreshingVar(this.GXValidFnc[94]);
   GridContainer.addRefreshingVar(this.GXValidFnc[95]);
   GridContainer.addRefreshingVar(this.GXValidFnc[96]);
   GridContainer.addRefreshingVar(this.GXValidFnc[97]);
   GridContainer.addRefreshingVar(this.GXValidFnc[98]);
   GridContainer.addRefreshingVar(this.GXValidFnc[99]);
   GridContainer.addRefreshingVar(this.GXValidFnc[103]);
   GridContainer.addRefreshingVar(this.GXValidFnc[104]);
   GridContainer.addRefreshingVar(this.GXValidFnc[84]);
   GridContainer.addRefreshingVar(this.GXValidFnc[86]);
   GridContainer.addRefreshingVar(this.GXValidFnc[88]);
   GridContainer.addRefreshingVar(this.GXValidFnc[90]);
   GridContainer.addRefreshingVar({rfrVar:"AV72Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV46IsAuthorized_PatientReTenant"});
   GridContainer.addRefreshingVar({rfrVar:"AV48IsAuthorized_Patient_Entity"});
   this.Initialize( );
});
gx.createParentObj(br_informationlist);
