/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:2:15.33
*/
gx.evt.autoSkip = false;
gx.define('br_medication_detailww', false, function () {
   this.ServerClass =  "br_medication_detailww" ;
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
      this.AV74Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV43IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV45IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV74Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV43IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV45IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus =  ""  ;
   };
   this.e114w2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e124w2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e134w2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e144w2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e154w2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e164w2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e174w2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e184w2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e224w2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e234w2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,44,45,46,48,50,52,54,56,58,59,60,61,62,63,64,65,66,67,68,69];
   this.GXLastCtrlId =69;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_medication_detailww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(301,35,"BR_MEDICATION_DETAILID","","","BR_Medication_DetailID","int",0,"px",18,18,"right",null,[],301,"BR_Medication_DetailID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(296,36,"BR_MEDICATION_SCHEMEID","","","BR_Medication_SchemeID","int",0,"px",18,18,"right",null,[],296,"BR_Medication_SchemeID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(310,37,"BR_MEDICATION_DRUG_NAME","","","BR_Medication_Drug_Name","svchar",0,"px",40,40,"left",null,[],310,"BR_Medication_Drug_Name",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(311,38,"BR_MEDICATION_DRUG_NUM","","","BR_Medication_Drug_Num","decimal",0,"px",15,15,"right",null,[],311,"BR_Medication_Drug_Num",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(312,39,"BR_MEDICATION_DRUG_UNIT","","","BR_Medication_Drug_Unit","svchar",0,"px",40,40,"left",null,[],312,"BR_Medication_Drug_Unit",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 43, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV38GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV38GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV40GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV40GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV39GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV39GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e114w2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e124w2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICATION_DETAILIDContainer = gx.uc.getNew(this, 47, 32, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_DETAILIDContainer", "Ddo_br_medication_detailid", "DDO_BR_MEDICATION_DETAILID");
   var DDO_BR_MEDICATION_DETAILIDContainer = this.DDO_BR_MEDICATION_DETAILIDContainer;
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_DETAILIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DETAILIDContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DETAILIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DETAILIDContainer.addV2CFunction('AV16BR_Medication_DetailIDTitleFilterData', "vBR_MEDICATION_DETAILIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DETAILIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Medication_DetailIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DETAILIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Medication_DetailIDTitleFilterData); });
   DDO_BR_MEDICATION_DETAILIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DETAILIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DETAILIDContainer.addEventHandler("OnOptionClicked", this.e134w2_client);
   this.setUserControl(DDO_BR_MEDICATION_DETAILIDContainer);
   this.DDO_BR_MEDICATION_SCHEMEIDContainer = gx.uc.getNew(this, 49, 48, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_SCHEMEIDContainer", "Ddo_br_medication_schemeid", "DDO_BR_MEDICATION_SCHEMEID");
   var DDO_BR_MEDICATION_SCHEMEIDContainer = this.DDO_BR_MEDICATION_SCHEMEIDContainer;
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_SCHEMEIDContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_SCHEMEIDContainer.addV2CFunction('AV20BR_Medication_SchemeIDTitleFilterData', "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_Medication_SchemeIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA",UC.ParentObject.AV20BR_Medication_SchemeIDTitleFilterData); });
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_SCHEMEIDContainer.addEventHandler("OnOptionClicked", this.e144w2_client);
   this.setUserControl(DDO_BR_MEDICATION_SCHEMEIDContainer);
   this.DDO_BR_MEDICATION_DRUG_NAMEContainer = gx.uc.getNew(this, 51, 48, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_DRUG_NAMEContainer", "Ddo_br_medication_drug_name", "DDO_BR_MEDICATION_DRUG_NAME");
   var DDO_BR_MEDICATION_DRUG_NAMEContainer = this.DDO_BR_MEDICATION_DRUG_NAMEContainer;
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
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
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListProc", "Datalistproc", "BR_Medication_DetailWWGetFilterData", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addV2CFunction('AV47BR_Medication_Drug_NameTitleFilterData', "vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47BR_Medication_Drug_NameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA",UC.ParentObject.AV47BR_Medication_Drug_NameTitleFilterData); });
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DRUG_NAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DRUG_NAMEContainer.addEventHandler("OnOptionClicked", this.e154w2_client);
   this.setUserControl(DDO_BR_MEDICATION_DRUG_NAMEContainer);
   this.DDO_BR_MEDICATION_DRUG_NUMContainer = gx.uc.getNew(this, 53, 48, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_DRUG_NUMContainer", "Ddo_br_medication_drug_num", "DDO_BR_MEDICATION_DRUG_NUM");
   var DDO_BR_MEDICATION_DRUG_NUMContainer = this.DDO_BR_MEDICATION_DRUG_NUMContainer;
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
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
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
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
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DRUG_NUMContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DRUG_NUMContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DRUG_NUMContainer.addV2CFunction('AV51BR_Medication_Drug_NumTitleFilterData', "vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DRUG_NUMContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51BR_Medication_Drug_NumTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA",UC.ParentObject.AV51BR_Medication_Drug_NumTitleFilterData); });
   DDO_BR_MEDICATION_DRUG_NUMContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DRUG_NUMContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DRUG_NUMContainer.addEventHandler("OnOptionClicked", this.e164w2_client);
   this.setUserControl(DDO_BR_MEDICATION_DRUG_NUMContainer);
   this.DDO_BR_MEDICATION_DRUG_UNITContainer = gx.uc.getNew(this, 55, 48, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_DRUG_UNITContainer", "Ddo_br_medication_drug_unit", "DDO_BR_MEDICATION_DRUG_UNIT");
   var DDO_BR_MEDICATION_DRUG_UNITContainer = this.DDO_BR_MEDICATION_DRUG_UNITContainer;
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
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
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListProc", "Datalistproc", "BR_Medication_DetailWWGetFilterData", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_DRUG_UNITContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_DRUG_UNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_DRUG_UNITContainer.addV2CFunction('AV55BR_Medication_Drug_UnitTitleFilterData', "vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_DRUG_UNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV55BR_Medication_Drug_UnitTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA",UC.ParentObject.AV55BR_Medication_Drug_UnitTitleFilterData); });
   DDO_BR_MEDICATION_DRUG_UNITContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_DRUG_UNITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_DRUG_UNITContainer.addEventHandler("OnOptionClicked", this.e174w2_client);
   this.setUserControl(DDO_BR_MEDICATION_DRUG_UNITContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 57, 48, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV41Display",gxold:"OV41Display",gxvar:"AV41Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV41Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV41Display,gx.O.AV71Display_GXI)},c2v:function(){gx.O.AV71Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV41Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV71Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV42Update",gxold:"OV42Update",gxvar:"AV42Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV42Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV42Update,gx.O.AV72Update_GXI)},c2v:function(){gx.O.AV72Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV42Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV72Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV44Delete",gxold:"OV44Delete",gxvar:"AV44Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV44Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV44Delete,gx.O.AV73Delete_GXI)},c2v:function(){gx.O.AV73Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV44Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV73Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DETAILID",gxz:"Z301BR_Medication_DetailID",gxold:"O301BR_Medication_DetailID",gxvar:"A301BR_Medication_DetailID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A301BR_Medication_DetailID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z301BR_Medication_DetailID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_DETAILID",row || gx.fn.currentGridRowImpl(31),gx.O.A301BR_Medication_DetailID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A301BR_Medication_DetailID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATION_DETAILID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_SCHEMEID",gxz:"Z296BR_Medication_SchemeID",gxold:"O296BR_Medication_SchemeID",gxvar:"A296BR_Medication_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z296BR_Medication_SchemeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_SCHEMEID",row || gx.fn.currentGridRowImpl(31),gx.O.A296BR_Medication_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATION_SCHEMEID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_NAME",gxz:"Z310BR_Medication_Drug_Name",gxold:"O310BR_Medication_Drug_Name",gxvar:"A310BR_Medication_Drug_Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A310BR_Medication_Drug_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z310BR_Medication_Drug_Name=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_DRUG_NAME",row || gx.fn.currentGridRowImpl(31),gx.O.A310BR_Medication_Drug_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A310BR_Medication_Drug_Name=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_DRUG_NAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_NUM",gxz:"Z311BR_Medication_Drug_Num",gxold:"O311BR_Medication_Drug_Num",gxvar:"A311BR_Medication_Drug_Num",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A311BR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z311BR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_DRUG_NUM",row || gx.fn.currentGridRowImpl(31),gx.O.A311BR_Medication_Drug_Num,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A311BR_Medication_Drug_Num=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_DRUG_NUM",row || gx.fn.currentGridRowImpl(31),',','.')},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_UNIT",gxz:"Z312BR_Medication_Drug_Unit",gxold:"O312BR_Medication_Drug_Unit",gxvar:"A312BR_Medication_Drug_Unit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A312BR_Medication_Drug_Unit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z312BR_Medication_Drug_Unit=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_DRUG_UNIT",row || gx.fn.currentGridRowImpl(31),gx.O.A312BR_Medication_Drug_Unit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A312BR_Medication_Drug_Unit=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_DRUG_UNIT",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Medication_DetailIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Medication_DetailIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Medication_DetailIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace",gxold:"OV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE",gxz:"ZV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace",gxold:"OV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace",gxvar:"AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE",gx.O.AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE",gxz:"ZV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace",gxold:"OV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace",gxvar:"AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE",gx.O.AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE",gxz:"ZV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace",gxold:"OV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace",gxvar:"AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE",gx.O.AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DETAILID",gxz:"ZV17TFBR_Medication_DetailID",gxold:"OV17TFBR_Medication_DetailID",gxvar:"AV17TFBR_Medication_DetailID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Medication_DetailID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Medication_DetailID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_DETAILID",gx.O.AV17TFBR_Medication_DetailID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Medication_DetailID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATION_DETAILID",',')},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DETAILID_TO",gxz:"ZV18TFBR_Medication_DetailID_To",gxold:"OV18TFBR_Medication_DetailID_To",gxvar:"AV18TFBR_Medication_DetailID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Medication_DetailID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Medication_DetailID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_DETAILID_TO",gx.O.AV18TFBR_Medication_DetailID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Medication_DetailID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATION_DETAILID_TO",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_SCHEMEID",gxz:"ZV21TFBR_Medication_SchemeID",gxold:"OV21TFBR_Medication_SchemeID",gxvar:"AV21TFBR_Medication_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_Medication_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_Medication_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_SCHEMEID",gx.O.AV21TFBR_Medication_SchemeID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_Medication_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATION_SCHEMEID",',')},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_SCHEMEID_TO",gxz:"ZV22TFBR_Medication_SchemeID_To",gxold:"OV22TFBR_Medication_SchemeID_To",gxvar:"AV22TFBR_Medication_SchemeID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_Medication_SchemeID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_Medication_SchemeID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_SCHEMEID_TO",gx.O.AV22TFBR_Medication_SchemeID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_Medication_SchemeID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATION_SCHEMEID_TO",',')},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DRUG_NAME",gxz:"ZV48TFBR_Medication_Drug_Name",gxold:"OV48TFBR_Medication_Drug_Name",gxvar:"AV48TFBR_Medication_Drug_Name",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV48TFBR_Medication_Drug_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV48TFBR_Medication_Drug_Name=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_DRUG_NAME",gx.O.AV48TFBR_Medication_Drug_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV48TFBR_Medication_Drug_Name=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_DRUG_NAME")},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DRUG_NAME_SEL",gxz:"ZV49TFBR_Medication_Drug_Name_Sel",gxold:"OV49TFBR_Medication_Drug_Name_Sel",gxvar:"AV49TFBR_Medication_Drug_Name_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV49TFBR_Medication_Drug_Name_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV49TFBR_Medication_Drug_Name_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_DRUG_NAME_SEL",gx.O.AV49TFBR_Medication_Drug_Name_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV49TFBR_Medication_Drug_Name_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_DRUG_NAME_SEL")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DRUG_NUM",gxz:"ZV52TFBR_Medication_Drug_Num",gxold:"OV52TFBR_Medication_Drug_Num",gxvar:"AV52TFBR_Medication_Drug_Num",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV52TFBR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV52TFBR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_DRUG_NUM",gx.O.AV52TFBR_Medication_Drug_Num,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV52TFBR_Medication_Drug_Num=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_DRUG_NUM",',','.')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DRUG_NUM_TO",gxz:"ZV53TFBR_Medication_Drug_Num_To",gxold:"OV53TFBR_Medication_Drug_Num_To",gxvar:"AV53TFBR_Medication_Drug_Num_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV53TFBR_Medication_Drug_Num_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV53TFBR_Medication_Drug_Num_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_DRUG_NUM_TO",gx.O.AV53TFBR_Medication_Drug_Num_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV53TFBR_Medication_Drug_Num_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_DRUG_NUM_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DRUG_UNIT",gxz:"ZV56TFBR_Medication_Drug_Unit",gxold:"OV56TFBR_Medication_Drug_Unit",gxvar:"AV56TFBR_Medication_Drug_Unit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV56TFBR_Medication_Drug_Unit=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV56TFBR_Medication_Drug_Unit=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_DRUG_UNIT",gx.O.AV56TFBR_Medication_Drug_Unit,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV56TFBR_Medication_Drug_Unit=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_DRUG_UNIT")},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_DRUG_UNIT_SEL",gxz:"ZV57TFBR_Medication_Drug_Unit_Sel",gxold:"OV57TFBR_Medication_Drug_Unit_Sel",gxvar:"AV57TFBR_Medication_Drug_Unit_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV57TFBR_Medication_Drug_Unit_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV57TFBR_Medication_Drug_Unit_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_DRUG_UNIT_SEL",gx.O.AV57TFBR_Medication_Drug_Unit_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV57TFBR_Medication_Drug_Unit_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_DRUG_UNIT_SEL")},nac:gx.falseFn};
   this.ZV41Display = "" ;
   this.OV41Display = "" ;
   this.ZV42Update = "" ;
   this.OV42Update = "" ;
   this.ZV44Delete = "" ;
   this.OV44Delete = "" ;
   this.Z301BR_Medication_DetailID = 0 ;
   this.O301BR_Medication_DetailID = 0 ;
   this.Z296BR_Medication_SchemeID = 0 ;
   this.O296BR_Medication_SchemeID = 0 ;
   this.Z310BR_Medication_Drug_Name = "" ;
   this.O310BR_Medication_Drug_Name = "" ;
   this.Z311BR_Medication_Drug_Num = 0 ;
   this.O311BR_Medication_Drug_Num = 0 ;
   this.Z312BR_Medication_Drug_Unit = "" ;
   this.O312BR_Medication_Drug_Unit = "" ;
   this.AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.ZV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.OV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.ZV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.OV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.ZV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.OV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Medication_DetailID = 0 ;
   this.ZV17TFBR_Medication_DetailID = 0 ;
   this.OV17TFBR_Medication_DetailID = 0 ;
   this.AV18TFBR_Medication_DetailID_To = 0 ;
   this.ZV18TFBR_Medication_DetailID_To = 0 ;
   this.OV18TFBR_Medication_DetailID_To = 0 ;
   this.AV21TFBR_Medication_SchemeID = 0 ;
   this.ZV21TFBR_Medication_SchemeID = 0 ;
   this.OV21TFBR_Medication_SchemeID = 0 ;
   this.AV22TFBR_Medication_SchemeID_To = 0 ;
   this.ZV22TFBR_Medication_SchemeID_To = 0 ;
   this.OV22TFBR_Medication_SchemeID_To = 0 ;
   this.AV48TFBR_Medication_Drug_Name = "" ;
   this.ZV48TFBR_Medication_Drug_Name = "" ;
   this.OV48TFBR_Medication_Drug_Name = "" ;
   this.AV49TFBR_Medication_Drug_Name_Sel = "" ;
   this.ZV49TFBR_Medication_Drug_Name_Sel = "" ;
   this.OV49TFBR_Medication_Drug_Name_Sel = "" ;
   this.AV52TFBR_Medication_Drug_Num = 0 ;
   this.ZV52TFBR_Medication_Drug_Num = 0 ;
   this.OV52TFBR_Medication_Drug_Num = 0 ;
   this.AV53TFBR_Medication_Drug_Num_To = 0 ;
   this.ZV53TFBR_Medication_Drug_Num_To = 0 ;
   this.OV53TFBR_Medication_Drug_Num_To = 0 ;
   this.AV56TFBR_Medication_Drug_Unit = "" ;
   this.ZV56TFBR_Medication_Drug_Unit = "" ;
   this.OV56TFBR_Medication_Drug_Unit = "" ;
   this.AV57TFBR_Medication_Drug_Unit_Sel = "" ;
   this.ZV57TFBR_Medication_Drug_Unit_Sel = "" ;
   this.OV57TFBR_Medication_Drug_Unit_Sel = "" ;
   this.AV38GridCurrentPage = 0 ;
   this.AV36DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "" ;
   this.AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "" ;
   this.AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Medication_DetailID = 0 ;
   this.AV18TFBR_Medication_DetailID_To = 0 ;
   this.AV21TFBR_Medication_SchemeID = 0 ;
   this.AV22TFBR_Medication_SchemeID_To = 0 ;
   this.AV48TFBR_Medication_Drug_Name = "" ;
   this.AV49TFBR_Medication_Drug_Name_Sel = "" ;
   this.AV52TFBR_Medication_Drug_Num = 0 ;
   this.AV53TFBR_Medication_Drug_Num_To = 0 ;
   this.AV56TFBR_Medication_Drug_Unit = "" ;
   this.AV57TFBR_Medication_Drug_Unit_Sel = "" ;
   this.AV41Display = "" ;
   this.AV42Update = "" ;
   this.AV44Delete = "" ;
   this.A301BR_Medication_DetailID = 0 ;
   this.A296BR_Medication_SchemeID = 0 ;
   this.A310BR_Medication_Drug_Name = "" ;
   this.A311BR_Medication_Drug_Num = 0 ;
   this.A312BR_Medication_Drug_Unit = "" ;
   this.AV74Pgmname = "" ;
   this.AV43IsAuthorized_Update = false ;
   this.AV45IsAuthorized_Delete = false ;
   this.Events = {"e114w2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e124w2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e134w2_client": ["DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED", true] ,"e144w2_client": ["DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED", true] ,"e154w2_client": ["DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED", true] ,"e164w2_client": ["DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED", true] ,"e174w2_client": ["DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED", true] ,"e184w2_client": ["'DOINSERT'", true] ,"e224w2_client": ["ENTER", true] ,"e234w2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Title")',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DETAILID","Visible")',ctrl:'vTFBR_MEDICATION_DETAILID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DETAILID_TO","Visible")',ctrl:'vTFBR_MEDICATION_DETAILID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_SCHEMEID","Visible")',ctrl:'vTFBR_MEDICATION_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_SCHEMEID_TO","Visible")',ctrl:'vTFBR_MEDICATION_SCHEMEID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DRUG_NAME","Visible")',ctrl:'vTFBR_MEDICATION_DRUG_NAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DRUG_NAME_SEL","Visible")',ctrl:'vTFBR_MEDICATION_DRUG_NAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DRUG_NUM","Visible")',ctrl:'vTFBR_MEDICATION_DRUG_NUM',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DRUG_NUM_TO","Visible")',ctrl:'vTFBR_MEDICATION_DRUG_NUM_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DRUG_UNIT","Visible")',ctrl:'vTFBR_MEDICATION_DRUG_UNIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_DRUG_UNIT_SEL","Visible")',ctrl:'vTFBR_MEDICATION_DRUG_UNIT_SEL',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'TitleControlIdToReplace'},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'TitleControlIdToReplace'},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'TitleControlIdToReplace'},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV36DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SelectedValue_set'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'FilteredText_set'},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'FilteredTextTo_set'},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SelectedValue_set'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'FilteredText_set'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Title")',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Title")',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Title")',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Title")',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_DRUG_UNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_DETAILIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_DRUG_NUMContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Title")',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NAME","Title")',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_NUM","Title")',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DRUG_UNIT","Title")',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV41Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV42Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV44Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV74Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV43IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV45IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV74Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV43IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV45IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV74Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV43IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV45IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[68]);
   GridContainer.addRefreshingVar(this.GXValidFnc[69]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar({rfrVar:"AV74Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV43IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV45IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_medication_detailww);
