/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:12.76
*/
gx.evt.autoSkip = false;
gx.define('br_encounterupdatebr_vitalwc', true, function (CmpContext) {
   this.ServerClass =  "br_encounterupdatebr_vitalwc" ;
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
      this.AV77Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV54IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV56IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV58IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV77Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV54IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV56IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV58IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV14OrderedBy == 1 )
      {
         this.DDO_BR_VITALIDContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 2 )
      {
         this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 3 )
      {
         this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 4 )
      {
         this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_VITALIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus =  ""  ;
      this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus =  ""  ;
   };
   this.e11602_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12602_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13602_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITALID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14602_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15602_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16602_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17602_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e21602_client=function()
   {
      return this.executeServerEvent("VUPDATE.CLICK", true, arguments[0], false, false);
   };
   this.e22602_client=function()
   {
      return this.executeServerEvent("VDELETE.CLICK", true, arguments[0], false, false);
   };
   this.e23602_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e24602_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,40,41,42,44,46,48,50,51,53,54,55,56];
   this.GXLastCtrlId =56;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encounterupdatebr_vitalwc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",30,0,"px",17,"px","e21602_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",31,0,"px",17,"px","e22602_client","","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(150,32,"BR_VITALID","","","BR_VitalID","int",0,"px",18,18,"right",null,[],150,"BR_VitalID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(152,33,"BR_VITAL_MEASUREDATE","","","BR_Vital_MeasureDate","date",0,"px",10,10,"right",null,[],152,"BR_Vital_MeasureDate",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(159,34,"BR_VITAL_WEIGHT","","","BR_Vital_Weight","decimal",0,"px",15,15,"right",null,[],159,"BR_Vital_Weight",true,5,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(153,35,"BR_VITAL_TEMPERATURE","","","BR_Vital_Temperature","decimal",0,"px",15,15,"right",null,[],153,"BR_Vital_Temperature",true,5,false,false,"Attribute",1,"WWColumn");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 39, 29, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV50GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV50GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV50GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV52GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV52GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV52GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV51GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV51GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11602_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12602_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_VITALIDContainer = gx.uc.getNew(this, 43, 29, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITALIDContainer", "Ddo_br_vitalid", "DDO_BR_VITALID");
   var DDO_BR_VITALIDContainer = this.DDO_BR_VITALIDContainer;
   DDO_BR_VITALIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITALIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITALIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITALIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITALIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITALIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITALIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITALIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITALIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITALIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITALIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITALIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITALIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITALIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_VITALIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_VITALIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITALIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITALIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITALIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITALIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITALIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITALIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITALIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITALIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITALIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITALIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITALIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITALIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_VITALIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_VITALIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_VITALIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITALIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITALIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITALIDContainer.addV2CFunction('AV47DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITALIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV47DDO_TitleSettingsIcons); });
   DDO_BR_VITALIDContainer.addV2CFunction('AV59BR_VitalIDTitleFilterData', "vBR_VITALIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITALIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV59BR_VitalIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITALIDTITLEFILTERDATA",UC.ParentObject.AV59BR_VitalIDTitleFilterData); });
   DDO_BR_VITALIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITALIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITALIDContainer.addEventHandler("OnOptionClicked", this.e13602_client);
   this.setUserControl(DDO_BR_VITALIDContainer);
   this.DDO_BR_VITAL_MEASUREDATEContainer = gx.uc.getNew(this, 45, 44, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITAL_MEASUREDATEContainer", "Ddo_br_vital_measuredate", "DDO_BR_VITAL_MEASUREDATE");
   var DDO_BR_VITAL_MEASUREDATEContainer = this.DDO_BR_VITAL_MEASUREDATEContainer;
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.addV2CFunction('AV47DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITAL_MEASUREDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV47DDO_TitleSettingsIcons); });
   DDO_BR_VITAL_MEASUREDATEContainer.addV2CFunction('AV17BR_Vital_MeasureDateTitleFilterData', "vBR_VITAL_MEASUREDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITAL_MEASUREDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17BR_Vital_MeasureDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITAL_MEASUREDATETITLEFILTERDATA",UC.ParentObject.AV17BR_Vital_MeasureDateTitleFilterData); });
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITAL_MEASUREDATEContainer.addEventHandler("OnOptionClicked", this.e14602_client);
   this.setUserControl(DDO_BR_VITAL_MEASUREDATEContainer);
   this.DDO_BR_VITAL_WEIGHTContainer = gx.uc.getNew(this, 47, 44, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITAL_WEIGHTContainer", "Ddo_br_vital_weight", "DDO_BR_VITAL_WEIGHT");
   var DDO_BR_VITAL_WEIGHTContainer = this.DDO_BR_VITAL_WEIGHTContainer;
   DDO_BR_VITAL_WEIGHTContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITAL_WEIGHTContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITAL_WEIGHTContainer.addV2CFunction('AV47DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITAL_WEIGHTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV47DDO_TitleSettingsIcons); });
   DDO_BR_VITAL_WEIGHTContainer.addV2CFunction('AV23BR_Vital_WeightTitleFilterData', "vBR_VITAL_WEIGHTTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITAL_WEIGHTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23BR_Vital_WeightTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITAL_WEIGHTTITLEFILTERDATA",UC.ParentObject.AV23BR_Vital_WeightTitleFilterData); });
   DDO_BR_VITAL_WEIGHTContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITAL_WEIGHTContainer.addEventHandler("OnOptionClicked", this.e15602_client);
   this.setUserControl(DDO_BR_VITAL_WEIGHTContainer);
   this.DDO_BR_VITAL_TEMPERATUREContainer = gx.uc.getNew(this, 49, 44, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITAL_TEMPERATUREContainer", "Ddo_br_vital_temperature", "DDO_BR_VITAL_TEMPERATURE");
   var DDO_BR_VITAL_TEMPERATUREContainer = this.DDO_BR_VITAL_TEMPERATUREContainer;
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.addV2CFunction('AV47DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITAL_TEMPERATUREContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV47DDO_TitleSettingsIcons); });
   DDO_BR_VITAL_TEMPERATUREContainer.addV2CFunction('AV27BR_Vital_TemperatureTitleFilterData', "vBR_VITAL_TEMPERATURETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITAL_TEMPERATUREContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27BR_Vital_TemperatureTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITAL_TEMPERATURETITLEFILTERDATA",UC.ParentObject.AV27BR_Vital_TemperatureTitleFilterData); });
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITAL_TEMPERATUREContainer.addEventHandler("OnOptionClicked", this.e16602_client);
   this.setUserControl(DDO_BR_VITAL_TEMPERATUREContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 52, 44, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[6]={ id: 6, fld:"TABLEGRIDHEADER",grid:0};
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
   GXValidFnc[25]={ id: 25, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV53Display",gxold:"OV53Display",gxvar:"AV53Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV53Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV53Display,gx.O.AV74Display_GXI)},c2v:function(){gx.O.AV74Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV53Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV74Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV55Update",gxold:"OV55Update",gxvar:"AV55Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV55Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV55Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(28),gx.O.AV55Update,gx.O.AV75Update_GXI)},c2v:function(){gx.O.AV75Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV55Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV75Update_GXI',nac:gx.falseFn,evt:"e21602_client"};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV57Delete",gxold:"OV57Delete",gxvar:"AV57Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV57Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV57Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(28),gx.O.AV57Delete,gx.O.AV76Delete_GXI)},c2v:function(){gx.O.AV76Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV57Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV76Delete_GXI',nac:gx.falseFn,evt:"e22602_client"};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITALID",gxz:"Z150BR_VitalID",gxold:"O150BR_VitalID",gxvar:"A150BR_VitalID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A150BR_VitalID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z150BR_VitalID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_VITALID",row || gx.fn.currentGridRowImpl(28),gx.O.A150BR_VitalID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A150BR_VitalID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_VITALID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_MEASUREDATE",gxz:"Z152BR_Vital_MeasureDate",gxold:"O152BR_Vital_MeasureDate",gxvar:"A152BR_Vital_MeasureDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_VITAL_MEASUREDATE",row || gx.fn.currentGridRowImpl(28),gx.O.A152BR_Vital_MeasureDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_VITAL_MEASUREDATE",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_WEIGHT",gxz:"Z159BR_Vital_Weight",gxold:"O159BR_Vital_Weight",gxvar:"A159BR_Vital_Weight",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A159BR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z159BR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_VITAL_WEIGHT",row || gx.fn.currentGridRowImpl(28),gx.O.A159BR_Vital_Weight,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A159BR_Vital_Weight=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_VITAL_WEIGHT",row || gx.fn.currentGridRowImpl(28),',','.')},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_TEMPERATURE",gxz:"Z153BR_Vital_Temperature",gxold:"O153BR_Vital_Temperature",gxvar:"A153BR_Vital_Temperature",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A153BR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z153BR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_VITAL_TEMPERATURE",row || gx.fn.currentGridRowImpl(28),gx.O.A153BR_Vital_Temperature,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A153BR_Vital_Temperature=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_VITAL_TEMPERATURE",row || gx.fn.currentGridRowImpl(28),',','.')},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE",gxz:"ZV62ddo_BR_VitalIDTitleControlIdToReplace",gxold:"OV62ddo_BR_VitalIDTitleControlIdToReplace",gxvar:"AV62ddo_BR_VitalIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV62ddo_BR_VitalIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV62ddo_BR_VitalIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE",gx.O.AV62ddo_BR_VitalIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV62ddo_BR_VitalIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE",gxz:"ZV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace",gxold:"OV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace",gxvar:"AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE",gx.O.AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE",gxz:"ZV26ddo_BR_Vital_WeightTitleControlIdToReplace",gxold:"OV26ddo_BR_Vital_WeightTitleControlIdToReplace",gxvar:"AV26ddo_BR_Vital_WeightTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26ddo_BR_Vital_WeightTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26ddo_BR_Vital_WeightTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE",gx.O.AV26ddo_BR_Vital_WeightTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26ddo_BR_Vital_WeightTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE",gxz:"ZV30ddo_BR_Vital_TemperatureTitleControlIdToReplace",gxold:"OV30ddo_BR_Vital_TemperatureTitleControlIdToReplace",gxvar:"AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30ddo_BR_Vital_TemperatureTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE",gx.O.AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 51 , function() {
   });
   GXValidFnc[53]={ id:53 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_TEMPERATURE",gxz:"ZV28TFBR_Vital_Temperature",gxold:"OV28TFBR_Vital_Temperature",gxvar:"AV28TFBR_Vital_Temperature",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28TFBR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV28TFBR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_VITAL_TEMPERATURE",gx.O.AV28TFBR_Vital_Temperature,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV28TFBR_Vital_Temperature=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_VITAL_TEMPERATURE",',','.')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_TEMPERATURE_TO",gxz:"ZV29TFBR_Vital_Temperature_To",gxold:"OV29TFBR_Vital_Temperature_To",gxvar:"AV29TFBR_Vital_Temperature_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Vital_Temperature_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Vital_Temperature_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_VITAL_TEMPERATURE_TO",gx.O.AV29TFBR_Vital_Temperature_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Vital_Temperature_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_VITAL_TEMPERATURE_TO",',','.')},nac:gx.falseFn};
   this.ZV53Display = "" ;
   this.OV53Display = "" ;
   this.ZV55Update = "" ;
   this.OV55Update = "" ;
   this.ZV57Delete = "" ;
   this.OV57Delete = "" ;
   this.Z150BR_VitalID = 0 ;
   this.O150BR_VitalID = 0 ;
   this.Z152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.O152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.Z159BR_Vital_Weight = 0 ;
   this.O159BR_Vital_Weight = 0 ;
   this.Z153BR_Vital_Temperature = 0 ;
   this.O153BR_Vital_Temperature = 0 ;
   this.AV62ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.ZV62ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.OV62ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.ZV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.OV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.ZV26ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.OV26ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.ZV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.OV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV28TFBR_Vital_Temperature = 0 ;
   this.ZV28TFBR_Vital_Temperature = 0 ;
   this.OV28TFBR_Vital_Temperature = 0 ;
   this.AV29TFBR_Vital_Temperature_To = 0 ;
   this.ZV29TFBR_Vital_Temperature_To = 0 ;
   this.OV29TFBR_Vital_Temperature_To = 0 ;
   this.AV50GridCurrentPage = 0 ;
   this.AV47DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV62ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV28TFBR_Vital_Temperature = 0 ;
   this.AV29TFBR_Vital_Temperature_To = 0 ;
   this.AV8BR_EncounterID = 0 ;
   this.AV53Display = "" ;
   this.AV55Update = "" ;
   this.AV57Delete = "" ;
   this.A150BR_VitalID = 0 ;
   this.A152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.A159BR_Vital_Weight = 0 ;
   this.A153BR_Vital_Temperature = 0 ;
   this.AV77Pgmname = "" ;
   this.AV54IsAuthorized_Display = false ;
   this.AV56IsAuthorized_Update = false ;
   this.AV58IsAuthorized_Delete = false ;
   this.Events = {"e11602_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12602_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13602_client": ["DDO_BR_VITALID.ONOPTIONCLICKED", true] ,"e14602_client": ["DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED", true] ,"e15602_client": ["DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED", true] ,"e16602_client": ["DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED", true] ,"e17602_client": ["'DOINSERT'", true] ,"e21602_client": ["VUPDATE.CLICK", true] ,"e22602_client": ["VDELETE.CLICK", true] ,"e23602_client": ["ENTER", true] ,"e24602_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'}],[{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_TEMPERATURE","Visible")',ctrl:'vTFBR_VITAL_TEMPERATURE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_TEMPERATURE_TO","Visible")',ctrl:'vTFBR_VITAL_TEMPERATURE_TO',prop:'Visible'},{av:'this.DDO_BR_VITALIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITALID',prop:'TitleControlIdToReplace'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'TitleControlIdToReplace'},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'TitleControlIdToReplace'},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'TitleControlIdToReplace'},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV47DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredText_set',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_set'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredTextTo_set',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_VITALID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITALIDContainer.ActiveEventKey',ctrl:'DDO_BR_VITALID',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.ActiveEventKey',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.ActiveEventKey',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.ActiveEventKey',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'ActiveEventKey'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredText_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_get'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredTextTo_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV53Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV55Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV57Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["VUPDATE.CLICK"] = [[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["VDELETE.CLICK"] = [[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV77Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV54IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV56IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV58IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV77Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV54IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV56IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV58IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV77Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV54IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV56IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV58IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar({rfrVar:"AV8BR_EncounterID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar({rfrVar:"AV77Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV54IsAuthorized_Display"});
   GridContainer.addRefreshingVar({rfrVar:"AV56IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV58IsAuthorized_Delete"});
   this.Initialize( );
});
