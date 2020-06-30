/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:0.89
*/
gx.evt.autoSkip = false;
gx.define('br_scheme_br_scheme_medication', true, function (CmpContext) {
   this.ServerClass =  "br_scheme_br_scheme_medication" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV68Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV8BR_SchemeID=gx.fn.getIntegerValue("vBR_SCHEMEID",',') ;
      this.AV44IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV8BR_SchemeID=gx.fn.getIntegerValue("vBR_SCHEMEID",',') ;
      this.AV68Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV44IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV8BR_SchemeID=gx.fn.getIntegerValue("vBR_SCHEMEID",',') ;
   };
   this.Valid_Br_medicationid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(28) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATIONID", gx.fn.currentGridRowImpl(28));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_schemeid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_SCHEMEID");
         this.AnyError  = 0;

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
      if ( this.AV14OrderedBy == 1 )
      {
         this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 2 )
      {
         this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 3 )
      {
         this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 4 )
      {
         this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus =  ""  ;
   };
   this.e116h1_client=function()
   {
      this.clearMessages();
      this.call("br_scheme_medicationupdate.aspx", [this.AV8BR_SchemeID, "insert"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e216h2_client=function()
   {
      this.clearMessages();
      this.call("br_scheme_medicationupdate.aspx", [this.A332BR_Scheme_MedicationID, "update"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e226h2_client=function()
   {
      this.clearMessages();
      this.call("br_scheme_medicationupdate.aspx", [this.A332BR_Scheme_MedicationID, "delete"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e126h2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e136h2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e146h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e156h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e166h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e176h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e236h2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e246h2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,42,43,44,46,48,50,52,53,55,56,57,58,59,60,61,62,63,64];
   this.GXLastCtrlId =64;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_scheme_br_scheme_medication",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Newupdate","vNEWUPDATE",30,0,"px",17,"px","e216h2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",31,0,"px",17,"px","e226h2_client","","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(328,32,"BR_SCHEME_CHEM_REGIMENS","","","BR_Scheme_Chem_Regimens","svchar",0,"px",100,80,"left",null,[],328,"BR_Scheme_Chem_Regimens",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(121,33,"BR_MEDICATION_RXNAME","","","BR_Medication_RXName","svchar",0,"px",40,40,"left",null,[],121,"BR_Medication_RXName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(124,34,"BR_MEDICATION_RXDOSE","","","BR_Medication_RXDose","decimal",0,"px",15,15,"right",null,[],124,"BR_Medication_RXDose",true,5,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(125,35,"BR_MEDICATION_RXUNIT","","","BR_Medication_RXUnit","svchar",0,"px",100,80,"left",null,[],125,"BR_Medication_RXUnit",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(119,36,"BR_MEDICATIONID","鑽墿娌荤枟涓婚敭","","BR_MedicationID","int",0,"px",18,18,"right",null,[],119,"BR_MedicationID",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(332,37,"BR_SCHEME_MEDICATIONID","鍖栫枟鏂规鑽墿璇︽儏涓婚敭","","BR_Scheme_MedicationID","int",0,"px",18,18,"right",null,[],332,"BR_Scheme_MedicationID",false,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", this.CmpContext + "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 41, 29, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV36GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV36GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV38GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV38GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV37GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV37GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV37GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e126h2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e136h2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_SCHEME_CHEM_REGIMENSContainer = gx.uc.getNew(this, 45, 29, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_SCHEME_CHEM_REGIMENSContainer", "Ddo_br_scheme_chem_regimens", "DDO_BR_SCHEME_CHEM_REGIMENS");
   var DDO_BR_SCHEME_CHEM_REGIMENSContainer = this.DDO_BR_SCHEME_CHEM_REGIMENSContainer;
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListProc", "Datalistproc", "BR_Scheme_BR_Scheme_MedicationGetFilterData", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV17BR_Scheme_Chem_RegimensTitleFilterData', "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17BR_Scheme_Chem_RegimensTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA",UC.ParentObject.AV17BR_Scheme_Chem_RegimensTitleFilterData); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addEventHandler("OnOptionClicked", this.e146h2_client);
   this.setUserControl(DDO_BR_SCHEME_CHEM_REGIMENSContainer);
   this.DDO_BR_MEDICATION_RXNAMEContainer = gx.uc.getNew(this, 47, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICATION_RXNAMEContainer", "Ddo_br_medication_rxname", "DDO_BR_MEDICATION_RXNAME");
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
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListProc", "Datalistproc", "BR_Scheme_BR_Scheme_MedicationGetFilterData", "str");
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
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV46BR_Medication_RXNameTitleFilterData', "vBR_MEDICATION_RXNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV46BR_Medication_RXNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXNAMETITLEFILTERDATA",UC.ParentObject.AV46BR_Medication_RXNameTitleFilterData); });
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXNAMEContainer.addEventHandler("OnOptionClicked", this.e156h2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXNAMEContainer);
   this.DDO_BR_MEDICATION_RXDOSEContainer = gx.uc.getNew(this, 49, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICATION_RXDOSEContainer", "Ddo_br_medication_rxdose", "DDO_BR_MEDICATION_RXDOSE");
   var DDO_BR_MEDICATION_RXDOSEContainer = this.DDO_BR_MEDICATION_RXDOSEContainer;
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV50BR_Medication_RXDoseTitleFilterData', "vBR_MEDICATION_RXDOSETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV50BR_Medication_RXDoseTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXDOSETITLEFILTERDATA",UC.ParentObject.AV50BR_Medication_RXDoseTitleFilterData); });
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXDOSEContainer.addEventHandler("OnOptionClicked", this.e166h2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXDOSEContainer);
   this.DDO_BR_MEDICATION_RXUNITContainer = gx.uc.getNew(this, 51, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICATION_RXUNITContainer", "Ddo_br_medication_rxunit", "DDO_BR_MEDICATION_RXUNIT");
   var DDO_BR_MEDICATION_RXUNITContainer = this.DDO_BR_MEDICATION_RXUNITContainer;
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListProc", "Datalistproc", "BR_Scheme_BR_Scheme_MedicationGetFilterData", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV54BR_Medication_RXUnitTitleFilterData', "vBR_MEDICATION_RXUNITTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV54BR_Medication_RXUnitTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXUNITTITLEFILTERDATA",UC.ParentObject.AV54BR_Medication_RXUnitTitleFilterData); });
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXUNITContainer.addEventHandler("OnOptionClicked", this.e176h2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXUNITContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 54, 46, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[6]={ id: 6, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"BTNMINEINSERT",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV39Display",gxold:"OV39Display",gxvar:"AV39Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV39Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV39Display,gx.O.AV65Display_GXI)},c2v:function(){gx.O.AV65Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV39Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV65Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNEWUPDATE",gxz:"ZV60newupdate",gxold:"OV60newupdate",gxvar:"AV60newupdate",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV60newupdate=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV60newupdate=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vNEWUPDATE",row || gx.fn.currentGridRowImpl(28),gx.O.AV60newupdate,gx.O.AV66Newupdate_GXI)},c2v:function(){gx.O.AV66Newupdate_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV60newupdate=this.val()},val:function(row){return gx.fn.getGridControlValue("vNEWUPDATE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vNEWUPDATE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV66Newupdate_GXI',nac:gx.falseFn,evt:"e216h2_client"};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV43Delete",gxold:"OV43Delete",gxvar:"AV43Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV43Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(28),gx.O.AV43Delete,gx.O.AV67Delete_GXI)},c2v:function(){gx.O.AV67Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV43Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV67Delete_GXI',nac:gx.falseFn,evt:"e226h2_client"};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z328BR_Scheme_Chem_Regimens=Value},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(28),gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(28),gx.O.A121BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(28),gx.O.A124BR_Medication_RXDose,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A124BR_Medication_RXDose=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(28),',','.')},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A125BR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z125BR_Medication_RXUnit=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(28),gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A125BR_Medication_RXUnit=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(28),gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_MEDICATIONID",gxz:"Z332BR_Scheme_MedicationID",gxold:"O332BR_Scheme_MedicationID",gxvar:"A332BR_Scheme_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z332BR_Scheme_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_MEDICATIONID",row || gx.fn.currentGridRowImpl(28),gx.O.A332BR_Scheme_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_SCHEME_MEDICATIONID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxold:"OV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxvar:"AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gx.O.AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gxz:"ZV49ddo_BR_Medication_RXNameTitleControlIdToReplace",gxold:"OV49ddo_BR_Medication_RXNameTitleControlIdToReplace",gxvar:"AV49ddo_BR_Medication_RXNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV49ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV49ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gx.O.AV49ddo_BR_Medication_RXNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV49ddo_BR_Medication_RXNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gxz:"ZV53ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxold:"OV53ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxvar:"AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gx.O.AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gxz:"ZV57ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxold:"OV57ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxvar:"AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV57ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gx.O.AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z327BR_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_SCHEMEID",gx.O.A327BR_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_SCHEMEID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 53 , function() {
   });
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_REGIMENS",gxz:"ZV18TFBR_Scheme_Chem_Regimens",gxold:"OV18TFBR_Scheme_Chem_Regimens",gxvar:"AV18TFBR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Scheme_Chem_Regimens=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_REGIMENS",gx.O.AV18TFBR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Scheme_Chem_Regimens=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_REGIMENS")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_REGIMENS_SEL",gxz:"ZV19TFBR_Scheme_Chem_Regimens_Sel",gxold:"OV19TFBR_Scheme_Chem_Regimens_Sel",gxvar:"AV19TFBR_Scheme_Chem_Regimens_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19TFBR_Scheme_Chem_Regimens_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19TFBR_Scheme_Chem_Regimens_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_REGIMENS_SEL",gx.O.AV19TFBR_Scheme_Chem_Regimens_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19TFBR_Scheme_Chem_Regimens_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_REGIMENS_SEL")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXNAME",gxz:"ZV47TFBR_Medication_RXName",gxold:"OV47TFBR_Medication_RXName",gxvar:"AV47TFBR_Medication_RXName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV47TFBR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV47TFBR_Medication_RXName=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXNAME",gx.O.AV47TFBR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV47TFBR_Medication_RXName=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXNAME")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXNAME_SEL",gxz:"ZV48TFBR_Medication_RXName_Sel",gxold:"OV48TFBR_Medication_RXName_Sel",gxvar:"AV48TFBR_Medication_RXName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV48TFBR_Medication_RXName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV48TFBR_Medication_RXName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXNAME_SEL",gx.O.AV48TFBR_Medication_RXName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV48TFBR_Medication_RXName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXNAME_SEL")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXDOSE",gxz:"ZV51TFBR_Medication_RXDose",gxold:"OV51TFBR_Medication_RXDose",gxvar:"AV51TFBR_Medication_RXDose",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV51TFBR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV51TFBR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_RXDOSE",gx.O.AV51TFBR_Medication_RXDose,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV51TFBR_Medication_RXDose=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_RXDOSE",',','.')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXDOSE_TO",gxz:"ZV52TFBR_Medication_RXDose_To",gxold:"OV52TFBR_Medication_RXDose_To",gxvar:"AV52TFBR_Medication_RXDose_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV52TFBR_Medication_RXDose_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV52TFBR_Medication_RXDose_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_RXDOSE_TO",gx.O.AV52TFBR_Medication_RXDose_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV52TFBR_Medication_RXDose_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_RXDOSE_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXUNIT",gxz:"ZV55TFBR_Medication_RXUnit",gxold:"OV55TFBR_Medication_RXUnit",gxvar:"AV55TFBR_Medication_RXUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV55TFBR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV55TFBR_Medication_RXUnit=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXUNIT",gx.O.AV55TFBR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV55TFBR_Medication_RXUnit=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXUNIT")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXUNIT_SEL",gxz:"ZV56TFBR_Medication_RXUnit_Sel",gxold:"OV56TFBR_Medication_RXUnit_Sel",gxvar:"AV56TFBR_Medication_RXUnit_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV56TFBR_Medication_RXUnit_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV56TFBR_Medication_RXUnit_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXUNIT_SEL",gx.O.AV56TFBR_Medication_RXUnit_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV56TFBR_Medication_RXUnit_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXUNIT_SEL")},nac:gx.falseFn};
   this.ZV39Display = "" ;
   this.OV39Display = "" ;
   this.ZV60newupdate = "" ;
   this.OV60newupdate = "" ;
   this.ZV43Delete = "" ;
   this.OV43Delete = "" ;
   this.Z328BR_Scheme_Chem_Regimens = "" ;
   this.O328BR_Scheme_Chem_Regimens = "" ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.Z124BR_Medication_RXDose = 0 ;
   this.O124BR_Medication_RXDose = 0 ;
   this.Z125BR_Medication_RXUnit = "" ;
   this.O125BR_Medication_RXUnit = "" ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.Z332BR_Scheme_MedicationID = 0 ;
   this.O332BR_Scheme_MedicationID = 0 ;
   this.AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.ZV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.OV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV49ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.ZV49ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.OV49ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.ZV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.OV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.ZV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.OV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.A327BR_SchemeID = 0 ;
   this.Z327BR_SchemeID = 0 ;
   this.O327BR_SchemeID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV18TFBR_Scheme_Chem_Regimens = "" ;
   this.ZV18TFBR_Scheme_Chem_Regimens = "" ;
   this.OV18TFBR_Scheme_Chem_Regimens = "" ;
   this.AV19TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.ZV19TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.OV19TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.AV47TFBR_Medication_RXName = "" ;
   this.ZV47TFBR_Medication_RXName = "" ;
   this.OV47TFBR_Medication_RXName = "" ;
   this.AV48TFBR_Medication_RXName_Sel = "" ;
   this.ZV48TFBR_Medication_RXName_Sel = "" ;
   this.OV48TFBR_Medication_RXName_Sel = "" ;
   this.AV51TFBR_Medication_RXDose = 0 ;
   this.ZV51TFBR_Medication_RXDose = 0 ;
   this.OV51TFBR_Medication_RXDose = 0 ;
   this.AV52TFBR_Medication_RXDose_To = 0 ;
   this.ZV52TFBR_Medication_RXDose_To = 0 ;
   this.OV52TFBR_Medication_RXDose_To = 0 ;
   this.AV55TFBR_Medication_RXUnit = "" ;
   this.ZV55TFBR_Medication_RXUnit = "" ;
   this.OV55TFBR_Medication_RXUnit = "" ;
   this.AV56TFBR_Medication_RXUnit_Sel = "" ;
   this.ZV56TFBR_Medication_RXUnit_Sel = "" ;
   this.OV56TFBR_Medication_RXUnit_Sel = "" ;
   this.AV36GridCurrentPage = 0 ;
   this.AV33DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV49ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.A327BR_SchemeID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV18TFBR_Scheme_Chem_Regimens = "" ;
   this.AV19TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.AV47TFBR_Medication_RXName = "" ;
   this.AV48TFBR_Medication_RXName_Sel = "" ;
   this.AV51TFBR_Medication_RXDose = 0 ;
   this.AV52TFBR_Medication_RXDose_To = 0 ;
   this.AV55TFBR_Medication_RXUnit = "" ;
   this.AV56TFBR_Medication_RXUnit_Sel = "" ;
   this.AV8BR_SchemeID = 0 ;
   this.AV39Display = "" ;
   this.AV60newupdate = "" ;
   this.AV43Delete = "" ;
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.A121BR_Medication_RXName = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.A119BR_MedicationID = 0 ;
   this.A332BR_Scheme_MedicationID = 0 ;
   this.AV68Pgmname = "" ;
   this.AV44IsAuthorized_Delete = false ;
   this.Events = {"e126h2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e136h2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e146h2_client": ["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", true] ,"e156h2_client": ["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", true] ,"e166h2_client": ["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", true] ,"e176h2_client": ["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", true] ,"e236h2_client": ["ENTER", true] ,"e246h2_client": ["CANCEL", true] ,"e116h1_client": ["'DOMINEINSERT'", false] ,"e216h2_client": ["VNEWUPDATE.CLICK", false] ,"e226h2_client": ["VDELETE.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_REGIMENS","Visible")',ctrl:'vTFBR_SCHEME_CHEM_REGIMENS',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_REGIMENS_SEL","Visible")',ctrl:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXNAME","Visible")',ctrl:'vTFBR_MEDICATION_RXNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXNAME_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXNAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXDOSE","Visible")',ctrl:'vTFBR_MEDICATION_RXDOSE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXDOSE_TO","Visible")',ctrl:'vTFBR_MEDICATION_RXDOSE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXUNIT","Visible")',ctrl:'vTFBR_MEDICATION_RXUNIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXUNIT_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXUNIT_SEL',prop:'Visible'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'TitleControlIdToReplace'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'TitleControlIdToReplace'},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'TitleControlIdToReplace'},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'TitleControlIdToReplace'},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Visible")',ctrl:'BR_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV33DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'gx.fn.getCtrlProperty("TABLEHEADER","Visible")',ctrl:'TABLEHEADER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_set'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_set'},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredTextTo_set'},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_set'},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_set'},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SelectedValue_set',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_set'},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_set'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SelectedValue_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Visible")',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV39Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV60newupdate',fld:'vNEWUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vNEWUPDATE","Tooltiptext")',ctrl:'vNEWUPDATE',prop:'Tooltiptext'},{av:'AV43Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'}]];
   this.EvtParms["'DOMINEINSERT'"] = [[{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["VNEWUPDATE.CLICK"] = [[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["VDELETE.CLICK"] = [[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV68Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8BR_SchemeID", "vBR_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV44IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_SchemeID", "vBR_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV68Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV44IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_SchemeID", "vBR_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV8BR_SchemeID", "vBR_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV68Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV44IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar({rfrVar:"AV8BR_SchemeID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar({rfrVar:"AV68Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV60newupdate", rfrProp:"Visible", gxAttId:"Newupdate"});
   GridContainer.addRefreshingVar({rfrVar:"AV43Delete", rfrProp:"Visible", gxAttId:"Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV44IsAuthorized_Delete"});
   this.Initialize( );
});
