/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:29.53
*/
gx.evt.autoSkip = false;
gx.define('br_medication_schemebr_medication_detailwc', true, function (CmpContext) {
   this.ServerClass =  "br_medication_schemebr_medication_detailwc" ;
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
      this.AV52Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV30IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV32IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV8BR_Medication_SchemeID=gx.fn.getIntegerValue("vBR_MEDICATION_SCHEMEID",',') ;
      this.AV36BR_MedicationID=gx.fn.getIntegerValue("vBR_MEDICATIONID",',') ;
      this.AV8BR_Medication_SchemeID=gx.fn.getIntegerValue("vBR_MEDICATION_SCHEMEID",',') ;
      this.AV36BR_MedicationID=gx.fn.getIntegerValue("vBR_MEDICATIONID",',') ;
      this.AV52Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV30IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV32IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.Valid_Br_medication_schemeid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_SCHEMEID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e11512_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12512_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13512_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14512_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15512_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16512_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e20512_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e21512_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,40,41,42,44,46,48,49,50,52,53];
   this.GXLastCtrlId =53;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_medication_schemebr_medication_detailwc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",30,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",31,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(301,32,"BR_MEDICATION_DETAILID","搴忓彿","","BR_Medication_DetailID","int",0,"px",18,18,"right",null,[],301,"BR_Medication_DetailID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(310,33,"BR_MEDICATION_DRUG_NAME","","","BR_Medication_Drug_Name","svchar",0,"px",40,40,"left",null,[],310,"BR_Medication_Drug_Name",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(311,34,"BR_MEDICATION_DRUG_NUM","","","BR_Medication_Drug_Num","decimal",0,"px",15,15,"right",null,[],311,"BR_Medication_Drug_Num",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(312,35,"BR_MEDICATION_DRUG_UNIT","","","BR_Medication_Drug_Unit","svchar",0,"px",40,40,"left",null,[],312,"BR_Medication_Drug_Unit",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV26GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV26GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV28GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV28GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV27GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV27GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11512_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12512_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICATION_DRUG_NAMEContainer = gx.uc.getNew(this, 43, 29, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICATION_DRUG_NAMEContainer", "Ddo_br_medication_drug_name", "DDO_BR_MEDICATION_DRUG_NAME");
   var DDO_BR_MEDICATION_DRUG_NAMEContainer = this.DDO_BR_MEDICATION_DRUG_NAMEContainer;
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addV2CFunction('AV23DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV23DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addV2CFunction('AV41BR_Medication_Drug_NameTitleFilterData', "vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV41BR_Medication_Drug_NameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA",UC.ParentObject.AV41BR_Medication_Drug_NameTitleFilterData); });
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addEventHandler("OnOptionClicked", this.e13512_client);
   this.setUserControl(DDO_BR_MEDICATION_DRUG_NAMEContainer);
   this.DDO_BR_MEDICATION_DRUG_NUMContainer = gx.uc.getNew(this, 45, 44, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICATION_DRUG_NUMContainer", "Ddo_br_medication_drug_num", "DDO_BR_MEDICATION_DRUG_NUM");
   var DDO_BR_MEDICATION_DRUG_NUMContainer = this.DDO_BR_MEDICATION_DRUG_NUMContainer;
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.addV2CFunction('AV23DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DRUG_NUMContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV23DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DRUG_NUMContainer.addV2CFunction('AV43BR_Medication_Drug_NumTitleFilterData', "vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DRUG_NUMContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43BR_Medication_Drug_NumTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA",UC.ParentObject.AV43BR_Medication_Drug_NumTitleFilterData); });
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DRUG_NUMContainer.addEventHandler("OnOptionClicked", this.e14512_client);
   this.setUserControl(DDO_BR_MEDICATION_DRUG_NUMContainer);
   this.DDO_BR_MEDICATION_DRUG_UNITContainer = gx.uc.getNew(this, 47, 44, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICATION_DRUG_UNITContainer", "Ddo_br_medication_drug_unit", "DDO_BR_MEDICATION_DRUG_UNIT");
   var DDO_BR_MEDICATION_DRUG_UNITContainer = this.DDO_BR_MEDICATION_DRUG_UNITContainer;
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.addV2CFunction('AV23DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DRUG_UNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV23DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DRUG_UNITContainer.addV2CFunction('AV45BR_Medication_Drug_UnitTitleFilterData', "vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DRUG_UNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45BR_Medication_Drug_UnitTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA",UC.ParentObject.AV45BR_Medication_Drug_UnitTitleFilterData); });
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DRUG_UNITContainer.addEventHandler("OnOptionClicked", this.e15512_client);
   this.setUserControl(DDO_BR_MEDICATION_DRUG_UNITContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 51, 44, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV33Display",gxold:"OV33Display",gxvar:"AV33Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV33Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV33Display,gx.O.AV49Display_GXI)},c2v:function(){gx.O.AV49Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV33Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV49Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV29Update",gxold:"OV29Update",gxvar:"AV29Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV29Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(28),gx.O.AV29Update,gx.O.AV50Update_GXI)},c2v:function(){gx.O.AV50Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV29Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV50Update_GXI',nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV31Delete",gxold:"OV31Delete",gxvar:"AV31Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV31Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(28),gx.O.AV31Delete,gx.O.AV51Delete_GXI)},c2v:function(){gx.O.AV51Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV31Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV51Delete_GXI',nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DETAILID",gxz:"Z301BR_Medication_DetailID",gxold:"O301BR_Medication_DetailID",gxvar:"A301BR_Medication_DetailID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A301BR_Medication_DetailID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z301BR_Medication_DetailID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_DETAILID",row || gx.fn.currentGridRowImpl(28),gx.O.A301BR_Medication_DetailID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A301BR_Medication_DetailID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATION_DETAILID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_NAME",gxz:"Z310BR_Medication_Drug_Name",gxold:"O310BR_Medication_Drug_Name",gxvar:"A310BR_Medication_Drug_Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A310BR_Medication_Drug_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z310BR_Medication_Drug_Name=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_DRUG_NAME",row || gx.fn.currentGridRowImpl(28),gx.O.A310BR_Medication_Drug_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A310BR_Medication_Drug_Name=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_DRUG_NAME",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_NUM",gxz:"Z311BR_Medication_Drug_Num",gxold:"O311BR_Medication_Drug_Num",gxvar:"A311BR_Medication_Drug_Num",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A311BR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z311BR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_DRUG_NUM",row || gx.fn.currentGridRowImpl(28),gx.O.A311BR_Medication_Drug_Num,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A311BR_Medication_Drug_Num=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_DRUG_NUM",row || gx.fn.currentGridRowImpl(28),',','.')},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_UNIT",gxz:"Z312BR_Medication_Drug_Unit",gxold:"O312BR_Medication_Drug_Unit",gxvar:"A312BR_Medication_Drug_Unit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A312BR_Medication_Drug_Unit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z312BR_Medication_Drug_Unit=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_DRUG_UNIT",row || gx.fn.currentGridRowImpl(28),gx.O.A312BR_Medication_Drug_Unit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A312BR_Medication_Drug_Unit=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_DRUG_UNIT",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE",gxz:"ZV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace",gxold:"OV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace",gxvar:"AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE",gx.O.AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE",gxz:"ZV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace",gxold:"OV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace",gxvar:"AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE",gx.O.AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE",gxz:"ZV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace",gxold:"OV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace",gxvar:"AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE",gx.O.AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_SCHEMEID",gxz:"Z296BR_Medication_SchemeID",gxold:"O296BR_Medication_SchemeID",gxvar:"A296BR_Medication_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z296BR_Medication_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_SCHEMEID",gx.O.A296BR_Medication_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_SCHEMEID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 49 , function() {
   });
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATIONID",gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICATIONID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[52]={ id:52 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.ZV33Display = "" ;
   this.OV33Display = "" ;
   this.ZV29Update = "" ;
   this.OV29Update = "" ;
   this.ZV31Delete = "" ;
   this.OV31Delete = "" ;
   this.Z301BR_Medication_DetailID = 0 ;
   this.O301BR_Medication_DetailID = 0 ;
   this.Z310BR_Medication_Drug_Name = "" ;
   this.O310BR_Medication_Drug_Name = "" ;
   this.Z311BR_Medication_Drug_Num = 0 ;
   this.O311BR_Medication_Drug_Num = 0 ;
   this.Z312BR_Medication_Drug_Unit = "" ;
   this.O312BR_Medication_Drug_Unit = "" ;
   this.AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.ZV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.OV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.ZV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.OV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.ZV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.OV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.A296BR_Medication_SchemeID = 0 ;
   this.Z296BR_Medication_SchemeID = 0 ;
   this.O296BR_Medication_SchemeID = 0 ;
   this.A119BR_MedicationID = 0 ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV26GridCurrentPage = 0 ;
   this.AV23DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.A296BR_Medication_SchemeID = 0 ;
   this.A119BR_MedicationID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV8BR_Medication_SchemeID = 0 ;
   this.AV36BR_MedicationID = 0 ;
   this.AV33Display = "" ;
   this.AV29Update = "" ;
   this.AV31Delete = "" ;
   this.A301BR_Medication_DetailID = 0 ;
   this.A310BR_Medication_Drug_Name = "" ;
   this.A311BR_Medication_Drug_Num = 0 ;
   this.A312BR_Medication_Drug_Unit = "" ;
   this.AV52Pgmname = "" ;
   this.AV30IsAuthorized_Update = false ;
   this.AV32IsAuthorized_Delete = false ;
   this.Events = {"e11512_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12512_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13512_client": ["DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED", true] ,"e14512_client": ["DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED", true] ,"e15512_client": ["DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED", true] ,"e16512_client": ["'DOINSERT'", true] ,"e20512_client": ["ENTER", true] ,"e21512_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV41BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV28GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'TitleControlIdToReplace'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'TitleControlIdToReplace'},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'TitleControlIdToReplace'},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Visible")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Visible")',ctrl:'BR_MEDICATIONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV23DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'gx.fn.getCtrlProperty("TABLEHEADER","Visible")',ctrl:'TABLEHEADER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'AV41BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV28GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'AV41BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV28GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV42ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV41BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV28GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV30IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV32IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV33Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV29Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV31Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV52Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV30IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV32IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_Medication_SchemeID", "vBR_MEDICATION_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV36BR_MedicationID", "vBR_MEDICATIONID", 0, "int", 18, 0);
   this.setVCMap("AV8BR_Medication_SchemeID", "vBR_MEDICATION_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV36BR_MedicationID", "vBR_MEDICATIONID", 0, "int", 18, 0);
   this.setVCMap("AV52Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV30IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV32IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_Medication_SchemeID", "vBR_MEDICATION_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV36BR_MedicationID", "vBR_MEDICATIONID", 0, "int", 18, 0);
   this.setVCMap("AV52Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV30IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV32IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar({rfrVar:"AV8BR_Medication_SchemeID"});
   GridContainer.addRefreshingVar({rfrVar:"AV36BR_MedicationID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar({rfrVar:"AV52Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV29Update", rfrProp:"Visible", gxAttId:"Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV31Delete", rfrProp:"Visible", gxAttId:"Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV30IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV32IsAuthorized_Delete"});
   this.Initialize( );
});
