/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:46:43.83
*/
gx.evt.autoSkip = false;
gx.define('xt_configww', false, function () {
   this.ServerClass =  "xt_configww" ;
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
      this.AV56Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV56Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_XT_CONFIGIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_XT_CONFIGKEYContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_XT_CONFIGVALUE1Container.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_XT_CONFIGVALUE2Container.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_XT_CONFIGIDContainer.SortedStatus =  ""  ;
      this.DDO_XT_CONFIGKEYContainer.SortedStatus =  ""  ;
      this.DDO_XT_CONFIGVALUE1Container.SortedStatus =  ""  ;
      this.DDO_XT_CONFIGVALUE2Container.SortedStatus =  ""  ;
   };
   this.e116x2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e126x2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e136x2_client=function()
   {
      return this.executeServerEvent("DDO_XT_CONFIGID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e146x2_client=function()
   {
      return this.executeServerEvent("DDO_XT_CONFIGKEY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e156x2_client=function()
   {
      return this.executeServerEvent("DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e166x2_client=function()
   {
      return this.executeServerEvent("DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e176x2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e216x2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e226x2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,40,41,42,44,46,48,50,52,53,54,55,56,57,58,59,60,61];
   this.GXLastCtrlId =61;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"xt_configww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",30,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",31,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(195,32,"XT_CONFIGID","","","XT_ConfigID","int",0,"px",18,18,"right",null,[],195,"XT_ConfigID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(196,33,"XT_CONFIGKEY","","","XT_ConfigKey","svchar",0,"px",40,40,"left",null,[],196,"XT_ConfigKey",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(197,34,"XT_CONFIGVALUE1","","","XT_ConfigValue1","svchar",0,"px",200,80,"left",null,[],197,"XT_ConfigValue1",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(198,35,"XT_CONFIGVALUE2","","","XT_ConfigValue2","svchar",0,"px",200,80,"left",null,[],198,"XT_ConfigValue2",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 39, 29, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV34GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV34GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV36GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV36GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV35GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV35GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV35GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e116x2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e126x2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_XT_CONFIGIDContainer = gx.uc.getNew(this, 43, 29, "BootstrapDropDownOptions", "DDO_XT_CONFIGIDContainer", "Ddo_xt_configid", "DDO_XT_CONFIGID");
   var DDO_XT_CONFIGIDContainer = this.DDO_XT_CONFIGIDContainer;
   DDO_XT_CONFIGIDContainer.setProp("Class", "Class", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_CONFIGIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_XT_CONFIGIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_CONFIGIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_CONFIGIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_CONFIGIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_CONFIGIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_CONFIGIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_CONFIGIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_CONFIGIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_CONFIGIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_CONFIGIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_XT_CONFIGIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_XT_CONFIGIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_XT_CONFIGIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_XT_CONFIGIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_XT_CONFIGIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_XT_CONFIGIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_CONFIGIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_CONFIGIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_CONFIGIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_XT_CONFIGIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_XT_CONFIGIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_XT_CONFIGIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_XT_CONFIGIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_CONFIGIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_CONFIGIDContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_CONFIGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_XT_CONFIGIDContainer.addV2CFunction('AV16XT_ConfigIDTitleFilterData', "vXT_CONFIGIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_CONFIGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16XT_ConfigIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_CONFIGIDTITLEFILTERDATA",UC.ParentObject.AV16XT_ConfigIDTitleFilterData); });
   DDO_XT_CONFIGIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_XT_CONFIGIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_CONFIGIDContainer.addEventHandler("OnOptionClicked", this.e136x2_client);
   this.setUserControl(DDO_XT_CONFIGIDContainer);
   this.DDO_XT_CONFIGKEYContainer = gx.uc.getNew(this, 45, 44, "BootstrapDropDownOptions", "DDO_XT_CONFIGKEYContainer", "Ddo_xt_configkey", "DDO_XT_CONFIGKEY");
   var DDO_XT_CONFIGKEYContainer = this.DDO_XT_CONFIGKEYContainer;
   DDO_XT_CONFIGKEYContainer.setProp("Class", "Class", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_CONFIGKEYContainer.setProp("Icon", "Icon", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("Caption", "Caption", "", "str");
   DDO_XT_CONFIGKEYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_CONFIGKEYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_CONFIGKEYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_CONFIGKEYContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_CONFIGKEYContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_CONFIGKEYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_CONFIGKEYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_CONFIGKEYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_CONFIGKEYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_CONFIGKEYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_XT_CONFIGKEYContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_XT_CONFIGKEYContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_XT_CONFIGKEYContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_XT_CONFIGKEYContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_XT_CONFIGKEYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_XT_CONFIGKEYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("DataListProc", "Datalistproc", "XT_ConfigWWGetFilterData", "str");
   DDO_XT_CONFIGKEYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_XT_CONFIGKEYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_CONFIGKEYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_CONFIGKEYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_CONFIGKEYContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_XT_CONFIGKEYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_XT_CONFIGKEYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_XT_CONFIGKEYContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_XT_CONFIGKEYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_CONFIGKEYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_CONFIGKEYContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_CONFIGKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_XT_CONFIGKEYContainer.addV2CFunction('AV20XT_ConfigKeyTitleFilterData', "vXT_CONFIGKEYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_CONFIGKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20XT_ConfigKeyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_CONFIGKEYTITLEFILTERDATA",UC.ParentObject.AV20XT_ConfigKeyTitleFilterData); });
   DDO_XT_CONFIGKEYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_XT_CONFIGKEYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_CONFIGKEYContainer.addEventHandler("OnOptionClicked", this.e146x2_client);
   this.setUserControl(DDO_XT_CONFIGKEYContainer);
   this.DDO_XT_CONFIGVALUE1Container = gx.uc.getNew(this, 47, 44, "BootstrapDropDownOptions", "DDO_XT_CONFIGVALUE1Container", "Ddo_xt_configvalue1", "DDO_XT_CONFIGVALUE1");
   var DDO_XT_CONFIGVALUE1Container = this.DDO_XT_CONFIGVALUE1Container;
   DDO_XT_CONFIGVALUE1Container.setProp("Class", "Class", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_CONFIGVALUE1Container.setProp("Icon", "Icon", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("Caption", "Caption", "", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_CONFIGVALUE1Container.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_CONFIGVALUE1Container.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_CONFIGVALUE1Container.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_CONFIGVALUE1Container.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_CONFIGVALUE1Container.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_XT_CONFIGVALUE1Container.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_XT_CONFIGVALUE1Container.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_XT_CONFIGVALUE1Container.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_XT_CONFIGVALUE1Container.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("DataListProc", "Datalistproc", "XT_ConfigWWGetFilterData", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_XT_CONFIGVALUE1Container.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_XT_CONFIGVALUE1Container.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_CONFIGVALUE1Container.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_CONFIGVALUE1Container.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_CONFIGVALUE1Container.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_XT_CONFIGVALUE1Container.addV2CFunction('AV24XT_ConfigValue1TitleFilterData', "vXT_CONFIGVALUE1TITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_CONFIGVALUE1Container.addC2VFunction(function(UC) { UC.ParentObject.AV24XT_ConfigValue1TitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_CONFIGVALUE1TITLEFILTERDATA",UC.ParentObject.AV24XT_ConfigValue1TitleFilterData); });
   DDO_XT_CONFIGVALUE1Container.setProp("Visible", "Visible", true, "bool");
   DDO_XT_CONFIGVALUE1Container.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_CONFIGVALUE1Container.addEventHandler("OnOptionClicked", this.e156x2_client);
   this.setUserControl(DDO_XT_CONFIGVALUE1Container);
   this.DDO_XT_CONFIGVALUE2Container = gx.uc.getNew(this, 49, 44, "BootstrapDropDownOptions", "DDO_XT_CONFIGVALUE2Container", "Ddo_xt_configvalue2", "DDO_XT_CONFIGVALUE2");
   var DDO_XT_CONFIGVALUE2Container = this.DDO_XT_CONFIGVALUE2Container;
   DDO_XT_CONFIGVALUE2Container.setProp("Class", "Class", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_CONFIGVALUE2Container.setProp("Icon", "Icon", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("Caption", "Caption", "", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_CONFIGVALUE2Container.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_CONFIGVALUE2Container.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_CONFIGVALUE2Container.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_CONFIGVALUE2Container.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_CONFIGVALUE2Container.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_XT_CONFIGVALUE2Container.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_XT_CONFIGVALUE2Container.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_XT_CONFIGVALUE2Container.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_XT_CONFIGVALUE2Container.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("DataListProc", "Datalistproc", "XT_ConfigWWGetFilterData", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_XT_CONFIGVALUE2Container.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_XT_CONFIGVALUE2Container.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_CONFIGVALUE2Container.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_CONFIGVALUE2Container.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_CONFIGVALUE2Container.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_XT_CONFIGVALUE2Container.addV2CFunction('AV28XT_ConfigValue2TitleFilterData', "vXT_CONFIGVALUE2TITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_CONFIGVALUE2Container.addC2VFunction(function(UC) { UC.ParentObject.AV28XT_ConfigValue2TitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_CONFIGVALUE2TITLEFILTERDATA",UC.ParentObject.AV28XT_ConfigValue2TitleFilterData); });
   DDO_XT_CONFIGVALUE2Container.setProp("Visible", "Visible", true, "bool");
   DDO_XT_CONFIGVALUE2Container.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_CONFIGVALUE2Container.addEventHandler("OnOptionClicked", this.e166x2_client);
   this.setUserControl(DDO_XT_CONFIGVALUE2Container);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 51, 44, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[25]={ id: 25, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV37Display",gxold:"OV37Display",gxvar:"AV37Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV37Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV37Display,gx.O.AV53Display_GXI)},c2v:function(){gx.O.AV53Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV37Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV53Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV38Update",gxold:"OV38Update",gxvar:"AV38Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV38Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(28),gx.O.AV38Update,gx.O.AV54Update_GXI)},c2v:function(){gx.O.AV54Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV38Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV54Update_GXI',nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV40Delete",gxold:"OV40Delete",gxvar:"AV40Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV40Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(28),gx.O.AV40Delete,gx.O.AV55Delete_GXI)},c2v:function(){gx.O.AV55Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV40Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV55Delete_GXI',nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_CONFIGID",gxz:"Z195XT_ConfigID",gxold:"O195XT_ConfigID",gxvar:"A195XT_ConfigID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A195XT_ConfigID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z195XT_ConfigID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("XT_CONFIGID",row || gx.fn.currentGridRowImpl(28),gx.O.A195XT_ConfigID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A195XT_ConfigID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("XT_CONFIGID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_CONFIGKEY",gxz:"Z196XT_ConfigKey",gxold:"O196XT_ConfigKey",gxvar:"A196XT_ConfigKey",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A196XT_ConfigKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z196XT_ConfigKey=Value},v2c:function(row){gx.fn.setGridControlValue("XT_CONFIGKEY",row || gx.fn.currentGridRowImpl(28),gx.O.A196XT_ConfigKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A196XT_ConfigKey=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_CONFIGKEY",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"svchar",len:200,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_CONFIGVALUE1",gxz:"Z197XT_ConfigValue1",gxold:"O197XT_ConfigValue1",gxvar:"A197XT_ConfigValue1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A197XT_ConfigValue1=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z197XT_ConfigValue1=Value},v2c:function(row){gx.fn.setGridControlValue("XT_CONFIGVALUE1",row || gx.fn.currentGridRowImpl(28),gx.O.A197XT_ConfigValue1,0)},c2v:function(){if(this.val()!==undefined)gx.O.A197XT_ConfigValue1=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_CONFIGVALUE1",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"svchar",len:200,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_CONFIGVALUE2",gxz:"Z198XT_ConfigValue2",gxold:"O198XT_ConfigValue2",gxvar:"A198XT_ConfigValue2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A198XT_ConfigValue2=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z198XT_ConfigValue2=Value},v2c:function(row){gx.fn.setGridControlValue("XT_CONFIGVALUE2",row || gx.fn.currentGridRowImpl(28),gx.O.A198XT_ConfigValue2,0)},c2v:function(){if(this.val()!==undefined)gx.O.A198XT_ConfigValue2=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_CONFIGVALUE2",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_XT_ConfigIDTitleControlIdToReplace",gxold:"OV19ddo_XT_ConfigIDTitleControlIdToReplace",gxvar:"AV19ddo_XT_ConfigIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_XT_ConfigIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_XT_ConfigIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_XT_ConfigIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_XT_ConfigIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_XT_ConfigKeyTitleControlIdToReplace",gxold:"OV23ddo_XT_ConfigKeyTitleControlIdToReplace",gxvar:"AV23ddo_XT_ConfigKeyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_XT_ConfigKeyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_XT_ConfigKeyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_XT_ConfigKeyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_XT_ConfigKeyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_XT_ConfigValue1TitleControlIdToReplace",gxold:"OV27ddo_XT_ConfigValue1TitleControlIdToReplace",gxvar:"AV27ddo_XT_ConfigValue1TitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_XT_ConfigValue1TitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_XT_ConfigValue1TitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE",gx.O.AV27ddo_XT_ConfigValue1TitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_XT_ConfigValue1TitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_XT_ConfigValue2TitleControlIdToReplace",gxold:"OV31ddo_XT_ConfigValue2TitleControlIdToReplace",gxvar:"AV31ddo_XT_ConfigValue2TitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_XT_ConfigValue2TitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_XT_ConfigValue2TitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE",gx.O.AV31ddo_XT_ConfigValue2TitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_XT_ConfigValue2TitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGID",gxz:"ZV17TFXT_ConfigID",gxold:"OV17TFXT_ConfigID",gxvar:"AV17TFXT_ConfigID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFXT_ConfigID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFXT_ConfigID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGID",gx.O.AV17TFXT_ConfigID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFXT_ConfigID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFXT_CONFIGID",',')},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGID_TO",gxz:"ZV18TFXT_ConfigID_To",gxold:"OV18TFXT_ConfigID_To",gxvar:"AV18TFXT_ConfigID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFXT_ConfigID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFXT_ConfigID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGID_TO",gx.O.AV18TFXT_ConfigID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFXT_ConfigID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFXT_CONFIGID_TO",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGKEY",gxz:"ZV21TFXT_ConfigKey",gxold:"OV21TFXT_ConfigKey",gxvar:"AV21TFXT_ConfigKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFXT_ConfigKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFXT_ConfigKey=Value},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGKEY",gx.O.AV21TFXT_ConfigKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFXT_ConfigKey=this.val()},val:function(){return gx.fn.getControlValue("vTFXT_CONFIGKEY")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGKEY_SEL",gxz:"ZV22TFXT_ConfigKey_Sel",gxold:"OV22TFXT_ConfigKey_Sel",gxvar:"AV22TFXT_ConfigKey_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFXT_ConfigKey_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFXT_ConfigKey_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGKEY_SEL",gx.O.AV22TFXT_ConfigKey_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFXT_ConfigKey_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFXT_CONFIGKEY_SEL")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGVALUE1",gxz:"ZV25TFXT_ConfigValue1",gxold:"OV25TFXT_ConfigValue1",gxvar:"AV25TFXT_ConfigValue1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFXT_ConfigValue1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFXT_ConfigValue1=Value},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGVALUE1",gx.O.AV25TFXT_ConfigValue1,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFXT_ConfigValue1=this.val()},val:function(){return gx.fn.getControlValue("vTFXT_CONFIGVALUE1")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGVALUE1_SEL",gxz:"ZV26TFXT_ConfigValue1_Sel",gxold:"OV26TFXT_ConfigValue1_Sel",gxvar:"AV26TFXT_ConfigValue1_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFXT_ConfigValue1_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFXT_ConfigValue1_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGVALUE1_SEL",gx.O.AV26TFXT_ConfigValue1_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFXT_ConfigValue1_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFXT_CONFIGVALUE1_SEL")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGVALUE2",gxz:"ZV29TFXT_ConfigValue2",gxold:"OV29TFXT_ConfigValue2",gxvar:"AV29TFXT_ConfigValue2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFXT_ConfigValue2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFXT_ConfigValue2=Value},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGVALUE2",gx.O.AV29TFXT_ConfigValue2,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFXT_ConfigValue2=this.val()},val:function(){return gx.fn.getControlValue("vTFXT_CONFIGVALUE2")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFXT_CONFIGVALUE2_SEL",gxz:"ZV30TFXT_ConfigValue2_Sel",gxold:"OV30TFXT_ConfigValue2_Sel",gxvar:"AV30TFXT_ConfigValue2_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFXT_ConfigValue2_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFXT_ConfigValue2_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFXT_CONFIGVALUE2_SEL",gx.O.AV30TFXT_ConfigValue2_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFXT_ConfigValue2_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFXT_CONFIGVALUE2_SEL")},nac:gx.falseFn};
   this.ZV37Display = "" ;
   this.OV37Display = "" ;
   this.ZV38Update = "" ;
   this.OV38Update = "" ;
   this.ZV40Delete = "" ;
   this.OV40Delete = "" ;
   this.Z195XT_ConfigID = 0 ;
   this.O195XT_ConfigID = 0 ;
   this.Z196XT_ConfigKey = "" ;
   this.O196XT_ConfigKey = "" ;
   this.Z197XT_ConfigValue1 = "" ;
   this.O197XT_ConfigValue1 = "" ;
   this.Z198XT_ConfigValue2 = "" ;
   this.O198XT_ConfigValue2 = "" ;
   this.AV19ddo_XT_ConfigIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_XT_ConfigIDTitleControlIdToReplace = "" ;
   this.OV19ddo_XT_ConfigIDTitleControlIdToReplace = "" ;
   this.AV23ddo_XT_ConfigKeyTitleControlIdToReplace = "" ;
   this.ZV23ddo_XT_ConfigKeyTitleControlIdToReplace = "" ;
   this.OV23ddo_XT_ConfigKeyTitleControlIdToReplace = "" ;
   this.AV27ddo_XT_ConfigValue1TitleControlIdToReplace = "" ;
   this.ZV27ddo_XT_ConfigValue1TitleControlIdToReplace = "" ;
   this.OV27ddo_XT_ConfigValue1TitleControlIdToReplace = "" ;
   this.AV31ddo_XT_ConfigValue2TitleControlIdToReplace = "" ;
   this.ZV31ddo_XT_ConfigValue2TitleControlIdToReplace = "" ;
   this.OV31ddo_XT_ConfigValue2TitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFXT_ConfigID = 0 ;
   this.ZV17TFXT_ConfigID = 0 ;
   this.OV17TFXT_ConfigID = 0 ;
   this.AV18TFXT_ConfigID_To = 0 ;
   this.ZV18TFXT_ConfigID_To = 0 ;
   this.OV18TFXT_ConfigID_To = 0 ;
   this.AV21TFXT_ConfigKey = "" ;
   this.ZV21TFXT_ConfigKey = "" ;
   this.OV21TFXT_ConfigKey = "" ;
   this.AV22TFXT_ConfigKey_Sel = "" ;
   this.ZV22TFXT_ConfigKey_Sel = "" ;
   this.OV22TFXT_ConfigKey_Sel = "" ;
   this.AV25TFXT_ConfigValue1 = "" ;
   this.ZV25TFXT_ConfigValue1 = "" ;
   this.OV25TFXT_ConfigValue1 = "" ;
   this.AV26TFXT_ConfigValue1_Sel = "" ;
   this.ZV26TFXT_ConfigValue1_Sel = "" ;
   this.OV26TFXT_ConfigValue1_Sel = "" ;
   this.AV29TFXT_ConfigValue2 = "" ;
   this.ZV29TFXT_ConfigValue2 = "" ;
   this.OV29TFXT_ConfigValue2 = "" ;
   this.AV30TFXT_ConfigValue2_Sel = "" ;
   this.ZV30TFXT_ConfigValue2_Sel = "" ;
   this.OV30TFXT_ConfigValue2_Sel = "" ;
   this.AV34GridCurrentPage = 0 ;
   this.AV32DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_XT_ConfigIDTitleControlIdToReplace = "" ;
   this.AV23ddo_XT_ConfigKeyTitleControlIdToReplace = "" ;
   this.AV27ddo_XT_ConfigValue1TitleControlIdToReplace = "" ;
   this.AV31ddo_XT_ConfigValue2TitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFXT_ConfigID = 0 ;
   this.AV18TFXT_ConfigID_To = 0 ;
   this.AV21TFXT_ConfigKey = "" ;
   this.AV22TFXT_ConfigKey_Sel = "" ;
   this.AV25TFXT_ConfigValue1 = "" ;
   this.AV26TFXT_ConfigValue1_Sel = "" ;
   this.AV29TFXT_ConfigValue2 = "" ;
   this.AV30TFXT_ConfigValue2_Sel = "" ;
   this.AV37Display = "" ;
   this.AV38Update = "" ;
   this.AV40Delete = "" ;
   this.A195XT_ConfigID = 0 ;
   this.A196XT_ConfigKey = "" ;
   this.A197XT_ConfigValue1 = "" ;
   this.A198XT_ConfigValue2 = "" ;
   this.AV56Pgmname = "" ;
   this.AV39IsAuthorized_Update = false ;
   this.AV41IsAuthorized_Delete = false ;
   this.Events = {"e116x2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e126x2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e136x2_client": ["DDO_XT_CONFIGID.ONOPTIONCLICKED", true] ,"e146x2_client": ["DDO_XT_CONFIGKEY.ONOPTIONCLICKED", true] ,"e156x2_client": ["DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED", true] ,"e166x2_client": ["DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED", true] ,"e176x2_client": ["'DOINSERT'", true] ,"e216x2_client": ["ENTER", true] ,"e226x2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{ctrl:'XT_CONFIGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_CONFIGID","Title")',ctrl:'XT_CONFIGID',prop:'Title'},{ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGKEY","Title")',ctrl:'XT_CONFIGKEY',prop:'Title'},{ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE1","Title")',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE2","Title")',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGID","Visible")',ctrl:'vTFXT_CONFIGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGID_TO","Visible")',ctrl:'vTFXT_CONFIGID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGKEY","Visible")',ctrl:'vTFXT_CONFIGKEY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGKEY_SEL","Visible")',ctrl:'vTFXT_CONFIGKEY_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGVALUE1","Visible")',ctrl:'vTFXT_CONFIGVALUE1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGVALUE1_SEL","Visible")',ctrl:'vTFXT_CONFIGVALUE1_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGVALUE2","Visible")',ctrl:'vTFXT_CONFIGVALUE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFXT_CONFIGVALUE2_SEL","Visible")',ctrl:'vTFXT_CONFIGVALUE2_SEL',prop:'Visible'},{av:'this.DDO_XT_CONFIGIDContainer.TitleControlIdToReplace',ctrl:'DDO_XT_CONFIGID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_XT_CONFIGKEYContainer.TitleControlIdToReplace',ctrl:'DDO_XT_CONFIGKEY',prop:'TitleControlIdToReplace'},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_XT_CONFIGVALUE1Container.TitleControlIdToReplace',ctrl:'DDO_XT_CONFIGVALUE1',prop:'TitleControlIdToReplace'},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_XT_CONFIGVALUE2Container.TitleControlIdToReplace',ctrl:'DDO_XT_CONFIGVALUE2',prop:'TitleControlIdToReplace'},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV32DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'this.DDO_XT_CONFIGVALUE2Container.SelectedValue_set',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SelectedValue_set'},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'this.DDO_XT_CONFIGVALUE2Container.FilteredText_set',ctrl:'DDO_XT_CONFIGVALUE2',prop:'FilteredText_set'},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'this.DDO_XT_CONFIGVALUE1Container.SelectedValue_set',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SelectedValue_set'},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'this.DDO_XT_CONFIGVALUE1Container.FilteredText_set',ctrl:'DDO_XT_CONFIGVALUE1',prop:'FilteredText_set'},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'this.DDO_XT_CONFIGKEYContainer.SelectedValue_set',ctrl:'DDO_XT_CONFIGKEY',prop:'SelectedValue_set'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'this.DDO_XT_CONFIGKEYContainer.FilteredText_set',ctrl:'DDO_XT_CONFIGKEY',prop:'FilteredText_set'},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_XT_CONFIGIDContainer.FilteredText_set',ctrl:'DDO_XT_CONFIGID',prop:'FilteredText_set'},{av:'this.DDO_XT_CONFIGIDContainer.FilteredTextTo_set',ctrl:'DDO_XT_CONFIGID',prop:'FilteredTextTo_set'},{av:'this.DDO_XT_CONFIGIDContainer.SortedStatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGKEYContainer.SortedStatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE1Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE2Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_XT_CONFIGID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_XT_CONFIGIDContainer.ActiveEventKey',ctrl:'DDO_XT_CONFIGID',prop:'ActiveEventKey'},{av:'this.DDO_XT_CONFIGIDContainer.FilteredText_get',ctrl:'DDO_XT_CONFIGID',prop:'FilteredText_get'},{av:'this.DDO_XT_CONFIGIDContainer.FilteredTextTo_get',ctrl:'DDO_XT_CONFIGID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_CONFIGIDContainer.SortedStatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_XT_CONFIGKEYContainer.SortedStatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE1Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE2Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{ctrl:'XT_CONFIGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_CONFIGID","Title")',ctrl:'XT_CONFIGID',prop:'Title'},{ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGKEY","Title")',ctrl:'XT_CONFIGKEY',prop:'Title'},{ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE1","Title")',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE2","Title")',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_XT_CONFIGKEY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_XT_CONFIGKEYContainer.ActiveEventKey',ctrl:'DDO_XT_CONFIGKEY',prop:'ActiveEventKey'},{av:'this.DDO_XT_CONFIGKEYContainer.FilteredText_get',ctrl:'DDO_XT_CONFIGKEY',prop:'FilteredText_get'},{av:'this.DDO_XT_CONFIGKEYContainer.SelectedValue_get',ctrl:'DDO_XT_CONFIGKEY',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_CONFIGKEYContainer.SortedStatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'this.DDO_XT_CONFIGIDContainer.SortedStatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE1Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE2Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{ctrl:'XT_CONFIGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_CONFIGID","Title")',ctrl:'XT_CONFIGID',prop:'Title'},{ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGKEY","Title")',ctrl:'XT_CONFIGKEY',prop:'Title'},{ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE1","Title")',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE2","Title")',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_XT_CONFIGVALUE1Container.ActiveEventKey',ctrl:'DDO_XT_CONFIGVALUE1',prop:'ActiveEventKey'},{av:'this.DDO_XT_CONFIGVALUE1Container.FilteredText_get',ctrl:'DDO_XT_CONFIGVALUE1',prop:'FilteredText_get'},{av:'this.DDO_XT_CONFIGVALUE1Container.SelectedValue_get',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_CONFIGVALUE1Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'this.DDO_XT_CONFIGIDContainer.SortedStatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGKEYContainer.SortedStatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE2Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{ctrl:'XT_CONFIGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_CONFIGID","Title")',ctrl:'XT_CONFIGID',prop:'Title'},{ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGKEY","Title")',ctrl:'XT_CONFIGKEY',prop:'Title'},{ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE1","Title")',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE2","Title")',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_XT_CONFIGVALUE2Container.ActiveEventKey',ctrl:'DDO_XT_CONFIGVALUE2',prop:'ActiveEventKey'},{av:'this.DDO_XT_CONFIGVALUE2Container.FilteredText_get',ctrl:'DDO_XT_CONFIGVALUE2',prop:'FilteredText_get'},{av:'this.DDO_XT_CONFIGVALUE2Container.SelectedValue_get',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_CONFIGVALUE2Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'this.DDO_XT_CONFIGIDContainer.SortedStatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGKEYContainer.SortedStatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'this.DDO_XT_CONFIGVALUE1Container.SortedStatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{ctrl:'XT_CONFIGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_CONFIGID","Title")',ctrl:'XT_CONFIGID',prop:'Title'},{ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGKEY","Title")',ctrl:'XT_CONFIGKEY',prop:'Title'},{ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE1","Title")',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_CONFIGVALUE2","Title")',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A195XT_ConfigID',fld:'XT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV38Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("XT_CONFIGKEY","Link")',ctrl:'XT_CONFIGKEY',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A195XT_ConfigID',fld:'XT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV56Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV56Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV56Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar({rfrVar:"AV56Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV39IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV41IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(xt_configww);
