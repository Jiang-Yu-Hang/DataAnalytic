/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:4:54.36
*/
gx.evt.autoSkip = false;
gx.define('br_procedure_surgeryww', false, function () {
   this.ServerClass =  "br_procedure_surgeryww" ;
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
      this.AV58Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV58Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_PROCEDUREIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDUREIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus =  ""  ;
   };
   this.e11662_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12662_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13662_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14662_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDUREID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15662_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16662_client=function()
   {
      return this.executeServerEvent("DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17662_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e21662_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e22662_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,43,44,45,47,49,51,53,55,56,57,58,59,60,61,62,63,64];
   this.GXLastCtrlId =64;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_procedure_surgeryww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(320,35,"BR_PROCEDURE_SURGERYID","","","BR_Procedure_SurgeryID","int",0,"px",18,18,"right",null,[],320,"BR_Procedure_SurgeryID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(139,36,"BR_PROCEDUREID","","","BR_ProcedureID","int",0,"px",18,18,"right",null,[],139,"BR_ProcedureID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(321,37,"BR_PROCEDURE_SURGERY_NAME","","","BR_Procedure_Surgery_Name","svchar",0,"px",100,80,"left",null,[],321,"BR_Procedure_Surgery_Name",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(322,38,"BR_PROCEDURE_SURGERY_LOC","","","BR_Procedure_Surgery_Loc","svchar",0,"px",100,80,"left",null,[],322,"BR_Procedure_Surgery_Loc",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11662_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12662_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_PROCEDURE_SURGERYIDContainer = gx.uc.getNew(this, 46, 32, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_SURGERYIDContainer", "Ddo_br_procedure_surgeryid", "DDO_BR_PROCEDURE_SURGERYID");
   var DDO_BR_PROCEDURE_SURGERYIDContainer = this.DDO_BR_PROCEDURE_SURGERYIDContainer;
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_SURGERYIDContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_SURGERYIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_SURGERYIDContainer.addV2CFunction('AV16BR_Procedure_SurgeryIDTitleFilterData', "vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_SURGERYIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Procedure_SurgeryIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Procedure_SurgeryIDTitleFilterData); });
   DDO_BR_PROCEDURE_SURGERYIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_SURGERYIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_SURGERYIDContainer.addEventHandler("OnOptionClicked", this.e13662_client);
   this.setUserControl(DDO_BR_PROCEDURE_SURGERYIDContainer);
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
   DDO_BR_PROCEDUREIDContainer.addEventHandler("OnOptionClicked", this.e14662_client);
   this.setUserControl(DDO_BR_PROCEDUREIDContainer);
   this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer = gx.uc.getNew(this, 50, 47, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_SURGERY_NAMEContainer", "Ddo_br_procedure_surgery_name", "DDO_BR_PROCEDURE_SURGERY_NAME");
   var DDO_BR_PROCEDURE_SURGERY_NAMEContainer = this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer;
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("DataListProc", "Datalistproc", "BR_Procedure_SurgeryWWGetFilterData", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.addV2CFunction('AV24BR_Procedure_Surgery_NameTitleFilterData', "vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Procedure_Surgery_NameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA",UC.ParentObject.AV24BR_Procedure_Surgery_NameTitleFilterData); });
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_SURGERY_NAMEContainer.addEventHandler("OnOptionClicked", this.e15662_client);
   this.setUserControl(DDO_BR_PROCEDURE_SURGERY_NAMEContainer);
   this.DDO_BR_PROCEDURE_SURGERY_LOCContainer = gx.uc.getNew(this, 52, 47, "BootstrapDropDownOptions", "DDO_BR_PROCEDURE_SURGERY_LOCContainer", "Ddo_br_procedure_surgery_loc", "DDO_BR_PROCEDURE_SURGERY_LOC");
   var DDO_BR_PROCEDURE_SURGERY_LOCContainer = this.DDO_BR_PROCEDURE_SURGERY_LOCContainer;
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("DataListProc", "Datalistproc", "BR_Procedure_SurgeryWWGetFilterData", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.addV2CFunction('AV28BR_Procedure_Surgery_LocTitleFilterData', "vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Procedure_Surgery_LocTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA",UC.ParentObject.AV28BR_Procedure_Surgery_LocTitleFilterData); });
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PROCEDURE_SURGERY_LOCContainer.addEventHandler("OnOptionClicked", this.e16662_client);
   this.setUserControl(DDO_BR_PROCEDURE_SURGERY_LOCContainer);
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV37Display",gxold:"OV37Display",gxvar:"AV37Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV37Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV37Display,gx.O.AV55Display_GXI)},c2v:function(){gx.O.AV55Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV37Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV55Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV38Update",gxold:"OV38Update",gxvar:"AV38Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV38Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV38Update,gx.O.AV56Update_GXI)},c2v:function(){gx.O.AV56Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV38Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV56Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV40Delete",gxold:"OV40Delete",gxvar:"AV40Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV40Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV40Delete,gx.O.AV57Delete_GXI)},c2v:function(){gx.O.AV57Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV40Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV57Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERYID",gxz:"Z320BR_Procedure_SurgeryID",gxold:"O320BR_Procedure_SurgeryID",gxvar:"A320BR_Procedure_SurgeryID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A320BR_Procedure_SurgeryID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z320BR_Procedure_SurgeryID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_SURGERYID",row || gx.fn.currentGridRowImpl(31),gx.O.A320BR_Procedure_SurgeryID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A320BR_Procedure_SurgeryID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PROCEDURE_SURGERYID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z139BR_ProcedureID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDUREID",row || gx.fn.currentGridRowImpl(31),gx.O.A139BR_ProcedureID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PROCEDUREID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_NAME",gxz:"Z321BR_Procedure_Surgery_Name",gxold:"O321BR_Procedure_Surgery_Name",gxvar:"A321BR_Procedure_Surgery_Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A321BR_Procedure_Surgery_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z321BR_Procedure_Surgery_Name=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_SURGERY_NAME",row || gx.fn.currentGridRowImpl(31),gx.O.A321BR_Procedure_Surgery_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A321BR_Procedure_Surgery_Name=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PROCEDURE_SURGERY_NAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_LOC",gxz:"Z322BR_Procedure_Surgery_Loc",gxold:"O322BR_Procedure_Surgery_Loc",gxvar:"A322BR_Procedure_Surgery_Loc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A322BR_Procedure_Surgery_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z322BR_Procedure_Surgery_Loc=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PROCEDURE_SURGERY_LOC",row || gx.fn.currentGridRowImpl(31),gx.O.A322BR_Procedure_Surgery_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A322BR_Procedure_Surgery_Loc=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PROCEDURE_SURGERY_LOC",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_ProcedureIDTitleControlIdToReplace",gxold:"OV23ddo_BR_ProcedureIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_ProcedureIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_ProcedureIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_ProcedureIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_ProcedureIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_ProcedureIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace",gxold:"OV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace",gxvar:"AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace",gxold:"OV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace",gxvar:"AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_SURGERYID",gxz:"ZV17TFBR_Procedure_SurgeryID",gxold:"OV17TFBR_Procedure_SurgeryID",gxvar:"AV17TFBR_Procedure_SurgeryID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Procedure_SurgeryID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Procedure_SurgeryID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_SURGERYID",gx.O.AV17TFBR_Procedure_SurgeryID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Procedure_SurgeryID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDURE_SURGERYID",',')},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_SURGERYID_TO",gxz:"ZV18TFBR_Procedure_SurgeryID_To",gxold:"OV18TFBR_Procedure_SurgeryID_To",gxvar:"AV18TFBR_Procedure_SurgeryID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Procedure_SurgeryID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Procedure_SurgeryID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_SURGERYID_TO",gx.O.AV18TFBR_Procedure_SurgeryID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Procedure_SurgeryID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDURE_SURGERYID_TO",',')},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDUREID",gxz:"ZV21TFBR_ProcedureID",gxold:"OV21TFBR_ProcedureID",gxvar:"AV21TFBR_ProcedureID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_ProcedureID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDUREID",gx.O.AV21TFBR_ProcedureID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_ProcedureID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDUREID",',')},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDUREID_TO",gxz:"ZV22TFBR_ProcedureID_To",gxold:"OV22TFBR_ProcedureID_To",gxvar:"AV22TFBR_ProcedureID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_ProcedureID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_ProcedureID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDUREID_TO",gx.O.AV22TFBR_ProcedureID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_ProcedureID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PROCEDUREID_TO",',')},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_SURGERY_NAME",gxz:"ZV25TFBR_Procedure_Surgery_Name",gxold:"OV25TFBR_Procedure_Surgery_Name",gxvar:"AV25TFBR_Procedure_Surgery_Name",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_Procedure_Surgery_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_Procedure_Surgery_Name=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_SURGERY_NAME",gx.O.AV25TFBR_Procedure_Surgery_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_Procedure_Surgery_Name=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_SURGERY_NAME")},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_SURGERY_NAME_SEL",gxz:"ZV26TFBR_Procedure_Surgery_Name_Sel",gxold:"OV26TFBR_Procedure_Surgery_Name_Sel",gxvar:"AV26TFBR_Procedure_Surgery_Name_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_Procedure_Surgery_Name_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_Procedure_Surgery_Name_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_SURGERY_NAME_SEL",gx.O.AV26TFBR_Procedure_Surgery_Name_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_Procedure_Surgery_Name_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_SURGERY_NAME_SEL")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_SURGERY_LOC",gxz:"ZV29TFBR_Procedure_Surgery_Loc",gxold:"OV29TFBR_Procedure_Surgery_Loc",gxvar:"AV29TFBR_Procedure_Surgery_Loc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Procedure_Surgery_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Procedure_Surgery_Loc=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_SURGERY_LOC",gx.O.AV29TFBR_Procedure_Surgery_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Procedure_Surgery_Loc=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_SURGERY_LOC")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PROCEDURE_SURGERY_LOC_SEL",gxz:"ZV30TFBR_Procedure_Surgery_Loc_Sel",gxold:"OV30TFBR_Procedure_Surgery_Loc_Sel",gxvar:"AV30TFBR_Procedure_Surgery_Loc_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_Procedure_Surgery_Loc_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_Procedure_Surgery_Loc_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PROCEDURE_SURGERY_LOC_SEL",gx.O.AV30TFBR_Procedure_Surgery_Loc_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_Procedure_Surgery_Loc_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PROCEDURE_SURGERY_LOC_SEL")},nac:gx.falseFn};
   this.ZV37Display = "" ;
   this.OV37Display = "" ;
   this.ZV38Update = "" ;
   this.OV38Update = "" ;
   this.ZV40Delete = "" ;
   this.OV40Delete = "" ;
   this.Z320BR_Procedure_SurgeryID = 0 ;
   this.O320BR_Procedure_SurgeryID = 0 ;
   this.Z139BR_ProcedureID = 0 ;
   this.O139BR_ProcedureID = 0 ;
   this.Z321BR_Procedure_Surgery_Name = "" ;
   this.O321BR_Procedure_Surgery_Name = "" ;
   this.Z322BR_Procedure_Surgery_Loc = "" ;
   this.O322BR_Procedure_Surgery_Loc = "" ;
   this.AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Procedure_SurgeryID = 0 ;
   this.ZV17TFBR_Procedure_SurgeryID = 0 ;
   this.OV17TFBR_Procedure_SurgeryID = 0 ;
   this.AV18TFBR_Procedure_SurgeryID_To = 0 ;
   this.ZV18TFBR_Procedure_SurgeryID_To = 0 ;
   this.OV18TFBR_Procedure_SurgeryID_To = 0 ;
   this.AV21TFBR_ProcedureID = 0 ;
   this.ZV21TFBR_ProcedureID = 0 ;
   this.OV21TFBR_ProcedureID = 0 ;
   this.AV22TFBR_ProcedureID_To = 0 ;
   this.ZV22TFBR_ProcedureID_To = 0 ;
   this.OV22TFBR_ProcedureID_To = 0 ;
   this.AV25TFBR_Procedure_Surgery_Name = "" ;
   this.ZV25TFBR_Procedure_Surgery_Name = "" ;
   this.OV25TFBR_Procedure_Surgery_Name = "" ;
   this.AV26TFBR_Procedure_Surgery_Name_Sel = "" ;
   this.ZV26TFBR_Procedure_Surgery_Name_Sel = "" ;
   this.OV26TFBR_Procedure_Surgery_Name_Sel = "" ;
   this.AV29TFBR_Procedure_Surgery_Loc = "" ;
   this.ZV29TFBR_Procedure_Surgery_Loc = "" ;
   this.OV29TFBR_Procedure_Surgery_Loc = "" ;
   this.AV30TFBR_Procedure_Surgery_Loc_Sel = "" ;
   this.ZV30TFBR_Procedure_Surgery_Loc_Sel = "" ;
   this.OV30TFBR_Procedure_Surgery_Loc_Sel = "" ;
   this.AV34GridCurrentPage = 0 ;
   this.AV32DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_ProcedureIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Procedure_SurgeryID = 0 ;
   this.AV18TFBR_Procedure_SurgeryID_To = 0 ;
   this.AV21TFBR_ProcedureID = 0 ;
   this.AV22TFBR_ProcedureID_To = 0 ;
   this.AV25TFBR_Procedure_Surgery_Name = "" ;
   this.AV26TFBR_Procedure_Surgery_Name_Sel = "" ;
   this.AV29TFBR_Procedure_Surgery_Loc = "" ;
   this.AV30TFBR_Procedure_Surgery_Loc_Sel = "" ;
   this.AV37Display = "" ;
   this.AV38Update = "" ;
   this.AV40Delete = "" ;
   this.A320BR_Procedure_SurgeryID = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.A321BR_Procedure_Surgery_Name = "" ;
   this.A322BR_Procedure_Surgery_Loc = "" ;
   this.AV58Pgmname = "" ;
   this.AV39IsAuthorized_Update = false ;
   this.AV41IsAuthorized_Delete = false ;
   this.Events = {"e11662_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12662_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13662_client": ["DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED", true] ,"e14662_client": ["DDO_BR_PROCEDUREID.ONOPTIONCLICKED", true] ,"e15662_client": ["DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED", true] ,"e16662_client": ["DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED", true] ,"e17662_client": ["'DOINSERT'", true] ,"e21662_client": ["ENTER", true] ,"e22662_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERYID","Title")',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_NAME","Title")',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_LOC","Title")',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_SURGERYID","Visible")',ctrl:'vTFBR_PROCEDURE_SURGERYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_SURGERYID_TO","Visible")',ctrl:'vTFBR_PROCEDURE_SURGERYID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDUREID","Visible")',ctrl:'vTFBR_PROCEDUREID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDUREID_TO","Visible")',ctrl:'vTFBR_PROCEDUREID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_SURGERY_NAME","Visible")',ctrl:'vTFBR_PROCEDURE_SURGERY_NAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_SURGERY_NAME_SEL","Visible")',ctrl:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_SURGERY_LOC","Visible")',ctrl:'vTFBR_PROCEDURE_SURGERY_LOC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PROCEDURE_SURGERY_LOC_SEL","Visible")',ctrl:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDUREIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDUREID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV32DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SelectedValue_set',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SelectedValue_set'},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'FilteredText_set'},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SelectedValue_set',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SelectedValue_set'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'FilteredText_set'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.FilteredText_set',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'FilteredText_set'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERYID","Title")',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_NAME","Title")',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_LOC","Title")',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDUREID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDUREIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERYID","Title")',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_NAME","Title")',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_LOC","Title")',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SelectedValue_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERYID","Title")',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_NAME","Title")',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_LOC","Title")',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.ActiveEventKey',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'ActiveEventKey'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.FilteredText_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'FilteredText_get'},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SelectedValue_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERY_LOCContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'this.DDO_BR_PROCEDURE_SURGERYIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDUREIDContainer.SortedStatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'this.DDO_BR_PROCEDURE_SURGERY_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERYID","Title")',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Title")',ctrl:'BR_PROCEDUREID',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_NAME","Title")',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_LOC","Title")',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A320BR_Procedure_SurgeryID',fld:'BR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV38Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERY_NAME","Link")',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A320BR_Procedure_SurgeryID',fld:'BR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV58Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV58Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV58Pgmname", "vPGMNAME", 0, "char", 129, 0);
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
   GridContainer.addRefreshingVar({rfrVar:"AV58Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV39IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV41IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_procedure_surgeryww);
