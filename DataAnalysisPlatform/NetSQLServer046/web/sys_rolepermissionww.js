/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:40.40
*/
gx.evt.autoSkip = false;
gx.define('sys_rolepermissionww', false, function () {
   this.ServerClass =  "sys_rolepermissionww" ;
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
      this.AV51Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV51Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.s132_client=function()
   {
      this.s152_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.SortedStatus =  ""  ;
      this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SortedStatus =  ""  ;
   };
   this.e118d2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e128d2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e138d2_client=function()
   {
      return this.executeServerEvent("DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e148d2_client=function()
   {
      return this.executeServerEvent("DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e158d2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e198d2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e208d2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,30,31,32,33,34,36,37,38,39,40,41,42,43,45,46,47,49,51,53,54,55,56];
   this.GXLastCtrlId =56;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",35,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"sys_rolepermissionww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",36,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",37,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",38,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(444,39,"SYS_ROLEPERMISSIONROLEID","","","SYS_RolePermissionRoleID","guid",0,"px",36,36,"",null,[],444,"SYS_RolePermissionRoleID",true,0,false,true,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(445,40,"SYS_ROLEPERMISSIONPERMISSIONCODE","","","SYS_RolePermissionPermissionCode","svchar",0,"px",64,64,"left",null,[],445,"SYS_RolePermissionPermissionCode",true,0,false,false,"Attribute",1,"WWColumn");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 44, 26, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV25GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV25GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV27GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV27GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV26GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV26GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e118d2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e128d2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SYS_ROLEPERMISSIONROLEIDContainer = gx.uc.getNew(this, 48, 26, "BootstrapDropDownOptions", "DDO_SYS_ROLEPERMISSIONROLEIDContainer", "Ddo_sys_rolepermissionroleid", "DDO_SYS_ROLEPERMISSIONROLEID");
   var DDO_SYS_ROLEPERMISSIONROLEIDContainer = this.DDO_SYS_ROLEPERMISSIONROLEIDContainer;
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Class", "Class", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addV2CFunction('AV23DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV23DDO_TitleSettingsIcons); });
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addV2CFunction('AV17SYS_RolePermissionRoleIDTitleFilterData', "vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17SYS_RolePermissionRoleIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA",UC.ParentObject.AV17SYS_RolePermissionRoleIDTitleFilterData); });
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addEventHandler("OnOptionClicked", this.e138d2_client);
   this.setUserControl(DDO_SYS_ROLEPERMISSIONROLEIDContainer);
   this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer = gx.uc.getNew(this, 50, 26, "BootstrapDropDownOptions", "DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer", "Ddo_sys_rolepermissionpermissioncode", "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE");
   var DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer = this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer;
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Class", "Class", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListProc", "Datalistproc", "SYS_RolePermissionWWGetFilterData", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addV2CFunction('AV23DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV23DDO_TitleSettingsIcons); });
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addV2CFunction('AV19SYS_RolePermissionPermissionCodeTitleFilterData', "vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19SYS_RolePermissionPermissionCodeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA",UC.ParentObject.AV19SYS_RolePermissionPermissionCodeTitleFilterData); });
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addEventHandler("OnOptionClicked", this.e148d2_client);
   this.setUserControl(DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 52, 26, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:64,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSYS_ROLEPERMISSIONPERMISSIONCODE",gxz:"ZV34SYS_RolePermissionPermissionCode",gxold:"OV34SYS_RolePermissionPermissionCode",gxvar:"AV34SYS_RolePermissionPermissionCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34SYS_RolePermissionPermissionCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34SYS_RolePermissionPermissionCode=Value},v2c:function(){gx.fn.setControlValue("vSYS_ROLEPERMISSIONPERMISSIONCODE",gx.O.AV34SYS_RolePermissionPermissionCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34SYS_RolePermissionPermissionCode=this.val()},val:function(){return gx.fn.getControlValue("vSYS_ROLEPERMISSIONPERMISSIONCODE")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV28Display",gxold:"OV28Display",gxvar:"AV28Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV28Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(35),gx.O.AV28Display,gx.O.AV48Display_GXI)},c2v:function(){gx.O.AV48Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV28Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(35))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(35))}, gxvar_GXI:'AV48Display_GXI',nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV29Update",gxold:"OV29Update",gxvar:"AV29Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV29Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(35),gx.O.AV29Update,gx.O.AV49Update_GXI)},c2v:function(){gx.O.AV49Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV29Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(35))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(35))}, gxvar_GXI:'AV49Update_GXI',nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV31Delete",gxold:"OV31Delete",gxvar:"AV31Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV31Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(35),gx.O.AV31Delete,gx.O.AV50Delete_GXI)},c2v:function(){gx.O.AV50Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV31Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(35))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(35))}, gxvar_GXI:'AV50Delete_GXI',nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"guid",len:16,dec:0,sign:false,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_ROLEPERMISSIONROLEID",gxz:"Z444SYS_RolePermissionRoleID",gxold:"O444SYS_RolePermissionRoleID",gxvar:"A444SYS_RolePermissionRoleID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A444SYS_RolePermissionRoleID=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z444SYS_RolePermissionRoleID=Value},v2c:function(row){gx.fn.setGridControlValue("SYS_ROLEPERMISSIONROLEID",row || gx.fn.currentGridRowImpl(35),gx.O.A444SYS_RolePermissionRoleID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A444SYS_RolePermissionRoleID=this.val()},val:function(row){return gx.fn.getGridControlValue("SYS_ROLEPERMISSIONROLEID",row || gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"svchar",len:64,dec:0,sign:false,ro:1,isacc:0,grid:35,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_ROLEPERMISSIONPERMISSIONCODE",gxz:"Z445SYS_RolePermissionPermissionCode",gxold:"O445SYS_RolePermissionPermissionCode",gxvar:"A445SYS_RolePermissionPermissionCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A445SYS_RolePermissionPermissionCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z445SYS_RolePermissionPermissionCode=Value},v2c:function(row){gx.fn.setGridControlValue("SYS_ROLEPERMISSIONPERMISSIONCODE",row || gx.fn.currentGridRowImpl(35),gx.O.A445SYS_RolePermissionPermissionCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A445SYS_RolePermissionPermissionCode=this.val()},val:function(row){return gx.fn.getGridControlValue("SYS_ROLEPERMISSIONPERMISSIONCODE",row || gx.fn.currentGridRowImpl(35))},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE",gxz:"ZV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace",gxold:"OV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace",gxvar:"AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE",gx.O.AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE",gxz:"ZV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace",gxold:"OV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace",gxvar:"AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE",gx.O.AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:64,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSYS_ROLEPERMISSIONPERMISSIONCODE",gxz:"ZV20TFSYS_RolePermissionPermissionCode",gxold:"OV20TFSYS_RolePermissionPermissionCode",gxvar:"AV20TFSYS_RolePermissionPermissionCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20TFSYS_RolePermissionPermissionCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20TFSYS_RolePermissionPermissionCode=Value},v2c:function(){gx.fn.setControlValue("vTFSYS_ROLEPERMISSIONPERMISSIONCODE",gx.O.AV20TFSYS_RolePermissionPermissionCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20TFSYS_RolePermissionPermissionCode=this.val()},val:function(){return gx.fn.getControlValue("vTFSYS_ROLEPERMISSIONPERMISSIONCODE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:64,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL",gxz:"ZV21TFSYS_RolePermissionPermissionCode_Sel",gxold:"OV21TFSYS_RolePermissionPermissionCode_Sel",gxvar:"AV21TFSYS_RolePermissionPermissionCode_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFSYS_RolePermissionPermissionCode_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFSYS_RolePermissionPermissionCode_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL",gx.O.AV21TFSYS_RolePermissionPermissionCode_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFSYS_RolePermissionPermissionCode_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL")},nac:gx.falseFn};
   this.AV34SYS_RolePermissionPermissionCode = "" ;
   this.ZV34SYS_RolePermissionPermissionCode = "" ;
   this.OV34SYS_RolePermissionPermissionCode = "" ;
   this.ZV28Display = "" ;
   this.OV28Display = "" ;
   this.ZV29Update = "" ;
   this.OV29Update = "" ;
   this.ZV31Delete = "" ;
   this.OV31Delete = "" ;
   this.Z444SYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.O444SYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.Z445SYS_RolePermissionPermissionCode = "" ;
   this.O445SYS_RolePermissionPermissionCode = "" ;
   this.AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.ZV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.OV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.ZV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.OV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV20TFSYS_RolePermissionPermissionCode = "" ;
   this.ZV20TFSYS_RolePermissionPermissionCode = "" ;
   this.OV20TFSYS_RolePermissionPermissionCode = "" ;
   this.AV21TFSYS_RolePermissionPermissionCode_Sel = "" ;
   this.ZV21TFSYS_RolePermissionPermissionCode_Sel = "" ;
   this.OV21TFSYS_RolePermissionPermissionCode_Sel = "" ;
   this.AV34SYS_RolePermissionPermissionCode = "" ;
   this.AV25GridCurrentPage = 0 ;
   this.AV23DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV20TFSYS_RolePermissionPermissionCode = "" ;
   this.AV21TFSYS_RolePermissionPermissionCode_Sel = "" ;
   this.AV28Display = "" ;
   this.AV29Update = "" ;
   this.AV31Delete = "" ;
   this.A444SYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.A445SYS_RolePermissionPermissionCode = "" ;
   this.AV51Pgmname = "" ;
   this.Events = {"e118d2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e128d2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e138d2_client": ["DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED", true] ,"e148d2_client": ["DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED", true] ,"e158d2_client": ["'DOINSERT'", true] ,"e198d2_client": ["ENTER", true] ,"e208d2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV17SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV19SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONROLEID","Title")',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Title")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFSYS_ROLEPERMISSIONPERMISSIONCODE","Visible")',ctrl:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL","Visible")',ctrl:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',prop:'Visible'},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.TitleControlIdToReplace',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'TitleControlIdToReplace'},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.TitleControlIdToReplace',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'TitleControlIdToReplace'},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV23DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.FilteredText_set',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'FilteredText_set'},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SelectedValue_set',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SelectedValue_set'},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.ActiveEventKey',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'},{av:'AV17SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV19SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONROLEID","Title")',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Title")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.ActiveEventKey',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'ActiveEventKey'},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.FilteredText_get',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'FilteredText_get'},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SelectedValue_get',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'AV17SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV19SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONROLEID","Title")',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Title")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A444SYS_RolePermissionRoleID',fld:'SYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'A445SYS_RolePermissionPermissionCode',fld:'SYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}],[{av:'AV28Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV29Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV31Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Link")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A444SYS_RolePermissionRoleID',fld:'SYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'A445SYS_RolePermissionPermissionCode',fld:'SYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}],[]];
   this.setVCMap("AV51Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV51Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV51Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar({rfrVar:"AV51Pgmname"});
   this.Initialize( );
});
gx.createParentObj(sys_rolepermissionww);
