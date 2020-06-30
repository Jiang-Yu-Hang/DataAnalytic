/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:43:17.67
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_diagww', false, function () {
   this.ServerClass =  "br_pathology_diagww" ;
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
      this.AV98Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV75IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV77IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV98Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV75IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV77IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_PATHOLOGYIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 7 )
      {
         this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGYIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus =  ""  ;
      this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus =  ""  ;
   };
   this.e11552_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12552_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_DIAGID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_DIAG_TUMORTYPE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e19552_client=function()
   {
      return this.executeServerEvent("DDO_BR_PATHOLOGY_DIAG_TUMORGRADE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e20552_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e24552_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e25552_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,44,46,47,48,50,52,54,56,58,60,62,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79];
   this.GXLastCtrlId =79;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_pathology_diagww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(276,35,"BR_PATHOLOGY_DIAGID","","","BR_Pathology_DiagID","int",0,"px",18,18,"right",null,[],276,"BR_Pathology_DiagID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(226,36,"BR_PATHOLOGYID","","","BR_PathologyID","int",0,"px",18,18,"right",null,[],226,"BR_PathologyID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(277,37,"BR_PATHOLOGY_DIAG_LOC","","","BR_Pathology_Diag_Loc","svchar",0,"px",100,80,"left",null,[],277,"BR_Pathology_Diag_Loc",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(278,38,"BR_PATHOLOGY_DIAG_ORGAN","","","BR_Pathology_Diag_Organ","svchar",0,"px",100,80,"left",null,[],278,"BR_Pathology_Diag_Organ",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(279,39,"BR_PATHOLOGY_DIAG_TUMORTYPE","","","BR_Pathology_Diag_TumorType","svchar",0,"px",40,40,"left",null,[],279,"BR_Pathology_Diag_TumorType",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(280,40,"BR_PATHOLOGY_DIAG_TUMORSTAGE","","","BR_Pathology_Diag_TumorStage","svchar",0,"px",40,40,"left",null,[],280,"BR_Pathology_Diag_TumorStage",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(281,41,"BR_PATHOLOGY_DIAG_TUMORGRADE","","","BR_Pathology_Diag_TumorGrade","svchar",0,"px",40,40,"left",null,[],281,"BR_Pathology_Diag_TumorGrade",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 45, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV70GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV70GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV70GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV72GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV72GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV72GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV71GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV71GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV71GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11552_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12552_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_PATHOLOGY_DIAGIDContainer = gx.uc.getNew(this, 49, 32, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_DIAGIDContainer", "Ddo_br_pathology_diagid", "DDO_BR_PATHOLOGY_DIAGID");
   var DDO_BR_PATHOLOGY_DIAGIDContainer = this.DDO_BR_PATHOLOGY_DIAGIDContainer;
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_DIAGIDContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_DIAGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_DIAGIDContainer.addV2CFunction('AV16BR_Pathology_DiagIDTitleFilterData', "vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_DIAGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Pathology_DiagIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Pathology_DiagIDTitleFilterData); });
   DDO_BR_PATHOLOGY_DIAGIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_DIAGIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_DIAGIDContainer.addEventHandler("OnOptionClicked", this.e13552_client);
   this.setUserControl(DDO_BR_PATHOLOGY_DIAGIDContainer);
   this.DDO_BR_PATHOLOGYIDContainer = gx.uc.getNew(this, 51, 50, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGYIDContainer", "Ddo_br_pathologyid", "DDO_BR_PATHOLOGYID");
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
   DDO_BR_PATHOLOGYIDContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGYIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGYIDContainer.addV2CFunction('AV20BR_PathologyIDTitleFilterData', "vBR_PATHOLOGYIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGYIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_PathologyIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGYIDTITLEFILTERDATA",UC.ParentObject.AV20BR_PathologyIDTitleFilterData); });
   DDO_BR_PATHOLOGYIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGYIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGYIDContainer.addEventHandler("OnOptionClicked", this.e14552_client);
   this.setUserControl(DDO_BR_PATHOLOGYIDContainer);
   this.DDO_BR_PATHOLOGY_DIAG_LOCContainer = gx.uc.getNew(this, 53, 50, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_DIAG_LOCContainer", "Ddo_br_pathology_diag_loc", "DDO_BR_PATHOLOGY_DIAG_LOC");
   var DDO_BR_PATHOLOGY_DIAG_LOCContainer = this.DDO_BR_PATHOLOGY_DIAG_LOCContainer;
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("DataListProc", "Datalistproc", "BR_Pathology_DiagWWGetFilterData", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.addV2CFunction('AV24BR_Pathology_Diag_LocTitleFilterData', "vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Pathology_Diag_LocTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA",UC.ParentObject.AV24BR_Pathology_Diag_LocTitleFilterData); });
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_DIAG_LOCContainer.addEventHandler("OnOptionClicked", this.e15552_client);
   this.setUserControl(DDO_BR_PATHOLOGY_DIAG_LOCContainer);
   this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer = gx.uc.getNew(this, 55, 50, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_DIAG_ORGANContainer", "Ddo_br_pathology_diag_organ", "DDO_BR_PATHOLOGY_DIAG_ORGAN");
   var DDO_BR_PATHOLOGY_DIAG_ORGANContainer = this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer;
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("DataListProc", "Datalistproc", "BR_Pathology_DiagWWGetFilterData", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.addV2CFunction('AV28BR_Pathology_Diag_OrganTitleFilterData', "vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Pathology_Diag_OrganTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA",UC.ParentObject.AV28BR_Pathology_Diag_OrganTitleFilterData); });
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_DIAG_ORGANContainer.addEventHandler("OnOptionClicked", this.e16552_client);
   this.setUserControl(DDO_BR_PATHOLOGY_DIAG_ORGANContainer);
   this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer = gx.uc.getNew(this, 57, 50, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer", "Ddo_br_pathology_diag_tumortype", "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE");
   var DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer = this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer;
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("DataListProc", "Datalistproc", "BR_Pathology_DiagWWGetFilterData", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.addV2CFunction('AV32BR_Pathology_Diag_TumorTypeTitleFilterData', "vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32BR_Pathology_Diag_TumorTypeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA",UC.ParentObject.AV32BR_Pathology_Diag_TumorTypeTitleFilterData); });
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.addEventHandler("OnOptionClicked", this.e17552_client);
   this.setUserControl(DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer);
   this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer = gx.uc.getNew(this, 59, 50, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer", "Ddo_br_pathology_diag_tumorstage", "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE");
   var DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer = this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer;
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("DataListProc", "Datalistproc", "BR_Pathology_DiagWWGetFilterData", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.addV2CFunction('AV36BR_Pathology_Diag_TumorStageTitleFilterData', "vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36BR_Pathology_Diag_TumorStageTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA",UC.ParentObject.AV36BR_Pathology_Diag_TumorStageTitleFilterData); });
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.addEventHandler("OnOptionClicked", this.e18552_client);
   this.setUserControl(DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer);
   this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer = gx.uc.getNew(this, 61, 50, "BootstrapDropDownOptions", "DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer", "Ddo_br_pathology_diag_tumorgrade", "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE");
   var DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer = this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer;
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("DataListProc", "Datalistproc", "BR_Pathology_DiagWWGetFilterData", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.addV2CFunction('AV68DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV68DDO_TitleSettingsIcons); });
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.addV2CFunction('AV40BR_Pathology_Diag_TumorGradeTitleFilterData', "vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40BR_Pathology_Diag_TumorGradeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA",UC.ParentObject.AV40BR_Pathology_Diag_TumorGradeTitleFilterData); });
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.addEventHandler("OnOptionClicked", this.e19552_client);
   this.setUserControl(DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 63, 50, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV73Display",gxold:"OV73Display",gxvar:"AV73Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV73Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV73Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV73Display,gx.O.AV95Display_GXI)},c2v:function(){gx.O.AV95Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV73Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV95Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV74Update",gxold:"OV74Update",gxvar:"AV74Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV74Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV74Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV74Update,gx.O.AV96Update_GXI)},c2v:function(){gx.O.AV96Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV74Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV96Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV76Delete",gxold:"OV76Delete",gxvar:"AV76Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV76Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV76Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV76Delete,gx.O.AV97Delete_GXI)},c2v:function(){gx.O.AV97Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV76Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV97Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAGID",gxz:"Z276BR_Pathology_DiagID",gxold:"O276BR_Pathology_DiagID",gxvar:"A276BR_Pathology_DiagID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A276BR_Pathology_DiagID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z276BR_Pathology_DiagID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_DIAGID",row || gx.fn.currentGridRowImpl(31),gx.O.A276BR_Pathology_DiagID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A276BR_Pathology_DiagID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PATHOLOGY_DIAGID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z226BR_PathologyID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGYID",row || gx.fn.currentGridRowImpl(31),gx.O.A226BR_PathologyID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_PATHOLOGYID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_LOC",gxz:"Z277BR_Pathology_Diag_Loc",gxold:"O277BR_Pathology_Diag_Loc",gxvar:"A277BR_Pathology_Diag_Loc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A277BR_Pathology_Diag_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z277BR_Pathology_Diag_Loc=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_DIAG_LOC",row || gx.fn.currentGridRowImpl(31),gx.O.A277BR_Pathology_Diag_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A277BR_Pathology_Diag_Loc=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PATHOLOGY_DIAG_LOC",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_ORGAN",gxz:"Z278BR_Pathology_Diag_Organ",gxold:"O278BR_Pathology_Diag_Organ",gxvar:"A278BR_Pathology_Diag_Organ",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A278BR_Pathology_Diag_Organ=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z278BR_Pathology_Diag_Organ=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_DIAG_ORGAN",row || gx.fn.currentGridRowImpl(31),gx.O.A278BR_Pathology_Diag_Organ,0)},c2v:function(){if(this.val()!==undefined)gx.O.A278BR_Pathology_Diag_Organ=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PATHOLOGY_DIAG_ORGAN",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORTYPE",gxz:"Z279BR_Pathology_Diag_TumorType",gxold:"O279BR_Pathology_Diag_TumorType",gxvar:"A279BR_Pathology_Diag_TumorType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A279BR_Pathology_Diag_TumorType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z279BR_Pathology_Diag_TumorType=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_DIAG_TUMORTYPE",row || gx.fn.currentGridRowImpl(31),gx.O.A279BR_Pathology_Diag_TumorType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A279BR_Pathology_Diag_TumorType=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PATHOLOGY_DIAG_TUMORTYPE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORSTAGE",gxz:"Z280BR_Pathology_Diag_TumorStage",gxold:"O280BR_Pathology_Diag_TumorStage",gxvar:"A280BR_Pathology_Diag_TumorStage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A280BR_Pathology_Diag_TumorStage=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z280BR_Pathology_Diag_TumorStage=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_DIAG_TUMORSTAGE",row || gx.fn.currentGridRowImpl(31),gx.O.A280BR_Pathology_Diag_TumorStage,0)},c2v:function(){if(this.val()!==undefined)gx.O.A280BR_Pathology_Diag_TumorStage=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PATHOLOGY_DIAG_TUMORSTAGE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORGRADE",gxz:"Z281BR_Pathology_Diag_TumorGrade",gxold:"O281BR_Pathology_Diag_TumorGrade",gxvar:"A281BR_Pathology_Diag_TumorGrade",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A281BR_Pathology_Diag_TumorGrade=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z281BR_Pathology_Diag_TumorGrade=Value},v2c:function(row){gx.fn.setGridControlValue("BR_PATHOLOGY_DIAG_TUMORGRADE",row || gx.fn.currentGridRowImpl(31),gx.O.A281BR_Pathology_Diag_TumorGrade,0)},c2v:function(){if(this.val()!==undefined)gx.O.A281BR_Pathology_Diag_TumorGrade=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_PATHOLOGY_DIAG_TUMORGRADE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_PathologyIDTitleControlIdToReplace",gxold:"OV23ddo_BR_PathologyIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_PathologyIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_PathologyIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_PathologyIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_PathologyIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_PathologyIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace",gxold:"OV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace",gxvar:"AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace",gxold:"OV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace",gxvar:"AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace",gxold:"OV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace",gxvar:"AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE",gx.O.AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace",gxold:"OV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace",gxvar:"AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE",gx.O.AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE",gxz:"ZV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace",gxold:"OV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace",gxvar:"AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE",gx.O.AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAGID",gxz:"ZV17TFBR_Pathology_DiagID",gxold:"OV17TFBR_Pathology_DiagID",gxvar:"AV17TFBR_Pathology_DiagID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Pathology_DiagID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Pathology_DiagID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAGID",gx.O.AV17TFBR_Pathology_DiagID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Pathology_DiagID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGY_DIAGID",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAGID_TO",gxz:"ZV18TFBR_Pathology_DiagID_To",gxold:"OV18TFBR_Pathology_DiagID_To",gxvar:"AV18TFBR_Pathology_DiagID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Pathology_DiagID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Pathology_DiagID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAGID_TO",gx.O.AV18TFBR_Pathology_DiagID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Pathology_DiagID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGY_DIAGID_TO",',')},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGYID",gxz:"ZV21TFBR_PathologyID",gxold:"OV21TFBR_PathologyID",gxvar:"AV21TFBR_PathologyID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_PathologyID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGYID",gx.O.AV21TFBR_PathologyID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_PathologyID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGYID",',')},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGYID_TO",gxz:"ZV22TFBR_PathologyID_To",gxold:"OV22TFBR_PathologyID_To",gxvar:"AV22TFBR_PathologyID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_PathologyID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_PathologyID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGYID_TO",gx.O.AV22TFBR_PathologyID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_PathologyID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_PATHOLOGYID_TO",',')},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_LOC",gxz:"ZV25TFBR_Pathology_Diag_Loc",gxold:"OV25TFBR_Pathology_Diag_Loc",gxvar:"AV25TFBR_Pathology_Diag_Loc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_Pathology_Diag_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_Pathology_Diag_Loc=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_LOC",gx.O.AV25TFBR_Pathology_Diag_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_Pathology_Diag_Loc=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_LOC")},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_LOC_SEL",gxz:"ZV26TFBR_Pathology_Diag_Loc_Sel",gxold:"OV26TFBR_Pathology_Diag_Loc_Sel",gxvar:"AV26TFBR_Pathology_Diag_Loc_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_Pathology_Diag_Loc_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_Pathology_Diag_Loc_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_LOC_SEL",gx.O.AV26TFBR_Pathology_Diag_Loc_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_Pathology_Diag_Loc_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_LOC_SEL")},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_ORGAN",gxz:"ZV29TFBR_Pathology_Diag_Organ",gxold:"OV29TFBR_Pathology_Diag_Organ",gxvar:"AV29TFBR_Pathology_Diag_Organ",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Pathology_Diag_Organ=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Pathology_Diag_Organ=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_ORGAN",gx.O.AV29TFBR_Pathology_Diag_Organ,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Pathology_Diag_Organ=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_ORGAN")},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_ORGAN_SEL",gxz:"ZV30TFBR_Pathology_Diag_Organ_Sel",gxold:"OV30TFBR_Pathology_Diag_Organ_Sel",gxvar:"AV30TFBR_Pathology_Diag_Organ_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_Pathology_Diag_Organ_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_Pathology_Diag_Organ_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_ORGAN_SEL",gx.O.AV30TFBR_Pathology_Diag_Organ_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_Pathology_Diag_Organ_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_ORGAN_SEL")},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_TUMORTYPE",gxz:"ZV33TFBR_Pathology_Diag_TumorType",gxold:"OV33TFBR_Pathology_Diag_TumorType",gxvar:"AV33TFBR_Pathology_Diag_TumorType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33TFBR_Pathology_Diag_TumorType=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33TFBR_Pathology_Diag_TumorType=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_TUMORTYPE",gx.O.AV33TFBR_Pathology_Diag_TumorType,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33TFBR_Pathology_Diag_TumorType=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_TUMORTYPE")},nac:gx.falseFn};
   GXValidFnc[75]={ id:75 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL",gxz:"ZV34TFBR_Pathology_Diag_TumorType_Sel",gxold:"OV34TFBR_Pathology_Diag_TumorType_Sel",gxvar:"AV34TFBR_Pathology_Diag_TumorType_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34TFBR_Pathology_Diag_TumorType_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34TFBR_Pathology_Diag_TumorType_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL",gx.O.AV34TFBR_Pathology_Diag_TumorType_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34TFBR_Pathology_Diag_TumorType_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL")},nac:gx.falseFn};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_TUMORSTAGE",gxz:"ZV37TFBR_Pathology_Diag_TumorStage",gxold:"OV37TFBR_Pathology_Diag_TumorStage",gxvar:"AV37TFBR_Pathology_Diag_TumorStage",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37TFBR_Pathology_Diag_TumorStage=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37TFBR_Pathology_Diag_TumorStage=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_TUMORSTAGE",gx.O.AV37TFBR_Pathology_Diag_TumorStage,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37TFBR_Pathology_Diag_TumorStage=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_TUMORSTAGE")},nac:gx.falseFn};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL",gxz:"ZV38TFBR_Pathology_Diag_TumorStage_Sel",gxold:"OV38TFBR_Pathology_Diag_TumorStage_Sel",gxvar:"AV38TFBR_Pathology_Diag_TumorStage_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38TFBR_Pathology_Diag_TumorStage_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38TFBR_Pathology_Diag_TumorStage_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL",gx.O.AV38TFBR_Pathology_Diag_TumorStage_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV38TFBR_Pathology_Diag_TumorStage_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL")},nac:gx.falseFn};
   GXValidFnc[78]={ id:78 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_TUMORGRADE",gxz:"ZV41TFBR_Pathology_Diag_TumorGrade",gxold:"OV41TFBR_Pathology_Diag_TumorGrade",gxvar:"AV41TFBR_Pathology_Diag_TumorGrade",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41TFBR_Pathology_Diag_TumorGrade=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41TFBR_Pathology_Diag_TumorGrade=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_TUMORGRADE",gx.O.AV41TFBR_Pathology_Diag_TumorGrade,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41TFBR_Pathology_Diag_TumorGrade=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_TUMORGRADE")},nac:gx.falseFn};
   GXValidFnc[79]={ id:79 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL",gxz:"ZV42TFBR_Pathology_Diag_TumorGrade_Sel",gxold:"OV42TFBR_Pathology_Diag_TumorGrade_Sel",gxvar:"AV42TFBR_Pathology_Diag_TumorGrade_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV42TFBR_Pathology_Diag_TumorGrade_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42TFBR_Pathology_Diag_TumorGrade_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL",gx.O.AV42TFBR_Pathology_Diag_TumorGrade_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV42TFBR_Pathology_Diag_TumorGrade_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL")},nac:gx.falseFn};
   this.ZV73Display = "" ;
   this.OV73Display = "" ;
   this.ZV74Update = "" ;
   this.OV74Update = "" ;
   this.ZV76Delete = "" ;
   this.OV76Delete = "" ;
   this.Z276BR_Pathology_DiagID = 0 ;
   this.O276BR_Pathology_DiagID = 0 ;
   this.Z226BR_PathologyID = 0 ;
   this.O226BR_PathologyID = 0 ;
   this.Z277BR_Pathology_Diag_Loc = "" ;
   this.O277BR_Pathology_Diag_Loc = "" ;
   this.Z278BR_Pathology_Diag_Organ = "" ;
   this.O278BR_Pathology_Diag_Organ = "" ;
   this.Z279BR_Pathology_Diag_TumorType = "" ;
   this.O279BR_Pathology_Diag_TumorType = "" ;
   this.Z280BR_Pathology_Diag_TumorStage = "" ;
   this.O280BR_Pathology_Diag_TumorStage = "" ;
   this.Z281BR_Pathology_Diag_TumorGrade = "" ;
   this.O281BR_Pathology_Diag_TumorGrade = "" ;
   this.AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = "" ;
   this.ZV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = "" ;
   this.OV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = "" ;
   this.ZV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = "" ;
   this.OV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = "" ;
   this.ZV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = "" ;
   this.OV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Pathology_DiagID = 0 ;
   this.ZV17TFBR_Pathology_DiagID = 0 ;
   this.OV17TFBR_Pathology_DiagID = 0 ;
   this.AV18TFBR_Pathology_DiagID_To = 0 ;
   this.ZV18TFBR_Pathology_DiagID_To = 0 ;
   this.OV18TFBR_Pathology_DiagID_To = 0 ;
   this.AV21TFBR_PathologyID = 0 ;
   this.ZV21TFBR_PathologyID = 0 ;
   this.OV21TFBR_PathologyID = 0 ;
   this.AV22TFBR_PathologyID_To = 0 ;
   this.ZV22TFBR_PathologyID_To = 0 ;
   this.OV22TFBR_PathologyID_To = 0 ;
   this.AV25TFBR_Pathology_Diag_Loc = "" ;
   this.ZV25TFBR_Pathology_Diag_Loc = "" ;
   this.OV25TFBR_Pathology_Diag_Loc = "" ;
   this.AV26TFBR_Pathology_Diag_Loc_Sel = "" ;
   this.ZV26TFBR_Pathology_Diag_Loc_Sel = "" ;
   this.OV26TFBR_Pathology_Diag_Loc_Sel = "" ;
   this.AV29TFBR_Pathology_Diag_Organ = "" ;
   this.ZV29TFBR_Pathology_Diag_Organ = "" ;
   this.OV29TFBR_Pathology_Diag_Organ = "" ;
   this.AV30TFBR_Pathology_Diag_Organ_Sel = "" ;
   this.ZV30TFBR_Pathology_Diag_Organ_Sel = "" ;
   this.OV30TFBR_Pathology_Diag_Organ_Sel = "" ;
   this.AV33TFBR_Pathology_Diag_TumorType = "" ;
   this.ZV33TFBR_Pathology_Diag_TumorType = "" ;
   this.OV33TFBR_Pathology_Diag_TumorType = "" ;
   this.AV34TFBR_Pathology_Diag_TumorType_Sel = "" ;
   this.ZV34TFBR_Pathology_Diag_TumorType_Sel = "" ;
   this.OV34TFBR_Pathology_Diag_TumorType_Sel = "" ;
   this.AV37TFBR_Pathology_Diag_TumorStage = "" ;
   this.ZV37TFBR_Pathology_Diag_TumorStage = "" ;
   this.OV37TFBR_Pathology_Diag_TumorStage = "" ;
   this.AV38TFBR_Pathology_Diag_TumorStage_Sel = "" ;
   this.ZV38TFBR_Pathology_Diag_TumorStage_Sel = "" ;
   this.OV38TFBR_Pathology_Diag_TumorStage_Sel = "" ;
   this.AV41TFBR_Pathology_Diag_TumorGrade = "" ;
   this.ZV41TFBR_Pathology_Diag_TumorGrade = "" ;
   this.OV41TFBR_Pathology_Diag_TumorGrade = "" ;
   this.AV42TFBR_Pathology_Diag_TumorGrade_Sel = "" ;
   this.ZV42TFBR_Pathology_Diag_TumorGrade_Sel = "" ;
   this.OV42TFBR_Pathology_Diag_TumorGrade_Sel = "" ;
   this.AV70GridCurrentPage = 0 ;
   this.AV68DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_PathologyIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = "" ;
   this.AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Pathology_DiagID = 0 ;
   this.AV18TFBR_Pathology_DiagID_To = 0 ;
   this.AV21TFBR_PathologyID = 0 ;
   this.AV22TFBR_PathologyID_To = 0 ;
   this.AV25TFBR_Pathology_Diag_Loc = "" ;
   this.AV26TFBR_Pathology_Diag_Loc_Sel = "" ;
   this.AV29TFBR_Pathology_Diag_Organ = "" ;
   this.AV30TFBR_Pathology_Diag_Organ_Sel = "" ;
   this.AV33TFBR_Pathology_Diag_TumorType = "" ;
   this.AV34TFBR_Pathology_Diag_TumorType_Sel = "" ;
   this.AV37TFBR_Pathology_Diag_TumorStage = "" ;
   this.AV38TFBR_Pathology_Diag_TumorStage_Sel = "" ;
   this.AV41TFBR_Pathology_Diag_TumorGrade = "" ;
   this.AV42TFBR_Pathology_Diag_TumorGrade_Sel = "" ;
   this.AV73Display = "" ;
   this.AV74Update = "" ;
   this.AV76Delete = "" ;
   this.A276BR_Pathology_DiagID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.A277BR_Pathology_Diag_Loc = "" ;
   this.A278BR_Pathology_Diag_Organ = "" ;
   this.A279BR_Pathology_Diag_TumorType = "" ;
   this.A280BR_Pathology_Diag_TumorStage = "" ;
   this.A281BR_Pathology_Diag_TumorGrade = "" ;
   this.AV98Pgmname = "" ;
   this.AV75IsAuthorized_Update = false ;
   this.AV77IsAuthorized_Delete = false ;
   this.Events = {"e11552_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12552_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13552_client": ["DDO_BR_PATHOLOGY_DIAGID.ONOPTIONCLICKED", true] ,"e14552_client": ["DDO_BR_PATHOLOGYID.ONOPTIONCLICKED", true] ,"e15552_client": ["DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED", true] ,"e16552_client": ["DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED", true] ,"e17552_client": ["DDO_BR_PATHOLOGY_DIAG_TUMORTYPE.ONOPTIONCLICKED", true] ,"e18552_client": ["DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE.ONOPTIONCLICKED", true] ,"e19552_client": ["DDO_BR_PATHOLOGY_DIAG_TUMORGRADE.ONOPTIONCLICKED", true] ,"e20552_client": ["'DOINSERT'", true] ,"e24552_client": ["ENTER", true] ,"e25552_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAGID","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAGID_TO","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAGID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGYID","Visible")',ctrl:'vTFBR_PATHOLOGYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGYID_TO","Visible")',ctrl:'vTFBR_PATHOLOGYID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_LOC","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_LOC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_LOC_SEL","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_ORGAN","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_ORGAN',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_ORGAN_SEL","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_TUMORTYPE","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_TUMORSTAGE","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_TUMORGRADE","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL","Visible")',ctrl:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGYIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGYID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'TitleControlIdToReplace'},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'TitleControlIdToReplace'},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'TitleControlIdToReplace'},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV68DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SelectedValue_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SelectedValue_set'},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'FilteredText_set'},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SelectedValue_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SelectedValue_set'},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'FilteredText_set'},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SelectedValue_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SelectedValue_set'},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'FilteredText_set'},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SelectedValue_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SelectedValue_set'},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'FilteredText_set'},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SelectedValue_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SelectedValue_set'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'FilteredText_set'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_set'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.FilteredText_set',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'FilteredText_set'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_DIAGID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGYID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGYIDContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGYIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SelectedValue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SelectedValue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_DIAG_TUMORTYPE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SelectedValue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SelectedValue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_PATHOLOGY_DIAG_TUMORGRADE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.ActiveEventKey',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'ActiveEventKey'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.FilteredText_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'FilteredText_get'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SelectedValue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'this.DDO_BR_PATHOLOGY_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGYIDContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer.SortedStatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Title")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Title")',ctrl:'BR_PATHOLOGYID',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Title")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_ORGAN","Title")',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORTYPE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORSTAGE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_TUMORGRADE","Title")',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV73Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV74Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV76Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAG_LOC","Link")',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV98Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV75IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV77IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV98Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV75IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV77IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV98Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV75IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV77IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
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
   GridContainer.addRefreshingVar(this.GXValidFnc[75]);
   GridContainer.addRefreshingVar(this.GXValidFnc[76]);
   GridContainer.addRefreshingVar(this.GXValidFnc[77]);
   GridContainer.addRefreshingVar(this.GXValidFnc[78]);
   GridContainer.addRefreshingVar(this.GXValidFnc[79]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar({rfrVar:"AV98Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV75IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV77IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_pathology_diagww);
