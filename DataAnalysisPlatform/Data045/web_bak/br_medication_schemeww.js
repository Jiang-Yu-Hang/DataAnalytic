/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:43:5.55
*/
gx.evt.autoSkip = false;
gx.define('br_medication_schemeww', false, function () {
   this.ServerClass =  "br_medication_schemeww" ;
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
      this.AV88Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV47IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV49IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV88Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV47IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV49IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_MEDICATIONIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATIONIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus =  ""  ;
   };
   this.e114z2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e124z2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e134z2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e144z2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATIONID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e154z2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e164z2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e174z2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e184z2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e194z2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e234z2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e244z2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,49,51,53,55,57,59,61,62,63,64,65,66,67,68,69,70,71,72,73,74];
   this.GXLastCtrlId =74;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_medication_schemeww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(296,35,"BR_MEDICATION_SCHEMEID","","","BR_Medication_SchemeID","int",0,"px",18,18,"right",null,[],296,"BR_Medication_SchemeID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(119,36,"BR_MEDICATIONID","","","BR_MedicationID","int",0,"px",18,18,"right",null,[],119,"BR_MedicationID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(305,37,"BR_MEDICATION_CHEM_NAME","","","BR_Medication_Chem_Name","svchar",0,"px",100,80,"left",null,[],305,"BR_Medication_Chem_Name",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(306,38,"BR_MEDICATION_CHEM_CYCLE","","","BR_Medication_Chem_Cycle","decimal",0,"px",15,15,"right",null,[],306,"BR_Medication_Chem_Cycle",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(307,39,"BR_MEDICATION_CHEM_LINE","","","BR_Medication_Chem_Line","svchar",0,"px",40,40,"left",null,[],307,"BR_Medication_Chem_Line",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(313,40,"BR_MEDICATION_CHEM_DETAIL","","","BR_Medication_Chem_Detail","svchar",0,"px",100,80,"left",null,[],313,"BR_Medication_Chem_Detail",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e114z2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e124z2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICATION_SCHEMEIDContainer = gx.uc.getNew(this, 48, 32, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_SCHEMEIDContainer", "Ddo_br_medication_schemeid", "DDO_BR_MEDICATION_SCHEMEID");
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
   DDO_BR_MEDICATION_SCHEMEIDContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_SCHEMEIDContainer.addV2CFunction('AV16BR_Medication_SchemeIDTitleFilterData', "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Medication_SchemeIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Medication_SchemeIDTitleFilterData); });
   DDO_BR_MEDICATION_SCHEMEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_SCHEMEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_SCHEMEIDContainer.addEventHandler("OnOptionClicked", this.e134z2_client);
   this.setUserControl(DDO_BR_MEDICATION_SCHEMEIDContainer);
   this.DDO_BR_MEDICATIONIDContainer = gx.uc.getNew(this, 50, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICATIONIDContainer", "Ddo_br_medicationid", "DDO_BR_MEDICATIONID");
   var DDO_BR_MEDICATIONIDContainer = this.DDO_BR_MEDICATIONIDContainer;
   DDO_BR_MEDICATIONIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATIONIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATIONIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATIONIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATIONIDContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATIONIDContainer.addV2CFunction('AV20BR_MedicationIDTitleFilterData', "vBR_MEDICATIONIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_MedicationIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATIONIDTITLEFILTERDATA",UC.ParentObject.AV20BR_MedicationIDTitleFilterData); });
   DDO_BR_MEDICATIONIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATIONIDContainer.addEventHandler("OnOptionClicked", this.e144z2_client);
   this.setUserControl(DDO_BR_MEDICATIONIDContainer);
   this.DDO_BR_MEDICATION_CHEM_NAMEContainer = gx.uc.getNew(this, 52, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_CHEM_NAMEContainer", "Ddo_br_medication_chem_name", "DDO_BR_MEDICATION_CHEM_NAME");
   var DDO_BR_MEDICATION_CHEM_NAMEContainer = this.DDO_BR_MEDICATION_CHEM_NAMEContainer;
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("DataListProc", "Datalistproc", "BR_Medication_SchemeWWGetFilterData", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_CHEM_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_CHEM_NAMEContainer.addV2CFunction('AV51BR_Medication_Chem_NameTitleFilterData', "vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_CHEM_NAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51BR_Medication_Chem_NameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA",UC.ParentObject.AV51BR_Medication_Chem_NameTitleFilterData); });
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_CHEM_NAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_CHEM_NAMEContainer.addEventHandler("OnOptionClicked", this.e154z2_client);
   this.setUserControl(DDO_BR_MEDICATION_CHEM_NAMEContainer);
   this.DDO_BR_MEDICATION_CHEM_CYCLEContainer = gx.uc.getNew(this, 54, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_CHEM_CYCLEContainer", "Ddo_br_medication_chem_cycle", "DDO_BR_MEDICATION_CHEM_CYCLE");
   var DDO_BR_MEDICATION_CHEM_CYCLEContainer = this.DDO_BR_MEDICATION_CHEM_CYCLEContainer;
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.addV2CFunction('AV55BR_Medication_Chem_CycleTitleFilterData', "vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV55BR_Medication_Chem_CycleTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA",UC.ParentObject.AV55BR_Medication_Chem_CycleTitleFilterData); });
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_CHEM_CYCLEContainer.addEventHandler("OnOptionClicked", this.e164z2_client);
   this.setUserControl(DDO_BR_MEDICATION_CHEM_CYCLEContainer);
   this.DDO_BR_MEDICATION_CHEM_LINEContainer = gx.uc.getNew(this, 56, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_CHEM_LINEContainer", "Ddo_br_medication_chem_line", "DDO_BR_MEDICATION_CHEM_LINE");
   var DDO_BR_MEDICATION_CHEM_LINEContainer = this.DDO_BR_MEDICATION_CHEM_LINEContainer;
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("DataListProc", "Datalistproc", "BR_Medication_SchemeWWGetFilterData", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_CHEM_LINEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_CHEM_LINEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_CHEM_LINEContainer.addV2CFunction('AV59BR_Medication_Chem_LineTitleFilterData', "vBR_MEDICATION_CHEM_LINETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_CHEM_LINEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV59BR_Medication_Chem_LineTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_CHEM_LINETITLEFILTERDATA",UC.ParentObject.AV59BR_Medication_Chem_LineTitleFilterData); });
   DDO_BR_MEDICATION_CHEM_LINEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_CHEM_LINEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_CHEM_LINEContainer.addEventHandler("OnOptionClicked", this.e174z2_client);
   this.setUserControl(DDO_BR_MEDICATION_CHEM_LINEContainer);
   this.DDO_BR_MEDICATION_CHEM_DETAILContainer = gx.uc.getNew(this, 58, 49, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_CHEM_DETAILContainer", "Ddo_br_medication_chem_detail", "DDO_BR_MEDICATION_CHEM_DETAIL");
   var DDO_BR_MEDICATION_CHEM_DETAILContainer = this.DDO_BR_MEDICATION_CHEM_DETAILContainer;
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("DataListProc", "Datalistproc", "BR_Medication_SchemeWWGetFilterData", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_CHEM_DETAILContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_CHEM_DETAILContainer.addV2CFunction('AV67BR_Medication_Chem_DetailTitleFilterData', "vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_CHEM_DETAILContainer.addC2VFunction(function(UC) { UC.ParentObject.AV67BR_Medication_Chem_DetailTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA",UC.ParentObject.AV67BR_Medication_Chem_DetailTitleFilterData); });
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_CHEM_DETAILContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_CHEM_DETAILContainer.addEventHandler("OnOptionClicked", this.e184z2_client);
   this.setUserControl(DDO_BR_MEDICATION_CHEM_DETAILContainer);
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV45Display",gxold:"OV45Display",gxvar:"AV45Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV45Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV45Display,gx.O.AV85Display_GXI)},c2v:function(){gx.O.AV85Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV45Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV85Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV46Update",gxold:"OV46Update",gxvar:"AV46Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV46Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV46Update,gx.O.AV86Update_GXI)},c2v:function(){gx.O.AV86Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV46Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV86Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV48Delete",gxold:"OV48Delete",gxvar:"AV48Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV48Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV48Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV48Delete,gx.O.AV87Delete_GXI)},c2v:function(){gx.O.AV87Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV48Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV87Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_SCHEMEID",gxz:"Z296BR_Medication_SchemeID",gxold:"O296BR_Medication_SchemeID",gxvar:"A296BR_Medication_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z296BR_Medication_SchemeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_SCHEMEID",row || gx.fn.currentGridRowImpl(31),gx.O.A296BR_Medication_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATION_SCHEMEID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(31),gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_NAME",gxz:"Z305BR_Medication_Chem_Name",gxold:"O305BR_Medication_Chem_Name",gxvar:"A305BR_Medication_Chem_Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A305BR_Medication_Chem_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z305BR_Medication_Chem_Name=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_CHEM_NAME",row || gx.fn.currentGridRowImpl(31),gx.O.A305BR_Medication_Chem_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A305BR_Medication_Chem_Name=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_CHEM_NAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_CYCLE",gxz:"Z306BR_Medication_Chem_Cycle",gxold:"O306BR_Medication_Chem_Cycle",gxvar:"A306BR_Medication_Chem_Cycle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A306BR_Medication_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z306BR_Medication_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_CHEM_CYCLE",row || gx.fn.currentGridRowImpl(31),gx.O.A306BR_Medication_Chem_Cycle,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A306BR_Medication_Chem_Cycle=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_CHEM_CYCLE",row || gx.fn.currentGridRowImpl(31),',','.')},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_LINE",gxz:"Z307BR_Medication_Chem_Line",gxold:"O307BR_Medication_Chem_Line",gxvar:"A307BR_Medication_Chem_Line",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A307BR_Medication_Chem_Line=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z307BR_Medication_Chem_Line=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_CHEM_LINE",row || gx.fn.currentGridRowImpl(31),gx.O.A307BR_Medication_Chem_Line,0)},c2v:function(){if(this.val()!==undefined)gx.O.A307BR_Medication_Chem_Line=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_CHEM_LINE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_DETAIL",gxz:"Z313BR_Medication_Chem_Detail",gxold:"O313BR_Medication_Chem_Detail",gxvar:"A313BR_Medication_Chem_Detail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A313BR_Medication_Chem_Detail=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z313BR_Medication_Chem_Detail=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_CHEM_DETAIL",row || gx.fn.currentGridRowImpl(31),gx.O.A313BR_Medication_Chem_Detail,0)},c2v:function(){if(this.val()!==undefined)gx.O.A313BR_Medication_Chem_Detail=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_CHEM_DETAIL",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_MedicationIDTitleControlIdToReplace",gxold:"OV23ddo_BR_MedicationIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_MedicationIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_MedicationIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_MedicationIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_MedicationIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_MedicationIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE",gxz:"ZV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace",gxold:"OV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace",gxvar:"AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE",gx.O.AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE",gxz:"ZV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace",gxold:"OV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace",gxvar:"AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE",gx.O.AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE",gxz:"ZV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace",gxold:"OV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace",gxvar:"AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE",gx.O.AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE",gxz:"ZV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace",gxold:"OV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace",gxvar:"AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE",gx.O.AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_SCHEMEID",gxz:"ZV17TFBR_Medication_SchemeID",gxold:"OV17TFBR_Medication_SchemeID",gxvar:"AV17TFBR_Medication_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Medication_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Medication_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_SCHEMEID",gx.O.AV17TFBR_Medication_SchemeID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Medication_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATION_SCHEMEID",',')},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_SCHEMEID_TO",gxz:"ZV18TFBR_Medication_SchemeID_To",gxold:"OV18TFBR_Medication_SchemeID_To",gxvar:"AV18TFBR_Medication_SchemeID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Medication_SchemeID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Medication_SchemeID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_SCHEMEID_TO",gx.O.AV18TFBR_Medication_SchemeID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Medication_SchemeID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATION_SCHEMEID_TO",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATIONID",gxz:"ZV21TFBR_MedicationID",gxold:"OV21TFBR_MedicationID",gxvar:"AV21TFBR_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATIONID",gx.O.AV21TFBR_MedicationID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATIONID",',')},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATIONID_TO",gxz:"ZV22TFBR_MedicationID_To",gxold:"OV22TFBR_MedicationID_To",gxvar:"AV22TFBR_MedicationID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_MedicationID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_MedicationID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATIONID_TO",gx.O.AV22TFBR_MedicationID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_MedicationID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICATIONID_TO",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_NAME",gxz:"ZV52TFBR_Medication_Chem_Name",gxold:"OV52TFBR_Medication_Chem_Name",gxvar:"AV52TFBR_Medication_Chem_Name",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV52TFBR_Medication_Chem_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV52TFBR_Medication_Chem_Name=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_CHEM_NAME",gx.O.AV52TFBR_Medication_Chem_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV52TFBR_Medication_Chem_Name=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_CHEM_NAME")},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_NAME_SEL",gxz:"ZV53TFBR_Medication_Chem_Name_Sel",gxold:"OV53TFBR_Medication_Chem_Name_Sel",gxvar:"AV53TFBR_Medication_Chem_Name_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV53TFBR_Medication_Chem_Name_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53TFBR_Medication_Chem_Name_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_CHEM_NAME_SEL",gx.O.AV53TFBR_Medication_Chem_Name_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV53TFBR_Medication_Chem_Name_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_CHEM_NAME_SEL")},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_CYCLE",gxz:"ZV56TFBR_Medication_Chem_Cycle",gxold:"OV56TFBR_Medication_Chem_Cycle",gxvar:"AV56TFBR_Medication_Chem_Cycle",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV56TFBR_Medication_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV56TFBR_Medication_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_CHEM_CYCLE",gx.O.AV56TFBR_Medication_Chem_Cycle,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV56TFBR_Medication_Chem_Cycle=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_CHEM_CYCLE",',','.')},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_CYCLE_TO",gxz:"ZV57TFBR_Medication_Chem_Cycle_To",gxold:"OV57TFBR_Medication_Chem_Cycle_To",gxvar:"AV57TFBR_Medication_Chem_Cycle_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV57TFBR_Medication_Chem_Cycle_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV57TFBR_Medication_Chem_Cycle_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_MEDICATION_CHEM_CYCLE_TO",gx.O.AV57TFBR_Medication_Chem_Cycle_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV57TFBR_Medication_Chem_Cycle_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_MEDICATION_CHEM_CYCLE_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_LINE",gxz:"ZV60TFBR_Medication_Chem_Line",gxold:"OV60TFBR_Medication_Chem_Line",gxvar:"AV60TFBR_Medication_Chem_Line",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV60TFBR_Medication_Chem_Line=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV60TFBR_Medication_Chem_Line=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_CHEM_LINE",gx.O.AV60TFBR_Medication_Chem_Line,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV60TFBR_Medication_Chem_Line=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_CHEM_LINE")},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_LINE_SEL",gxz:"ZV61TFBR_Medication_Chem_Line_Sel",gxold:"OV61TFBR_Medication_Chem_Line_Sel",gxvar:"AV61TFBR_Medication_Chem_Line_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV61TFBR_Medication_Chem_Line_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV61TFBR_Medication_Chem_Line_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_CHEM_LINE_SEL",gx.O.AV61TFBR_Medication_Chem_Line_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV61TFBR_Medication_Chem_Line_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_CHEM_LINE_SEL")},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_DETAIL",gxz:"ZV68TFBR_Medication_Chem_Detail",gxold:"OV68TFBR_Medication_Chem_Detail",gxvar:"AV68TFBR_Medication_Chem_Detail",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV68TFBR_Medication_Chem_Detail=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV68TFBR_Medication_Chem_Detail=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_CHEM_DETAIL",gx.O.AV68TFBR_Medication_Chem_Detail,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV68TFBR_Medication_Chem_Detail=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_CHEM_DETAIL")},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_CHEM_DETAIL_SEL",gxz:"ZV69TFBR_Medication_Chem_Detail_Sel",gxold:"OV69TFBR_Medication_Chem_Detail_Sel",gxvar:"AV69TFBR_Medication_Chem_Detail_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV69TFBR_Medication_Chem_Detail_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV69TFBR_Medication_Chem_Detail_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_CHEM_DETAIL_SEL",gx.O.AV69TFBR_Medication_Chem_Detail_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV69TFBR_Medication_Chem_Detail_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_CHEM_DETAIL_SEL")},nac:gx.falseFn};
   this.ZV45Display = "" ;
   this.OV45Display = "" ;
   this.ZV46Update = "" ;
   this.OV46Update = "" ;
   this.ZV48Delete = "" ;
   this.OV48Delete = "" ;
   this.Z296BR_Medication_SchemeID = 0 ;
   this.O296BR_Medication_SchemeID = 0 ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.Z305BR_Medication_Chem_Name = "" ;
   this.O305BR_Medication_Chem_Name = "" ;
   this.Z306BR_Medication_Chem_Cycle = 0 ;
   this.O306BR_Medication_Chem_Cycle = 0 ;
   this.Z307BR_Medication_Chem_Line = "" ;
   this.O307BR_Medication_Chem_Line = "" ;
   this.Z313BR_Medication_Chem_Detail = "" ;
   this.O313BR_Medication_Chem_Detail = "" ;
   this.AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = "" ;
   this.ZV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = "" ;
   this.OV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = "" ;
   this.AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = "" ;
   this.ZV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = "" ;
   this.OV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = "" ;
   this.AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = "" ;
   this.ZV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = "" ;
   this.OV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = "" ;
   this.AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = "" ;
   this.ZV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = "" ;
   this.OV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Medication_SchemeID = 0 ;
   this.ZV17TFBR_Medication_SchemeID = 0 ;
   this.OV17TFBR_Medication_SchemeID = 0 ;
   this.AV18TFBR_Medication_SchemeID_To = 0 ;
   this.ZV18TFBR_Medication_SchemeID_To = 0 ;
   this.OV18TFBR_Medication_SchemeID_To = 0 ;
   this.AV21TFBR_MedicationID = 0 ;
   this.ZV21TFBR_MedicationID = 0 ;
   this.OV21TFBR_MedicationID = 0 ;
   this.AV22TFBR_MedicationID_To = 0 ;
   this.ZV22TFBR_MedicationID_To = 0 ;
   this.OV22TFBR_MedicationID_To = 0 ;
   this.AV52TFBR_Medication_Chem_Name = "" ;
   this.ZV52TFBR_Medication_Chem_Name = "" ;
   this.OV52TFBR_Medication_Chem_Name = "" ;
   this.AV53TFBR_Medication_Chem_Name_Sel = "" ;
   this.ZV53TFBR_Medication_Chem_Name_Sel = "" ;
   this.OV53TFBR_Medication_Chem_Name_Sel = "" ;
   this.AV56TFBR_Medication_Chem_Cycle = 0 ;
   this.ZV56TFBR_Medication_Chem_Cycle = 0 ;
   this.OV56TFBR_Medication_Chem_Cycle = 0 ;
   this.AV57TFBR_Medication_Chem_Cycle_To = 0 ;
   this.ZV57TFBR_Medication_Chem_Cycle_To = 0 ;
   this.OV57TFBR_Medication_Chem_Cycle_To = 0 ;
   this.AV60TFBR_Medication_Chem_Line = "" ;
   this.ZV60TFBR_Medication_Chem_Line = "" ;
   this.OV60TFBR_Medication_Chem_Line = "" ;
   this.AV61TFBR_Medication_Chem_Line_Sel = "" ;
   this.ZV61TFBR_Medication_Chem_Line_Sel = "" ;
   this.OV61TFBR_Medication_Chem_Line_Sel = "" ;
   this.AV68TFBR_Medication_Chem_Detail = "" ;
   this.ZV68TFBR_Medication_Chem_Detail = "" ;
   this.OV68TFBR_Medication_Chem_Detail = "" ;
   this.AV69TFBR_Medication_Chem_Detail_Sel = "" ;
   this.ZV69TFBR_Medication_Chem_Detail_Sel = "" ;
   this.OV69TFBR_Medication_Chem_Detail_Sel = "" ;
   this.AV42GridCurrentPage = 0 ;
   this.AV40DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = "" ;
   this.AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = "" ;
   this.AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = "" ;
   this.AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Medication_SchemeID = 0 ;
   this.AV18TFBR_Medication_SchemeID_To = 0 ;
   this.AV21TFBR_MedicationID = 0 ;
   this.AV22TFBR_MedicationID_To = 0 ;
   this.AV52TFBR_Medication_Chem_Name = "" ;
   this.AV53TFBR_Medication_Chem_Name_Sel = "" ;
   this.AV56TFBR_Medication_Chem_Cycle = 0 ;
   this.AV57TFBR_Medication_Chem_Cycle_To = 0 ;
   this.AV60TFBR_Medication_Chem_Line = "" ;
   this.AV61TFBR_Medication_Chem_Line_Sel = "" ;
   this.AV68TFBR_Medication_Chem_Detail = "" ;
   this.AV69TFBR_Medication_Chem_Detail_Sel = "" ;
   this.AV45Display = "" ;
   this.AV46Update = "" ;
   this.AV48Delete = "" ;
   this.A296BR_Medication_SchemeID = 0 ;
   this.A119BR_MedicationID = 0 ;
   this.A305BR_Medication_Chem_Name = "" ;
   this.A306BR_Medication_Chem_Cycle = 0 ;
   this.A307BR_Medication_Chem_Line = "" ;
   this.A313BR_Medication_Chem_Detail = "" ;
   this.AV88Pgmname = "" ;
   this.AV47IsAuthorized_Update = false ;
   this.AV49IsAuthorized_Delete = false ;
   this.Events = {"e114z2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e124z2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e134z2_client": ["DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED", true] ,"e144z2_client": ["DDO_BR_MEDICATIONID.ONOPTIONCLICKED", true] ,"e154z2_client": ["DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED", true] ,"e164z2_client": ["DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED", true] ,"e174z2_client": ["DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED", true] ,"e184z2_client": ["DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED", true] ,"e194z2_client": ["'DOINSERT'", true] ,"e234z2_client": ["ENTER", true] ,"e244z2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_SCHEMEID","Visible")',ctrl:'vTFBR_MEDICATION_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_SCHEMEID_TO","Visible")',ctrl:'vTFBR_MEDICATION_SCHEMEID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATIONID","Visible")',ctrl:'vTFBR_MEDICATIONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATIONID_TO","Visible")',ctrl:'vTFBR_MEDICATIONID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_NAME","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_NAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_NAME_SEL","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_NAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_CYCLE","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_CYCLE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_CYCLE_TO","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_CYCLE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_LINE","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_LINE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_LINE_SEL","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_LINE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_DETAIL","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_DETAIL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_CHEM_DETAIL_SEL","Visible")',ctrl:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATIONIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATIONID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'TitleControlIdToReplace'},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'TitleControlIdToReplace'},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'TitleControlIdToReplace'},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'TitleControlIdToReplace'},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV40DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SelectedValue_set'},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'FilteredText_set'},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SelectedValue_set'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'FilteredText_set'},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'FilteredTextTo_set'},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SelectedValue_set',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SelectedValue_set'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'FilteredText_set'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredText_set',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATIONID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATIONIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATIONIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_CHEM_DETAILContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_NAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_CYCLEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_CHEM_LINEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Title")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_NAME","Title")',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_CYCLE","Title")',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_LINE","Title")',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_CHEM_DETAIL","Title")',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV45Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV46Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV48Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV88Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV49IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV88Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV47IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV49IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV88Pgmname", "vPGMNAME", 0, "char", 129, 0);
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
   GridContainer.addRefreshingVar({rfrVar:"AV88Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV47IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV49IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_medication_schemeww);
