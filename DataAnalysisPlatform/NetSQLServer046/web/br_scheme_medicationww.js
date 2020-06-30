/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:5:55.22
*/
gx.evt.autoSkip = false;
gx.define('br_scheme_medicationww', false, function () {
   this.ServerClass =  "br_scheme_medicationww" ;
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
      this.AV76Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV56IsAuthorized_BR_Scheme_MedicationID=gx.fn.getControlValue("vISAUTHORIZED_BR_SCHEME_MEDICATIONID") ;
      this.AV54IsAuthorized_BR_Scheme_Chem_Regimens=gx.fn.getControlValue("vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS") ;
      this.AV76Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV56IsAuthorized_BR_Scheme_MedicationID=gx.fn.getControlValue("vISAUTHORIZED_BR_SCHEME_MEDICATIONID") ;
      this.AV54IsAuthorized_BR_Scheme_Chem_Regimens=gx.fn.getControlValue("vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS") ;
   };
   this.Valid_Br_schemeid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(31) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_SCHEMEID", gx.fn.currentGridRowImpl(31));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medicationid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(31) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATIONID", gx.fn.currentGridRowImpl(31));
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
      this.s152_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_SCHEMEIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_MEDICATIONIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 7 )
      {
         this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_SCHEMEIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATIONIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus =  ""  ;
   };
   this.e116j2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e126j2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e136j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e146j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEMEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e156j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATIONID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e166j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e176j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e186j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e196j2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e206j2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e246j2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e256j2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,44,46,47,48,50,52,54,56,58,60,62,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79];
   this.GXLastCtrlId =79;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_scheme_medicationww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(332,35,"BR_SCHEME_MEDICATIONID","","","BR_Scheme_MedicationID","int",0,"px",18,18,"right",null,[],332,"BR_Scheme_MedicationID",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(327,36,"BR_SCHEMEID","","","BR_SchemeID","int",0,"px",18,18,"right",null,[],327,"BR_SchemeID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(119,37,"BR_MEDICATIONID","","","BR_MedicationID","int",0,"px",18,18,"right",null,[],119,"BR_MedicationID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(328,38,"BR_SCHEME_CHEM_REGIMENS","","","BR_Scheme_Chem_Regimens","svchar",0,"px",100,80,"left",null,[],328,"BR_Scheme_Chem_Regimens",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(121,39,"BR_MEDICATION_RXNAME","","","BR_Medication_RXName","svchar",0,"px",40,40,"left",null,[],121,"BR_Medication_RXName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(124,40,"BR_MEDICATION_RXDOSE","","","BR_Medication_RXDose","decimal",0,"px",15,15,"right",null,[],124,"BR_Medication_RXDose",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(125,41,"BR_MEDICATION_RXUNIT","","","BR_Medication_RXUnit","svchar",0,"px",100,80,"left",null,[],125,"BR_Medication_RXUnit",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 45, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV46GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV46GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV46GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV48GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV48GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV48GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV47GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV47GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e116j2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e126j2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_SCHEME_MEDICATIONIDContainer = gx.uc.getNew(this, 49, 32, "BootstrapDropDownOptions", "DDO_BR_SCHEME_MEDICATIONIDContainer", "Ddo_br_scheme_medicationid", "DDO_BR_SCHEME_MEDICATIONID");
   var DDO_BR_SCHEME_MEDICATIONIDContainer = this.DDO_BR_SCHEME_MEDICATIONIDContainer;
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_MEDICATIONIDContainer.addV2CFunction('AV16BR_Scheme_MedicationIDTitleFilterData', "vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Scheme_MedicationIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Scheme_MedicationIDTitleFilterData); });
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_MEDICATIONIDContainer.addEventHandler("OnOptionClicked", this.e136j2_client);
   this.setUserControl(DDO_BR_SCHEME_MEDICATIONIDContainer);
   this.DDO_BR_SCHEMEIDContainer = gx.uc.getNew(this, 51, 50, "BootstrapDropDownOptions", "DDO_BR_SCHEMEIDContainer", "Ddo_br_schemeid", "DDO_BR_SCHEMEID");
   var DDO_BR_SCHEMEIDContainer = this.DDO_BR_SCHEMEIDContainer;
   DDO_BR_SCHEMEIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEMEIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEMEIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEMEIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEMEIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEMEIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEMEIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_SCHEMEIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEMEIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEMEIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEMEIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEMEIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_SCHEMEIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_SCHEMEIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEMEIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEMEIDContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_SCHEMEIDContainer.addV2CFunction('AV20BR_SchemeIDTitleFilterData', "vBR_SCHEMEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_SchemeIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEMEIDTITLEFILTERDATA",UC.ParentObject.AV20BR_SchemeIDTitleFilterData); });
   DDO_BR_SCHEMEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEMEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEMEIDContainer.addEventHandler("OnOptionClicked", this.e146j2_client);
   this.setUserControl(DDO_BR_SCHEMEIDContainer);
   this.DDO_BR_MEDICATIONIDContainer = gx.uc.getNew(this, 53, 50, "BootstrapDropDownOptions", "DDO_BR_MEDICATIONIDContainer", "Ddo_br_medicationid", "DDO_BR_MEDICATIONID");
   var DDO_BR_MEDICATIONIDContainer = this.DDO_BR_MEDICATIONIDContainer;
   DDO_BR_MEDICATIONIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATIONIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATIONIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATIONIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATIONIDContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATIONIDContainer.addV2CFunction('AV24BR_MedicationIDTitleFilterData', "vBR_MEDICATIONIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_MedicationIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATIONIDTITLEFILTERDATA",UC.ParentObject.AV24BR_MedicationIDTitleFilterData); });
   DDO_BR_MEDICATIONIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATIONIDContainer.addEventHandler("OnOptionClicked", this.e156j2_client);
   this.setUserControl(DDO_BR_MEDICATIONIDContainer);
   this.DDO_BR_SCHEME_CHEM_REGIMENSContainer = gx.uc.getNew(this, 55, 50, "BootstrapDropDownOptions", "DDO_BR_SCHEME_CHEM_REGIMENSContainer", "Ddo_br_scheme_chem_regimens", "DDO_BR_SCHEME_CHEM_REGIMENS");
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
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListProc", "Datalistproc", "BR_Scheme_MedicationWWGetFilterData", "str");
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
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV28BR_Scheme_Chem_RegimensTitleFilterData', "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Scheme_Chem_RegimensTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA",UC.ParentObject.AV28BR_Scheme_Chem_RegimensTitleFilterData); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addEventHandler("OnOptionClicked", this.e166j2_client);
   this.setUserControl(DDO_BR_SCHEME_CHEM_REGIMENSContainer);
   this.DDO_BR_MEDICATION_RXNAMEContainer = gx.uc.getNew(this, 57, 50, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXNAMEContainer", "Ddo_br_medication_rxname", "DDO_BR_MEDICATION_RXNAME");
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
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListProc", "Datalistproc", "BR_Scheme_MedicationWWGetFilterData", "str");
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
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV32BR_Medication_RXNameTitleFilterData', "vBR_MEDICATION_RXNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32BR_Medication_RXNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXNAMETITLEFILTERDATA",UC.ParentObject.AV32BR_Medication_RXNameTitleFilterData); });
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXNAMEContainer.addEventHandler("OnOptionClicked", this.e176j2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXNAMEContainer);
   this.DDO_BR_MEDICATION_RXDOSEContainer = gx.uc.getNew(this, 59, 50, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXDOSEContainer", "Ddo_br_medication_rxdose", "DDO_BR_MEDICATION_RXDOSE");
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
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV36BR_Medication_RXDoseTitleFilterData', "vBR_MEDICATION_RXDOSETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36BR_Medication_RXDoseTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXDOSETITLEFILTERDATA",UC.ParentObject.AV36BR_Medication_RXDoseTitleFilterData); });
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXDOSEContainer.addEventHandler("OnOptionClicked", this.e186j2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXDOSEContainer);
   this.DDO_BR_MEDICATION_RXUNITContainer = gx.uc.getNew(this, 61, 50, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXUNITContainer", "Ddo_br_medication_rxunit", "DDO_BR_MEDICATION_RXUNIT");
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
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListProc", "Datalistproc", "BR_Scheme_MedicationWWGetFilterData", "str");
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
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV44DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV44DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV40BR_Medication_RXUnitTitleFilterData', "vBR_MEDICATION_RXUNITTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40BR_Medication_RXUnitTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXUNITTITLEFILTERDATA",UC.ParentObject.AV40BR_Medication_RXUnitTitleFilterData); });
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXUNITContainer.addEventHandler("OnOptionClicked", this.e196j2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXUNITContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 63, 50, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[17]={ id: 17, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"BTNINSERT",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV49Display",gxold:"OV49Display",gxvar:"AV49Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV49Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV49Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV49Display,gx.O.AV73Display_GXI)},c2v:function(){gx.O.AV73Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV49Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV73Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV50Update",gxold:"OV50Update",gxvar:"AV50Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV50Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV50Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV50Update,gx.O.AV74Update_GXI)},c2v:function(){gx.O.AV74Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV50Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV74Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV52Delete",gxold:"OV52Delete",gxvar:"AV52Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV52Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV52Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV52Delete,gx.O.AV75Delete_GXI)},c2v:function(){gx.O.AV75Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV52Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV75Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_MEDICATIONID",gxz:"Z332BR_Scheme_MedicationID",gxold:"O332BR_Scheme_MedicationID",gxvar:"A332BR_Scheme_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z332BR_Scheme_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_MEDICATIONID",row || gx.fn.currentGridRowImpl(31),gx.O.A332BR_Scheme_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_SCHEME_MEDICATIONID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:this.Valid_Br_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z327BR_SchemeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEMEID",row || gx.fn.currentGridRowImpl(31),gx.O.A327BR_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_SCHEMEID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(31),gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z328BR_Scheme_Chem_Regimens=Value},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(31),gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(31),gx.O.A121BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(31),gx.O.A124BR_Medication_RXDose,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A124BR_Medication_RXDose=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(31),',','.')},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A125BR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z125BR_Medication_RXUnit=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(31),gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A125BR_Medication_RXUnit=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_SchemeIDTitleControlIdToReplace",gxold:"OV23ddo_BR_SchemeIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_SchemeIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_SchemeIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_SchemeIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_SchemeIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_SchemeIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_MedicationIDTitleControlIdToReplace",gxold:"OV27ddo_BR_MedicationIDTitleControlIdToReplace",gxvar:"AV27ddo_BR_MedicationIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_MedicationIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_MedicationIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_MedicationIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_MedicationIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxold:"OV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxvar:"AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_BR_Medication_RXNameTitleControlIdToReplace",gxold:"OV35ddo_BR_Medication_RXNameTitleControlIdToReplace",gxvar:"AV35ddo_BR_Medication_RXNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gx.O.AV35ddo_BR_Medication_RXNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_BR_Medication_RXNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxold:"OV39ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxvar:"AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gx.O.AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gxz:"ZV43ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxold:"OV43ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxvar:"AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gx.O.AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_MEDICATIONID",gxz:"ZV17TFBR_Scheme_MedicationID",gxold:"OV17TFBR_Scheme_MedicationID",gxvar:"AV17TFBR_Scheme_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Scheme_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Scheme_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_MEDICATIONID",gx.O.AV17TFBR_Scheme_MedicationID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Scheme_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_SCHEME_MEDICATIONID",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_MEDICATIONID_TO",gxz:"ZV18TFBR_Scheme_MedicationID_To",gxold:"OV18TFBR_Scheme_MedicationID_To",gxvar:"AV18TFBR_Scheme_MedicationID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Scheme_MedicationID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Scheme_MedicationID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_MEDICATIONID_TO",gx.O.AV18TFBR_Scheme_MedicationID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Scheme_MedicationID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_SCHEME_MEDICATIONID_TO",',')},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEMEID",gxz:"ZV21TFBR_SchemeID",gxold:"OV21TFBR_SchemeID",gxvar:"AV21TFBR_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEMEID",gx.O.AV21TFBR_SchemeID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_SCHEMEID",',')},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEMEID_TO",gxz:"ZV22TFBR_SchemeID_To",gxold:"OV22TFBR_SchemeID_To",gxvar:"AV22TFBR_SchemeID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_SchemeID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_SchemeID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEMEID_TO",gx.O.AV22TFBR_SchemeID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_SchemeID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_SCHEMEID_TO",',')},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATIONID",gxz:"ZV25TFBR_MedicationID",gxold:"OV25TFBR_MedicationID",gxvar:"AV25TFBR_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATIONID",gx.O.AV25TFBR_MedicationID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATIONID",',')},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATIONID_TO",gxz:"ZV26TFBR_MedicationID_To",gxold:"OV26TFBR_MedicationID_To",gxvar:"AV26TFBR_MedicationID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_MedicationID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_MedicationID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATIONID_TO",gx.O.AV26TFBR_MedicationID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_MedicationID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATIONID_TO",',')},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_REGIMENS",gxz:"ZV29TFBR_Scheme_Chem_Regimens",gxold:"OV29TFBR_Scheme_Chem_Regimens",gxvar:"AV29TFBR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Scheme_Chem_Regimens=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_REGIMENS",gx.O.AV29TFBR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Scheme_Chem_Regimens=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_REGIMENS")},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_REGIMENS_SEL",gxz:"ZV30TFBR_Scheme_Chem_Regimens_Sel",gxold:"OV30TFBR_Scheme_Chem_Regimens_Sel",gxvar:"AV30TFBR_Scheme_Chem_Regimens_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_Scheme_Chem_Regimens_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_Scheme_Chem_Regimens_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_REGIMENS_SEL",gx.O.AV30TFBR_Scheme_Chem_Regimens_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_Scheme_Chem_Regimens_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_REGIMENS_SEL")},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXNAME",gxz:"ZV33TFBR_Medication_RXName",gxold:"OV33TFBR_Medication_RXName",gxvar:"AV33TFBR_Medication_RXName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33TFBR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33TFBR_Medication_RXName=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXNAME",gx.O.AV33TFBR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33TFBR_Medication_RXName=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXNAME")},nac:gx.falseFn};
   GXValidFnc[75]={ id:75 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXNAME_SEL",gxz:"ZV34TFBR_Medication_RXName_Sel",gxold:"OV34TFBR_Medication_RXName_Sel",gxvar:"AV34TFBR_Medication_RXName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34TFBR_Medication_RXName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34TFBR_Medication_RXName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXNAME_SEL",gx.O.AV34TFBR_Medication_RXName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34TFBR_Medication_RXName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXNAME_SEL")},nac:gx.falseFn};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXDOSE",gxz:"ZV37TFBR_Medication_RXDose",gxold:"OV37TFBR_Medication_RXDose",gxvar:"AV37TFBR_Medication_RXDose",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37TFBR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV37TFBR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_RXDOSE",gx.O.AV37TFBR_Medication_RXDose,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV37TFBR_Medication_RXDose=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_RXDOSE",',','.')},nac:gx.falseFn};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXDOSE_TO",gxz:"ZV38TFBR_Medication_RXDose_To",gxold:"OV38TFBR_Medication_RXDose_To",gxvar:"AV38TFBR_Medication_RXDose_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38TFBR_Medication_RXDose_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV38TFBR_Medication_RXDose_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_RXDOSE_TO",gx.O.AV38TFBR_Medication_RXDose_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV38TFBR_Medication_RXDose_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_RXDOSE_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[78]={ id:78 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXUNIT",gxz:"ZV41TFBR_Medication_RXUnit",gxold:"OV41TFBR_Medication_RXUnit",gxvar:"AV41TFBR_Medication_RXUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41TFBR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41TFBR_Medication_RXUnit=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXUNIT",gx.O.AV41TFBR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41TFBR_Medication_RXUnit=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXUNIT")},nac:gx.falseFn};
   GXValidFnc[79]={ id:79 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXUNIT_SEL",gxz:"ZV42TFBR_Medication_RXUnit_Sel",gxold:"OV42TFBR_Medication_RXUnit_Sel",gxvar:"AV42TFBR_Medication_RXUnit_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV42TFBR_Medication_RXUnit_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42TFBR_Medication_RXUnit_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXUNIT_SEL",gx.O.AV42TFBR_Medication_RXUnit_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV42TFBR_Medication_RXUnit_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXUNIT_SEL")},nac:gx.falseFn};
   this.ZV49Display = "" ;
   this.OV49Display = "" ;
   this.ZV50Update = "" ;
   this.OV50Update = "" ;
   this.ZV52Delete = "" ;
   this.OV52Delete = "" ;
   this.Z332BR_Scheme_MedicationID = 0 ;
   this.O332BR_Scheme_MedicationID = 0 ;
   this.Z327BR_SchemeID = 0 ;
   this.O327BR_SchemeID = 0 ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.Z328BR_Scheme_Chem_Regimens = "" ;
   this.O328BR_Scheme_Chem_Regimens = "" ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.Z124BR_Medication_RXDose = 0 ;
   this.O124BR_Medication_RXDose = 0 ;
   this.Z125BR_Medication_RXUnit = "" ;
   this.O125BR_Medication_RXUnit = "" ;
   this.AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.ZV35ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.OV35ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.ZV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.OV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.ZV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.OV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Scheme_MedicationID = 0 ;
   this.ZV17TFBR_Scheme_MedicationID = 0 ;
   this.OV17TFBR_Scheme_MedicationID = 0 ;
   this.AV18TFBR_Scheme_MedicationID_To = 0 ;
   this.ZV18TFBR_Scheme_MedicationID_To = 0 ;
   this.OV18TFBR_Scheme_MedicationID_To = 0 ;
   this.AV21TFBR_SchemeID = 0 ;
   this.ZV21TFBR_SchemeID = 0 ;
   this.OV21TFBR_SchemeID = 0 ;
   this.AV22TFBR_SchemeID_To = 0 ;
   this.ZV22TFBR_SchemeID_To = 0 ;
   this.OV22TFBR_SchemeID_To = 0 ;
   this.AV25TFBR_MedicationID = 0 ;
   this.ZV25TFBR_MedicationID = 0 ;
   this.OV25TFBR_MedicationID = 0 ;
   this.AV26TFBR_MedicationID_To = 0 ;
   this.ZV26TFBR_MedicationID_To = 0 ;
   this.OV26TFBR_MedicationID_To = 0 ;
   this.AV29TFBR_Scheme_Chem_Regimens = "" ;
   this.ZV29TFBR_Scheme_Chem_Regimens = "" ;
   this.OV29TFBR_Scheme_Chem_Regimens = "" ;
   this.AV30TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.ZV30TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.OV30TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.AV33TFBR_Medication_RXName = "" ;
   this.ZV33TFBR_Medication_RXName = "" ;
   this.OV33TFBR_Medication_RXName = "" ;
   this.AV34TFBR_Medication_RXName_Sel = "" ;
   this.ZV34TFBR_Medication_RXName_Sel = "" ;
   this.OV34TFBR_Medication_RXName_Sel = "" ;
   this.AV37TFBR_Medication_RXDose = 0 ;
   this.ZV37TFBR_Medication_RXDose = 0 ;
   this.OV37TFBR_Medication_RXDose = 0 ;
   this.AV38TFBR_Medication_RXDose_To = 0 ;
   this.ZV38TFBR_Medication_RXDose_To = 0 ;
   this.OV38TFBR_Medication_RXDose_To = 0 ;
   this.AV41TFBR_Medication_RXUnit = "" ;
   this.ZV41TFBR_Medication_RXUnit = "" ;
   this.OV41TFBR_Medication_RXUnit = "" ;
   this.AV42TFBR_Medication_RXUnit_Sel = "" ;
   this.ZV42TFBR_Medication_RXUnit_Sel = "" ;
   this.OV42TFBR_Medication_RXUnit_Sel = "" ;
   this.AV46GridCurrentPage = 0 ;
   this.AV44DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Scheme_MedicationID = 0 ;
   this.AV18TFBR_Scheme_MedicationID_To = 0 ;
   this.AV21TFBR_SchemeID = 0 ;
   this.AV22TFBR_SchemeID_To = 0 ;
   this.AV25TFBR_MedicationID = 0 ;
   this.AV26TFBR_MedicationID_To = 0 ;
   this.AV29TFBR_Scheme_Chem_Regimens = "" ;
   this.AV30TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.AV33TFBR_Medication_RXName = "" ;
   this.AV34TFBR_Medication_RXName_Sel = "" ;
   this.AV37TFBR_Medication_RXDose = 0 ;
   this.AV38TFBR_Medication_RXDose_To = 0 ;
   this.AV41TFBR_Medication_RXUnit = "" ;
   this.AV42TFBR_Medication_RXUnit_Sel = "" ;
   this.AV49Display = "" ;
   this.AV50Update = "" ;
   this.AV52Delete = "" ;
   this.A332BR_Scheme_MedicationID = 0 ;
   this.A327BR_SchemeID = 0 ;
   this.A119BR_MedicationID = 0 ;
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.A121BR_Medication_RXName = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.AV76Pgmname = "" ;
   this.AV56IsAuthorized_BR_Scheme_MedicationID = false ;
   this.AV54IsAuthorized_BR_Scheme_Chem_Regimens = false ;
   this.Events = {"e116j2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e126j2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e136j2_client": ["DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED", true] ,"e146j2_client": ["DDO_BR_SCHEMEID.ONOPTIONCLICKED", true] ,"e156j2_client": ["DDO_BR_MEDICATIONID.ONOPTIONCLICKED", true] ,"e166j2_client": ["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", true] ,"e176j2_client": ["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", true] ,"e186j2_client": ["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", true] ,"e196j2_client": ["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", true] ,"e206j2_client": ["'DOINSERT'", true] ,"e246j2_client": ["ENTER", true] ,"e256j2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true}],[{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_MEDICATIONID","Visible")',ctrl:'vTFBR_SCHEME_MEDICATIONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_MEDICATIONID_TO","Visible")',ctrl:'vTFBR_SCHEME_MEDICATIONID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEMEID","Visible")',ctrl:'vTFBR_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEMEID_TO","Visible")',ctrl:'vTFBR_SCHEMEID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATIONID","Visible")',ctrl:'vTFBR_MEDICATIONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATIONID_TO","Visible")',ctrl:'vTFBR_MEDICATIONID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_REGIMENS","Visible")',ctrl:'vTFBR_SCHEME_CHEM_REGIMENS',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_REGIMENS_SEL","Visible")',ctrl:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXNAME","Visible")',ctrl:'vTFBR_MEDICATION_RXNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXNAME_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXNAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXDOSE","Visible")',ctrl:'vTFBR_MEDICATION_RXDOSE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXDOSE_TO","Visible")',ctrl:'vTFBR_MEDICATION_RXDOSE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXUNIT","Visible")',ctrl:'vTFBR_MEDICATION_RXUNIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXUNIT_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXUNIT_SEL',prop:'Visible'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEMEIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEMEID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATIONIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATIONID',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'TitleControlIdToReplace'},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'TitleControlIdToReplace'},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'TitleControlIdToReplace'},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV44DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_set'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_set'},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredTextTo_set'},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_set'},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_set'},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SelectedValue_set',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_set'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_set'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredTextTo_set'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredText_set',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredText_set'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'FilteredText_set'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_SCHEMEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_SCHEMEIDContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredText_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATIONID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_MEDICATIONIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SelectedValue_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV49Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV50Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV52Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Link")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Link")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV76Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV56IsAuthorized_BR_Scheme_MedicationID", "vISAUTHORIZED_BR_SCHEME_MEDICATIONID", 0, "boolean", 4, 0);
   this.setVCMap("AV54IsAuthorized_BR_Scheme_Chem_Regimens", "vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", 0, "boolean", 4, 0);
   this.setVCMap("AV76Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV56IsAuthorized_BR_Scheme_MedicationID", "vISAUTHORIZED_BR_SCHEME_MEDICATIONID", 0, "boolean", 4, 0);
   this.setVCMap("AV54IsAuthorized_BR_Scheme_Chem_Regimens", "vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", 0, "boolean", 4, 0);
   this.setVCMap("AV76Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV56IsAuthorized_BR_Scheme_MedicationID", "vISAUTHORIZED_BR_SCHEME_MEDICATIONID", 0, "boolean", 4, 0);
   this.setVCMap("AV54IsAuthorized_BR_Scheme_Chem_Regimens", "vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[68]);
   GridContainer.addRefreshingVar(this.GXValidFnc[69]);
   GridContainer.addRefreshingVar(this.GXValidFnc[70]);
   GridContainer.addRefreshingVar(this.GXValidFnc[71]);
   GridContainer.addRefreshingVar(this.GXValidFnc[72]);
   GridContainer.addRefreshingVar(this.GXValidFnc[73]);
   GridContainer.addRefreshingVar(this.GXValidFnc[74]);
   GridContainer.addRefreshingVar(this.GXValidFnc[75]);
   GridContainer.addRefreshingVar(this.GXValidFnc[76]);
   GridContainer.addRefreshingVar(this.GXValidFnc[77]);
   GridContainer.addRefreshingVar(this.GXValidFnc[78]);
   GridContainer.addRefreshingVar(this.GXValidFnc[79]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar({rfrVar:"AV76Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV56IsAuthorized_BR_Scheme_MedicationID"});
   GridContainer.addRefreshingVar({rfrVar:"AV54IsAuthorized_BR_Scheme_Chem_Regimens"});
   this.Initialize( );
});
gx.createParentObj(br_scheme_medicationww);
