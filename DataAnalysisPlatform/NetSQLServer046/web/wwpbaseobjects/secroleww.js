/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:58:27.12
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secroleww', false, function () {
   this.ServerClass =  "wwpbaseobjects.secroleww" ;
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
      this.AV110Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV37IsAuthorized_UAAssociateFunctionalities=gx.fn.getControlValue("vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES") ;
      this.AV110Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV37IsAuthorized_UAAssociateFunctionalities=gx.fn.getControlValue("vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV46OrderedBy == 2 )
      {
         this.DDO_SECROLENAMEContainer.SortedStatus =  (this.AV47OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV46OrderedBy == 3 )
      {
         this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus =  (this.AV47OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_SECROLENAMEContainer.SortedStatus =  ""  ;
      this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus =  ""  ;
   };
   this.e190i2_client=function()
   {
      this.clearMessages();
      this.call("wwpbaseobjects.secroleview.aspx", [this.A4SecRoleId, "General"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e110i2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120i2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130i2_client=function()
   {
      return this.executeServerEvent("DDO_SECROLENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e140i2_client=function()
   {
      return this.executeServerEvent("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e150i2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e200i2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e210i2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,41,42,43,45,47,49,50,51,52,53,54];
   this.GXLastCtrlId =54;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secroleww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",30,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Deleterole","vDELETEROLE",31,0,"px",17,"px","e190i2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Roleassociateusers","vROLEASSOCIATEUSERS",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Uaassociatefunctionalities","vUAASSOCIATEFUNCTIONALITIES",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(4,34,"SECROLEID","缂栧彿","","SecRoleId","int",0,"px",4,4,"right",null,[],4,"SecRoleId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(13,35,"SECROLENAME","","","SecRoleName","svchar",0,"px",40,40,"left",null,[],13,"SecRoleName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(12,36,"SECROLEDESCRIPTION","","","SecRoleDescription","svchar",0,"px",120,80,"left",null,[],12,"SecRoleDescription",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 40, 29, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV91GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV91GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV91GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV94GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV94GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV94GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV93GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV93GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV93GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110i2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120i2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECROLENAMEContainer = gx.uc.getNew(this, 44, 29, "BootstrapDropDownOptions", "DDO_SECROLENAMEContainer", "Ddo_secrolename", "DDO_SECROLENAME");
   var DDO_SECROLENAMEContainer = this.DDO_SECROLENAMEContainer;
   DDO_SECROLENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_SECROLENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECROLENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECROLENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECROLENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECROLENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECROLENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECROLENAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECROLENAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECROLENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECROLENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECROLENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECROLENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECROLENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECROLENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECROLENAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SECROLENAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SECROLENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SECROLENAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SECROLENAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SECROLENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SECROLENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECROLENAMEContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecRoleWWGetFilterData", "str");
   DDO_SECROLENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SECROLENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECROLENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECROLENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECROLENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECROLENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECROLENAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SECROLENAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SECROLENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECROLENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECROLENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SECROLENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECROLENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECROLENAMEContainer.addV2CFunction('AV80DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECROLENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV80DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV80DDO_TitleSettingsIcons); });
   DDO_SECROLENAMEContainer.addV2CFunction('AV72SecRoleNameTitleFilterData', "vSECROLENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECROLENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV72SecRoleNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECROLENAMETITLEFILTERDATA",UC.ParentObject.AV72SecRoleNameTitleFilterData); });
   DDO_SECROLENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECROLENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECROLENAMEContainer.addEventHandler("OnOptionClicked", this.e130i2_client);
   this.setUserControl(DDO_SECROLENAMEContainer);
   this.DDO_SECROLEDESCRIPTIONContainer = gx.uc.getNew(this, 46, 45, "BootstrapDropDownOptions", "DDO_SECROLEDESCRIPTIONContainer", "Ddo_secroledescription", "DDO_SECROLEDESCRIPTION");
   var DDO_SECROLEDESCRIPTIONContainer = this.DDO_SECROLEDESCRIPTIONContainer;
   DDO_SECROLEDESCRIPTIONContainer.setProp("Class", "Class", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecRoleWWGetFilterData", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECROLEDESCRIPTIONContainer.addV2CFunction('AV80DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECROLEDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV80DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV80DDO_TitleSettingsIcons); });
   DDO_SECROLEDESCRIPTIONContainer.addV2CFunction('AV76SecRoleDescriptionTitleFilterData', "vSECROLEDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECROLEDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV76SecRoleDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECROLEDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV76SecRoleDescriptionTitleFilterData); });
   DDO_SECROLEDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECROLEDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e140i2_client);
   this.setUserControl(DDO_SECROLEDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 48, 45, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV95Display",gxold:"OV95Display",gxvar:"AV95Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV95Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV95Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV95Display,gx.O.AV105Display_GXI)},c2v:function(){gx.O.AV105Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV95Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV105Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV13Update",gxold:"OV13Update",gxvar:"AV13Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV13Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(28),gx.O.AV13Update,gx.O.AV106Update_GXI)},c2v:function(){gx.O.AV106Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV13Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV106Update_GXI',nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETEROLE",gxz:"ZV98deleteRole",gxold:"OV98deleteRole",gxvar:"AV98deleteRole",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV98deleteRole=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV98deleteRole=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETEROLE",row || gx.fn.currentGridRowImpl(28),gx.O.AV98deleteRole,gx.O.AV107Deleterole_GXI)},c2v:function(){gx.O.AV107Deleterole_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV98deleteRole=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETEROLE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETEROLE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV107Deleterole_GXI',nac:gx.falseFn,evt:"e190i2_client"};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vROLEASSOCIATEUSERS",gxz:"ZV97RoleAssociateUsers",gxold:"OV97RoleAssociateUsers",gxvar:"AV97RoleAssociateUsers",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV97RoleAssociateUsers=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV97RoleAssociateUsers=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vROLEASSOCIATEUSERS",row || gx.fn.currentGridRowImpl(28),gx.O.AV97RoleAssociateUsers,gx.O.AV108Roleassociateusers_GXI)},c2v:function(){gx.O.AV108Roleassociateusers_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV97RoleAssociateUsers=this.val()},val:function(row){return gx.fn.getGridControlValue("vROLEASSOCIATEUSERS",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vROLEASSOCIATEUSERS_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV108Roleassociateusers_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUAASSOCIATEFUNCTIONALITIES",gxz:"ZV36UAAssociateFunctionalities",gxold:"OV36UAAssociateFunctionalities",gxvar:"AV36UAAssociateFunctionalities",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV36UAAssociateFunctionalities=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36UAAssociateFunctionalities=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUAASSOCIATEFUNCTIONALITIES",row || gx.fn.currentGridRowImpl(28),gx.O.AV36UAAssociateFunctionalities,gx.O.AV109Uaassociatefunctionalities_GXI)},c2v:function(){gx.O.AV109Uaassociatefunctionalities_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV36UAAssociateFunctionalities=this.val()},val:function(row){return gx.fn.getGridControlValue("vUAASSOCIATEFUNCTIONALITIES",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vUAASSOCIATEFUNCTIONALITIES_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV109Uaassociatefunctionalities_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEID",gxz:"Z4SecRoleId",gxold:"O4SecRoleId",gxvar:"A4SecRoleId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A4SecRoleId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z4SecRoleId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECROLEID",row || gx.fn.currentGridRowImpl(28),gx.O.A4SecRoleId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A4SecRoleId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECROLEID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLENAME",gxz:"Z13SecRoleName",gxold:"O13SecRoleName",gxvar:"A13SecRoleName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A13SecRoleName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z13SecRoleName=Value},v2c:function(row){gx.fn.setGridControlValue("SECROLENAME",row || gx.fn.currentGridRowImpl(28),gx.O.A13SecRoleName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A13SecRoleName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECROLENAME",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"svchar",len:120,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEDESCRIPTION",gxz:"Z12SecRoleDescription",gxold:"O12SecRoleDescription",gxvar:"A12SecRoleDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A12SecRoleDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z12SecRoleDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECROLEDESCRIPTION",row || gx.fn.currentGridRowImpl(28),gx.O.A12SecRoleDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A12SecRoleDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECROLEDESCRIPTION",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECROLENAMETITLECONTROLIDTOREPLACE",gxz:"ZV75ddo_SecRoleNameTitleControlIdToReplace",gxold:"OV75ddo_SecRoleNameTitleControlIdToReplace",gxvar:"AV75ddo_SecRoleNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV75ddo_SecRoleNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV75ddo_SecRoleNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE",gx.O.AV75ddo_SecRoleNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV75ddo_SecRoleNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV79ddo_SecRoleDescriptionTitleControlIdToReplace",gxold:"OV79ddo_SecRoleDescriptionTitleControlIdToReplace",gxvar:"AV79ddo_SecRoleDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV79ddo_SecRoleDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV79ddo_SecRoleDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV79ddo_SecRoleDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV79ddo_SecRoleDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV46OrderedBy",gxold:"OV46OrderedBy",gxvar:"AV46OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV46OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV46OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV46OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV46OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV47OrderedDsc",gxold:"OV47OrderedDsc",gxvar:"AV47OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV47OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV47OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV47OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV47OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLENAME",gxz:"ZV73TFSecRoleName",gxold:"OV73TFSecRoleName",gxvar:"AV73TFSecRoleName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV73TFSecRoleName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV73TFSecRoleName=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLENAME",gx.O.AV73TFSecRoleName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV73TFSecRoleName=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLENAME")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLENAME_SEL",gxz:"ZV74TFSecRoleName_Sel",gxold:"OV74TFSecRoleName_Sel",gxvar:"AV74TFSecRoleName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV74TFSecRoleName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV74TFSecRoleName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLENAME_SEL",gx.O.AV74TFSecRoleName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV74TFSecRoleName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLENAME_SEL")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLEDESCRIPTION",gxz:"ZV77TFSecRoleDescription",gxold:"OV77TFSecRoleDescription",gxvar:"AV77TFSecRoleDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV77TFSecRoleDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV77TFSecRoleDescription=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLEDESCRIPTION",gx.O.AV77TFSecRoleDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV77TFSecRoleDescription=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLEDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLEDESCRIPTION_SEL",gxz:"ZV78TFSecRoleDescription_Sel",gxold:"OV78TFSecRoleDescription_Sel",gxvar:"AV78TFSecRoleDescription_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV78TFSecRoleDescription_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV78TFSecRoleDescription_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLEDESCRIPTION_SEL",gx.O.AV78TFSecRoleDescription_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV78TFSecRoleDescription_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLEDESCRIPTION_SEL")},nac:gx.falseFn};
   this.ZV95Display = "" ;
   this.OV95Display = "" ;
   this.ZV13Update = "" ;
   this.OV13Update = "" ;
   this.ZV98deleteRole = "" ;
   this.OV98deleteRole = "" ;
   this.ZV97RoleAssociateUsers = "" ;
   this.OV97RoleAssociateUsers = "" ;
   this.ZV36UAAssociateFunctionalities = "" ;
   this.OV36UAAssociateFunctionalities = "" ;
   this.Z4SecRoleId = 0 ;
   this.O4SecRoleId = 0 ;
   this.Z13SecRoleName = "" ;
   this.O13SecRoleName = "" ;
   this.Z12SecRoleDescription = "" ;
   this.O12SecRoleDescription = "" ;
   this.AV75ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.ZV75ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.OV75ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.AV79ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.ZV79ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.OV79ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.AV46OrderedBy = 0 ;
   this.ZV46OrderedBy = 0 ;
   this.OV46OrderedBy = 0 ;
   this.AV47OrderedDsc = false ;
   this.ZV47OrderedDsc = false ;
   this.OV47OrderedDsc = false ;
   this.AV73TFSecRoleName = "" ;
   this.ZV73TFSecRoleName = "" ;
   this.OV73TFSecRoleName = "" ;
   this.AV74TFSecRoleName_Sel = "" ;
   this.ZV74TFSecRoleName_Sel = "" ;
   this.OV74TFSecRoleName_Sel = "" ;
   this.AV77TFSecRoleDescription = "" ;
   this.ZV77TFSecRoleDescription = "" ;
   this.OV77TFSecRoleDescription = "" ;
   this.AV78TFSecRoleDescription_Sel = "" ;
   this.ZV78TFSecRoleDescription_Sel = "" ;
   this.OV78TFSecRoleDescription_Sel = "" ;
   this.AV91GridCurrentPage = 0 ;
   this.AV80DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV75ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.AV79ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.AV46OrderedBy = 0 ;
   this.AV47OrderedDsc = false ;
   this.AV73TFSecRoleName = "" ;
   this.AV74TFSecRoleName_Sel = "" ;
   this.AV77TFSecRoleDescription = "" ;
   this.AV78TFSecRoleDescription_Sel = "" ;
   this.AV95Display = "" ;
   this.AV13Update = "" ;
   this.AV98deleteRole = "" ;
   this.AV97RoleAssociateUsers = "" ;
   this.AV36UAAssociateFunctionalities = "" ;
   this.A4SecRoleId = 0 ;
   this.A13SecRoleName = "" ;
   this.A12SecRoleDescription = "" ;
   this.AV110Pgmname = "" ;
   this.AV39IsAuthorized_Update = false ;
   this.AV37IsAuthorized_UAAssociateFunctionalities = false ;
   this.Events = {"e110i2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120i2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130i2_client": ["DDO_SECROLENAME.ONOPTIONCLICKED", true] ,"e140i2_client": ["DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED", true] ,"e150i2_client": ["'DOINSERT'", true] ,"e200i2_client": ["ENTER", true] ,"e210i2_client": ["CANCEL", true] ,"e190i2_client": ["VDELETEROLE.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Title")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV72SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV76SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV91GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV94GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Visible")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFSECROLENAME","Visible")',ctrl:'vTFSECROLENAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECROLENAME_SEL","Visible")',ctrl:'vTFSECROLENAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECROLEDESCRIPTION","Visible")',ctrl:'vTFSECROLEDESCRIPTION',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECROLEDESCRIPTION_SEL","Visible")',ctrl:'vTFSECROLEDESCRIPTION_SEL',prop:'Visible'},{av:'this.DDO_SECROLENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECROLENAME',prop:'TitleControlIdToReplace'},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECROLEDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV80DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Title")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'this.DDO_SECROLENAMEContainer.FilteredText_set',ctrl:'DDO_SECROLENAME',prop:'FilteredText_set'},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'this.DDO_SECROLENAMEContainer.SelectedValue_set',ctrl:'DDO_SECROLENAME',prop:'SelectedValue_set'},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.FilteredText_set',ctrl:'DDO_SECROLEDESCRIPTION',prop:'FilteredText_set'},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SelectedValue_set',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SelectedValue_set'},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Title")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Title")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECROLENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Title")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'this.DDO_SECROLENAMEContainer.ActiveEventKey',ctrl:'DDO_SECROLENAME',prop:'ActiveEventKey'},{av:'this.DDO_SECROLENAMEContainer.FilteredText_get',ctrl:'DDO_SECROLENAME',prop:'FilteredText_get'},{av:'this.DDO_SECROLENAMEContainer.SelectedValue_get',ctrl:'DDO_SECROLENAME',prop:'SelectedValue_get'}],[{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV72SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV76SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV91GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV94GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Visible")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Title")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECROLEDESCRIPTION',prop:'ActiveEventKey'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.FilteredText_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'FilteredText_get'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SelectedValue_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SelectedValue_get'}],[{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV72SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV76SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV91GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV94GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Visible")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''}],[{av:'AV95Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV13Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV98deleteRole',fld:'vDELETEROLE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETEROLE","Tooltiptext")',ctrl:'vDELETEROLE',prop:'Tooltiptext'},{av:'AV97RoleAssociateUsers',fld:'vROLEASSOCIATEUSERS',pic:''},{av:'gx.fn.getCtrlProperty("vROLEASSOCIATEUSERS","Tooltiptext")',ctrl:'vROLEASSOCIATEUSERS',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vROLEASSOCIATEUSERS","Link")',ctrl:'vROLEASSOCIATEUSERS',prop:'Link'},{av:'AV36UAAssociateFunctionalities',fld:'vUAASSOCIATEFUNCTIONALITIES',pic:''},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Tooltiptext")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUAASSOCIATEFUNCTIONALITIES","Link")',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Link'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Link")',ctrl:'SECROLENAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["VDELETEROLE.CLICK"] = [[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}],[]];
   this.setVCMap("AV110Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV37IsAuthorized_UAAssociateFunctionalities", "vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES", 0, "boolean", 4, 0);
   this.setVCMap("AV110Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV37IsAuthorized_UAAssociateFunctionalities", "vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES", 0, "boolean", 4, 0);
   this.setVCMap("AV110Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV37IsAuthorized_UAAssociateFunctionalities", "vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar({rfrVar:"AV110Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV36UAAssociateFunctionalities", rfrProp:"Title", gxAttId:"Uaassociatefunctionalities"});
   GridContainer.addRefreshingVar({rfrVar:"AV39IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV37IsAuthorized_UAAssociateFunctionalities"});
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secroleww);
