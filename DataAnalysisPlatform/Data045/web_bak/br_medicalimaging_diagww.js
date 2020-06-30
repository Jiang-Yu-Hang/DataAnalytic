/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:42:35.53
*/
gx.evt.autoSkip = false;
gx.define('br_medicalimaging_diagww', false, function () {
   this.ServerClass =  "br_medicalimaging_diagww" ;
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
      this.AV70Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV47IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV43IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV45IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV48IsAuthorized_BR_MedicalImaging_Diag_Loc=gx.fn.getControlValue("vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC") ;
      this.AV70Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV47IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV43IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV45IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV48IsAuthorized_BR_MedicalImaging_Diag_Loc=gx.fn.getControlValue("vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus =  ""  ;
   };
   this.e114p2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e124p2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e134p2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e144p2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e154p2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e164p2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e174p2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e184p2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e194p2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e234p2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e244p2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,49,51,53,55,57,59,61,62,63,64,65,66,67,68,69,70,71,72,73,74];
   this.GXLastCtrlId =74;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_medicalimaging_diagww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(270,35,"BR_MEDICALIMAGING_DIAGID","","","BR_MedicalImaging_DiagID","int",0,"px",18,18,"right",null,[],270,"BR_MedicalImaging_DiagID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(225,36,"BR_MEDICALIMAGINGID","","","BR_MedicalImagingID","int",0,"px",18,18,"right",null,[],225,"BR_MedicalImagingID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(271,37,"BR_MEDICALIMAGING_DIAG_LOC","","","BR_MedicalImaging_Diag_Loc","svchar",0,"px",100,80,"left",null,[],271,"BR_MedicalImaging_Diag_Loc",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(272,38,"BR_MEDICALIMAGING_DIAG_ORGAN","","","BR_MedicalImaging_Diag_Organ","svchar",0,"px",100,80,"left",null,[],272,"BR_MedicalImaging_Diag_Organ",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(273,39,"BR_MEDICALIMAGING_DIAG_DIS","","","BR_MedicalImaging_Diag_Dis","svchar",0,"px",100,80,"left",null,[],273,"BR_MedicalImaging_Diag_Dis",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(517,40,"BR_MEDICALIMAGING_DIAG_NO","","","BR_MedicalImaging_Diag_No","int",0,"px",18,18,"right",null,[],517,"BR_MedicalImaging_Diag_No",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV38GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV38GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV40GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV40GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV39GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV39GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e114p2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e124p2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICALIMAGING_DIAGIDContainer = gx.uc.getNew(this, 48, 32, "BootstrapDropDownOptions", "DDO_BR_MEDICALIMAGING_DIAGIDContainer", "Ddo_br_medicalimaging_diagid", "DDO_BR_MEDICALIMAGING_DIAGID");
   var DDO_BR_MEDICALIMAGING_DIAGIDContainer = this.DDO_BR_MEDICALIMAGING_DIAGIDContainer;
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.addV2CFunction('AV16BR_MedicalImaging_DiagIDTitleFilterData', "vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_MedicalImaging_DiagIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA",UC.ParentObject.AV16BR_MedicalImaging_DiagIDTitleFilterData); });
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_DIAGIDContainer.addEventHandler("OnOptionClicked", this.e134p2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_DIAGIDContainer);
   this.DDO_BR_MEDICALIMAGINGIDContainer = gx.uc.getNew(this, 50, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICALIMAGINGIDContainer", "Ddo_br_medicalimagingid", "DDO_BR_MEDICALIMAGINGID");
   var DDO_BR_MEDICALIMAGINGIDContainer = this.DDO_BR_MEDICALIMAGINGIDContainer;
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGINGIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGINGIDContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGINGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGINGIDContainer.addV2CFunction('AV20BR_MedicalImagingIDTitleFilterData', "vBR_MEDICALIMAGINGIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGINGIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_MedicalImagingIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGINGIDTITLEFILTERDATA",UC.ParentObject.AV20BR_MedicalImagingIDTitleFilterData); });
   DDO_BR_MEDICALIMAGINGIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGINGIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGINGIDContainer.addEventHandler("OnOptionClicked", this.e144p2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGINGIDContainer);
   this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer = gx.uc.getNew(this, 52, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICALIMAGING_DIAG_LOCContainer", "Ddo_br_medicalimaging_diag_loc", "DDO_BR_MEDICALIMAGING_DIAG_LOC");
   var DDO_BR_MEDICALIMAGING_DIAG_LOCContainer = this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer;
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("DataListProc", "Datalistproc", "BR_MedicalImaging_DiagWWGetFilterData", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.addV2CFunction('AV24BR_MedicalImaging_Diag_LocTitleFilterData', "vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_MedicalImaging_Diag_LocTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA",UC.ParentObject.AV24BR_MedicalImaging_Diag_LocTitleFilterData); });
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.addEventHandler("OnOptionClicked", this.e154p2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_DIAG_LOCContainer);
   this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer = gx.uc.getNew(this, 54, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer", "Ddo_br_medicalimaging_diag_organ", "DDO_BR_MEDICALIMAGING_DIAG_ORGAN");
   var DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer = this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer;
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("DataListProc", "Datalistproc", "BR_MedicalImaging_DiagWWGetFilterData", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.addV2CFunction('AV28BR_MedicalImaging_Diag_OrganTitleFilterData', "vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_MedicalImaging_Diag_OrganTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA",UC.ParentObject.AV28BR_MedicalImaging_Diag_OrganTitleFilterData); });
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.addEventHandler("OnOptionClicked", this.e164p2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer);
   this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer = gx.uc.getNew(this, 56, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICALIMAGING_DIAG_DISContainer", "Ddo_br_medicalimaging_diag_dis", "DDO_BR_MEDICALIMAGING_DIAG_DIS");
   var DDO_BR_MEDICALIMAGING_DIAG_DISContainer = this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer;
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("DataListProc", "Datalistproc", "BR_MedicalImaging_DiagWWGetFilterData", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.addV2CFunction('AV32BR_MedicalImaging_Diag_DisTitleFilterData', "vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32BR_MedicalImaging_Diag_DisTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA",UC.ParentObject.AV32BR_MedicalImaging_Diag_DisTitleFilterData); });
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_DIAG_DISContainer.addEventHandler("OnOptionClicked", this.e174p2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_DIAG_DISContainer);
   this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer = gx.uc.getNew(this, 58, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICALIMAGING_DIAG_NOContainer", "Ddo_br_medicalimaging_diag_no", "DDO_BR_MEDICALIMAGING_DIAG_NO");
   var DDO_BR_MEDICALIMAGING_DIAG_NOContainer = this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer;
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.addV2CFunction('AV36DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV36DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.addV2CFunction('AV49BR_MedicalImaging_Diag_NoTitleFilterData', "vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV49BR_MedicalImaging_Diag_NoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA",UC.ParentObject.AV49BR_MedicalImaging_Diag_NoTitleFilterData); });
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_DIAG_NOContainer.addEventHandler("OnOptionClicked", this.e184p2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_DIAG_NOContainer);
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV41Display",gxold:"OV41Display",gxvar:"AV41Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV41Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV41Display,gx.O.AV67Display_GXI)},c2v:function(){gx.O.AV67Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV41Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV67Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV42Update",gxold:"OV42Update",gxvar:"AV42Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV42Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV42Update,gx.O.AV68Update_GXI)},c2v:function(){gx.O.AV68Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV42Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV68Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV44Delete",gxold:"OV44Delete",gxvar:"AV44Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV44Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV44Delete,gx.O.AV69Delete_GXI)},c2v:function(){gx.O.AV69Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV44Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV69Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAGID",gxz:"Z270BR_MedicalImaging_DiagID",gxold:"O270BR_MedicalImaging_DiagID",gxvar:"A270BR_MedicalImaging_DiagID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A270BR_MedicalImaging_DiagID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z270BR_MedicalImaging_DiagID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_DIAGID",row || gx.fn.currentGridRowImpl(31),gx.O.A270BR_MedicalImaging_DiagID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A270BR_MedicalImaging_DiagID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICALIMAGING_DIAGID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGINGID",gxz:"Z225BR_MedicalImagingID",gxold:"O225BR_MedicalImagingID",gxvar:"A225BR_MedicalImagingID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z225BR_MedicalImagingID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGINGID",row || gx.fn.currentGridRowImpl(31),gx.O.A225BR_MedicalImagingID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICALIMAGINGID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_LOC",gxz:"Z271BR_MedicalImaging_Diag_Loc",gxold:"O271BR_MedicalImaging_Diag_Loc",gxvar:"A271BR_MedicalImaging_Diag_Loc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A271BR_MedicalImaging_Diag_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z271BR_MedicalImaging_Diag_Loc=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_DIAG_LOC",row || gx.fn.currentGridRowImpl(31),gx.O.A271BR_MedicalImaging_Diag_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A271BR_MedicalImaging_Diag_Loc=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICALIMAGING_DIAG_LOC",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_ORGAN",gxz:"Z272BR_MedicalImaging_Diag_Organ",gxold:"O272BR_MedicalImaging_Diag_Organ",gxvar:"A272BR_MedicalImaging_Diag_Organ",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A272BR_MedicalImaging_Diag_Organ=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z272BR_MedicalImaging_Diag_Organ=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_DIAG_ORGAN",row || gx.fn.currentGridRowImpl(31),gx.O.A272BR_MedicalImaging_Diag_Organ,0)},c2v:function(){if(this.val()!==undefined)gx.O.A272BR_MedicalImaging_Diag_Organ=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICALIMAGING_DIAG_ORGAN",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_DIS",gxz:"Z273BR_MedicalImaging_Diag_Dis",gxold:"O273BR_MedicalImaging_Diag_Dis",gxvar:"A273BR_MedicalImaging_Diag_Dis",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A273BR_MedicalImaging_Diag_Dis=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z273BR_MedicalImaging_Diag_Dis=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_DIAG_DIS",row || gx.fn.currentGridRowImpl(31),gx.O.A273BR_MedicalImaging_Diag_Dis,0)},c2v:function(){if(this.val()!==undefined)gx.O.A273BR_MedicalImaging_Diag_Dis=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICALIMAGING_DIAG_DIS",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_NO",gxz:"Z517BR_MedicalImaging_Diag_No",gxold:"O517BR_MedicalImaging_Diag_No",gxvar:"A517BR_MedicalImaging_Diag_No",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A517BR_MedicalImaging_Diag_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z517BR_MedicalImaging_Diag_No=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_DIAG_NO",row || gx.fn.currentGridRowImpl(31),gx.O.A517BR_MedicalImaging_Diag_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.A517BR_MedicalImaging_Diag_No=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICALIMAGING_DIAG_NO",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace",gxold:"OV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_MedicalImagingIDTitleControlIdToReplace",gxold:"OV23ddo_BR_MedicalImagingIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_MedicalImagingIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace",gxold:"OV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace",gxvar:"AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace",gxold:"OV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace",gxvar:"AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace",gxold:"OV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace",gxvar:"AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE",gx.O.AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE",gxz:"ZV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace",gxold:"OV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace",gxvar:"AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE",gx.O.AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAGID",gxz:"ZV17TFBR_MedicalImaging_DiagID",gxold:"OV17TFBR_MedicalImaging_DiagID",gxvar:"AV17TFBR_MedicalImaging_DiagID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_MedicalImaging_DiagID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_MedicalImaging_DiagID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAGID",gx.O.AV17TFBR_MedicalImaging_DiagID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_MedicalImaging_DiagID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGING_DIAGID",',')},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAGID_TO",gxz:"ZV18TFBR_MedicalImaging_DiagID_To",gxold:"OV18TFBR_MedicalImaging_DiagID_To",gxvar:"AV18TFBR_MedicalImaging_DiagID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_MedicalImaging_DiagID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_MedicalImaging_DiagID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAGID_TO",gx.O.AV18TFBR_MedicalImaging_DiagID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_MedicalImaging_DiagID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGING_DIAGID_TO",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGINGID",gxz:"ZV21TFBR_MedicalImagingID",gxold:"OV21TFBR_MedicalImagingID",gxvar:"AV21TFBR_MedicalImagingID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_MedicalImagingID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_MedicalImagingID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGINGID",gx.O.AV21TFBR_MedicalImagingID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_MedicalImagingID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGINGID",',')},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGINGID_TO",gxz:"ZV22TFBR_MedicalImagingID_To",gxold:"OV22TFBR_MedicalImagingID_To",gxvar:"AV22TFBR_MedicalImagingID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_MedicalImagingID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_MedicalImagingID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGINGID_TO",gx.O.AV22TFBR_MedicalImagingID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_MedicalImagingID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGINGID_TO",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_LOC",gxz:"ZV25TFBR_MedicalImaging_Diag_Loc",gxold:"OV25TFBR_MedicalImaging_Diag_Loc",gxvar:"AV25TFBR_MedicalImaging_Diag_Loc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_MedicalImaging_Diag_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_MedicalImaging_Diag_Loc=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_LOC",gx.O.AV25TFBR_MedicalImaging_Diag_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_MedicalImaging_Diag_Loc=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICALIMAGING_DIAG_LOC")},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_LOC_SEL",gxz:"ZV26TFBR_MedicalImaging_Diag_Loc_Sel",gxold:"OV26TFBR_MedicalImaging_Diag_Loc_Sel",gxvar:"AV26TFBR_MedicalImaging_Diag_Loc_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_MedicalImaging_Diag_Loc_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_MedicalImaging_Diag_Loc_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_LOC_SEL",gx.O.AV26TFBR_MedicalImaging_Diag_Loc_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_MedicalImaging_Diag_Loc_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICALIMAGING_DIAG_LOC_SEL")},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_ORGAN",gxz:"ZV29TFBR_MedicalImaging_Diag_Organ",gxold:"OV29TFBR_MedicalImaging_Diag_Organ",gxvar:"AV29TFBR_MedicalImaging_Diag_Organ",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_MedicalImaging_Diag_Organ=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_MedicalImaging_Diag_Organ=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_ORGAN",gx.O.AV29TFBR_MedicalImaging_Diag_Organ,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_MedicalImaging_Diag_Organ=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICALIMAGING_DIAG_ORGAN")},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL",gxz:"ZV30TFBR_MedicalImaging_Diag_Organ_Sel",gxold:"OV30TFBR_MedicalImaging_Diag_Organ_Sel",gxvar:"AV30TFBR_MedicalImaging_Diag_Organ_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_MedicalImaging_Diag_Organ_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_MedicalImaging_Diag_Organ_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL",gx.O.AV30TFBR_MedicalImaging_Diag_Organ_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_MedicalImaging_Diag_Organ_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL")},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_DIS",gxz:"ZV33TFBR_MedicalImaging_Diag_Dis",gxold:"OV33TFBR_MedicalImaging_Diag_Dis",gxvar:"AV33TFBR_MedicalImaging_Diag_Dis",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33TFBR_MedicalImaging_Diag_Dis=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33TFBR_MedicalImaging_Diag_Dis=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_DIS",gx.O.AV33TFBR_MedicalImaging_Diag_Dis,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33TFBR_MedicalImaging_Diag_Dis=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICALIMAGING_DIAG_DIS")},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_DIS_SEL",gxz:"ZV34TFBR_MedicalImaging_Diag_Dis_Sel",gxold:"OV34TFBR_MedicalImaging_Diag_Dis_Sel",gxvar:"AV34TFBR_MedicalImaging_Diag_Dis_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34TFBR_MedicalImaging_Diag_Dis_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34TFBR_MedicalImaging_Diag_Dis_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_DIS_SEL",gx.O.AV34TFBR_MedicalImaging_Diag_Dis_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34TFBR_MedicalImaging_Diag_Dis_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICALIMAGING_DIAG_DIS_SEL")},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_NO",gxz:"ZV50TFBR_MedicalImaging_Diag_No",gxold:"OV50TFBR_MedicalImaging_Diag_No",gxvar:"AV50TFBR_MedicalImaging_Diag_No",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV50TFBR_MedicalImaging_Diag_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV50TFBR_MedicalImaging_Diag_No=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_NO",gx.O.AV50TFBR_MedicalImaging_Diag_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV50TFBR_MedicalImaging_Diag_No=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGING_DIAG_NO",',')},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_DIAG_NO_TO",gxz:"ZV51TFBR_MedicalImaging_Diag_No_To",gxold:"OV51TFBR_MedicalImaging_Diag_No_To",gxvar:"AV51TFBR_MedicalImaging_Diag_No_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV51TFBR_MedicalImaging_Diag_No_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV51TFBR_MedicalImaging_Diag_No_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_DIAG_NO_TO",gx.O.AV51TFBR_MedicalImaging_Diag_No_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV51TFBR_MedicalImaging_Diag_No_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGING_DIAG_NO_TO",',')},nac:gx.falseFn};
   this.ZV41Display = "" ;
   this.OV41Display = "" ;
   this.ZV42Update = "" ;
   this.OV42Update = "" ;
   this.ZV44Delete = "" ;
   this.OV44Delete = "" ;
   this.Z270BR_MedicalImaging_DiagID = 0 ;
   this.O270BR_MedicalImaging_DiagID = 0 ;
   this.Z225BR_MedicalImagingID = 0 ;
   this.O225BR_MedicalImagingID = 0 ;
   this.Z271BR_MedicalImaging_Diag_Loc = "" ;
   this.O271BR_MedicalImaging_Diag_Loc = "" ;
   this.Z272BR_MedicalImaging_Diag_Organ = "" ;
   this.O272BR_MedicalImaging_Diag_Organ = "" ;
   this.Z273BR_MedicalImaging_Diag_Dis = "" ;
   this.O273BR_MedicalImaging_Diag_Dis = "" ;
   this.Z517BR_MedicalImaging_Diag_No = 0 ;
   this.O517BR_MedicalImaging_Diag_No = 0 ;
   this.AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = "" ;
   this.ZV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = "" ;
   this.OV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = "" ;
   this.AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = "" ;
   this.ZV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = "" ;
   this.OV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_MedicalImaging_DiagID = 0 ;
   this.ZV17TFBR_MedicalImaging_DiagID = 0 ;
   this.OV17TFBR_MedicalImaging_DiagID = 0 ;
   this.AV18TFBR_MedicalImaging_DiagID_To = 0 ;
   this.ZV18TFBR_MedicalImaging_DiagID_To = 0 ;
   this.OV18TFBR_MedicalImaging_DiagID_To = 0 ;
   this.AV21TFBR_MedicalImagingID = 0 ;
   this.ZV21TFBR_MedicalImagingID = 0 ;
   this.OV21TFBR_MedicalImagingID = 0 ;
   this.AV22TFBR_MedicalImagingID_To = 0 ;
   this.ZV22TFBR_MedicalImagingID_To = 0 ;
   this.OV22TFBR_MedicalImagingID_To = 0 ;
   this.AV25TFBR_MedicalImaging_Diag_Loc = "" ;
   this.ZV25TFBR_MedicalImaging_Diag_Loc = "" ;
   this.OV25TFBR_MedicalImaging_Diag_Loc = "" ;
   this.AV26TFBR_MedicalImaging_Diag_Loc_Sel = "" ;
   this.ZV26TFBR_MedicalImaging_Diag_Loc_Sel = "" ;
   this.OV26TFBR_MedicalImaging_Diag_Loc_Sel = "" ;
   this.AV29TFBR_MedicalImaging_Diag_Organ = "" ;
   this.ZV29TFBR_MedicalImaging_Diag_Organ = "" ;
   this.OV29TFBR_MedicalImaging_Diag_Organ = "" ;
   this.AV30TFBR_MedicalImaging_Diag_Organ_Sel = "" ;
   this.ZV30TFBR_MedicalImaging_Diag_Organ_Sel = "" ;
   this.OV30TFBR_MedicalImaging_Diag_Organ_Sel = "" ;
   this.AV33TFBR_MedicalImaging_Diag_Dis = "" ;
   this.ZV33TFBR_MedicalImaging_Diag_Dis = "" ;
   this.OV33TFBR_MedicalImaging_Diag_Dis = "" ;
   this.AV34TFBR_MedicalImaging_Diag_Dis_Sel = "" ;
   this.ZV34TFBR_MedicalImaging_Diag_Dis_Sel = "" ;
   this.OV34TFBR_MedicalImaging_Diag_Dis_Sel = "" ;
   this.AV50TFBR_MedicalImaging_Diag_No = 0 ;
   this.ZV50TFBR_MedicalImaging_Diag_No = 0 ;
   this.OV50TFBR_MedicalImaging_Diag_No = 0 ;
   this.AV51TFBR_MedicalImaging_Diag_No_To = 0 ;
   this.ZV51TFBR_MedicalImaging_Diag_No_To = 0 ;
   this.OV51TFBR_MedicalImaging_Diag_No_To = 0 ;
   this.AV38GridCurrentPage = 0 ;
   this.AV36DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = "" ;
   this.AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_MedicalImaging_DiagID = 0 ;
   this.AV18TFBR_MedicalImaging_DiagID_To = 0 ;
   this.AV21TFBR_MedicalImagingID = 0 ;
   this.AV22TFBR_MedicalImagingID_To = 0 ;
   this.AV25TFBR_MedicalImaging_Diag_Loc = "" ;
   this.AV26TFBR_MedicalImaging_Diag_Loc_Sel = "" ;
   this.AV29TFBR_MedicalImaging_Diag_Organ = "" ;
   this.AV30TFBR_MedicalImaging_Diag_Organ_Sel = "" ;
   this.AV33TFBR_MedicalImaging_Diag_Dis = "" ;
   this.AV34TFBR_MedicalImaging_Diag_Dis_Sel = "" ;
   this.AV50TFBR_MedicalImaging_Diag_No = 0 ;
   this.AV51TFBR_MedicalImaging_Diag_No_To = 0 ;
   this.AV41Display = "" ;
   this.AV42Update = "" ;
   this.AV44Delete = "" ;
   this.A270BR_MedicalImaging_DiagID = 0 ;
   this.A225BR_MedicalImagingID = 0 ;
   this.A271BR_MedicalImaging_Diag_Loc = "" ;
   this.A272BR_MedicalImaging_Diag_Organ = "" ;
   this.A273BR_MedicalImaging_Diag_Dis = "" ;
   this.A517BR_MedicalImaging_Diag_No = 0 ;
   this.AV70Pgmname = "" ;
   this.AV47IsAuthorized_Display = false ;
   this.AV43IsAuthorized_Update = false ;
   this.AV45IsAuthorized_Delete = false ;
   this.AV48IsAuthorized_BR_MedicalImaging_Diag_Loc = false ;
   this.Events = {"e114p2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e124p2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e134p2_client": ["DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED", true] ,"e144p2_client": ["DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED", true] ,"e154p2_client": ["DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED", true] ,"e164p2_client": ["DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED", true] ,"e174p2_client": ["DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED", true] ,"e184p2_client": ["DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED", true] ,"e194p2_client": ["'DOINSERT'", true] ,"e234p2_client": ["ENTER", true] ,"e244p2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true}],[{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAGID","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAGID_TO","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAGID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGINGID","Visible")',ctrl:'vTFBR_MEDICALIMAGINGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGINGID_TO","Visible")',ctrl:'vTFBR_MEDICALIMAGINGID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_LOC","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_LOC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_LOC_SEL","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_ORGAN","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_DIS","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_DIS',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_DIS_SEL","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_NO","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_NO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_DIAG_NO_TO","Visible")',ctrl:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'TitleControlIdToReplace'},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'TitleControlIdToReplace'},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV36DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'FilteredTextTo_set'},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SelectedValue_set'},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'FilteredText_set'},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SelectedValue_set'},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'FilteredText_set'},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SelectedValue_set'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'FilteredText_set'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGING_DIAGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGINGIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_LOCContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_DIAG_DISContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Title")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Title")',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_ORGAN","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_DIS","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_NO","Title")',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A270BR_MedicalImaging_DiagID',fld:'BR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true}],[{av:'AV41Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV42Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV44Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAG_LOC","Link")',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A270BR_MedicalImaging_DiagID',fld:'BR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV70Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV43IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV45IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV48IsAuthorized_BR_MedicalImaging_Diag_Loc", "vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", 0, "boolean", 4, 0);
   this.setVCMap("AV70Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV43IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV45IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV48IsAuthorized_BR_MedicalImaging_Diag_Loc", "vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", 0, "boolean", 4, 0);
   this.setVCMap("AV70Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV43IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV45IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV48IsAuthorized_BR_MedicalImaging_Diag_Loc", "vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", 0, "boolean", 4, 0);
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
   GridContainer.addRefreshingVar({rfrVar:"AV70Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV47IsAuthorized_Display"});
   GridContainer.addRefreshingVar({rfrVar:"AV43IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV45IsAuthorized_Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV48IsAuthorized_BR_MedicalImaging_Diag_Loc"});
   this.Initialize( );
});
gx.createParentObj(br_medicalimaging_diagww);
