/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:41:47.72
*/
gx.evt.autoSkip = false;
gx.define('br_medicationww', false, function () {
   this.ServerClass =  "br_medicationww" ;
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
      this.AV141Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV141Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Valid_Br_encounterid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTERID", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tfbr_medication_admitstartdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_MEDICATION_ADMITSTARTDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV77TFBR_Medication_AdmitStartDate)==0) || new gx.date.gxdate( this.AV77TFBR_Medication_AdmitStartDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Medication_Admit Start Date瓒呯晫");
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
   this.Validv_Tfbr_medication_admitstartdate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_MEDICATION_ADMITSTARTDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV78TFBR_Medication_AdmitStartDate_To)==0) || new gx.date.gxdate( this.AV78TFBR_Medication_AdmitStartDate_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Medication_Admit Start Date_To瓒呯晫");
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
   this.Validv_Ddo_br_medication_admitstartdateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV79DDO_BR_Medication_AdmitStartDateAuxDate)==0) || new gx.date.gxdate( this.AV79DDO_BR_Medication_AdmitStartDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Medication_Admit Start Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_medication_admitstartdateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo)==0) || new gx.date.gxdate( this.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Medication_Admit Start Date Aux Date To瓒呯晫");
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
      this.s152_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus =  ""  ;
   };
   this.e113k2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e123k2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e133k2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e143k2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e153k2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e163k2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e173k2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e183k2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e223k2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e233k2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,27,28,29,31,33,35,37,39,41,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59];
   this.GXLastCtrlId =59;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_medicationww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",13,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(119,14,"BR_MEDICATIONID","鑽墿娌荤枟涓婚敭","","BR_MedicationID","int",0,"px",18,18,"right",null,[],119,"BR_MedicationID",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(19,15,"BR_ENCOUNTERID","灏辫瘖淇℃伅涓婚敭","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(36,16,"BR_INFORMATION_PATIENTNO","鎮ｈ€呯紪鍙?,"","BR_Information_PatientNo","svchar",410,"px",2000,80,"left",null,[],36,"BR_Information_PatientNo",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(121,17,"BR_MEDICATION_RXNAME","","","BR_Medication_RXName","svchar",0,"px",40,40,"left",null,[],121,"BR_Medication_RXName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(122,18,"BR_MEDICATION_RXCODE","","","BR_Medication_RXCode","svchar",0,"px",40,40,"left",null,[],122,"BR_Medication_RXCode",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(127,19,"BR_MEDICATION_RXQUANTITY","","","BR_Medication_RXQuantity","svchar",0,"px",100,80,"left",null,[],127,"BR_Medication_RXQuantity",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(128,20,"BR_MEDICATION_RXDAYSSUPPLY","","","BR_Medication_RXDaysSupply","decimal",0,"px",15,15,"right",null,[],128,"BR_Medication_RXDaysSupply",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(126,21,"BR_MEDICATION_RXFREQUENCY","","","BR_Medication_RXFrequency","svchar",0,"px",100,80,"left",null,[],126,"BR_Medication_RXFrequency",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(132,22,"BR_MEDICATION_ADMITSTARTDATE","","","BR_Medication_AdmitStartDate","date",0,"px",10,10,"right",null,[],132,"BR_Medication_AdmitStartDate",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 26, 13, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV110GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV110GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV110GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV112GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV112GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV112GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV111GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV111GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV111GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e113k2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e123k2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICATION_RXNAMEContainer = gx.uc.getNew(this, 30, 13, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXNAMEContainer", "Ddo_br_medication_rxname", "DDO_BR_MEDICATION_RXNAME");
   var DDO_BR_MEDICATION_RXNAMEContainer = this.DDO_BR_MEDICATION_RXNAMEContainer;
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListProc", "Datalistproc", "BR_MedicationWWGetFilterData", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV108DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV108DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV108DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV30BR_Medication_RXNameTitleFilterData', "vBR_MEDICATION_RXNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30BR_Medication_RXNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXNAMETITLEFILTERDATA",UC.ParentObject.AV30BR_Medication_RXNameTitleFilterData); });
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXNAMEContainer.addEventHandler("OnOptionClicked", this.e133k2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXNAMEContainer);
   this.DDO_BR_MEDICATION_RXCODEContainer = gx.uc.getNew(this, 32, 31, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXCODEContainer", "Ddo_br_medication_rxcode", "DDO_BR_MEDICATION_RXCODE");
   var DDO_BR_MEDICATION_RXCODEContainer = this.DDO_BR_MEDICATION_RXCODEContainer;
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("DataListProc", "Datalistproc", "BR_MedicationWWGetFilterData", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXCODEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXCODEContainer.addV2CFunction('AV108DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV108DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV108DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXCODEContainer.addV2CFunction('AV34BR_Medication_RXCodeTitleFilterData', "vBR_MEDICATION_RXCODETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34BR_Medication_RXCodeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXCODETITLEFILTERDATA",UC.ParentObject.AV34BR_Medication_RXCodeTitleFilterData); });
   DDO_BR_MEDICATION_RXCODEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXCODEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXCODEContainer.addEventHandler("OnOptionClicked", this.e143k2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXCODEContainer);
   this.DDO_BR_MEDICATION_RXQUANTITYContainer = gx.uc.getNew(this, 34, 31, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXQUANTITYContainer", "Ddo_br_medication_rxquantity", "DDO_BR_MEDICATION_RXQUANTITY");
   var DDO_BR_MEDICATION_RXQUANTITYContainer = this.DDO_BR_MEDICATION_RXQUANTITYContainer;
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListProc", "Datalistproc", "BR_MedicationWWGetFilterData", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.addV2CFunction('AV108DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXQUANTITYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV108DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV108DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXQUANTITYContainer.addV2CFunction('AV54BR_Medication_RXQuantityTitleFilterData', "vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXQUANTITYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV54BR_Medication_RXQuantityTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA",UC.ParentObject.AV54BR_Medication_RXQuantityTitleFilterData); });
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXQUANTITYContainer.addEventHandler("OnOptionClicked", this.e153k2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXQUANTITYContainer);
   this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer = gx.uc.getNew(this, 36, 31, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXDAYSSUPPLYContainer", "Ddo_br_medication_rxdayssupply", "DDO_BR_MEDICATION_RXDAYSSUPPLY");
   var DDO_BR_MEDICATION_RXDAYSSUPPLYContainer = this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer;
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addV2CFunction('AV108DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV108DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV108DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addV2CFunction('AV58BR_Medication_RXDaysSupplyTitleFilterData', "vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV58BR_Medication_RXDaysSupplyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA",UC.ParentObject.AV58BR_Medication_RXDaysSupplyTitleFilterData); });
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addEventHandler("OnOptionClicked", this.e163k2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXDAYSSUPPLYContainer);
   this.DDO_BR_MEDICATION_RXFREQUENCYContainer = gx.uc.getNew(this, 38, 31, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXFREQUENCYContainer", "Ddo_br_medication_rxfrequency", "DDO_BR_MEDICATION_RXFREQUENCY");
   var DDO_BR_MEDICATION_RXFREQUENCYContainer = this.DDO_BR_MEDICATION_RXFREQUENCYContainer;
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListProc", "Datalistproc", "BR_MedicationWWGetFilterData", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addV2CFunction('AV108DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV108DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV108DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addV2CFunction('AV50BR_Medication_RXFrequencyTitleFilterData', "vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV50BR_Medication_RXFrequencyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA",UC.ParentObject.AV50BR_Medication_RXFrequencyTitleFilterData); });
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addEventHandler("OnOptionClicked", this.e173k2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXFREQUENCYContainer);
   this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer = gx.uc.getNew(this, 40, 31, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_ADMITSTARTDATEContainer", "Ddo_br_medication_admitstartdate", "DDO_BR_MEDICATION_ADMITSTARTDATE");
   var DDO_BR_MEDICATION_ADMITSTARTDATEContainer = this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer;
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addV2CFunction('AV108DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV108DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV108DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addV2CFunction('AV76BR_Medication_AdmitStartDateTitleFilterData', "vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV76BR_Medication_AdmitStartDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA",UC.ParentObject.AV76BR_Medication_AdmitStartDateTitleFilterData); });
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addEventHandler("OnOptionClicked", this.e183k2_client);
   this.setUserControl(DDO_BR_MEDICATION_ADMITSTARTDATEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 42, 31, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id:13 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV113Display",gxold:"OV113Display",gxvar:"AV113Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV113Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV113Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(12),gx.O.AV113Display,gx.O.AV140Display_GXI)},c2v:function(){gx.O.AV140Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV113Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(12))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(12))}, gxvar_GXI:'AV140Display_GXI',nac:gx.falseFn};
   GXValidFnc[14]={ id:14 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(12),gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[15]={ id:15 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(12),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[16]={ id:16 ,lvl:2,type:"svchar",len:2000,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(12),gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[17]={ id:17 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(12),gx.O.A121BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[18]={ id:18 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXCODE",gxz:"Z122BR_Medication_RXCode",gxold:"O122BR_Medication_RXCode",gxvar:"A122BR_Medication_RXCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A122BR_Medication_RXCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z122BR_Medication_RXCode=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXCODE",row || gx.fn.currentGridRowImpl(12),gx.O.A122BR_Medication_RXCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A122BR_Medication_RXCode=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXCODE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[19]={ id:19 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXQUANTITY",gxz:"Z127BR_Medication_RXQuantity",gxold:"O127BR_Medication_RXQuantity",gxvar:"A127BR_Medication_RXQuantity",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A127BR_Medication_RXQuantity=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z127BR_Medication_RXQuantity=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXQUANTITY",row || gx.fn.currentGridRowImpl(12),gx.O.A127BR_Medication_RXQuantity,0)},c2v:function(){if(this.val()!==undefined)gx.O.A127BR_Medication_RXQuantity=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXQUANTITY",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[20]={ id:20 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDAYSSUPPLY",gxz:"Z128BR_Medication_RXDaysSupply",gxold:"O128BR_Medication_RXDaysSupply",gxvar:"A128BR_Medication_RXDaysSupply",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",row || gx.fn.currentGridRowImpl(12),gx.O.A128BR_Medication_RXDaysSupply,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A128BR_Medication_RXDaysSupply=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",row || gx.fn.currentGridRowImpl(12),',','.')},nac:gx.falseFn};
   GXValidFnc[21]={ id:21 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXFREQUENCY",gxz:"Z126BR_Medication_RXFrequency",gxold:"O126BR_Medication_RXFrequency",gxvar:"A126BR_Medication_RXFrequency",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A126BR_Medication_RXFrequency=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z126BR_Medication_RXFrequency=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXFREQUENCY",row || gx.fn.currentGridRowImpl(12),gx.O.A126BR_Medication_RXFrequency,0)},c2v:function(){if(this.val()!==undefined)gx.O.A126BR_Medication_RXFrequency=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXFREQUENCY",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[22]={ id:22 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_ADMITSTARTDATE",gxz:"Z132BR_Medication_AdmitStartDate",gxold:"O132BR_Medication_AdmitStartDate",gxvar:"A132BR_Medication_AdmitStartDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_ADMITSTARTDATE",row || gx.fn.currentGridRowImpl(12),gx.O.A132BR_Medication_AdmitStartDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_MEDICATION_ADMITSTARTDATE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[31]={ id:31 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_BR_Medication_RXNameTitleControlIdToReplace",gxold:"OV33ddo_BR_Medication_RXNameTitleControlIdToReplace",gxvar:"AV33ddo_BR_Medication_RXNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gx.O.AV33ddo_BR_Medication_RXNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_BR_Medication_RXNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE",gxz:"ZV37ddo_BR_Medication_RXCodeTitleControlIdToReplace",gxold:"OV37ddo_BR_Medication_RXCodeTitleControlIdToReplace",gxvar:"AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37ddo_BR_Medication_RXCodeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE",gx.O.AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE",gxz:"ZV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace",gxold:"OV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace",gxvar:"AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE",gx.O.AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE",gxz:"ZV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace",gxold:"OV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace",gxvar:"AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE",gx.O.AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE",gxz:"ZV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace",gxold:"OV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace",gxvar:"AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE",gx.O.AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE",gxz:"ZV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace",gxold:"OV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace",gxvar:"AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE",gx.O.AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXNAME",gxz:"ZV31TFBR_Medication_RXName",gxold:"OV31TFBR_Medication_RXName",gxvar:"AV31TFBR_Medication_RXName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31TFBR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31TFBR_Medication_RXName=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXNAME",gx.O.AV31TFBR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31TFBR_Medication_RXName=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXNAME")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXNAME_SEL",gxz:"ZV32TFBR_Medication_RXName_Sel",gxold:"OV32TFBR_Medication_RXName_Sel",gxvar:"AV32TFBR_Medication_RXName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV32TFBR_Medication_RXName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV32TFBR_Medication_RXName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXNAME_SEL",gx.O.AV32TFBR_Medication_RXName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV32TFBR_Medication_RXName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXNAME_SEL")},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXCODE",gxz:"ZV35TFBR_Medication_RXCode",gxold:"OV35TFBR_Medication_RXCode",gxvar:"AV35TFBR_Medication_RXCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35TFBR_Medication_RXCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35TFBR_Medication_RXCode=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXCODE",gx.O.AV35TFBR_Medication_RXCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35TFBR_Medication_RXCode=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXCODE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXCODE_SEL",gxz:"ZV36TFBR_Medication_RXCode_Sel",gxold:"OV36TFBR_Medication_RXCode_Sel",gxvar:"AV36TFBR_Medication_RXCode_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV36TFBR_Medication_RXCode_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36TFBR_Medication_RXCode_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXCODE_SEL",gx.O.AV36TFBR_Medication_RXCode_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV36TFBR_Medication_RXCode_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXCODE_SEL")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXQUANTITY",gxz:"ZV55TFBR_Medication_RXQuantity",gxold:"OV55TFBR_Medication_RXQuantity",gxvar:"AV55TFBR_Medication_RXQuantity",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV55TFBR_Medication_RXQuantity=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV55TFBR_Medication_RXQuantity=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXQUANTITY",gx.O.AV55TFBR_Medication_RXQuantity,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV55TFBR_Medication_RXQuantity=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXQUANTITY")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXQUANTITY_SEL",gxz:"ZV56TFBR_Medication_RXQuantity_Sel",gxold:"OV56TFBR_Medication_RXQuantity_Sel",gxvar:"AV56TFBR_Medication_RXQuantity_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV56TFBR_Medication_RXQuantity_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV56TFBR_Medication_RXQuantity_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXQUANTITY_SEL",gx.O.AV56TFBR_Medication_RXQuantity_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV56TFBR_Medication_RXQuantity_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXQUANTITY_SEL")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXDAYSSUPPLY",gxz:"ZV59TFBR_Medication_RXDaysSupply",gxold:"OV59TFBR_Medication_RXDaysSupply",gxvar:"AV59TFBR_Medication_RXDaysSupply",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV59TFBR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV59TFBR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_RXDAYSSUPPLY",gx.O.AV59TFBR_Medication_RXDaysSupply,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV59TFBR_Medication_RXDaysSupply=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_RXDAYSSUPPLY",',','.')},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXDAYSSUPPLY_TO",gxz:"ZV60TFBR_Medication_RXDaysSupply_To",gxold:"OV60TFBR_Medication_RXDaysSupply_To",gxvar:"AV60TFBR_Medication_RXDaysSupply_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV60TFBR_Medication_RXDaysSupply_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV60TFBR_Medication_RXDaysSupply_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_RXDAYSSUPPLY_TO",gx.O.AV60TFBR_Medication_RXDaysSupply_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV60TFBR_Medication_RXDaysSupply_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_RXDAYSSUPPLY_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXFREQUENCY",gxz:"ZV51TFBR_Medication_RXFrequency",gxold:"OV51TFBR_Medication_RXFrequency",gxvar:"AV51TFBR_Medication_RXFrequency",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV51TFBR_Medication_RXFrequency=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV51TFBR_Medication_RXFrequency=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXFREQUENCY",gx.O.AV51TFBR_Medication_RXFrequency,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV51TFBR_Medication_RXFrequency=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXFREQUENCY")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXFREQUENCY_SEL",gxz:"ZV122TFBR_Medication_RXFrequency_Sel",gxold:"OV122TFBR_Medication_RXFrequency_Sel",gxvar:"AV122TFBR_Medication_RXFrequency_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV122TFBR_Medication_RXFrequency_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV122TFBR_Medication_RXFrequency_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXFREQUENCY_SEL",gx.O.AV122TFBR_Medication_RXFrequency_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV122TFBR_Medication_RXFrequency_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXFREQUENCY_SEL")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_medication_admitstartdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_ADMITSTARTDATE",gxz:"ZV77TFBR_Medication_AdmitStartDate",gxold:"OV77TFBR_Medication_AdmitStartDate",gxvar:"AV77TFBR_Medication_AdmitStartDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[55],ip:[55],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV77TFBR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV77TFBR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_ADMITSTARTDATE",gx.O.AV77TFBR_Medication_AdmitStartDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV77TFBR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_ADMITSTARTDATE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_medication_admitstartdate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_ADMITSTARTDATE_TO",gxz:"ZV78TFBR_Medication_AdmitStartDate_To",gxold:"OV78TFBR_Medication_AdmitStartDate_To",gxvar:"AV78TFBR_Medication_AdmitStartDate_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[56],ip:[56],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV78TFBR_Medication_AdmitStartDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV78TFBR_Medication_AdmitStartDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_ADMITSTARTDATE_TO",gx.O.AV78TFBR_Medication_AdmitStartDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV78TFBR_Medication_AdmitStartDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_ADMITSTARTDATE_TO")},nac:gx.falseFn};
   GXValidFnc[57]={ id: 57, fld:"DDO_BR_MEDICATION_ADMITSTARTDATEAUXDATES",grid:0};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_medication_admitstartdateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATE",gxz:"ZV79DDO_BR_Medication_AdmitStartDateAuxDate",gxold:"OV79DDO_BR_Medication_AdmitStartDateAuxDate",gxvar:"AV79DDO_BR_Medication_AdmitStartDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[58],ip:[58],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV79DDO_BR_Medication_AdmitStartDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV79DDO_BR_Medication_AdmitStartDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATE",gx.O.AV79DDO_BR_Medication_AdmitStartDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV79DDO_BR_Medication_AdmitStartDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_medication_admitstartdateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATETO",gxz:"ZV80DDO_BR_Medication_AdmitStartDateAuxDateTo",gxold:"OV80DDO_BR_Medication_AdmitStartDateAuxDateTo",gxvar:"AV80DDO_BR_Medication_AdmitStartDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[59],ip:[59],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV80DDO_BR_Medication_AdmitStartDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATETO",gx.O.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATETO")},nac:gx.falseFn};
   this.ZV113Display = "" ;
   this.OV113Display = "" ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.Z122BR_Medication_RXCode = "" ;
   this.O122BR_Medication_RXCode = "" ;
   this.Z127BR_Medication_RXQuantity = "" ;
   this.O127BR_Medication_RXQuantity = "" ;
   this.Z128BR_Medication_RXDaysSupply = 0 ;
   this.O128BR_Medication_RXDaysSupply = 0 ;
   this.Z126BR_Medication_RXFrequency = "" ;
   this.O126BR_Medication_RXFrequency = "" ;
   this.Z132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.O132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.AV33ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.ZV33ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.OV33ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = "" ;
   this.ZV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = "" ;
   this.OV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = "" ;
   this.AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.ZV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.OV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.ZV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.OV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.ZV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.OV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.ZV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.OV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV31TFBR_Medication_RXName = "" ;
   this.ZV31TFBR_Medication_RXName = "" ;
   this.OV31TFBR_Medication_RXName = "" ;
   this.AV32TFBR_Medication_RXName_Sel = "" ;
   this.ZV32TFBR_Medication_RXName_Sel = "" ;
   this.OV32TFBR_Medication_RXName_Sel = "" ;
   this.AV35TFBR_Medication_RXCode = "" ;
   this.ZV35TFBR_Medication_RXCode = "" ;
   this.OV35TFBR_Medication_RXCode = "" ;
   this.AV36TFBR_Medication_RXCode_Sel = "" ;
   this.ZV36TFBR_Medication_RXCode_Sel = "" ;
   this.OV36TFBR_Medication_RXCode_Sel = "" ;
   this.AV55TFBR_Medication_RXQuantity = "" ;
   this.ZV55TFBR_Medication_RXQuantity = "" ;
   this.OV55TFBR_Medication_RXQuantity = "" ;
   this.AV56TFBR_Medication_RXQuantity_Sel = "" ;
   this.ZV56TFBR_Medication_RXQuantity_Sel = "" ;
   this.OV56TFBR_Medication_RXQuantity_Sel = "" ;
   this.AV59TFBR_Medication_RXDaysSupply = 0 ;
   this.ZV59TFBR_Medication_RXDaysSupply = 0 ;
   this.OV59TFBR_Medication_RXDaysSupply = 0 ;
   this.AV60TFBR_Medication_RXDaysSupply_To = 0 ;
   this.ZV60TFBR_Medication_RXDaysSupply_To = 0 ;
   this.OV60TFBR_Medication_RXDaysSupply_To = 0 ;
   this.AV51TFBR_Medication_RXFrequency = "" ;
   this.ZV51TFBR_Medication_RXFrequency = "" ;
   this.OV51TFBR_Medication_RXFrequency = "" ;
   this.AV122TFBR_Medication_RXFrequency_Sel = "" ;
   this.ZV122TFBR_Medication_RXFrequency_Sel = "" ;
   this.OV122TFBR_Medication_RXFrequency_Sel = "" ;
   this.AV77TFBR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.ZV77TFBR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.OV77TFBR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.AV78TFBR_Medication_AdmitStartDate_To = gx.date.nullDate() ;
   this.ZV78TFBR_Medication_AdmitStartDate_To = gx.date.nullDate() ;
   this.OV78TFBR_Medication_AdmitStartDate_To = gx.date.nullDate() ;
   this.AV79DDO_BR_Medication_AdmitStartDateAuxDate = gx.date.nullDate() ;
   this.ZV79DDO_BR_Medication_AdmitStartDateAuxDate = gx.date.nullDate() ;
   this.OV79DDO_BR_Medication_AdmitStartDateAuxDate = gx.date.nullDate() ;
   this.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo = gx.date.nullDate() ;
   this.ZV80DDO_BR_Medication_AdmitStartDateAuxDateTo = gx.date.nullDate() ;
   this.OV80DDO_BR_Medication_AdmitStartDateAuxDateTo = gx.date.nullDate() ;
   this.AV110GridCurrentPage = 0 ;
   this.AV108DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV33ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = "" ;
   this.AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV31TFBR_Medication_RXName = "" ;
   this.AV32TFBR_Medication_RXName_Sel = "" ;
   this.AV35TFBR_Medication_RXCode = "" ;
   this.AV36TFBR_Medication_RXCode_Sel = "" ;
   this.AV55TFBR_Medication_RXQuantity = "" ;
   this.AV56TFBR_Medication_RXQuantity_Sel = "" ;
   this.AV59TFBR_Medication_RXDaysSupply = 0 ;
   this.AV60TFBR_Medication_RXDaysSupply_To = 0 ;
   this.AV51TFBR_Medication_RXFrequency = "" ;
   this.AV122TFBR_Medication_RXFrequency_Sel = "" ;
   this.AV77TFBR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.AV78TFBR_Medication_AdmitStartDate_To = gx.date.nullDate() ;
   this.AV79DDO_BR_Medication_AdmitStartDateAuxDate = gx.date.nullDate() ;
   this.AV80DDO_BR_Medication_AdmitStartDateAuxDateTo = gx.date.nullDate() ;
   this.A85BR_Information_ID = 0 ;
   this.AV113Display = "" ;
   this.A119BR_MedicationID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A121BR_Medication_RXName = "" ;
   this.A122BR_Medication_RXCode = "" ;
   this.A127BR_Medication_RXQuantity = "" ;
   this.A128BR_Medication_RXDaysSupply = 0 ;
   this.A126BR_Medication_RXFrequency = "" ;
   this.A132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.AV141Pgmname = "" ;
   this.Events = {"e113k2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e123k2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e133k2_client": ["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", true] ,"e143k2_client": ["DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED", true] ,"e153k2_client": ["DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED", true] ,"e163k2_client": ["DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED", true] ,"e173k2_client": ["DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED", true] ,"e183k2_client": ["DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED", true] ,"e223k2_client": ["ENTER", true] ,"e233k2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXNAME","Visible")',ctrl:'vTFBR_MEDICATION_RXNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXNAME_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXNAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXCODE","Visible")',ctrl:'vTFBR_MEDICATION_RXCODE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXCODE_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXCODE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXQUANTITY","Visible")',ctrl:'vTFBR_MEDICATION_RXQUANTITY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXQUANTITY_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXQUANTITY_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXDAYSSUPPLY","Visible")',ctrl:'vTFBR_MEDICATION_RXDAYSSUPPLY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXDAYSSUPPLY_TO","Visible")',ctrl:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXFREQUENCY","Visible")',ctrl:'vTFBR_MEDICATION_RXFREQUENCY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXFREQUENCY_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXFREQUENCY_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_ADMITSTARTDATE","Visible")',ctrl:'vTFBR_MEDICATION_ADMITSTARTDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_ADMITSTARTDATE_TO","Visible")',ctrl:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'TitleControlIdToReplace'},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'TitleControlIdToReplace'},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'TitleControlIdToReplace'},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'TitleControlIdToReplace'},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'TitleControlIdToReplace'},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'TitleControlIdToReplace'},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV108DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'FilteredTextTo_set'},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SelectedValue_set'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'FilteredText_set'},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'FilteredTextTo_set'},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SelectedValue_set'},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'FilteredText_set'},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SelectedValue_set'},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'FilteredText_set'},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_set'},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXCODEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXCODE","Title")',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV113Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'}]];
   this.setVCMap("AV141Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV141Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV141Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[43]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[31]);
   GridContainer.addRefreshingVar(this.GXValidFnc[33]);
   GridContainer.addRefreshingVar(this.GXValidFnc[35]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[41]);
   GridContainer.addRefreshingVar({rfrVar:"AV141Pgmname"});
   this.Initialize( );
});
gx.createParentObj(br_medicationww);
