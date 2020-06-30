/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:25.16
*/
gx.evt.autoSkip = false;
gx.define('xt_intialdefinecode', false, function () {
   this.ServerClass =  "xt_intialdefinecode" ;
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
      this.AV49Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV46tTenantCode=gx.fn.getControlValue("vTTENANTCODE") ;
      this.AV8InOutBAS_TenantTenantCode=gx.fn.getControlValue("vINOUTBAS_TENANTTENANTCODE") ;
      this.AV49Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV46tTenantCode=gx.fn.getControlValue("vTTENANTCODE") ;
   };
   this.s112_client=function()
   {
      this.s132_client();
      if ( this.AV11OrderedBy == 1 )
      {
         this.DDO_TENANTNAMEContainer.SortedStatus =  (this.AV12OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV11OrderedBy == 2 )
      {
         this.DDO_HOSPITALNAMEContainer.SortedStatus =  (this.AV12OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV11OrderedBy == 3 )
      {
         this.DDO_BAS_TENANTTENANTCODEContainer.SortedStatus =  (this.AV12OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s132_client=function()
   {
      this.DDO_TENANTNAMEContainer.SortedStatus =  ""  ;
      this.DDO_HOSPITALNAMEContainer.SortedStatus =  ""  ;
      this.DDO_BAS_TENANTTENANTCODEContainer.SortedStatus =  ""  ;
   };
   this.e11871_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_MINSAVEContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e22872_client=function()
   {
      this.clearMessages();
      this.AV46tTenantCode =  this.A360BAS_TenantTenantCode  ;
      this.refreshOutputs([{av:'AV46tTenantCode',fld:'vTTENANTCODE',pic:''}]);
      return gx.$.Deferred().resolve();
   };
   this.e12872_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e13872_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e14872_client=function()
   {
      return this.executeServerEvent("DDO_TENANTNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15872_client=function()
   {
      return this.executeServerEvent("DDO_HOSPITALNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16872_client=function()
   {
      return this.executeServerEvent("DDO_BAS_TENANTTENANTCODE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e21872_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e17872_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_MINSAVE.CLOSE", false, null, true, true);
   };
   this.e23871_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,38,40,42,44,45,46,51,52];
   this.GXLastCtrlId =52;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",15,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"xt_intialdefinecode",[],false,1,true,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,"e22872_client",false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(394,16,"TENANTNAME","","","TenantName","svchar",0,"px",200,80,"left",null,[],394,"TenantName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(358,17,"INSTITUTECODE","Institute Code","","InstituteCode","svchar",0,"px",20,20,"left",null,[],358,"InstituteCode",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(395,18,"HOSPITALNAME","","","HospitalName","svchar",0,"px",200,80,"left",null,[],395,"HospitalName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(360,19,"BAS_TENANTTENANTCODE","","","BAS_TenantTenantCode","svchar",0,"px",20,20,"left",null,[],360,"BAS_TenantTenantCode",true,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 23, 16, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV37GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV37GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV37GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV39GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV39GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV38GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV38GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e12872_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e13872_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_TENANTNAMEContainer = gx.uc.getNew(this, 37, 16, "BootstrapDropDownOptions", "DDO_TENANTNAMEContainer", "Ddo_tenantname", "DDO_TENANTNAME");
   var DDO_TENANTNAMEContainer = this.DDO_TENANTNAMEContainer;
   DDO_TENANTNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_TENANTNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_TENANTNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_TENANTNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_TENANTNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_TENANTNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_TENANTNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_TENANTNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_TENANTNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_TENANTNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_TENANTNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_TENANTNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_TENANTNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_TENANTNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_TENANTNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_TENANTNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_TENANTNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_TENANTNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_TENANTNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_TENANTNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_TENANTNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_TENANTNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_TENANTNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_TENANTNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_TENANTNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_TENANTNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_TENANTNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_TENANTNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_TENANTNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_TENANTNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_TENANTNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_TENANTNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_TENANTNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_TENANTNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_TENANTNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_TENANTNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_TENANTNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_TENANTNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_TENANTNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_TENANTNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_TENANTNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_TENANTNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_TENANTNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_TENANTNAMEContainer.addV2CFunction('AV35DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_TENANTNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV35DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV35DDO_TitleSettingsIcons); });
   DDO_TENANTNAMEContainer.addV2CFunction('AV15TenantNameTitleFilterData', "vTENANTNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_TENANTNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV15TenantNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vTENANTNAMETITLEFILTERDATA",UC.ParentObject.AV15TenantNameTitleFilterData); });
   DDO_TENANTNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_TENANTNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_TENANTNAMEContainer.addEventHandler("OnOptionClicked", this.e14872_client);
   this.setUserControl(DDO_TENANTNAMEContainer);
   this.DDO_HOSPITALNAMEContainer = gx.uc.getNew(this, 39, 38, "BootstrapDropDownOptions", "DDO_HOSPITALNAMEContainer", "Ddo_hospitalname", "DDO_HOSPITALNAME");
   var DDO_HOSPITALNAMEContainer = this.DDO_HOSPITALNAMEContainer;
   DDO_HOSPITALNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_HOSPITALNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_HOSPITALNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_HOSPITALNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_HOSPITALNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_HOSPITALNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_HOSPITALNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_HOSPITALNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_HOSPITALNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_HOSPITALNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_HOSPITALNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_HOSPITALNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_HOSPITALNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_HOSPITALNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_HOSPITALNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_HOSPITALNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_HOSPITALNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_HOSPITALNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_HOSPITALNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_HOSPITALNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_HOSPITALNAMEContainer.addV2CFunction('AV35DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_HOSPITALNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV35DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV35DDO_TitleSettingsIcons); });
   DDO_HOSPITALNAMEContainer.addV2CFunction('AV19HospitalNameTitleFilterData', "vHOSPITALNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_HOSPITALNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19HospitalNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vHOSPITALNAMETITLEFILTERDATA",UC.ParentObject.AV19HospitalNameTitleFilterData); });
   DDO_HOSPITALNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_HOSPITALNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_HOSPITALNAMEContainer.addEventHandler("OnOptionClicked", this.e15872_client);
   this.setUserControl(DDO_HOSPITALNAMEContainer);
   this.DDO_BAS_TENANTTENANTCODEContainer = gx.uc.getNew(this, 41, 38, "BootstrapDropDownOptions", "DDO_BAS_TENANTTENANTCODEContainer", "Ddo_bas_tenanttenantcode", "DDO_BAS_TENANTTENANTCODE");
   var DDO_BAS_TENANTTENANTCODEContainer = this.DDO_BAS_TENANTTENANTCODEContainer;
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Class", "Class", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("DataListProc", "Datalistproc", "XT_IntialDefineCodeGetFilterData", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BAS_TENANTTENANTCODEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BAS_TENANTTENANTCODEContainer.addV2CFunction('AV35DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BAS_TENANTTENANTCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV35DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV35DDO_TitleSettingsIcons); });
   DDO_BAS_TENANTTENANTCODEContainer.addV2CFunction('AV13BAS_TenantTenantCodeTitleFilterData', "vBAS_TENANTTENANTCODETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BAS_TENANTTENANTCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV13BAS_TenantTenantCodeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBAS_TENANTTENANTCODETITLEFILTERDATA",UC.ParentObject.AV13BAS_TenantTenantCodeTitleFilterData); });
   DDO_BAS_TENANTTENANTCODEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BAS_TENANTTENANTCODEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BAS_TENANTTENANTCODEContainer.addEventHandler("OnOptionClicked", this.e16872_client);
   this.setUserControl(DDO_BAS_TENANTTENANTCODEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 43, 38, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   this.DVELOP_CONFIRMPANEL_MINSAVEContainer = gx.uc.getNew(this, 49, 38, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_MINSAVEContainer", "Dvelop_confirmpanel_minsave", "DVELOP_CONFIRMPANEL_MINSAVE");
   var DVELOP_CONFIRMPANEL_MINSAVEContainer = this.DVELOP_CONFIRMPANEL_MINSAVEContainer;
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("ConfirmationText", "Confirmationtext", "纭鍒濆鍖栫鎴锋暟鎹瓧鍏?鍒濆鍖栨搷浣滀細灏嗛€夋嫨绉熸埛鐨勫師鏈夋墍鏈夋暟鎹瓧鍏镐俊鎭垹闄?", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_MINSAVEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_MINSAVEContainer.addEventHandler("Close", this.e17872_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_MINSAVEContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[16]={ id:16 ,lvl:2,type:"svchar",len:200,dec:0,sign:false,ro:1,isacc:0,grid:15,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TENANTNAME",gxz:"Z394TenantName",gxold:"O394TenantName",gxvar:"A394TenantName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A394TenantName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z394TenantName=Value},v2c:function(row){gx.fn.setGridControlValue("TENANTNAME",row || gx.fn.currentGridRowImpl(15),gx.O.A394TenantName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A394TenantName=this.val()},val:function(row){return gx.fn.getGridControlValue("TENANTNAME",row || gx.fn.currentGridRowImpl(15))},nac:gx.falseFn};
   GXValidFnc[17]={ id:17 ,lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,isacc:0,grid:15,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INSTITUTECODE",gxz:"Z358InstituteCode",gxold:"O358InstituteCode",gxvar:"A358InstituteCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A358InstituteCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z358InstituteCode=Value},v2c:function(row){gx.fn.setGridControlValue("INSTITUTECODE",row || gx.fn.currentGridRowImpl(15),gx.O.A358InstituteCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A358InstituteCode=this.val()},val:function(row){return gx.fn.getGridControlValue("INSTITUTECODE",row || gx.fn.currentGridRowImpl(15))},nac:gx.falseFn};
   GXValidFnc[18]={ id:18 ,lvl:2,type:"svchar",len:200,dec:0,sign:false,ro:1,isacc:0,grid:15,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"HOSPITALNAME",gxz:"Z395HospitalName",gxold:"O395HospitalName",gxvar:"A395HospitalName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A395HospitalName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z395HospitalName=Value},v2c:function(row){gx.fn.setGridControlValue("HOSPITALNAME",row || gx.fn.currentGridRowImpl(15),gx.O.A395HospitalName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A395HospitalName=this.val()},val:function(row){return gx.fn.getGridControlValue("HOSPITALNAME",row || gx.fn.currentGridRowImpl(15))},nac:gx.falseFn};
   GXValidFnc[19]={ id:19 ,lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,isacc:0,grid:15,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_TENANTTENANTCODE",gxz:"Z360BAS_TenantTenantCode",gxold:"O360BAS_TenantTenantCode",gxvar:"A360BAS_TenantTenantCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A360BAS_TenantTenantCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z360BAS_TenantTenantCode=Value},v2c:function(row){gx.fn.setGridControlValue("BAS_TENANTTENANTCODE",row || gx.fn.currentGridRowImpl(15),gx.O.A360BAS_TenantTenantCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A360BAS_TenantTenantCode=this.val()},val:function(row){return gx.fn.getGridControlValue("BAS_TENANTTENANTCODE",row || gx.fn.currentGridRowImpl(15))},nac:gx.falseFn};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"BTNMINSAVE",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"BTNCANCEL",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_TENANTNAMETITLECONTROLIDTOREPLACE",gxz:"ZV16ddo_TenantNameTitleControlIdToReplace",gxold:"OV16ddo_TenantNameTitleControlIdToReplace",gxvar:"AV16ddo_TenantNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16ddo_TenantNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16ddo_TenantNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_TENANTNAMETITLECONTROLIDTOREPLACE",gx.O.AV16ddo_TenantNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16ddo_TenantNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_TENANTNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_HospitalNameTitleControlIdToReplace",gxold:"OV20ddo_HospitalNameTitleControlIdToReplace",gxvar:"AV20ddo_HospitalNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_HospitalNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_HospitalNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE",gx.O.AV20ddo_HospitalNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_HospitalNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE",gxz:"ZV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace",gxold:"OV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace",gxvar:"AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE",gx.O.AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV11OrderedBy",gxold:"OV11OrderedBy",gxvar:"AV11OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV11OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV11OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV11OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV11OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV12OrderedDsc",gxold:"OV12OrderedDsc",gxvar:"AV12OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV12OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV12OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[46]={ id: 46, fld:"TABLEDVELOP_CONFIRMPANEL_MINSAVE",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBAS_TENANTTENANTCODE",gxz:"ZV44TFBAS_TenantTenantCode",gxold:"OV44TFBAS_TenantTenantCode",gxvar:"AV44TFBAS_TenantTenantCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV44TFBAS_TenantTenantCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44TFBAS_TenantTenantCode=Value},v2c:function(){gx.fn.setControlValue("vTFBAS_TENANTTENANTCODE",gx.O.AV44TFBAS_TenantTenantCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV44TFBAS_TenantTenantCode=this.val()},val:function(){return gx.fn.getControlValue("vTFBAS_TENANTTENANTCODE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBAS_TENANTTENANTCODE_SEL",gxz:"ZV45TFBAS_TenantTenantCode_Sel",gxold:"OV45TFBAS_TenantTenantCode_Sel",gxvar:"AV45TFBAS_TenantTenantCode_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV45TFBAS_TenantTenantCode_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45TFBAS_TenantTenantCode_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBAS_TENANTTENANTCODE_SEL",gx.O.AV45TFBAS_TenantTenantCode_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV45TFBAS_TenantTenantCode_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBAS_TENANTTENANTCODE_SEL")},nac:gx.falseFn};
   this.Z394TenantName = "" ;
   this.O394TenantName = "" ;
   this.Z358InstituteCode = "" ;
   this.O358InstituteCode = "" ;
   this.Z395HospitalName = "" ;
   this.O395HospitalName = "" ;
   this.Z360BAS_TenantTenantCode = "" ;
   this.O360BAS_TenantTenantCode = "" ;
   this.AV16ddo_TenantNameTitleControlIdToReplace = "" ;
   this.ZV16ddo_TenantNameTitleControlIdToReplace = "" ;
   this.OV16ddo_TenantNameTitleControlIdToReplace = "" ;
   this.AV20ddo_HospitalNameTitleControlIdToReplace = "" ;
   this.ZV20ddo_HospitalNameTitleControlIdToReplace = "" ;
   this.OV20ddo_HospitalNameTitleControlIdToReplace = "" ;
   this.AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = "" ;
   this.ZV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = "" ;
   this.OV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = "" ;
   this.AV11OrderedBy = 0 ;
   this.ZV11OrderedBy = 0 ;
   this.OV11OrderedBy = 0 ;
   this.AV12OrderedDsc = false ;
   this.ZV12OrderedDsc = false ;
   this.OV12OrderedDsc = false ;
   this.AV44TFBAS_TenantTenantCode = "" ;
   this.ZV44TFBAS_TenantTenantCode = "" ;
   this.OV44TFBAS_TenantTenantCode = "" ;
   this.AV45TFBAS_TenantTenantCode_Sel = "" ;
   this.ZV45TFBAS_TenantTenantCode_Sel = "" ;
   this.OV45TFBAS_TenantTenantCode_Sel = "" ;
   this.AV37GridCurrentPage = 0 ;
   this.AV35DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV16ddo_TenantNameTitleControlIdToReplace = "" ;
   this.AV20ddo_HospitalNameTitleControlIdToReplace = "" ;
   this.AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = "" ;
   this.AV11OrderedBy = 0 ;
   this.AV12OrderedDsc = false ;
   this.AV44TFBAS_TenantTenantCode = "" ;
   this.AV45TFBAS_TenantTenantCode_Sel = "" ;
   this.AV8InOutBAS_TenantTenantCode = "" ;
   this.A401BAS_TenantIsDeleted = 0 ;
   this.A394TenantName = "" ;
   this.A358InstituteCode = "" ;
   this.A395HospitalName = "" ;
   this.A360BAS_TenantTenantCode = "" ;
   this.AV49Pgmname = "" ;
   this.AV46tTenantCode = "" ;
   this.Events = {"e12872_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e13872_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e14872_client": ["DDO_TENANTNAME.ONOPTIONCLICKED", true] ,"e15872_client": ["DDO_HOSPITALNAME.ONOPTIONCLICKED", true] ,"e16872_client": ["DDO_BAS_TENANTTENANTCODE.ONOPTIONCLICKED", true] ,"e21872_client": ["ENTER", true] ,"e17872_client": ["DVELOP_CONFIRMPANEL_MINSAVE.CLOSE", true] ,"e23871_client": ["CANCEL", true] ,"e11871_client": ["'DOMINSAVE'", false] ,"e22872_client": ["GRID.ONLINEACTIVATE", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{ctrl:'TENANTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("TENANTNAME","Title")',ctrl:'TENANTNAME',prop:'Title'},{ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("HOSPITALNAME","Title")',ctrl:'HOSPITALNAME',prop:'Title'},{ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BAS_TENANTTENANTCODE","Title")',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBAS_TENANTTENANTCODE","Visible")',ctrl:'vTFBAS_TENANTTENANTCODE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBAS_TENANTTENANTCODE_SEL","Visible")',ctrl:'vTFBAS_TENANTTENANTCODE_SEL',prop:'Visible'},{av:'this.DDO_TENANTNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_TENANTNAME',prop:'TitleControlIdToReplace'},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_TENANTNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_HOSPITALNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_HOSPITALNAME',prop:'TitleControlIdToReplace'},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.TitleControlIdToReplace',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'TitleControlIdToReplace'},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV35DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'this.DDO_TENANTNAMEContainer.SortedStatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'this.DDO_HOSPITALNAMEContainer.SortedStatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.SortedStatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_TENANTNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_TENANTNAMEContainer.ActiveEventKey',ctrl:'DDO_TENANTNAME',prop:'ActiveEventKey'}],[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_TENANTNAMEContainer.SortedStatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'this.DDO_HOSPITALNAMEContainer.SortedStatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.SortedStatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'},{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{ctrl:'TENANTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("TENANTNAME","Title")',ctrl:'TENANTNAME',prop:'Title'},{ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("HOSPITALNAME","Title")',ctrl:'HOSPITALNAME',prop:'Title'},{ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BAS_TENANTTENANTCODE","Title")',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_HOSPITALNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_HOSPITALNAMEContainer.ActiveEventKey',ctrl:'DDO_HOSPITALNAME',prop:'ActiveEventKey'}],[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_HOSPITALNAMEContainer.SortedStatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'this.DDO_TENANTNAMEContainer.SortedStatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.SortedStatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'},{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{ctrl:'TENANTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("TENANTNAME","Title")',ctrl:'TENANTNAME',prop:'Title'},{ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("HOSPITALNAME","Title")',ctrl:'HOSPITALNAME',prop:'Title'},{ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BAS_TENANTTENANTCODE","Title")',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BAS_TENANTTENANTCODE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.ActiveEventKey',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'ActiveEventKey'},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.FilteredText_get',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'FilteredText_get'},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.SelectedValue_get',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SelectedValue_get'}],[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BAS_TENANTTENANTCODEContainer.SortedStatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'this.DDO_TENANTNAMEContainer.SortedStatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'this.DDO_HOSPITALNAMEContainer.SortedStatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{ctrl:'TENANTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("TENANTNAME","Title")',ctrl:'TENANTNAME',prop:'Title'},{ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("HOSPITALNAME","Title")',ctrl:'HOSPITALNAME',prop:'Title'},{ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BAS_TENANTTENANTCODE","Title")',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[]];
   this.EvtParms["ENTER"] = [[{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:'',hsh:true}],[{av:'AV8InOutBAS_TenantTenantCode',fld:'vINOUTBAS_TENANTTENANTCODE',pic:''}]];
   this.EvtParms["'DOMINSAVE'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_MINSAVE.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_MINSAVEContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_MINSAVE',prop:'Result'},{av:'AV46tTenantCode',fld:'vTTENANTCODE',pic:''},{av:'AV8InOutBAS_TenantTenantCode',fld:'vINOUTBAS_TENANTTENANTCODE',pic:''}],[]];
   this.EvtParms["GRID.ONLINEACTIVATE"] = [[{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:'',hsh:true}],[{av:'AV46tTenantCode',fld:'vTTENANTCODE',pic:''}]];
   this.setVCMap("AV49Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV46tTenantCode", "vTTENANTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV8InOutBAS_TenantTenantCode", "vINOUTBAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("AV49Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV46tTenantCode", "vTTENANTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV49Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[38]);
   GridContainer.addRefreshingVar(this.GXValidFnc[40]);
   GridContainer.addRefreshingVar(this.GXValidFnc[42]);
   GridContainer.addRefreshingVar({rfrVar:"AV49Pgmname"});
   this.Initialize( );
});
gx.createParentObj(xt_intialdefinecode);
