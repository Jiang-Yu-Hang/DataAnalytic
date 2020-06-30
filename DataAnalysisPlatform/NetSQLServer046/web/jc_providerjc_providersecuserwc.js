/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:18.30
*/
gx.evt.autoSkip = false;
gx.define('jc_providerjc_providersecuserwc', true, function (CmpContext) {
   this.ServerClass =  "jc_providerjc_providersecuserwc" ;
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
      this.AV36Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV30IsAuthorized_SecUserName=gx.fn.getControlValue("vISAUTHORIZED_SECUSERNAME") ;
      this.AV8JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
      this.AV8JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
      this.AV36Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV30IsAuthorized_SecUserName=gx.fn.getControlValue("vISAUTHORIZED_SECUSERNAME") ;
   };
   this.Valid_Secuserid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(33) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECUSERID", gx.fn.currentGridRowImpl(33));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e118l2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e128l2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e138l2_client=function()
   {
      return this.executeServerEvent("DDO_SECUSERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e148l2_client=function()
   {
      return this.executeServerEvent("DDO_SECUSERNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e158l2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e198l2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e208l2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,43,44,45,47,49,50,52,53];
   this.GXLastCtrlId =53;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",33,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"jc_providerjc_providersecuserwc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Update","vUPDATE",34,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",35,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Display","vDISPLAY",36,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(6,37,"SECUSERID","","","SecUserId","int",0,"px",4,4,"right",null,[],6,"SecUserId",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(14,38,"SECUSERNAME","","","SecUserName","svchar",0,"px",100,80,"left",null,[],14,"SecUserName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 13, 0, "BootstrapPanel", this.CmpContext + "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 42, 34, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV24GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV24GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV26GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV26GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV25GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV25GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e118l2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e128l2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECUSERIDContainer = gx.uc.getNew(this, 46, 34, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECUSERIDContainer", "Ddo_secuserid", "DDO_SECUSERID");
   var DDO_SECUSERIDContainer = this.DDO_SECUSERIDContainer;
   DDO_SECUSERIDContainer.setProp("Class", "Class", "", "char");
   DDO_SECUSERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECUSERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECUSERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECUSERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECUSERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECUSERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECUSERIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECUSERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECUSERIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECUSERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECUSERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECUSERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECUSERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECUSERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECUSERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECUSERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECUSERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECUSERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECUSERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECUSERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECUSERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECUSERIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECUSERIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECUSERIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECUSERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECUSERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECUSERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECUSERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECUSERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECUSERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECUSERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECUSERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECUSERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECUSERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECUSERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECUSERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECUSERIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECUSERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECUSERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECUSERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECUSERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECUSERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECUSERIDContainer.addV2CFunction('AV21DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECUSERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV21DDO_TitleSettingsIcons); });
   DDO_SECUSERIDContainer.addV2CFunction('AV17SecUserIdTitleFilterData', "vSECUSERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECUSERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17SecUserIdTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERIDTITLEFILTERDATA",UC.ParentObject.AV17SecUserIdTitleFilterData); });
   DDO_SECUSERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECUSERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECUSERIDContainer.addEventHandler("OnOptionClicked", this.e138l2_client);
   this.setUserControl(DDO_SECUSERIDContainer);
   this.DDO_SECUSERNAMEContainer = gx.uc.getNew(this, 48, 47, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECUSERNAMEContainer", "Ddo_secusername", "DDO_SECUSERNAME");
   var DDO_SECUSERNAMEContainer = this.DDO_SECUSERNAMEContainer;
   DDO_SECUSERNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_SECUSERNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECUSERNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECUSERNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECUSERNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECUSERNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECUSERNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECUSERNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECUSERNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECUSERNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECUSERNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECUSERNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECUSERNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECUSERNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECUSERNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECUSERNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECUSERNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECUSERNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECUSERNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECUSERNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECUSERNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECUSERNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECUSERNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECUSERNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECUSERNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECUSERNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECUSERNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECUSERNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECUSERNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECUSERNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECUSERNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECUSERNAMEContainer.addV2CFunction('AV21DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV21DDO_TitleSettingsIcons); });
   DDO_SECUSERNAMEContainer.addV2CFunction('AV19SecUserNameTitleFilterData', "vSECUSERNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19SecUserNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERNAMETITLEFILTERDATA",UC.ParentObject.AV19SecUserNameTitleFilterData); });
   DDO_SECUSERNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECUSERNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECUSERNAMEContainer.addEventHandler("OnOptionClicked", this.e148l2_client);
   this.setUserControl(DDO_SECUSERNAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 51, 47, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEHEADER",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"JC_PROVIDERSECUSERTITLE", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"BTNINSERT",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV27Update",gxold:"OV27Update",gxvar:"AV27Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV27Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(33),gx.O.AV27Update,gx.O.AV33Update_GXI)},c2v:function(){gx.O.AV33Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV27Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(33))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(33))}, gxvar_GXI:'AV33Update_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV28Delete",gxold:"OV28Delete",gxvar:"AV28Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV28Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(33),gx.O.AV28Delete,gx.O.AV34Delete_GXI)},c2v:function(){gx.O.AV34Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV28Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(33))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(33))}, gxvar_GXI:'AV34Delete_GXI',nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV29Display",gxold:"OV29Display",gxvar:"AV29Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV29Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(33),gx.O.AV29Display,gx.O.AV35Display_GXI)},c2v:function(){gx.O.AV35Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV29Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(33))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(33))}, gxvar_GXI:'AV35Display_GXI',nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[38],ip:[38,37],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERID",row || gx.fn.currentGridRowImpl(33),gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECUSERID",row || gx.fn.currentGridRowImpl(33),',')},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(33),gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(33))},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",gxz:"ZV18ddo_SecUserIdTitleControlIdToReplace",gxold:"OV18ddo_SecUserIdTitleControlIdToReplace",gxvar:"AV18ddo_SecUserIdTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18ddo_SecUserIdTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18ddo_SecUserIdTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERIDTITLECONTROLIDTOREPLACE",gx.O.AV18ddo_SecUserIdTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18ddo_SecUserIdTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECUSERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_SecUserNameTitleControlIdToReplace",gxold:"OV20ddo_SecUserNameTitleControlIdToReplace",gxvar:"AV20ddo_SecUserNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_SecUserNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_SecUserNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gx.O.AV20ddo_SecUserNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_SecUserNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z87JC_ProviderID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERID",gx.O.A87JC_ProviderID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("JC_PROVIDERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[52]={ id:52 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.ZV27Update = "" ;
   this.OV27Update = "" ;
   this.ZV28Delete = "" ;
   this.OV28Delete = "" ;
   this.ZV29Display = "" ;
   this.OV29Display = "" ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.AV18ddo_SecUserIdTitleControlIdToReplace = "" ;
   this.ZV18ddo_SecUserIdTitleControlIdToReplace = "" ;
   this.OV18ddo_SecUserIdTitleControlIdToReplace = "" ;
   this.AV20ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.ZV20ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.OV20ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.A87JC_ProviderID = 0 ;
   this.Z87JC_ProviderID = 0 ;
   this.O87JC_ProviderID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV24GridCurrentPage = 0 ;
   this.AV21DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV18ddo_SecUserIdTitleControlIdToReplace = "" ;
   this.AV20ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.A87JC_ProviderID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV8JC_ProviderID = 0 ;
   this.AV27Update = "" ;
   this.AV28Delete = "" ;
   this.AV29Display = "" ;
   this.A6SecUserId = 0 ;
   this.A14SecUserName = "" ;
   this.AV36Pgmname = "" ;
   this.AV30IsAuthorized_SecUserName = false ;
   this.Events = {"e118l2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e128l2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e138l2_client": ["DDO_SECUSERID.ONOPTIONCLICKED", true] ,"e148l2_client": ["DDO_SECUSERNAME.ONOPTIONCLICKED", true] ,"e158l2_client": ["'DOINSERT'", true] ,"e198l2_client": ["ENTER", true] ,"e208l2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'AV18ddo_SecUserIdTitleControlIdToReplace',fld:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV36Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV17SecUserIdTitleFilterData',fld:'vSECUSERIDTITLEFILTERDATA',pic:''},{av:'AV19SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERID","Title")',ctrl:'SECUSERID',prop:'Title'},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{ctrl:'GRID',prop:'Rows'},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'this.DDO_SECUSERIDContainer.TitleControlIdToReplace',ctrl:'DDO_SECUSERID',prop:'TitleControlIdToReplace'},{av:'AV18ddo_SecUserIdTitleControlIdToReplace',fld:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECUSERNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECUSERNAME',prop:'TitleControlIdToReplace'},{av:'AV20ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Visible")',ctrl:'JC_PROVIDERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV21DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_SecUserIdTitleControlIdToReplace',fld:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36Pgmname',fld:'vPGMNAME',pic:''},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_SecUserIdTitleControlIdToReplace',fld:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36Pgmname',fld:'vPGMNAME',pic:''},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECUSERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_SecUserIdTitleControlIdToReplace',fld:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36Pgmname',fld:'vPGMNAME',pic:''},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.DDO_SECUSERIDContainer.ActiveEventKey',ctrl:'DDO_SECUSERID',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECUSERIDContainer.SortedStatus',ctrl:'DDO_SECUSERID',prop:'SortedStatus'},{av:'AV17SecUserIdTitleFilterData',fld:'vSECUSERIDTITLEFILTERDATA',pic:''},{av:'AV19SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERID","Title")',ctrl:'SECUSERID',prop:'Title'},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_SECUSERNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_SecUserIdTitleControlIdToReplace',fld:'vDDO_SECUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36Pgmname',fld:'vPGMNAME',pic:''},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.DDO_SECUSERNAMEContainer.ActiveEventKey',ctrl:'DDO_SECUSERNAME',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECUSERNAMEContainer.SortedStatus',ctrl:'DDO_SECUSERNAME',prop:'SortedStatus'},{av:'AV17SecUserIdTitleFilterData',fld:'vSECUSERIDTITLEFILTERDATA',pic:''},{av:'AV19SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERID","Title")',ctrl:'SECUSERID',prop:'Title'},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV30IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true}],[{av:'AV27Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV28Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'AV29Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Link")',ctrl:'SECUSERNAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'}]];
   this.setVCMap("AV36Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV30IsAuthorized_SecUserName", "vISAUTHORIZED_SECUSERNAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV8JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV36Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV30IsAuthorized_SecUserName", "vISAUTHORIZED_SECUSERNAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV36Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV30IsAuthorized_SecUserName", "vISAUTHORIZED_SECUSERNAME", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar({rfrVar:"AV8JC_ProviderID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar({rfrVar:"AV36Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV30IsAuthorized_SecUserName"});
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   this.Initialize( );
});
