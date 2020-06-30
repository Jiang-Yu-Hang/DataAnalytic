/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:45:41.64
*/
gx.evt.autoSkip = false;
gx.define('br_procedure_radioww', false, function () {
   this.ServerClass =  "br_procedure_radioww" ;
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
      this.AV59Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV59Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_PROCEDUREIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDUREIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus =  ""  ;
   };
   this.e11682_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12682_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13682_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14682_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDUREID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15682_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16682_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17682_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e21682_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e22682_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,43,44,45,47,49,51,53,55,56,57,58,59,60,61,62,63,64];
   this.GXLastCtrlId =64;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_procedure_radioww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(323,35,"BR_PROCEDURE_RADIOID","","","BR_Procedure_RadioID","int",0,"px",18,18,"right",null,[],323,"BR_Procedure_RadioID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(139,36,"BR_PROCEDUREID","","","BR_ProcedureID","int",0,"px",18,18,"right",null,[],139,"BR_ProcedureID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(324,37,"BR_PROCEDURE_RADIO_LOC","","","BR_Procedure_Radio_Loc","svchar",0,"px",100,80,"left",null,[],324,"BR_Procedure_Radio_Loc",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(325,38,"BR_PROCEDURE_RADIO_AMOUNT","","","BR_Procedure_Radio_Amount","svchar",0,"px",100,80,"left",null,[],325,"BR_Procedure_Radio_Amount",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 42, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11682_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12682_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_PROCEDURE_RADIOIDContainer = gx.uc.getNew(this, 46, 32, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_RADIOIDContainer", "Ddo_br_procedure_radioid", "DDO_BR_PROCEDURE_RADIOID");
   var DDO_BR_PROCEDURE_RADIOIDContainer = this.DDO_BR_PROCEDURE_RADIOIDContainer;
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_RADIOIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_RADIOIDContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_RADIOIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_RADIOIDContainer.addV2CFunction('AV16BR_Procedure_RadioIDTitleFilterData', "vBR_PROCEDURE_RADIOIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_RADIOIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Procedure_RadioIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_RADIOIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Procedure_RadioIDTitleFilterData); });
   DDO_BR_PROCEDURE_RADIOIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_RADIOIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_RADIOIDContainer.addEventHandler("OnOptionClicked", this.e13682_client);
   this.setUserControl(DDO_BR_PROCEDURE_RADIOIDContainer);
   this.DDO_BR_PROCEDUREIDContainer = gx.uc.getNew(this, 48, 47, "BootstrapDropDownOptions", "DDO_BR_PROCEDUREIDContainer", "Ddo_br_procedureid", "DDO_BR_PROCEDUREID");
   var DDO_BR_PROCEDUREIDContainer = this.DDO_BR_PROCEDUREIDContainer;
   DDO_BR_PROCEDUREIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDUREIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDUREIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDUREIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDUREIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDUREIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDUREIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDUREIDContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDUREIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDUREIDContainer.addV2CFunction('AV20BR_ProcedureIDTitleFilterData', "vBR_PROCEDUREIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDUREIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_ProcedureIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDUREIDTITLEFILTERDATA",UC.ParentObject.AV20BR_ProcedureIDTitleFilterData); });
   DDO_BR_PROCEDUREIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDUREIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDUREIDContainer.addEventHandler("OnOptionClicked", this.e14682_client);
   this.setUserControl(DDO_BR_PROCEDUREIDContainer);
   this.DDO_BR_PROCEDURE_RADIO_LOCContainer = gx.uc.getNew(this, 50, 47, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_RADIO_LOCContainer", "Ddo_br_procedure_radio_loc", "DDO_BR_PROCEDURE_RADIO_LOC");
   var DDO_BR_PROCEDURE_RADIO_LOCContainer = this.DDO_BR_PROCEDURE_RADIO_LOCContainer;
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("DataListProc", "Datalistproc", "BR_Procedure_RadioWWGetFilterData", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_RADIO_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_RADIO_LOCContainer.addV2CFunction('AV24BR_Procedure_Radio_LocTitleFilterData', "vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_RADIO_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Procedure_Radio_LocTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA",UC.ParentObject.AV24BR_Procedure_Radio_LocTitleFilterData); });
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_RADIO_LOCContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_RADIO_LOCContainer.addEventHandler("OnOptionClicked", this.e15682_client);
   this.setUserControl(DDO_BR_PROCEDURE_RADIO_LOCContainer);
   this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer = gx.uc.getNew(this, 52, 47, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_RADIO_AMOUNTContainer", "Ddo_br_procedure_radio_amount", "DDO_BR_PROCEDURE_RADIO_AMOUNT");
   var DDO_BR_PROCEDURE_RADIO_AMOUNTContainer = this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer;
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("DataListProc", "Datalistproc", "BR_Procedure_RadioWWGetFilterData", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.addV2CFunction('AV28BR_Procedure_Radio_AmountTitleFilterData', "vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Procedure_Radio_AmountTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA",UC.ParentObject.AV28BR_Procedure_Radio_AmountTitleFilterData); });
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.addEventHandler("OnOptionClicked", this.e16682_client);
   this.setUserControl(DDO_BR_PROCEDURE_RADIO_AMOUNTContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 54, 47, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV37Display",gxold:"OV37Display",gxvar:"AV37Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV37Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV37Display,gx.O.AV56Display_GXI)},c2v:function(){gx.O.AV56Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV37Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV56Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV38Update",gxold:"OV38Update",gxvar:"AV38Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV38Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV38Update,gx.O.AV57Update_GXI)},c2v:function(){gx.O.AV57Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV38Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV57Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV40Delete",gxold:"OV40Delete",gxvar:"AV40Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV40Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV40Delete,gx.O.AV58Delete_GXI)},c2v:function(){gx.O.AV58Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV40Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV58Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIOID",gxz:"Z323BR_Procedure_RadioID",gxold:"O323BR_Procedure_RadioID",gxvar:"A323BR_Procedure_RadioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A323BR_Procedure_RadioID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z323BR_Procedure_RadioID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_RADIOID",row || gx.fn.currentGridRowImpl(31),gx.O.A323BR_Procedure_RadioID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A323BR_Procedure_RadioID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PROCEDURE_RADIOID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z139BR_ProcedureID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDUREID",row || gx.fn.currentGridRowImpl(31),gx.O.A139BR_ProcedureID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PROCEDUREID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIO_LOC",gxz:"Z324BR_Procedure_Radio_Loc",gxold:"O324BR_Procedure_Radio_Loc",gxvar:"A324BR_Procedure_Radio_Loc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A324BR_Procedure_Radio_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z324BR_Procedure_Radio_Loc=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_RADIO_LOC",row || gx.fn.currentGridRowImpl(31),gx.O.A324BR_Procedure_Radio_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A324BR_Procedure_Radio_Loc=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PROCEDURE_RADIO_LOC",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIO_AMOUNT",gxz:"Z325BR_Procedure_Radio_Amount",gxold:"O325BR_Procedure_Radio_Amount",gxvar:"A325BR_Procedure_Radio_Amount",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A325BR_Procedure_Radio_Amount=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z325BR_Procedure_Radio_Amount=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_RADIO_AMOUNT",row || gx.fn.currentGridRowImpl(31),gx.O.A325BR_Procedure_Radio_Amount,0)},c2v:function(){if(this.val()!==undefined)gx.O.A325BR_Procedure_Radio_Amount=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PROCEDURE_RADIO_AMOUNT",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_ProcedureIDTitleControlIdToReplace",gxold:"OV23ddo_BR_ProcedureIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_ProcedureIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_ProcedureIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_ProcedureIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_ProcedureIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_ProcedureIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace",gxold:"OV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace",gxvar:"AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace",gxold:"OV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace",gxvar:"AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIOID",gxz:"ZV17TFBR_Procedure_RadioID",gxold:"OV17TFBR_Procedure_RadioID",gxvar:"AV17TFBR_Procedure_RadioID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Procedure_RadioID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Procedure_RadioID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIOID",gx.O.AV17TFBR_Procedure_RadioID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Procedure_RadioID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDURE_RADIOID",',')},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIOID_TO",gxz:"ZV18TFBR_Procedure_RadioID_To",gxold:"OV18TFBR_Procedure_RadioID_To",gxvar:"AV18TFBR_Procedure_RadioID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Procedure_RadioID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Procedure_RadioID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIOID_TO",gx.O.AV18TFBR_Procedure_RadioID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Procedure_RadioID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDURE_RADIOID_TO",',')},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDUREID",gxz:"ZV21TFBR_ProcedureID",gxold:"OV21TFBR_ProcedureID",gxvar:"AV21TFBR_ProcedureID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_ProcedureID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDUREID",gx.O.AV21TFBR_ProcedureID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_ProcedureID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDUREID",',')},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDUREID_TO",gxz:"ZV22TFBR_ProcedureID_To",gxold:"OV22TFBR_ProcedureID_To",gxvar:"AV22TFBR_ProcedureID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_ProcedureID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_ProcedureID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDUREID_TO",gx.O.AV22TFBR_ProcedureID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_ProcedureID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDUREID_TO",',')},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIO_LOC",gxz:"ZV25TFBR_Procedure_Radio_Loc",gxold:"OV25TFBR_Procedure_Radio_Loc",gxvar:"AV25TFBR_Procedure_Radio_Loc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_Procedure_Radio_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_Procedure_Radio_Loc=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIO_LOC",gx.O.AV25TFBR_Procedure_Radio_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_Procedure_Radio_Loc=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_RADIO_LOC")},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIO_LOC_SEL",gxz:"ZV26TFBR_Procedure_Radio_Loc_Sel",gxold:"OV26TFBR_Procedure_Radio_Loc_Sel",gxvar:"AV26TFBR_Procedure_Radio_Loc_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_Procedure_Radio_Loc_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_Procedure_Radio_Loc_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIO_LOC_SEL",gx.O.AV26TFBR_Procedure_Radio_Loc_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_Procedure_Radio_Loc_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_RADIO_LOC_SEL")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIO_AMOUNT",gxz:"ZV29TFBR_Procedure_Radio_Amount",gxold:"OV29TFBR_Procedure_Radio_Amount",gxvar:"AV29TFBR_Procedure_Radio_Amount",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Procedure_Radio_Amount=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Procedure_Radio_Amount=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIO_AMOUNT",gx.O.AV29TFBR_Procedure_Radio_Amount,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Procedure_Radio_Amount=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_RADIO_AMOUNT")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_RADIO_AMOUNT_SEL",gxz:"ZV43TFBR_Procedure_Radio_Amount_Sel",gxold:"OV43TFBR_Procedure_Radio_Amount_Sel",gxvar:"AV43TFBR_Procedure_Radio_Amount_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43TFBR_Procedure_Radio_Amount_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43TFBR_Procedure_Radio_Amount_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_RADIO_AMOUNT_SEL",gx.O.AV43TFBR_Procedure_Radio_Amount_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43TFBR_Procedure_Radio_Amount_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_RADIO_AMOUNT_SEL")},nac:gx.falseFn};
   this.ZV37Display = "" ;
   this.OV37Display = "" ;
   this.ZV38Update = "" ;
   this.OV38Update = "" ;
   this.ZV40Delete = "" ;
   this.OV40Delete = "" ;
   this.Z323BR_Procedure_RadioID = 0 ;
   this.O323BR_Procedure_RadioID = 0 ;
   this.Z139BR_ProcedureID = 0 ;
   this.O139BR_ProcedureID = 0 ;
   this.Z324BR_Procedure_Radio_Loc = "" ;
   this.O324BR_Procedure_Radio_Loc = "" ;
   this.Z325BR_Procedure_Radio_Amount = "" ;
   this.O325BR_Procedure_Radio_Amount = "" ;
   this.AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Procedure_RadioID = 0 ;
   this.ZV17TFBR_Procedure_RadioID = 0 ;
   this.OV17TFBR_Procedure_RadioID = 0 ;
   this.AV18TFBR_Procedure_RadioID_To = 0 ;
   this.ZV18TFBR_Procedure_RadioID_To = 0 ;
   this.OV18TFBR_Procedure_RadioID_To = 0 ;
   this.AV21TFBR_ProcedureID = 0 ;
   this.ZV21TFBR_ProcedureID = 0 ;
   this.OV21TFBR_ProcedureID = 0 ;
   this.AV22TFBR_ProcedureID_To = 0 ;
   this.ZV22TFBR_ProcedureID_To = 0 ;
   this.OV22TFBR_ProcedureID_To = 0 ;
   this.AV25TFBR_Procedure_Radio_Loc = "" ;
   this.ZV25TFBR_Procedure_Radio_Loc = "" ;
   this.OV25TFBR_Procedure_Radio_Loc = "" ;
   this.AV26TFBR_Procedure_Radio_Loc_Sel = "" ;
   this.ZV26TFBR_Procedure_Radio_Loc_Sel = "" ;
   this.OV26TFBR_Procedure_Radio_Loc_Sel = "" ;
   this.AV29TFBR_Procedure_Radio_Amount = "" ;
   this.ZV29TFBR_Procedure_Radio_Amount = "" ;
   this.OV29TFBR_Procedure_Radio_Amount = "" ;
   this.AV43TFBR_Procedure_Radio_Amount_Sel = "" ;
   this.ZV43TFBR_Procedure_Radio_Amount_Sel = "" ;
   this.OV43TFBR_Procedure_Radio_Amount_Sel = "" ;
   this.AV34GridCurrentPage = 0 ;
   this.AV32DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Procedure_RadioID = 0 ;
   this.AV18TFBR_Procedure_RadioID_To = 0 ;
   this.AV21TFBR_ProcedureID = 0 ;
   this.AV22TFBR_ProcedureID_To = 0 ;
   this.AV25TFBR_Procedure_Radio_Loc = "" ;
   this.AV26TFBR_Procedure_Radio_Loc_Sel = "" ;
   this.AV29TFBR_Procedure_Radio_Amount = "" ;
   this.AV43TFBR_Procedure_Radio_Amount_Sel = "" ;
   this.AV37Display = "" ;
   this.AV38Update = "" ;
   this.AV40Delete = "" ;
   this.A323BR_Procedure_RadioID = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.A324BR_Procedure_Radio_Loc = "" ;
   this.A325BR_Procedure_Radio_Amount = "" ;
   this.AV59Pgmname = "" ;
   this.AV39IsAuthorized_Update = false ;
   this.AV41IsAuthorized_Delete = false ;
   this.Events = {"e11682_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12682_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13682_client": ["DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED", true] ,"e14682_client": ["DDO_BR_PROCEDUREID.ONOPTIONCLICKED", true] ,"e15682_client": ["DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED", true] ,"e16682_client": ["DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED", true] ,"e17682_client": ["'DOINSERT'", true] ,"e21682_client": ["ENTER", true] ,"e22682_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Title")',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_LOC","Title")',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_AMOUNT","Title")',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIOID","Visible")',ctrl:'vTFBR_PROCEDURE_RADIOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIOID_TO","Visible")',ctrl:'vTFBR_PROCEDURE_RADIOID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDUREID","Visible")',ctrl:'vTFBR_PROCEDUREID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDUREID_TO","Visible")',ctrl:'vTFBR_PROCEDUREID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIO_LOC","Visible")',ctrl:'vTFBR_PROCEDURE_RADIO_LOC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIO_LOC_SEL","Visible")',ctrl:'vTFBR_PROCEDURE_RADIO_LOC_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIO_AMOUNT","Visible")',ctrl:'vTFBR_PROCEDURE_RADIO_AMOUNT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_RADIO_AMOUNT_SEL","Visible")',ctrl:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDUREIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDUREID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV32DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SelectedValue_set',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SelectedValue_set'},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'FilteredText_set'},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SelectedValue_set',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SelectedValue_set'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'FilteredText_set'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Title")',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_LOC","Title")',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_AMOUNT","Title")',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDUREID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Title")',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_LOC","Title")',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_AMOUNT","Title")',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SelectedValue_get',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Title")',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_LOC","Title")',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_AMOUNT","Title")',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SelectedValue_get',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIO_AMOUNTContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_RADIOIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_RADIO_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Title")',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_LOC","Title")',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_AMOUNT","Title")',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A323BR_Procedure_RadioID',fld:'BR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV38Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIO_LOC","Link")',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A323BR_Procedure_RadioID',fld:'BR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV59Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV59Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV59Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar({rfrVar:"AV59Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV39IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV41IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_procedure_radioww);
