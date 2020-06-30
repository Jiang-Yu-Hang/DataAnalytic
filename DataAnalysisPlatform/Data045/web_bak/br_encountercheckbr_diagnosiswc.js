/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:14.11
*/
gx.evt.autoSkip = false;
gx.define('br_encountercheckbr_diagnosiswc', true, function (CmpContext) {
   this.ServerClass =  "br_encountercheckbr_diagnosiswc" ;
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
      this.AV59Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV45IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV59Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV45IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV14OrderedBy == 2 )
      {
         this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 3 )
      {
         this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 4 )
      {
         this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 5 )
      {
         this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 6 )
      {
         this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 7 )
      {
         this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus =  ""  ;
      this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus =  ""  ;
      this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus =  ""  ;
      this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus =  ""  ;
      this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus =  ""  ;
   };
   this.e11402_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12402_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13402_client=function()
   {
      return this.executeServerEvent("DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14402_client=function()
   {
      return this.executeServerEvent("DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15402_client=function()
   {
      return this.executeServerEvent("DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16402_client=function()
   {
      return this.executeServerEvent("DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17402_client=function()
   {
      return this.executeServerEvent("DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18402_client=function()
   {
      return this.executeServerEvent("DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e22402_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e23402_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,27,28,29,31,33,35,37,39,41,42,44,45,46,47];
   this.GXLastCtrlId =47;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encountercheckbr_diagnosiswc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",13,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(64,14,"BR_DIAGNOSISID","搴忓彿","","BR_DiagnosisID","int",0,"px",18,18,"right",null,[],64,"BR_DiagnosisID",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(513,15,"BR_DIAGNOSIS_NO","","","BR_Diagnosis_No","int",0,"px",10,10,"right",null,[],513,"BR_Diagnosis_No",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(69,16,"BR_DIAGNOSIS_DXDESCRIPTION","","","BR_Diagnosis_DXDescription","svchar",0,"px",100,80,"left",null,[],69,"BR_Diagnosis_DXDescription",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(68,17,"BR_DIAGNOSIS_DXTSOURCE","","","BR_Diagnosis_DXTsource","svchar",0,"px",100,80,"left",null,[],68,"BR_Diagnosis_DXTsource",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(65,18,"BR_DIAGNOSIS_DXID","","","BR_Diagnosis_DXID","svchar",0,"px",40,40,"left",null,[],65,"BR_Diagnosis_DXID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(66,19,"BR_DIAGNOSIS_DXCODE","","","BR_Diagnosis_DXCode","svchar",0,"px",40,40,"left",null,[],66,"BR_Diagnosis_DXCode",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(67,20,"BR_DIAGNOSIS_DXTYPE","","","BR_Diagnosis_DXType","svchar",0,"px",100,80,"left",null,[],67,"BR_Diagnosis_DXType",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addComboBox(70,21,"BR_DIAGNOSIS_INITIALDX","鏄惁涓哄師鍙戣偪鐦?,"BR_Diagnosis_InitialDX","svchar",null,0,false,false,0,"px","WWColumn hidden-xs");
   GridContainer.addComboBox(71,22,"BR_DIAGNOSIS_METASTASESDX","鏄惁涓鸿浆绉昏偪鐦?,"BR_Diagnosis_MetastasesDX","svchar",null,0,false,false,0,"px","WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 26, 13, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV36GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV36GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV38GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV38GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV37GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV37GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV37GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11402_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12402_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_DIAGNOSIS_NOContainer = gx.uc.getNew(this, 30, 13, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_DIAGNOSIS_NOContainer", "Ddo_br_diagnosis_no", "DDO_BR_DIAGNOSIS_NO");
   var DDO_BR_DIAGNOSIS_NOContainer = this.DDO_BR_DIAGNOSIS_NOContainer;
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Class", "Class", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_DIAGNOSIS_NOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_DIAGNOSIS_NOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_DIAGNOSIS_NOContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_DIAGNOSIS_NOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_DIAGNOSIS_NOContainer.addV2CFunction('AV52BR_Diagnosis_NoTitleFilterData', "vBR_DIAGNOSIS_NOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_DIAGNOSIS_NOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV52BR_Diagnosis_NoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_DIAGNOSIS_NOTITLEFILTERDATA",UC.ParentObject.AV52BR_Diagnosis_NoTitleFilterData); });
   DDO_BR_DIAGNOSIS_NOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_DIAGNOSIS_NOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_DIAGNOSIS_NOContainer.addEventHandler("OnOptionClicked", this.e13402_client);
   this.setUserControl(DDO_BR_DIAGNOSIS_NOContainer);
   this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer = gx.uc.getNew(this, 32, 31, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer", "Ddo_br_diagnosis_dxdescription", "DDO_BR_DIAGNOSIS_DXDESCRIPTION");
   var DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer = this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer;
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Class", "Class", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.addV2CFunction('AV27BR_Diagnosis_DXDescriptionTitleFilterData', "vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27BR_Diagnosis_DXDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV27BR_Diagnosis_DXDescriptionTitleFilterData); });
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e14402_client);
   this.setUserControl(DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer);
   this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer = gx.uc.getNew(this, 34, 31, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_DIAGNOSIS_DXTSOURCEContainer", "Ddo_br_diagnosis_dxtsource", "DDO_BR_DIAGNOSIS_DXTSOURCE");
   var DDO_BR_DIAGNOSIS_DXTSOURCEContainer = this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer;
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.addV2CFunction('AV25BR_Diagnosis_DXTsourceTitleFilterData', "vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25BR_Diagnosis_DXTsourceTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA",UC.ParentObject.AV25BR_Diagnosis_DXTsourceTitleFilterData); });
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_DIAGNOSIS_DXTSOURCEContainer.addEventHandler("OnOptionClicked", this.e15402_client);
   this.setUserControl(DDO_BR_DIAGNOSIS_DXTSOURCEContainer);
   this.DDO_BR_DIAGNOSIS_DXIDContainer = gx.uc.getNew(this, 36, 31, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_DIAGNOSIS_DXIDContainer", "Ddo_br_diagnosis_dxid", "DDO_BR_DIAGNOSIS_DXID");
   var DDO_BR_DIAGNOSIS_DXIDContainer = this.DDO_BR_DIAGNOSIS_DXIDContainer;
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_DIAGNOSIS_DXIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_DIAGNOSIS_DXIDContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_DIAGNOSIS_DXIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_DIAGNOSIS_DXIDContainer.addV2CFunction('AV19BR_Diagnosis_DXIDTitleFilterData', "vBR_DIAGNOSIS_DXIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_DIAGNOSIS_DXIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19BR_Diagnosis_DXIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_DIAGNOSIS_DXIDTITLEFILTERDATA",UC.ParentObject.AV19BR_Diagnosis_DXIDTitleFilterData); });
   DDO_BR_DIAGNOSIS_DXIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_DIAGNOSIS_DXIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_DIAGNOSIS_DXIDContainer.addEventHandler("OnOptionClicked", this.e16402_client);
   this.setUserControl(DDO_BR_DIAGNOSIS_DXIDContainer);
   this.DDO_BR_DIAGNOSIS_DXCODEContainer = gx.uc.getNew(this, 38, 31, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_DIAGNOSIS_DXCODEContainer", "Ddo_br_diagnosis_dxcode", "DDO_BR_DIAGNOSIS_DXCODE");
   var DDO_BR_DIAGNOSIS_DXCODEContainer = this.DDO_BR_DIAGNOSIS_DXCODEContainer;
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_DIAGNOSIS_DXCODEContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_DIAGNOSIS_DXCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_DIAGNOSIS_DXCODEContainer.addV2CFunction('AV21BR_Diagnosis_DXCodeTitleFilterData', "vBR_DIAGNOSIS_DXCODETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_DIAGNOSIS_DXCODEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21BR_Diagnosis_DXCodeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_DIAGNOSIS_DXCODETITLEFILTERDATA",UC.ParentObject.AV21BR_Diagnosis_DXCodeTitleFilterData); });
   DDO_BR_DIAGNOSIS_DXCODEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_DIAGNOSIS_DXCODEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_DIAGNOSIS_DXCODEContainer.addEventHandler("OnOptionClicked", this.e17402_client);
   this.setUserControl(DDO_BR_DIAGNOSIS_DXCODEContainer);
   this.DDO_BR_DIAGNOSIS_DXTYPEContainer = gx.uc.getNew(this, 40, 31, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_DIAGNOSIS_DXTYPEContainer", "Ddo_br_diagnosis_dxtype", "DDO_BR_DIAGNOSIS_DXTYPE");
   var DDO_BR_DIAGNOSIS_DXTYPEContainer = this.DDO_BR_DIAGNOSIS_DXTYPEContainer;
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.addV2CFunction('AV33DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_DIAGNOSIS_DXTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV33DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV33DDO_TitleSettingsIcons); });
   DDO_BR_DIAGNOSIS_DXTYPEContainer.addV2CFunction('AV23BR_Diagnosis_DXTypeTitleFilterData', "vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_DIAGNOSIS_DXTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23BR_Diagnosis_DXTypeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA",UC.ParentObject.AV23BR_Diagnosis_DXTypeTitleFilterData); });
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_DIAGNOSIS_DXTYPEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_DIAGNOSIS_DXTYPEContainer.addEventHandler("OnOptionClicked", this.e18402_client);
   this.setUserControl(DDO_BR_DIAGNOSIS_DXTYPEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 43, 31, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id:13 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV43Display",gxold:"OV43Display",gxvar:"AV43Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV43Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(12),gx.O.AV43Display,gx.O.AV58Display_GXI)},c2v:function(){gx.O.AV58Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV43Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(12))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(12))}, gxvar_GXI:'AV58Display_GXI',nac:gx.falseFn};
   GXValidFnc[14]={ id:14 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSISID",gxz:"Z64BR_DiagnosisID",gxold:"O64BR_DiagnosisID",gxvar:"A64BR_DiagnosisID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A64BR_DiagnosisID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z64BR_DiagnosisID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSISID",row || gx.fn.currentGridRowImpl(12),gx.O.A64BR_DiagnosisID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A64BR_DiagnosisID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_DIAGNOSISID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[15]={ id:15 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_NO",gxz:"Z513BR_Diagnosis_No",gxold:"O513BR_Diagnosis_No",gxvar:"A513BR_Diagnosis_No",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A513BR_Diagnosis_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z513BR_Diagnosis_No=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSIS_NO",row || gx.fn.currentGridRowImpl(12),gx.O.A513BR_Diagnosis_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.A513BR_Diagnosis_No=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_DIAGNOSIS_NO",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[16]={ id:16 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXDESCRIPTION",gxz:"Z69BR_Diagnosis_DXDescription",gxold:"O69BR_Diagnosis_DXDescription",gxvar:"A69BR_Diagnosis_DXDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A69BR_Diagnosis_DXDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z69BR_Diagnosis_DXDescription=Value},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSIS_DXDESCRIPTION",row || gx.fn.currentGridRowImpl(12),gx.O.A69BR_Diagnosis_DXDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A69BR_Diagnosis_DXDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_DXDESCRIPTION",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[17]={ id:17 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXTSOURCE",gxz:"Z68BR_Diagnosis_DXTsource",gxold:"O68BR_Diagnosis_DXTsource",gxvar:"A68BR_Diagnosis_DXTsource",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A68BR_Diagnosis_DXTsource=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z68BR_Diagnosis_DXTsource=Value},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSIS_DXTSOURCE",row || gx.fn.currentGridRowImpl(12),gx.O.A68BR_Diagnosis_DXTsource,0)},c2v:function(){if(this.val()!==undefined)gx.O.A68BR_Diagnosis_DXTsource=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_DXTSOURCE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[18]={ id:18 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXID",gxz:"Z65BR_Diagnosis_DXID",gxold:"O65BR_Diagnosis_DXID",gxvar:"A65BR_Diagnosis_DXID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A65BR_Diagnosis_DXID=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z65BR_Diagnosis_DXID=Value},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSIS_DXID",row || gx.fn.currentGridRowImpl(12),gx.O.A65BR_Diagnosis_DXID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A65BR_Diagnosis_DXID=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_DXID",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[19]={ id:19 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXCODE",gxz:"Z66BR_Diagnosis_DXCode",gxold:"O66BR_Diagnosis_DXCode",gxvar:"A66BR_Diagnosis_DXCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A66BR_Diagnosis_DXCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z66BR_Diagnosis_DXCode=Value},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSIS_DXCODE",row || gx.fn.currentGridRowImpl(12),gx.O.A66BR_Diagnosis_DXCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A66BR_Diagnosis_DXCode=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_DXCODE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[20]={ id:20 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_DXTYPE",gxz:"Z67BR_Diagnosis_DXType",gxold:"O67BR_Diagnosis_DXType",gxvar:"A67BR_Diagnosis_DXType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A67BR_Diagnosis_DXType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z67BR_Diagnosis_DXType=Value},v2c:function(row){gx.fn.setGridControlValue("BR_DIAGNOSIS_DXTYPE",row || gx.fn.currentGridRowImpl(12),gx.O.A67BR_Diagnosis_DXType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A67BR_Diagnosis_DXType=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_DXTYPE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[21]={ id:21 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_INITIALDX",gxz:"Z70BR_Diagnosis_InitialDX",gxold:"O70BR_Diagnosis_InitialDX",gxvar:"A70BR_Diagnosis_InitialDX",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A70BR_Diagnosis_InitialDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z70BR_Diagnosis_InitialDX=Value},v2c:function(row){gx.fn.setGridComboBoxValue("BR_DIAGNOSIS_INITIALDX",row || gx.fn.currentGridRowImpl(12),gx.O.A70BR_Diagnosis_InitialDX);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A70BR_Diagnosis_InitialDX=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_INITIALDX",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[22]={ id:22 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DIAGNOSIS_METASTASESDX",gxz:"Z71BR_Diagnosis_MetastasesDX",gxold:"O71BR_Diagnosis_MetastasesDX",gxvar:"A71BR_Diagnosis_MetastasesDX",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A71BR_Diagnosis_MetastasesDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z71BR_Diagnosis_MetastasesDX=Value},v2c:function(row){gx.fn.setGridComboBoxValue("BR_DIAGNOSIS_METASTASESDX",row || gx.fn.currentGridRowImpl(12),gx.O.A71BR_Diagnosis_MetastasesDX);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A71BR_Diagnosis_MetastasesDX=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_DIAGNOSIS_METASTASESDX",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[31]={ id:31 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE",gxz:"ZV55ddo_BR_Diagnosis_NoTitleControlIdToReplace",gxold:"OV55ddo_BR_Diagnosis_NoTitleControlIdToReplace",gxvar:"AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV55ddo_BR_Diagnosis_NoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE",gx.O.AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace",gxold:"OV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace",gxvar:"AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE",gxz:"ZV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace",gxold:"OV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace",gxvar:"AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE",gx.O.AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace",gxold:"OV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace",gxvar:"AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE",gx.O.AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE",gxz:"ZV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace",gxold:"OV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace",gxvar:"AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE",gx.O.AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE",gxz:"ZV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace",gxold:"OV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace",gxvar:"AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE",gx.O.AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 42 , function() {
   });
   GXValidFnc[44]={ id:44 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_DIAGNOSIS_NO",gxz:"ZV53TFBR_Diagnosis_No",gxold:"OV53TFBR_Diagnosis_No",gxvar:"AV53TFBR_Diagnosis_No",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV53TFBR_Diagnosis_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV53TFBR_Diagnosis_No=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_DIAGNOSIS_NO",gx.O.AV53TFBR_Diagnosis_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV53TFBR_Diagnosis_No=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_DIAGNOSIS_NO",',')},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_DIAGNOSIS_NO_TO",gxz:"ZV54TFBR_Diagnosis_No_To",gxold:"OV54TFBR_Diagnosis_No_To",gxvar:"AV54TFBR_Diagnosis_No_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV54TFBR_Diagnosis_No_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV54TFBR_Diagnosis_No_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_DIAGNOSIS_NO_TO",gx.O.AV54TFBR_Diagnosis_No_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV54TFBR_Diagnosis_No_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_DIAGNOSIS_NO_TO",',')},nac:gx.falseFn};
   this.ZV43Display = "" ;
   this.OV43Display = "" ;
   this.Z64BR_DiagnosisID = 0 ;
   this.O64BR_DiagnosisID = 0 ;
   this.Z513BR_Diagnosis_No = 0 ;
   this.O513BR_Diagnosis_No = 0 ;
   this.Z69BR_Diagnosis_DXDescription = "" ;
   this.O69BR_Diagnosis_DXDescription = "" ;
   this.Z68BR_Diagnosis_DXTsource = "" ;
   this.O68BR_Diagnosis_DXTsource = "" ;
   this.Z65BR_Diagnosis_DXID = "" ;
   this.O65BR_Diagnosis_DXID = "" ;
   this.Z66BR_Diagnosis_DXCode = "" ;
   this.O66BR_Diagnosis_DXCode = "" ;
   this.Z67BR_Diagnosis_DXType = "" ;
   this.O67BR_Diagnosis_DXType = "" ;
   this.Z70BR_Diagnosis_InitialDX = "" ;
   this.O70BR_Diagnosis_InitialDX = "" ;
   this.Z71BR_Diagnosis_MetastasesDX = "" ;
   this.O71BR_Diagnosis_MetastasesDX = "" ;
   this.AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace = "" ;
   this.ZV55ddo_BR_Diagnosis_NoTitleControlIdToReplace = "" ;
   this.OV55ddo_BR_Diagnosis_NoTitleControlIdToReplace = "" ;
   this.AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = "" ;
   this.ZV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = "" ;
   this.OV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = "" ;
   this.ZV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = "" ;
   this.OV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = "" ;
   this.AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = "" ;
   this.ZV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = "" ;
   this.OV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = "" ;
   this.AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = "" ;
   this.ZV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = "" ;
   this.OV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = "" ;
   this.AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = "" ;
   this.ZV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = "" ;
   this.OV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV53TFBR_Diagnosis_No = 0 ;
   this.ZV53TFBR_Diagnosis_No = 0 ;
   this.OV53TFBR_Diagnosis_No = 0 ;
   this.AV54TFBR_Diagnosis_No_To = 0 ;
   this.ZV54TFBR_Diagnosis_No_To = 0 ;
   this.OV54TFBR_Diagnosis_No_To = 0 ;
   this.AV36GridCurrentPage = 0 ;
   this.AV33DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace = "" ;
   this.AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = "" ;
   this.AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = "" ;
   this.AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = "" ;
   this.AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV53TFBR_Diagnosis_No = 0 ;
   this.AV54TFBR_Diagnosis_No_To = 0 ;
   this.AV8BR_EncounterID = 0 ;
   this.AV43Display = "" ;
   this.A64BR_DiagnosisID = 0 ;
   this.A513BR_Diagnosis_No = 0 ;
   this.A69BR_Diagnosis_DXDescription = "" ;
   this.A68BR_Diagnosis_DXTsource = "" ;
   this.A65BR_Diagnosis_DXID = "" ;
   this.A66BR_Diagnosis_DXCode = "" ;
   this.A67BR_Diagnosis_DXType = "" ;
   this.A70BR_Diagnosis_InitialDX = "" ;
   this.A71BR_Diagnosis_MetastasesDX = "" ;
   this.AV59Pgmname = "" ;
   this.AV45IsAuthorized_Display = false ;
   this.Events = {"e11402_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12402_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13402_client": ["DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED", true] ,"e14402_client": ["DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED", true] ,"e15402_client": ["DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED", true] ,"e16402_client": ["DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED", true] ,"e17402_client": ["DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED", true] ,"e18402_client": ["DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED", true] ,"e22402_client": ["ENTER", true] ,"e23402_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'}],[{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_DIAGNOSIS_NO","Visible")',ctrl:'vTFBR_DIAGNOSIS_NO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_DIAGNOSIS_NO_TO","Visible")',ctrl:'vTFBR_DIAGNOSIS_NO_TO',prop:'Visible'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.TitleControlIdToReplace',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'TitleControlIdToReplace'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'TitleControlIdToReplace'},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'TitleControlIdToReplace'},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'TitleControlIdToReplace'},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'TitleControlIdToReplace'},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV33DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.FilteredText_set',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'FilteredText_set'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.FilteredTextTo_set',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.ActiveEventKey',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'ActiveEventKey'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.FilteredText_get',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'FilteredText_get'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.FilteredTextTo_get',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.ActiveEventKey',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.ActiveEventKey',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.ActiveEventKey',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV54TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV55ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.ActiveEventKey',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_DIAGNOSIS_DXTYPEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_NOContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXTSOURCEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXIDContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'this.DDO_BR_DIAGNOSIS_DXCODEContainer.SortedStatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'AV52BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_NO","Title")',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXDESCRIPTION","Title")',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTSOURCE","Title")',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXID","Title")',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXCODE","Title")',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_DIAGNOSIS_DXTYPE","Title")',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV45IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV43Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'}]];
   this.setVCMap("AV59Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV45IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV59Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV45IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV59Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV45IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar({rfrVar:"AV8BR_EncounterID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[31]);
   GridContainer.addRefreshingVar(this.GXValidFnc[33]);
   GridContainer.addRefreshingVar(this.GXValidFnc[35]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[41]);
   GridContainer.addRefreshingVar({rfrVar:"AV59Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV45IsAuthorized_Display"});
   this.Initialize( );
});
