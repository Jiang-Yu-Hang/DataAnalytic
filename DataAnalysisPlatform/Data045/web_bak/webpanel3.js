/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:48:22.38
*/
gx.evt.autoSkip = false;
gx.define('webpanel3', false, function () {
   this.ServerClass =  "webpanel3" ;
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
      this.AV49Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV49Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Validv_Br_encounter_status=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vBR_ENCOUNTER_STATUS");
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
         this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 7 )
      {
         this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 8 )
      {
         this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus =  ""  ;
   };
   this.e11a82_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12a82_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e19a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e20a82_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e24a82_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e25a82_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,44,45,46,48,50,52,54,56,58,60,62,64,65,66,67];
   this.GXLastCtrlId =67;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"webpanel3",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(19,32,"BR_ENCOUNTERID","","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(84,33,"BR_ENCOUNTER_DEPARTMENT","","","BR_Encounter_Department","svchar",0,"px",100,80,"left",null,[],84,"BR_Encounter_Department",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(90,34,"BR_ENCOUNTER_ENCTYPE","","","BR_Encounter_ENCType","svchar",0,"px",100,80,"left",null,[],90,"BR_Encounter_ENCType",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(91,35,"BR_ENCOUNTER_ADMITDATE","","","BR_Encounter_AdmitDate","date",0,"px",10,10,"right",null,[],91,"BR_Encounter_AdmitDate",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(172,36,"BR_ENCOUNTER_STATUS","","BR_Encounter_Status","int",null,0,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(192,37,"BR_ENCOUNTER_ISRANDAPPROVE","","","BR_Encounter_IsRandApprove","boolean","true","false",null,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(193,38,"BR_ENCOUNTER_ISRANDRECHECK","","","BR_Encounter_IsRandRecheck","boolean","true","false",null,true,false,0,"px","WWColumn");
   GridContainer.addCheckBox(202,39,"BR_ENCOUNTER_ISUPDATE","","","BR_Encounter_IsUpdate","boolean","true","false",null,true,false,0,"px","WWColumn");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 43, 22, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV27GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV27GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV29GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV29GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV29GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV28GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV28GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11a82_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12a82_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_ENCOUNTERIDContainer = gx.uc.getNew(this, 47, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERIDContainer", "Ddo_br_encounterid", "DDO_BR_ENCOUNTERID");
   var DDO_BR_ENCOUNTERIDContainer = this.DDO_BR_ENCOUNTERIDContainer;
   DDO_BR_ENCOUNTERIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV17BR_EncounterIDTitleFilterData', "vBR_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17BR_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV17BR_EncounterIDTitleFilterData); });
   DDO_BR_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e13a82_client);
   this.setUserControl(DDO_BR_ENCOUNTERIDContainer);
   this.DDO_BR_ENCOUNTER_DEPARTMENTContainer = gx.uc.getNew(this, 49, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_DEPARTMENTContainer", "Ddo_br_encounter_department", "DDO_BR_ENCOUNTER_DEPARTMENT");
   var DDO_BR_ENCOUNTER_DEPARTMENTContainer = this.DDO_BR_ENCOUNTER_DEPARTMENTContainer;
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addV2CFunction('AV32BR_Encounter_DepartmentTitleFilterData', "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32BR_Encounter_DepartmentTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA",UC.ParentObject.AV32BR_Encounter_DepartmentTitleFilterData); });
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addEventHandler("OnOptionClicked", this.e14a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_DEPARTMENTContainer);
   this.DDO_BR_ENCOUNTER_ENCTYPEContainer = gx.uc.getNew(this, 51, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ENCTYPEContainer", "Ddo_br_encounter_enctype", "DDO_BR_ENCOUNTER_ENCTYPE");
   var DDO_BR_ENCOUNTER_ENCTYPEContainer = this.DDO_BR_ENCOUNTER_ENCTYPEContainer;
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addV2CFunction('AV34BR_Encounter_ENCTypeTitleFilterData', "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34BR_Encounter_ENCTypeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA",UC.ParentObject.AV34BR_Encounter_ENCTypeTitleFilterData); });
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addEventHandler("OnOptionClicked", this.e15a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ENCTYPEContainer);
   this.DDO_BR_ENCOUNTER_ADMITDATEContainer = gx.uc.getNew(this, 53, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ADMITDATEContainer", "Ddo_br_encounter_admitdate", "DDO_BR_ENCOUNTER_ADMITDATE");
   var DDO_BR_ENCOUNTER_ADMITDATEContainer = this.DDO_BR_ENCOUNTER_ADMITDATEContainer;
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addV2CFunction('AV36BR_Encounter_AdmitDateTitleFilterData', "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36BR_Encounter_AdmitDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA",UC.ParentObject.AV36BR_Encounter_AdmitDateTitleFilterData); });
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addEventHandler("OnOptionClicked", this.e16a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ADMITDATEContainer);
   this.DDO_BR_ENCOUNTER_STATUSContainer = gx.uc.getNew(this, 55, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_STATUSContainer", "Ddo_br_encounter_status", "DDO_BR_ENCOUNTER_STATUS");
   var DDO_BR_ENCOUNTER_STATUSContainer = this.DDO_BR_ENCOUNTER_STATUSContainer;
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_STATUSContainer.addV2CFunction('AV21BR_Encounter_StatusTitleFilterData', "vBR_ENCOUNTER_STATUSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21BR_Encounter_StatusTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_STATUSTITLEFILTERDATA",UC.ParentObject.AV21BR_Encounter_StatusTitleFilterData); });
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_STATUSContainer.addEventHandler("OnOptionClicked", this.e17a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_STATUSContainer);
   this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer = gx.uc.getNew(this, 57, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer", "Ddo_br_encounter_israndapprove", "DDO_BR_ENCOUNTER_ISRANDAPPROVE");
   var DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer = this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer;
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addV2CFunction('AV38BR_Encounter_IsRandApproveTitleFilterData', "vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38BR_Encounter_IsRandApproveTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA",UC.ParentObject.AV38BR_Encounter_IsRandApproveTitleFilterData); });
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addEventHandler("OnOptionClicked", this.e18a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer);
   this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer = gx.uc.getNew(this, 59, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ISRANDRECHECKContainer", "Ddo_br_encounter_israndrecheck", "DDO_BR_ENCOUNTER_ISRANDRECHECK");
   var DDO_BR_ENCOUNTER_ISRANDRECHECKContainer = this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer;
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addV2CFunction('AV40BR_Encounter_IsRandRecheckTitleFilterData', "vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40BR_Encounter_IsRandRecheckTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA",UC.ParentObject.AV40BR_Encounter_IsRandRecheckTitleFilterData); });
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addEventHandler("OnOptionClicked", this.e19a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ISRANDRECHECKContainer);
   this.DDO_BR_ENCOUNTER_ISUPDATEContainer = gx.uc.getNew(this, 61, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ISUPDATEContainer", "Ddo_br_encounter_isupdate", "DDO_BR_ENCOUNTER_ISUPDATE");
   var DDO_BR_ENCOUNTER_ISUPDATEContainer = this.DDO_BR_ENCOUNTER_ISUPDATEContainer;
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addV2CFunction('AV25DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV25DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addV2CFunction('AV42BR_Encounter_IsUpdateTitleFilterData', "vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42BR_Encounter_IsUpdateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA",UC.ParentObject.AV42BR_Encounter_IsUpdateTitleFilterData); });
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addEventHandler("OnOptionClicked", this.e20a82_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ISUPDATEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 63, 22, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[22]={ id:22 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Br_encounter_status,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_STATUS",gxz:"ZV15BR_Encounter_Status",gxold:"OV15BR_Encounter_Status",gxvar:"AV15BR_Encounter_Status",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV15BR_Encounter_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15BR_Encounter_Status=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vBR_ENCOUNTER_STATUS",gx.O.AV15BR_Encounter_Status)},c2v:function(){if(this.val()!==undefined)gx.O.AV15BR_Encounter_Status=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vBR_ENCOUNTER_STATUS",',')},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DEPARTMENT",gxz:"Z84BR_Encounter_Department",gxold:"O84BR_Encounter_Department",gxvar:"A84BR_Encounter_Department",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A84BR_Encounter_Department=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z84BR_Encounter_Department=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_DEPARTMENT",row || gx.fn.currentGridRowImpl(31),gx.O.A84BR_Encounter_Department,0)},c2v:function(){if(this.val()!==undefined)gx.O.A84BR_Encounter_Department=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_DEPARTMENT",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ENCTYPE",gxz:"Z90BR_Encounter_ENCType",gxold:"O90BR_Encounter_ENCType",gxvar:"A90BR_Encounter_ENCType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A90BR_Encounter_ENCType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z90BR_Encounter_ENCType=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_ENCTYPE",row || gx.fn.currentGridRowImpl(31),gx.O.A90BR_Encounter_ENCType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A90BR_Encounter_ENCType=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ENCTYPE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ADMITDATE",gxz:"Z91BR_Encounter_AdmitDate",gxold:"O91BR_Encounter_AdmitDate",gxvar:"A91BR_Encounter_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_ADMITDATE",row || gx.fn.currentGridRowImpl(31),gx.O.A91BR_Encounter_AdmitDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_ENCOUNTER_ADMITDATE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_STATUS",gxz:"Z172BR_Encounter_Status",gxold:"O172BR_Encounter_Status",gxvar:"A172BR_Encounter_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A172BR_Encounter_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z172BR_Encounter_Status=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("BR_ENCOUNTER_STATUS",row || gx.fn.currentGridRowImpl(31),gx.O.A172BR_Encounter_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A172BR_Encounter_Status=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_STATUS",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ISRANDAPPROVE",gxz:"Z192BR_Encounter_IsRandApprove",gxold:"O192BR_Encounter_IsRandApprove",gxvar:"A192BR_Encounter_IsRandApprove",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A192BR_Encounter_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z192BR_Encounter_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTER_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(31),gx.O.A192BR_Encounter_IsRandApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.A192BR_Encounter_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ISRANDRECHECK",gxz:"Z193BR_Encounter_IsRandRecheck",gxold:"O193BR_Encounter_IsRandRecheck",gxvar:"A193BR_Encounter_IsRandRecheck",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A193BR_Encounter_IsRandRecheck=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z193BR_Encounter_IsRandRecheck=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTER_ISRANDRECHECK",row || gx.fn.currentGridRowImpl(31),gx.O.A193BR_Encounter_IsRandRecheck,true)},c2v:function(){if(this.val()!==undefined)gx.O.A193BR_Encounter_IsRandRecheck=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ISRANDRECHECK",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ISUPDATE",gxz:"Z202BR_Encounter_IsUpdate",gxold:"O202BR_Encounter_IsUpdate",gxvar:"A202BR_Encounter_IsUpdate",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A202BR_Encounter_IsUpdate=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z202BR_Encounter_IsUpdate=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTER_ISUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.A202BR_Encounter_IsUpdate,true)},c2v:function(){if(this.val()!==undefined)gx.O.A202BR_Encounter_IsUpdate=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ISUPDATE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_BR_EncounterIDTitleControlIdToReplace",gxold:"OV20ddo_BR_EncounterIDTitleControlIdToReplace",gxvar:"AV20ddo_BR_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV20ddo_BR_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_BR_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace",gxold:"OV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace",gxvar:"AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE",gx.O.AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace",gxold:"OV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace",gxvar:"AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE",gx.O.AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE",gxz:"ZV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace",gxold:"OV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace",gxvar:"AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE",gx.O.AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE",gxz:"ZV24ddo_BR_Encounter_StatusTitleControlIdToReplace",gxold:"OV24ddo_BR_Encounter_StatusTitleControlIdToReplace",gxvar:"AV24ddo_BR_Encounter_StatusTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24ddo_BR_Encounter_StatusTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24ddo_BR_Encounter_StatusTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE",gx.O.AV24ddo_BR_Encounter_StatusTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24ddo_BR_Encounter_StatusTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace",gxold:"OV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace",gxvar:"AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gx.O.AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE",gxz:"ZV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace",gxold:"OV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace",gxvar:"AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE",gx.O.AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE",gxz:"ZV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace",gxold:"OV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace",gxvar:"AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE",gx.O.AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID",gxz:"ZV18TFBR_EncounterID",gxold:"OV18TFBR_EncounterID",gxvar:"AV18TFBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID",gx.O.AV18TFBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID_TO",gxz:"ZV19TFBR_EncounterID_To",gxold:"OV19TFBR_EncounterID_To",gxvar:"AV19TFBR_EncounterID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19TFBR_EncounterID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19TFBR_EncounterID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID_TO",gx.O.AV19TFBR_EncounterID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19TFBR_EncounterID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID_TO",',')},nac:gx.falseFn};
   this.AV15BR_Encounter_Status = 0 ;
   this.ZV15BR_Encounter_Status = 0 ;
   this.OV15BR_Encounter_Status = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z84BR_Encounter_Department = "" ;
   this.O84BR_Encounter_Department = "" ;
   this.Z90BR_Encounter_ENCType = "" ;
   this.O90BR_Encounter_ENCType = "" ;
   this.Z91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.O91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.Z172BR_Encounter_Status = 0 ;
   this.O172BR_Encounter_Status = 0 ;
   this.Z192BR_Encounter_IsRandApprove = false ;
   this.O192BR_Encounter_IsRandApprove = false ;
   this.Z193BR_Encounter_IsRandRecheck = false ;
   this.O193BR_Encounter_IsRandRecheck = false ;
   this.Z202BR_Encounter_IsUpdate = false ;
   this.O202BR_Encounter_IsUpdate = false ;
   this.AV20ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV20ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.OV20ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.ZV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.OV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.ZV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.OV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.ZV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.OV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.AV24ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.ZV24ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.OV24ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.ZV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.OV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.ZV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.OV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.ZV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.OV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV18TFBR_EncounterID = 0 ;
   this.ZV18TFBR_EncounterID = 0 ;
   this.OV18TFBR_EncounterID = 0 ;
   this.AV19TFBR_EncounterID_To = 0 ;
   this.ZV19TFBR_EncounterID_To = 0 ;
   this.OV19TFBR_EncounterID_To = 0 ;
   this.AV15BR_Encounter_Status = 0 ;
   this.AV27GridCurrentPage = 0 ;
   this.AV25DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV20ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.AV24ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV18TFBR_EncounterID = 0 ;
   this.AV19TFBR_EncounterID_To = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A84BR_Encounter_Department = "" ;
   this.A90BR_Encounter_ENCType = "" ;
   this.A91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.A172BR_Encounter_Status = 0 ;
   this.A192BR_Encounter_IsRandApprove = false ;
   this.A193BR_Encounter_IsRandRecheck = false ;
   this.A202BR_Encounter_IsUpdate = false ;
   this.AV49Pgmname = "" ;
   this.Events = {"e11a82_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12a82_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13a82_client": ["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e14a82_client": ["DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED", true] ,"e15a82_client": ["DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED", true] ,"e16a82_client": ["DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED", true] ,"e17a82_client": ["DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED", true] ,"e18a82_client": ["DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED", true] ,"e19a82_client": ["DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED", true] ,"e20a82_client": ["DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED", true] ,"e24a82_client": ["ENTER", true] ,"e25a82_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID","Visible")',ctrl:'vTFBR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID_TO","Visible")',ctrl:'vTFBR_ENCOUNTERID_TO',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'TitleControlIdToReplace'},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'TitleControlIdToReplace'},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'TitleControlIdToReplace'},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'TitleControlIdToReplace'},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'TitleControlIdToReplace'},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'TitleControlIdToReplace'},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'TitleControlIdToReplace'},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV25DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[]];
   this.setVCMap("AV49Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV49Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV49Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[22]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar({rfrVar:"AV49Pgmname"});
   this.Initialize( );
});
gx.createParentObj(webpanel3);
