/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:5:39.96
*/
gx.evt.autoSkip = false;
gx.define('br_schemeww', false, function () {
   this.ServerClass =  "br_schemeww" ;
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
      this.AV68Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV47IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV49IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV68Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV47IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV49IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_SCHEMEIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_SCHEMEIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus =  ""  ;
      this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus =  ""  ;
      this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus =  ""  ;
      this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus =  ""  ;
   };
   this.e116e2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e126e2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e136e2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEMEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e146e2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e156e2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e166e2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e176e2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e186e2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e196e2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e236e2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e246e2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,49,51,53,55,57,59,61,62,63,64,65,66,67,68,69,70,71,72,73,74];
   this.GXLastCtrlId =74;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_schemeww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(327,35,"BR_SCHEMEID","","","BR_SchemeID","int",0,"px",18,18,"right",null,[],327,"BR_SchemeID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(19,36,"BR_ENCOUNTERID","","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(328,37,"BR_SCHEME_CHEM_REGIMENS","","","BR_Scheme_Chem_Regimens","svchar",0,"px",100,80,"left",null,[],328,"BR_Scheme_Chem_Regimens",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(329,38,"BR_SCHEME_THERAPY_LINE","","","BR_Scheme_Therapy_Line","svchar",0,"px",40,40,"left",null,[],329,"BR_Scheme_Therapy_Line",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(330,39,"BR_SCHEME_CHEM_CYCLE","","","BR_Scheme_Chem_Cycle","decimal",0,"px",15,15,"right",null,[],330,"BR_Scheme_Chem_Cycle",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(331,40,"BR_SCHEME_CHEM_DETAIL","","","BR_Scheme_Chem_Detail","svchar",0,"px",4000,80,"left",null,[],331,"BR_Scheme_Chem_Detail",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 44, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV42GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV42GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV44GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV44GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV43GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV43GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e116e2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e126e2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_SCHEMEIDContainer = gx.uc.getNew(this, 48, 32, "BootstrapDropDownOptions", "DDO_BR_SCHEMEIDContainer", "Ddo_br_schemeid", "DDO_BR_SCHEMEID");
   var DDO_BR_SCHEMEIDContainer = this.DDO_BR_SCHEMEIDContainer;
   DDO_BR_SCHEMEIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEMEIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEMEIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEMEIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEMEIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEMEIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEMEIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_SCHEMEIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEMEIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEMEIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEMEIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEMEIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_SCHEMEIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_SCHEMEIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEMEIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEMEIDContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_SCHEMEIDContainer.addV2CFunction('AV16BR_SchemeIDTitleFilterData', "vBR_SCHEMEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_SchemeIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEMEIDTITLEFILTERDATA",UC.ParentObject.AV16BR_SchemeIDTitleFilterData); });
   DDO_BR_SCHEMEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEMEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEMEIDContainer.addEventHandler("OnOptionClicked", this.e136e2_client);
   this.setUserControl(DDO_BR_SCHEMEIDContainer);
   this.DDO_BR_ENCOUNTERIDContainer = gx.uc.getNew(this, 50, 49, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERIDContainer", "Ddo_br_encounterid", "DDO_BR_ENCOUNTERID");
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
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV20BR_EncounterIDTitleFilterData', "vBR_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV20BR_EncounterIDTitleFilterData); });
   DDO_BR_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e146e2_client);
   this.setUserControl(DDO_BR_ENCOUNTERIDContainer);
   this.DDO_BR_SCHEME_CHEM_REGIMENSContainer = gx.uc.getNew(this, 52, 49, "BootstrapDropDownOptions", "DDO_BR_SCHEME_CHEM_REGIMENSContainer", "Ddo_br_scheme_chem_regimens", "DDO_BR_SCHEME_CHEM_REGIMENS");
   var DDO_BR_SCHEME_CHEM_REGIMENSContainer = this.DDO_BR_SCHEME_CHEM_REGIMENSContainer;
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListProc", "Datalistproc", "BR_SchemeWWGetFilterData", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV24BR_Scheme_Chem_RegimensTitleFilterData', "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Scheme_Chem_RegimensTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA",UC.ParentObject.AV24BR_Scheme_Chem_RegimensTitleFilterData); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addEventHandler("OnOptionClicked", this.e156e2_client);
   this.setUserControl(DDO_BR_SCHEME_CHEM_REGIMENSContainer);
   this.DDO_BR_SCHEME_THERAPY_LINEContainer = gx.uc.getNew(this, 54, 49, "BootstrapDropDownOptions", "DDO_BR_SCHEME_THERAPY_LINEContainer", "Ddo_br_scheme_therapy_line", "DDO_BR_SCHEME_THERAPY_LINE");
   var DDO_BR_SCHEME_THERAPY_LINEContainer = this.DDO_BR_SCHEME_THERAPY_LINEContainer;
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("DataListProc", "Datalistproc", "BR_SchemeWWGetFilterData", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_THERAPY_LINEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_THERAPY_LINEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_THERAPY_LINEContainer.addV2CFunction('AV28BR_Scheme_Therapy_LineTitleFilterData', "vBR_SCHEME_THERAPY_LINETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_THERAPY_LINEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Scheme_Therapy_LineTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_THERAPY_LINETITLEFILTERDATA",UC.ParentObject.AV28BR_Scheme_Therapy_LineTitleFilterData); });
   DDO_BR_SCHEME_THERAPY_LINEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_THERAPY_LINEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_THERAPY_LINEContainer.addEventHandler("OnOptionClicked", this.e166e2_client);
   this.setUserControl(DDO_BR_SCHEME_THERAPY_LINEContainer);
   this.DDO_BR_SCHEME_CHEM_CYCLEContainer = gx.uc.getNew(this, 56, 49, "BootstrapDropDownOptions", "DDO_BR_SCHEME_CHEM_CYCLEContainer", "Ddo_br_scheme_chem_cycle", "DDO_BR_SCHEME_CHEM_CYCLE");
   var DDO_BR_SCHEME_CHEM_CYCLEContainer = this.DDO_BR_SCHEME_CHEM_CYCLEContainer;
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_CHEM_CYCLEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_CHEM_CYCLEContainer.addV2CFunction('AV32BR_Scheme_Chem_CycleTitleFilterData', "vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_CHEM_CYCLEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32BR_Scheme_Chem_CycleTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA",UC.ParentObject.AV32BR_Scheme_Chem_CycleTitleFilterData); });
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_CHEM_CYCLEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_CHEM_CYCLEContainer.addEventHandler("OnOptionClicked", this.e176e2_client);
   this.setUserControl(DDO_BR_SCHEME_CHEM_CYCLEContainer);
   this.DDO_BR_SCHEME_CHEM_DETAILContainer = gx.uc.getNew(this, 58, 49, "BootstrapDropDownOptions", "DDO_BR_SCHEME_CHEM_DETAILContainer", "Ddo_br_scheme_chem_detail", "DDO_BR_SCHEME_CHEM_DETAIL");
   var DDO_BR_SCHEME_CHEM_DETAILContainer = this.DDO_BR_SCHEME_CHEM_DETAILContainer;
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("DataListProc", "Datalistproc", "BR_SchemeWWGetFilterData", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_CHEM_DETAILContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_CHEM_DETAILContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_CHEM_DETAILContainer.addV2CFunction('AV36BR_Scheme_Chem_DetailTitleFilterData', "vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_CHEM_DETAILContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36BR_Scheme_Chem_DetailTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA",UC.ParentObject.AV36BR_Scheme_Chem_DetailTitleFilterData); });
   DDO_BR_SCHEME_CHEM_DETAILContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_CHEM_DETAILContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_CHEM_DETAILContainer.addEventHandler("OnOptionClicked", this.e186e2_client);
   this.setUserControl(DDO_BR_SCHEME_CHEM_DETAILContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 60, 49, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV45Display",gxold:"OV45Display",gxvar:"AV45Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV45Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV45Display,gx.O.AV65Display_GXI)},c2v:function(){gx.O.AV65Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV45Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV65Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV46Update",gxold:"OV46Update",gxvar:"AV46Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV46Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV46Update,gx.O.AV66Update_GXI)},c2v:function(){gx.O.AV66Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV46Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV66Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV48Delete",gxold:"OV48Delete",gxvar:"AV48Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV48Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV48Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV48Delete,gx.O.AV67Delete_GXI)},c2v:function(){gx.O.AV67Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV48Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV67Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z327BR_SchemeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEMEID",row || gx.fn.currentGridRowImpl(31),gx.O.A327BR_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_SCHEMEID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z328BR_Scheme_Chem_Regimens=Value},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(31),gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_THERAPY_LINE",gxz:"Z329BR_Scheme_Therapy_Line",gxold:"O329BR_Scheme_Therapy_Line",gxvar:"A329BR_Scheme_Therapy_Line",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A329BR_Scheme_Therapy_Line=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z329BR_Scheme_Therapy_Line=Value},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_THERAPY_LINE",row || gx.fn.currentGridRowImpl(31),gx.O.A329BR_Scheme_Therapy_Line,0)},c2v:function(){if(this.val()!==undefined)gx.O.A329BR_Scheme_Therapy_Line=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_SCHEME_THERAPY_LINE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_CYCLE",gxz:"Z330BR_Scheme_Chem_Cycle",gxold:"O330BR_Scheme_Chem_Cycle",gxvar:"A330BR_Scheme_Chem_Cycle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A330BR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z330BR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_SCHEME_CHEM_CYCLE",row || gx.fn.currentGridRowImpl(31),gx.O.A330BR_Scheme_Chem_Cycle,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A330BR_Scheme_Chem_Cycle=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_SCHEME_CHEM_CYCLE",row || gx.fn.currentGridRowImpl(31),',','.')},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_DETAIL",gxz:"Z331BR_Scheme_Chem_Detail",gxold:"O331BR_Scheme_Chem_Detail",gxvar:"A331BR_Scheme_Chem_Detail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A331BR_Scheme_Chem_Detail=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z331BR_Scheme_Chem_Detail=Value},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_CHEM_DETAIL",row || gx.fn.currentGridRowImpl(31),gx.O.A331BR_Scheme_Chem_Detail,0)},c2v:function(){if(this.val()!==undefined)gx.O.A331BR_Scheme_Chem_Detail=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_SCHEME_CHEM_DETAIL",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_SchemeIDTitleControlIdToReplace",gxold:"OV19ddo_BR_SchemeIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_SchemeIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_SchemeIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_SchemeIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_SchemeIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_SchemeIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_EncounterIDTitleControlIdToReplace",gxold:"OV23ddo_BR_EncounterIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxold:"OV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxvar:"AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace",gxold:"OV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace",gxvar:"AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace",gxold:"OV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace",gxvar:"AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE",gx.O.AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace",gxold:"OV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace",gxvar:"AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE",gx.O.AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEMEID",gxz:"ZV17TFBR_SchemeID",gxold:"OV17TFBR_SchemeID",gxvar:"AV17TFBR_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEMEID",gx.O.AV17TFBR_SchemeID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_SCHEMEID",',')},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEMEID_TO",gxz:"ZV18TFBR_SchemeID_To",gxold:"OV18TFBR_SchemeID_To",gxvar:"AV18TFBR_SchemeID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_SchemeID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_SchemeID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEMEID_TO",gx.O.AV18TFBR_SchemeID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_SchemeID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_SCHEMEID_TO",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID",gxz:"ZV21TFBR_EncounterID",gxold:"OV21TFBR_EncounterID",gxvar:"AV21TFBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID",gx.O.AV21TFBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID_TO",gxz:"ZV22TFBR_EncounterID_To",gxold:"OV22TFBR_EncounterID_To",gxvar:"AV22TFBR_EncounterID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_EncounterID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_EncounterID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID_TO",gx.O.AV22TFBR_EncounterID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_EncounterID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID_TO",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_REGIMENS",gxz:"ZV25TFBR_Scheme_Chem_Regimens",gxold:"OV25TFBR_Scheme_Chem_Regimens",gxvar:"AV25TFBR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_Scheme_Chem_Regimens=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_REGIMENS",gx.O.AV25TFBR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_Scheme_Chem_Regimens=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_REGIMENS")},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_REGIMENS_SEL",gxz:"ZV26TFBR_Scheme_Chem_Regimens_Sel",gxold:"OV26TFBR_Scheme_Chem_Regimens_Sel",gxvar:"AV26TFBR_Scheme_Chem_Regimens_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_Scheme_Chem_Regimens_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_Scheme_Chem_Regimens_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_REGIMENS_SEL",gx.O.AV26TFBR_Scheme_Chem_Regimens_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_Scheme_Chem_Regimens_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_REGIMENS_SEL")},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_THERAPY_LINE",gxz:"ZV29TFBR_Scheme_Therapy_Line",gxold:"OV29TFBR_Scheme_Therapy_Line",gxvar:"AV29TFBR_Scheme_Therapy_Line",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Scheme_Therapy_Line=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Scheme_Therapy_Line=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_THERAPY_LINE",gx.O.AV29TFBR_Scheme_Therapy_Line,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Scheme_Therapy_Line=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_THERAPY_LINE")},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_THERAPY_LINE_SEL",gxz:"ZV30TFBR_Scheme_Therapy_Line_Sel",gxold:"OV30TFBR_Scheme_Therapy_Line_Sel",gxvar:"AV30TFBR_Scheme_Therapy_Line_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_Scheme_Therapy_Line_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_Scheme_Therapy_Line_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_THERAPY_LINE_SEL",gx.O.AV30TFBR_Scheme_Therapy_Line_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_Scheme_Therapy_Line_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_THERAPY_LINE_SEL")},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_CYCLE",gxz:"ZV33TFBR_Scheme_Chem_Cycle",gxold:"OV33TFBR_Scheme_Chem_Cycle",gxvar:"AV33TFBR_Scheme_Chem_Cycle",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33TFBR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV33TFBR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_SCHEME_CHEM_CYCLE",gx.O.AV33TFBR_Scheme_Chem_Cycle,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV33TFBR_Scheme_Chem_Cycle=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_SCHEME_CHEM_CYCLE",',','.')},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_CYCLE_TO",gxz:"ZV34TFBR_Scheme_Chem_Cycle_To",gxold:"OV34TFBR_Scheme_Chem_Cycle_To",gxvar:"AV34TFBR_Scheme_Chem_Cycle_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34TFBR_Scheme_Chem_Cycle_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV34TFBR_Scheme_Chem_Cycle_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_SCHEME_CHEM_CYCLE_TO",gx.O.AV34TFBR_Scheme_Chem_Cycle_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV34TFBR_Scheme_Chem_Cycle_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_SCHEME_CHEM_CYCLE_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_DETAIL",gxz:"ZV37TFBR_Scheme_Chem_Detail",gxold:"OV37TFBR_Scheme_Chem_Detail",gxvar:"AV37TFBR_Scheme_Chem_Detail",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37TFBR_Scheme_Chem_Detail=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37TFBR_Scheme_Chem_Detail=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_DETAIL",gx.O.AV37TFBR_Scheme_Chem_Detail,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37TFBR_Scheme_Chem_Detail=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_DETAIL")},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_SCHEME_CHEM_DETAIL_SEL",gxz:"ZV38TFBR_Scheme_Chem_Detail_Sel",gxold:"OV38TFBR_Scheme_Chem_Detail_Sel",gxvar:"AV38TFBR_Scheme_Chem_Detail_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38TFBR_Scheme_Chem_Detail_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38TFBR_Scheme_Chem_Detail_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_SCHEME_CHEM_DETAIL_SEL",gx.O.AV38TFBR_Scheme_Chem_Detail_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV38TFBR_Scheme_Chem_Detail_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_SCHEME_CHEM_DETAIL_SEL")},nac:gx.falseFn};
   this.ZV45Display = "" ;
   this.OV45Display = "" ;
   this.ZV46Update = "" ;
   this.OV46Update = "" ;
   this.ZV48Delete = "" ;
   this.OV48Delete = "" ;
   this.Z327BR_SchemeID = 0 ;
   this.O327BR_SchemeID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z328BR_Scheme_Chem_Regimens = "" ;
   this.O328BR_Scheme_Chem_Regimens = "" ;
   this.Z329BR_Scheme_Therapy_Line = "" ;
   this.O329BR_Scheme_Therapy_Line = "" ;
   this.Z330BR_Scheme_Chem_Cycle = 0 ;
   this.O330BR_Scheme_Chem_Cycle = 0 ;
   this.Z331BR_Scheme_Chem_Detail = "" ;
   this.O331BR_Scheme_Chem_Detail = "" ;
   this.AV19ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = "" ;
   this.ZV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = "" ;
   this.OV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = "" ;
   this.ZV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = "" ;
   this.OV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_SchemeID = 0 ;
   this.ZV17TFBR_SchemeID = 0 ;
   this.OV17TFBR_SchemeID = 0 ;
   this.AV18TFBR_SchemeID_To = 0 ;
   this.ZV18TFBR_SchemeID_To = 0 ;
   this.OV18TFBR_SchemeID_To = 0 ;
   this.AV21TFBR_EncounterID = 0 ;
   this.ZV21TFBR_EncounterID = 0 ;
   this.OV21TFBR_EncounterID = 0 ;
   this.AV22TFBR_EncounterID_To = 0 ;
   this.ZV22TFBR_EncounterID_To = 0 ;
   this.OV22TFBR_EncounterID_To = 0 ;
   this.AV25TFBR_Scheme_Chem_Regimens = "" ;
   this.ZV25TFBR_Scheme_Chem_Regimens = "" ;
   this.OV25TFBR_Scheme_Chem_Regimens = "" ;
   this.AV26TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.ZV26TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.OV26TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.AV29TFBR_Scheme_Therapy_Line = "" ;
   this.ZV29TFBR_Scheme_Therapy_Line = "" ;
   this.OV29TFBR_Scheme_Therapy_Line = "" ;
   this.AV30TFBR_Scheme_Therapy_Line_Sel = "" ;
   this.ZV30TFBR_Scheme_Therapy_Line_Sel = "" ;
   this.OV30TFBR_Scheme_Therapy_Line_Sel = "" ;
   this.AV33TFBR_Scheme_Chem_Cycle = 0 ;
   this.ZV33TFBR_Scheme_Chem_Cycle = 0 ;
   this.OV33TFBR_Scheme_Chem_Cycle = 0 ;
   this.AV34TFBR_Scheme_Chem_Cycle_To = 0 ;
   this.ZV34TFBR_Scheme_Chem_Cycle_To = 0 ;
   this.OV34TFBR_Scheme_Chem_Cycle_To = 0 ;
   this.AV37TFBR_Scheme_Chem_Detail = "" ;
   this.ZV37TFBR_Scheme_Chem_Detail = "" ;
   this.OV37TFBR_Scheme_Chem_Detail = "" ;
   this.AV38TFBR_Scheme_Chem_Detail_Sel = "" ;
   this.ZV38TFBR_Scheme_Chem_Detail_Sel = "" ;
   this.OV38TFBR_Scheme_Chem_Detail_Sel = "" ;
   this.AV42GridCurrentPage = 0 ;
   this.AV40DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_SchemeID = 0 ;
   this.AV18TFBR_SchemeID_To = 0 ;
   this.AV21TFBR_EncounterID = 0 ;
   this.AV22TFBR_EncounterID_To = 0 ;
   this.AV25TFBR_Scheme_Chem_Regimens = "" ;
   this.AV26TFBR_Scheme_Chem_Regimens_Sel = "" ;
   this.AV29TFBR_Scheme_Therapy_Line = "" ;
   this.AV30TFBR_Scheme_Therapy_Line_Sel = "" ;
   this.AV33TFBR_Scheme_Chem_Cycle = 0 ;
   this.AV34TFBR_Scheme_Chem_Cycle_To = 0 ;
   this.AV37TFBR_Scheme_Chem_Detail = "" ;
   this.AV38TFBR_Scheme_Chem_Detail_Sel = "" ;
   this.AV45Display = "" ;
   this.AV46Update = "" ;
   this.AV48Delete = "" ;
   this.A327BR_SchemeID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.A329BR_Scheme_Therapy_Line = "" ;
   this.A330BR_Scheme_Chem_Cycle = 0 ;
   this.A331BR_Scheme_Chem_Detail = "" ;
   this.AV68Pgmname = "" ;
   this.AV47IsAuthorized_Update = false ;
   this.AV49IsAuthorized_Delete = false ;
   this.Events = {"e116e2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e126e2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e136e2_client": ["DDO_BR_SCHEMEID.ONOPTIONCLICKED", true] ,"e146e2_client": ["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e156e2_client": ["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", true] ,"e166e2_client": ["DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED", true] ,"e176e2_client": ["DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED", true] ,"e186e2_client": ["DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED", true] ,"e196e2_client": ["'DOINSERT'", true] ,"e236e2_client": ["ENTER", true] ,"e246e2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEMEID","Visible")',ctrl:'vTFBR_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEMEID_TO","Visible")',ctrl:'vTFBR_SCHEMEID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID","Visible")',ctrl:'vTFBR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID_TO","Visible")',ctrl:'vTFBR_ENCOUNTERID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_REGIMENS","Visible")',ctrl:'vTFBR_SCHEME_CHEM_REGIMENS',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_REGIMENS_SEL","Visible")',ctrl:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_THERAPY_LINE","Visible")',ctrl:'vTFBR_SCHEME_THERAPY_LINE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_THERAPY_LINE_SEL","Visible")',ctrl:'vTFBR_SCHEME_THERAPY_LINE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_CYCLE","Visible")',ctrl:'vTFBR_SCHEME_CHEM_CYCLE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_CYCLE_TO","Visible")',ctrl:'vTFBR_SCHEME_CHEM_CYCLE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_DETAIL","Visible")',ctrl:'vTFBR_SCHEME_CHEM_DETAIL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_SCHEME_CHEM_DETAIL_SEL","Visible")',ctrl:'vTFBR_SCHEME_CHEM_DETAIL_SEL',prop:'Visible'},{av:'this.DDO_BR_SCHEMEIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEMEID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'TitleControlIdToReplace'},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'TitleControlIdToReplace'},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV40DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SelectedValue_set',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SelectedValue_set'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'FilteredText_set'},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'FilteredText_set'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.FilteredTextTo_set',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'FilteredTextTo_set'},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SelectedValue_set',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SelectedValue_set'},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'FilteredText_set'},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SelectedValue_set',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_set'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.FilteredText_set',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_set'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredText_set',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredText_set'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_SCHEMEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredText_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEMEIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SelectedValue_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SelectedValue_get',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.FilteredTextTo_get',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'ActiveEventKey'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.FilteredText_get',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'FilteredText_get'},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SelectedValue_get',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_THERAPY_LINEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_SCHEME_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_THERAPY_LINE","Title")',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_CYCLE","Title")',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_DETAIL","Title")',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV45Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV46Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV48Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Link")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV68Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV49IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV68Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV49IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV68Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV49IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[68]);
   GridContainer.addRefreshingVar(this.GXValidFnc[69]);
   GridContainer.addRefreshingVar(this.GXValidFnc[70]);
   GridContainer.addRefreshingVar(this.GXValidFnc[71]);
   GridContainer.addRefreshingVar(this.GXValidFnc[72]);
   GridContainer.addRefreshingVar(this.GXValidFnc[73]);
   GridContainer.addRefreshingVar(this.GXValidFnc[74]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar({rfrVar:"AV68Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV47IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV49IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_schemeww);
