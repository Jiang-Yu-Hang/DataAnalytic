/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:34.59
*/
gx.evt.autoSkip = false;
gx.define('sys_rolepermissionprompt', false, function () {
   this.ServerClass =  "sys_rolepermissionprompt" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV8InOutSYS_RolePermissionRoleID=gx.fn.getControlValue("vINOUTSYS_ROLEPERMISSIONROLEID") ;
      this.AV9InOutSYS_RolePermissionPermissionCode=gx.fn.getControlValue("vINOUTSYS_ROLEPERMISSIONPERMISSIONCODE") ;
   };
   this.e118f2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e128f2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e138f2_client=function()
   {
      return this.executeServerEvent("DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e148f2_client=function()
   {
      return this.executeServerEvent("DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e188f2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e198f2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,20,21,22,24,26,28,29];
   this.GXLastCtrlId =29;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"sys_rolepermissionprompt",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Select","vSELECT",13,0,"px",17,"px","e188f2_client","","","SelectAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(444,14,"SYS_ROLEPERMISSIONROLEID","","","SYS_RolePermissionRoleID","guid",0,"px",36,36,"",null,[],444,"SYS_RolePermissionRoleID",true,0,false,true,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(445,15,"SYS_ROLEPERMISSIONPERMISSIONCODE","","","SYS_RolePermissionPermissionCode","svchar",0,"px",64,64,"left",null,[],445,"SYS_RolePermissionPermissionCode",true,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 19, 13, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV19GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV19GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV21GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV21GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV20GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV20GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e118f2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e128f2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SYS_ROLEPERMISSIONROLEIDContainer = gx.uc.getNew(this, 23, 13, "BootstrapDropDownOptions", "DDO_SYS_ROLEPERMISSIONROLEIDContainer", "Ddo_sys_rolepermissionroleid", "DDO_SYS_ROLEPERMISSIONROLEID");
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
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addV2CFunction('AV17DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV17DDO_TitleSettingsIcons); });
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addV2CFunction('AV13SYS_RolePermissionRoleIDTitleFilterData', "vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV13SYS_RolePermissionRoleIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA",UC.ParentObject.AV13SYS_RolePermissionRoleIDTitleFilterData); });
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SYS_ROLEPERMISSIONROLEIDContainer.addEventHandler("OnOptionClicked", this.e138f2_client);
   this.setUserControl(DDO_SYS_ROLEPERMISSIONROLEIDContainer);
   this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer = gx.uc.getNew(this, 25, 24, "BootstrapDropDownOptions", "DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer", "Ddo_sys_rolepermissionpermissioncode", "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE");
   var DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer = this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer;
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Class", "Class", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
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
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addV2CFunction('AV17DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV17DDO_TitleSettingsIcons); });
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addV2CFunction('AV15SYS_RolePermissionPermissionCodeTitleFilterData', "vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV15SYS_RolePermissionPermissionCodeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA",UC.ParentObject.AV15SYS_RolePermissionPermissionCodeTitleFilterData); });
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.addEventHandler("OnOptionClicked", this.e148f2_client);
   this.setUserControl(DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 27, 24, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[13]={ id:13 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV22Select",gxold:"OV22Select",gxvar:"AV22Select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV22Select=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22Select=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vSELECT",row || gx.fn.currentGridRowImpl(12),gx.O.AV22Select,gx.O.AV26Select_GXI)},c2v:function(){gx.O.AV26Select_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV22Select=this.val()},val:function(row){return gx.fn.getGridControlValue("vSELECT",row || gx.fn.currentGridRowImpl(12))},val_GXI:function(row){return gx.fn.getGridControlValue("vSELECT_GXI",row || gx.fn.currentGridRowImpl(12))}, gxvar_GXI:'AV26Select_GXI',nac:gx.falseFn,evt:"e188f2_client",std:"ENTER"};
   GXValidFnc[14]={ id:14 ,lvl:2,type:"guid",len:16,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_ROLEPERMISSIONROLEID",gxz:"Z444SYS_RolePermissionRoleID",gxold:"O444SYS_RolePermissionRoleID",gxvar:"A444SYS_RolePermissionRoleID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A444SYS_RolePermissionRoleID=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z444SYS_RolePermissionRoleID=Value},v2c:function(row){gx.fn.setGridControlValue("SYS_ROLEPERMISSIONROLEID",row || gx.fn.currentGridRowImpl(12),gx.O.A444SYS_RolePermissionRoleID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A444SYS_RolePermissionRoleID=this.val()},val:function(row){return gx.fn.getGridControlValue("SYS_ROLEPERMISSIONROLEID",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[15]={ id:15 ,lvl:2,type:"svchar",len:64,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_ROLEPERMISSIONPERMISSIONCODE",gxz:"Z445SYS_RolePermissionPermissionCode",gxold:"O445SYS_RolePermissionPermissionCode",gxvar:"A445SYS_RolePermissionPermissionCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A445SYS_RolePermissionPermissionCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z445SYS_RolePermissionPermissionCode=Value},v2c:function(row){gx.fn.setGridControlValue("SYS_ROLEPERMISSIONPERMISSIONCODE",row || gx.fn.currentGridRowImpl(12),gx.O.A445SYS_RolePermissionPermissionCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A445SYS_RolePermissionPermissionCode=this.val()},val:function(row){return gx.fn.getGridControlValue("SYS_ROLEPERMISSIONPERMISSIONCODE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[24]={ id:24 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE",gxz:"ZV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace",gxold:"OV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace",gxvar:"AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE",gx.O.AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE",gxz:"ZV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace",gxold:"OV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace",gxvar:"AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE",gx.O.AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV11OrderedBy",gxold:"OV11OrderedBy",gxvar:"AV11OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV11OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV11OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV11OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV11OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV12OrderedDsc",gxold:"OV12OrderedDsc",gxvar:"AV12OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV12OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV12OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.ZV22Select = "" ;
   this.OV22Select = "" ;
   this.Z444SYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.O444SYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.Z445SYS_RolePermissionPermissionCode = "" ;
   this.O445SYS_RolePermissionPermissionCode = "" ;
   this.AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.ZV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.OV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.ZV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.OV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.AV11OrderedBy = 0 ;
   this.ZV11OrderedBy = 0 ;
   this.OV11OrderedBy = 0 ;
   this.AV12OrderedDsc = false ;
   this.ZV12OrderedDsc = false ;
   this.OV12OrderedDsc = false ;
   this.AV19GridCurrentPage = 0 ;
   this.AV17DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "" ;
   this.AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "" ;
   this.AV11OrderedBy = 0 ;
   this.AV12OrderedDsc = false ;
   this.AV8InOutSYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.AV9InOutSYS_RolePermissionPermissionCode = "" ;
   this.AV22Select = "" ;
   this.A444SYS_RolePermissionRoleID = '00000000-0000-0000-0000-000000000000' ;
   this.A445SYS_RolePermissionPermissionCode = "" ;
   this.Events = {"e118f2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e128f2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e138f2_client": ["DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED", true] ,"e148f2_client": ["DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED", true] ,"e188f2_client": ["ENTER", true] ,"e198f2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'}],[{av:'AV13SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV15SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONROLEID","Title")',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Title")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV25Pgmname',fld:'vPGMNAME',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.TitleControlIdToReplace',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'TitleControlIdToReplace'},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.TitleControlIdToReplace',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'TitleControlIdToReplace'},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV17DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.ActiveEventKey',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'ActiveEventKey'}],[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONROLEIDContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'AV13SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV15SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONROLEID","Title")',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Title")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.ActiveEventKey',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'ActiveEventKey'}],[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer.SortedStatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'},{av:'AV13SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV15SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONROLEID","Title")',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SYS_ROLEPERMISSIONPERMISSIONCODE","Title")',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV22Select',fld:'vSELECT',pic:''},{av:'gx.fn.getCtrlProperty("vSELECT","Tooltiptext")',ctrl:'vSELECT',prop:'Tooltiptext'}]];
   this.EvtParms["ENTER"] = [[{av:'A444SYS_RolePermissionRoleID',fld:'SYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'A445SYS_RolePermissionPermissionCode',fld:'SYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}],[{av:'AV8InOutSYS_RolePermissionRoleID',fld:'vINOUTSYS_ROLEPERMISSIONROLEID',pic:''},{av:'AV9InOutSYS_RolePermissionPermissionCode',fld:'vINOUTSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''}]];
   this.EnterCtrl = ["vSELECT"];
   this.setVCMap("AV8InOutSYS_RolePermissionRoleID", "vINOUTSYS_ROLEPERMISSIONROLEID", 0, "guid", 16, 0);
   this.setVCMap("AV9InOutSYS_RolePermissionPermissionCode", "vINOUTSYS_ROLEPERMISSIONPERMISSIONCODE", 0, "svchar", 64, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[28]);
   GridContainer.addRefreshingVar(this.GXValidFnc[29]);
   GridContainer.addRefreshingVar(this.GXValidFnc[24]);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   this.Initialize( );
});
gx.createParentObj(sys_rolepermissionprompt);
