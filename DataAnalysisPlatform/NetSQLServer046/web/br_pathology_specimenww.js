/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:2:30.24
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_specimenww', false, function () {
   this.ServerClass =  "br_pathology_specimenww" ;
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
      this.AV52Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV40IsAuthorized_BR_Pathology_Specimen_Name=gx.fn.getControlValue("vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME") ;
      this.AV52Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV39IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV40IsAuthorized_BR_Pathology_Specimen_Name=gx.fn.getControlValue("vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_PATHOLOGYIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGYIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SortedStatus =  ""  ;
   };
   this.e11532_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12532_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13532_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14532_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15532_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16532_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e20532_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e21532_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,42,43,44,46,48,50,52,53,54,55,56,57,58,59];
   this.GXLastCtrlId =59;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_pathology_specimenww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(274,35,"BR_PATHOLOGY_SPECIMENID","","","BR_Pathology_SpecimenID","int",0,"px",18,18,"right",null,[],274,"BR_Pathology_SpecimenID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(226,36,"BR_PATHOLOGYID","","","BR_PathologyID","int",0,"px",18,18,"right",null,[],226,"BR_PathologyID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(275,37,"BR_PATHOLOGY_SPECIMEN_NAME","","","BR_Pathology_Specimen_Name","svchar",0,"px",100,80,"left",null,[],275,"BR_Pathology_Specimen_Name",true,0,false,false,"Attribute",1,"WWColumn");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 41, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV30GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV30GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV32GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV32GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV31GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV31GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV31GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11532_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12532_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_PATHOLOGY_SPECIMENIDContainer = gx.uc.getNew(this, 45, 32, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_SPECIMENIDContainer", "Ddo_br_pathology_specimenid", "DDO_BR_PATHOLOGY_SPECIMENID");
   var DDO_BR_PATHOLOGY_SPECIMENIDContainer = this.DDO_BR_PATHOLOGY_SPECIMENIDContainer;
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.addV2CFunction('AV28DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV28DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.addV2CFunction('AV16BR_Pathology_SpecimenIDTitleFilterData', "vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Pathology_SpecimenIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Pathology_SpecimenIDTitleFilterData); });
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_SPECIMENIDContainer.addEventHandler("OnOptionClicked", this.e13532_client);
   this.setUserControl(DDO_BR_PATHOLOGY_SPECIMENIDContainer);
   this.DDO_BR_PATHOLOGYIDContainer = gx.uc.getNew(this, 47, 46, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGYIDContainer", "Ddo_br_pathologyid", "DDO_BR_PATHOLOGYID");
   var DDO_BR_PATHOLOGYIDContainer = this.DDO_BR_PATHOLOGYIDContainer;
   DDO_BR_PATHOLOGYIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGYIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGYIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGYIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGYIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGYIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PATHOLOGYIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PATHOLOGYIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PATHOLOGYIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PATHOLOGYIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PATHOLOGYIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGYIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGYIDContainer.addV2CFunction('AV28DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGYIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV28DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGYIDContainer.addV2CFunction('AV20BR_PathologyIDTitleFilterData', "vBR_PATHOLOGYIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGYIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_PathologyIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGYIDTITLEFILTERDATA",UC.ParentObject.AV20BR_PathologyIDTitleFilterData); });
   DDO_BR_PATHOLOGYIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGYIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGYIDContainer.addEventHandler("OnOptionClicked", this.e14532_client);
   this.setUserControl(DDO_BR_PATHOLOGYIDContainer);
   this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer = gx.uc.getNew(this, 49, 46, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer", "Ddo_br_pathology_specimen_name", "DDO_BR_PATHOLOGY_SPECIMEN_NAME");
   var DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer = this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer;
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("DataListProc", "Datalistproc", "BR_Pathology_SpecimenWWGetFilterData", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.addV2CFunction('AV28DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV28DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.addV2CFunction('AV24BR_Pathology_Specimen_NameTitleFilterData', "vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Pathology_Specimen_NameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA",UC.ParentObject.AV24BR_Pathology_Specimen_NameTitleFilterData); });
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.addEventHandler("OnOptionClicked", this.e15532_client);
   this.setUserControl(DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 51, 46, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV33Display",gxold:"OV33Display",gxvar:"AV33Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV33Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV33Display,gx.O.AV49Display_GXI)},c2v:function(){gx.O.AV49Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV33Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV49Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV34Update",gxold:"OV34Update",gxvar:"AV34Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV34Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV34Update,gx.O.AV50Update_GXI)},c2v:function(){gx.O.AV50Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV34Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV50Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV36Delete",gxold:"OV36Delete",gxvar:"AV36Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV36Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV36Delete,gx.O.AV51Delete_GXI)},c2v:function(){gx.O.AV51Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV36Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV51Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMENID",gxz:"Z274BR_Pathology_SpecimenID",gxold:"O274BR_Pathology_SpecimenID",gxvar:"A274BR_Pathology_SpecimenID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A274BR_Pathology_SpecimenID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z274BR_Pathology_SpecimenID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_SPECIMENID",row || gx.fn.currentGridRowImpl(31),gx.O.A274BR_Pathology_SpecimenID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A274BR_Pathology_SpecimenID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PATHOLOGY_SPECIMENID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z226BR_PathologyID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGYID",row || gx.fn.currentGridRowImpl(31),gx.O.A226BR_PathologyID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PATHOLOGYID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMEN_NAME",gxz:"Z275BR_Pathology_Specimen_Name",gxold:"O275BR_Pathology_Specimen_Name",gxvar:"A275BR_Pathology_Specimen_Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A275BR_Pathology_Specimen_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z275BR_Pathology_Specimen_Name=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_SPECIMEN_NAME",row || gx.fn.currentGridRowImpl(31),gx.O.A275BR_Pathology_Specimen_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A275BR_Pathology_Specimen_Name=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PATHOLOGY_SPECIMEN_NAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_PathologyIDTitleControlIdToReplace",gxold:"OV23ddo_BR_PathologyIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_PathologyIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_PathologyIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_PathologyIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_PathologyIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_PathologyIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace",gxold:"OV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace",gxvar:"AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_SPECIMENID",gxz:"ZV17TFBR_Pathology_SpecimenID",gxold:"OV17TFBR_Pathology_SpecimenID",gxvar:"AV17TFBR_Pathology_SpecimenID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Pathology_SpecimenID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Pathology_SpecimenID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_SPECIMENID",gx.O.AV17TFBR_Pathology_SpecimenID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Pathology_SpecimenID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGY_SPECIMENID",',')},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_SPECIMENID_TO",gxz:"ZV18TFBR_Pathology_SpecimenID_To",gxold:"OV18TFBR_Pathology_SpecimenID_To",gxvar:"AV18TFBR_Pathology_SpecimenID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Pathology_SpecimenID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Pathology_SpecimenID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_SPECIMENID_TO",gx.O.AV18TFBR_Pathology_SpecimenID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Pathology_SpecimenID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGY_SPECIMENID_TO",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGYID",gxz:"ZV21TFBR_PathologyID",gxold:"OV21TFBR_PathologyID",gxvar:"AV21TFBR_PathologyID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_PathologyID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGYID",gx.O.AV21TFBR_PathologyID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_PathologyID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGYID",',')},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGYID_TO",gxz:"ZV22TFBR_PathologyID_To",gxold:"OV22TFBR_PathologyID_To",gxvar:"AV22TFBR_PathologyID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_PathologyID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_PathologyID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGYID_TO",gx.O.AV22TFBR_PathologyID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_PathologyID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGYID_TO",',')},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_SPECIMEN_NAME",gxz:"ZV25TFBR_Pathology_Specimen_Name",gxold:"OV25TFBR_Pathology_Specimen_Name",gxvar:"AV25TFBR_Pathology_Specimen_Name",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_Pathology_Specimen_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_Pathology_Specimen_Name=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_SPECIMEN_NAME",gx.O.AV25TFBR_Pathology_Specimen_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_Pathology_Specimen_Name=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_SPECIMEN_NAME")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL",gxz:"ZV26TFBR_Pathology_Specimen_Name_Sel",gxold:"OV26TFBR_Pathology_Specimen_Name_Sel",gxvar:"AV26TFBR_Pathology_Specimen_Name_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_Pathology_Specimen_Name_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_Pathology_Specimen_Name_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL",gx.O.AV26TFBR_Pathology_Specimen_Name_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_Pathology_Specimen_Name_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL")},nac:gx.falseFn};
   this.ZV33Display = "" ;
   this.OV33Display = "" ;
   this.ZV34Update = "" ;
   this.OV34Update = "" ;
   this.ZV36Delete = "" ;
   this.OV36Delete = "" ;
   this.Z274BR_Pathology_SpecimenID = 0 ;
   this.O274BR_Pathology_SpecimenID = 0 ;
   this.Z226BR_PathologyID = 0 ;
   this.O226BR_PathologyID = 0 ;
   this.Z275BR_Pathology_Specimen_Name = "" ;
   this.O275BR_Pathology_Specimen_Name = "" ;
   this.AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Pathology_SpecimenID = 0 ;
   this.ZV17TFBR_Pathology_SpecimenID = 0 ;
   this.OV17TFBR_Pathology_SpecimenID = 0 ;
   this.AV18TFBR_Pathology_SpecimenID_To = 0 ;
   this.ZV18TFBR_Pathology_SpecimenID_To = 0 ;
   this.OV18TFBR_Pathology_SpecimenID_To = 0 ;
   this.AV21TFBR_PathologyID = 0 ;
   this.ZV21TFBR_PathologyID = 0 ;
   this.OV21TFBR_PathologyID = 0 ;
   this.AV22TFBR_PathologyID_To = 0 ;
   this.ZV22TFBR_PathologyID_To = 0 ;
   this.OV22TFBR_PathologyID_To = 0 ;
   this.AV25TFBR_Pathology_Specimen_Name = "" ;
   this.ZV25TFBR_Pathology_Specimen_Name = "" ;
   this.OV25TFBR_Pathology_Specimen_Name = "" ;
   this.AV26TFBR_Pathology_Specimen_Name_Sel = "" ;
   this.ZV26TFBR_Pathology_Specimen_Name_Sel = "" ;
   this.OV26TFBR_Pathology_Specimen_Name_Sel = "" ;
   this.AV30GridCurrentPage = 0 ;
   this.AV28DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Pathology_SpecimenID = 0 ;
   this.AV18TFBR_Pathology_SpecimenID_To = 0 ;
   this.AV21TFBR_PathologyID = 0 ;
   this.AV22TFBR_PathologyID_To = 0 ;
   this.AV25TFBR_Pathology_Specimen_Name = "" ;
   this.AV26TFBR_Pathology_Specimen_Name_Sel = "" ;
   this.AV33Display = "" ;
   this.AV34Update = "" ;
   this.AV36Delete = "" ;
   this.A274BR_Pathology_SpecimenID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.A275BR_Pathology_Specimen_Name = "" ;
   this.AV52Pgmname = "" ;
   this.AV39IsAuthorized_Display = false ;
   this.AV40IsAuthorized_BR_Pathology_Specimen_Name = false ;
   this.Events = {"e11532_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12532_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13532_client": ["DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED", true] ,"e14532_client": ["DDO_BR_PATHOLOGYID.ONOPTIONCLICKED", true] ,"e15532_client": ["DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED", true] ,"e16532_client": ["'DOINSERT'", true] ,"e20532_client": ["ENTER", true] ,"e21532_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true}],[{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMENID","Title")',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMEN_NAME","Title")',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_SPECIMENID","Visible")',ctrl:'vTFBR_PATHOLOGY_SPECIMENID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_SPECIMENID_TO","Visible")',ctrl:'vTFBR_PATHOLOGY_SPECIMENID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGYID","Visible")',ctrl:'vTFBR_PATHOLOGYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGYID_TO","Visible")',ctrl:'vTFBR_PATHOLOGYID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_SPECIMEN_NAME","Visible")',ctrl:'vTFBR_PATHOLOGY_SPECIMEN_NAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL","Visible")',ctrl:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGYIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGYID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV28DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'FilteredText_set'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'FilteredTextTo_set'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_set'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_set'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'FilteredText_set'},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SelectedValue_set',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SelectedValue_set'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMENID","Title")',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMEN_NAME","Title")',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGYID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'this.DDO_BR_PATHOLOGYIDContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMENID","Title")',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMEN_NAME","Title")',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SelectedValue_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_SPECIMENIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMENID","Title")',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMEN_NAME","Title")',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A274BR_Pathology_SpecimenID',fld:'BR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true}],[{av:'AV33Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV34Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV36Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMEN_NAME","Link")',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A274BR_Pathology_SpecimenID',fld:'BR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV52Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV40IsAuthorized_BR_Pathology_Specimen_Name", "vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", 0, "boolean", 4, 0);
   this.setVCMap("AV52Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV40IsAuthorized_BR_Pathology_Specimen_Name", "vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", 0, "boolean", 4, 0);
   this.setVCMap("AV52Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV39IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV40IsAuthorized_BR_Pathology_Specimen_Name", "vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar({rfrVar:"AV52Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV39IsAuthorized_Display"});
   GridContainer.addRefreshingVar({rfrVar:"AV40IsAuthorized_BR_Pathology_Specimen_Name"});
   this.Initialize( );
});
gx.createParentObj(br_pathology_specimenww);
