/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:20.39
*/
gx.evt.autoSkip = false;
gx.define('jc_providerjc_provider_br_informationwc', true, function (CmpContext) {
   this.ServerClass =  "jc_providerjc_provider_br_informationwc" ;
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
      this.AV40Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV28IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV30IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV32IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV33IsAuthorized_BR_Information_PatientNo=gx.fn.getControlValue("vISAUTHORIZED_BR_INFORMATION_PATIENTNO") ;
      this.AV8JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
      this.AV8JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
      this.AV40Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV28IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV30IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV32IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV33IsAuthorized_BR_Information_PatientNo=gx.fn.getControlValue("vISAUTHORIZED_BR_INFORMATION_PATIENTNO") ;
   };
   this.Valid_Br_information_id=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(33) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_INFORMATION_ID", gx.fn.currentGridRowImpl(33));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e118m2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e128m2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e138m2_client=function()
   {
      return this.executeServerEvent("DDO_BR_INFORMATION_ID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e148m2_client=function()
   {
      return this.executeServerEvent("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e158m2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e198m2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e208m2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,43,44,45,47,49,50,52,53];
   this.GXLastCtrlId =53;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",33,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"jc_providerjc_provider_br_informationwc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Update","vUPDATE",34,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",35,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Display","vDISPLAY",36,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(85,37,"BR_INFORMATION_ID","","","BR_Information_ID","int",0,"px",18,18,"right",null,[],85,"BR_Information_ID",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(36,38,"BR_INFORMATION_PATIENTNO","","","BR_Information_PatientNo","svchar",410,"px",2000,80,"left",null,[],36,"BR_Information_PatientNo",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 13, 0, "BootstrapPanel", this.CmpContext + "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 42, 34, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV24GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV24GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV26GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV26GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV25GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV25GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e118m2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e128m2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_INFORMATION_IDContainer = gx.uc.getNew(this, 46, 34, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_INFORMATION_IDContainer", "Ddo_br_information_id", "DDO_BR_INFORMATION_ID");
   var DDO_BR_INFORMATION_IDContainer = this.DDO_BR_INFORMATION_IDContainer;
   DDO_BR_INFORMATION_IDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_INFORMATION_IDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_INFORMATION_IDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_INFORMATION_IDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_INFORMATION_IDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_INFORMATION_IDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_INFORMATION_IDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_INFORMATION_IDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_INFORMATION_IDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_INFORMATION_IDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_INFORMATION_IDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_INFORMATION_IDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_INFORMATION_IDContainer.addV2CFunction('AV21DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_INFORMATION_IDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV21DDO_TitleSettingsIcons); });
   DDO_BR_INFORMATION_IDContainer.addV2CFunction('AV17BR_Information_IDTitleFilterData', "vBR_INFORMATION_IDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_INFORMATION_IDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17BR_Information_IDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_INFORMATION_IDTITLEFILTERDATA",UC.ParentObject.AV17BR_Information_IDTitleFilterData); });
   DDO_BR_INFORMATION_IDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_INFORMATION_IDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_INFORMATION_IDContainer.addEventHandler("OnOptionClicked", this.e138m2_client);
   this.setUserControl(DDO_BR_INFORMATION_IDContainer);
   this.DDO_BR_INFORMATION_PATIENTNOContainer = gx.uc.getNew(this, 48, 47, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_INFORMATION_PATIENTNOContainer", "Ddo_br_information_patientno", "DDO_BR_INFORMATION_PATIENTNO");
   var DDO_BR_INFORMATION_PATIENTNOContainer = this.DDO_BR_INFORMATION_PATIENTNOContainer;
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Class", "Class", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV21DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV21DDO_TitleSettingsIcons); });
   DDO_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV19BR_Information_PatientNoTitleFilterData', "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19BR_Information_PatientNoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA",UC.ParentObject.AV19BR_Information_PatientNoTitleFilterData); });
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_INFORMATION_PATIENTNOContainer.addEventHandler("OnOptionClicked", this.e148m2_client);
   this.setUserControl(DDO_BR_INFORMATION_PATIENTNOContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 51, 47, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEHEADER",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"JC_PROVIDER_BR_INFORMATIONTITLE", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"BTNINSERT",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV27Update",gxold:"OV27Update",gxvar:"AV27Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV27Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(33),gx.O.AV27Update,gx.O.AV37Update_GXI)},c2v:function(){gx.O.AV37Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV27Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(33))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(33))}, gxvar_GXI:'AV37Update_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV29Delete",gxold:"OV29Delete",gxvar:"AV29Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV29Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(33),gx.O.AV29Delete,gx.O.AV38Delete_GXI)},c2v:function(){gx.O.AV38Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV29Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(33))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(33))}, gxvar_GXI:'AV38Delete_GXI',nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV31Display",gxold:"OV31Display",gxvar:"AV31Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV31Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(33),gx.O.AV31Display,gx.O.AV39Display_GXI)},c2v:function(){gx.O.AV39Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV31Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(33))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(33))}, gxvar_GXI:'AV39Display_GXI',nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:this.Valid_Br_information_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_ID",gxz:"Z85BR_Information_ID",gxold:"O85BR_Information_ID",gxvar:"A85BR_Information_ID",ucs:[],op:[38],ip:[38,37],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z85BR_Information_ID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(33),gx.O.A85BR_Information_ID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(33),',')},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:2000,dec:0,sign:false,ro:1,isacc:0,grid:33,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(33),gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(33))},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE",gxz:"ZV18ddo_BR_Information_IDTitleControlIdToReplace",gxold:"OV18ddo_BR_Information_IDTitleControlIdToReplace",gxvar:"AV18ddo_BR_Information_IDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18ddo_BR_Information_IDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18ddo_BR_Information_IDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE",gx.O.AV18ddo_BR_Information_IDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18ddo_BR_Information_IDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_BR_Information_PatientNoTitleControlIdToReplace",gxold:"OV20ddo_BR_Information_PatientNoTitleControlIdToReplace",gxvar:"AV20ddo_BR_Information_PatientNoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_BR_Information_PatientNoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_BR_Information_PatientNoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gx.O.AV20ddo_BR_Information_PatientNoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_BR_Information_PatientNoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z87JC_ProviderID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERID",gx.O.A87JC_ProviderID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("JC_PROVIDERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[52]={ id:52 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.ZV27Update = "" ;
   this.OV27Update = "" ;
   this.ZV29Delete = "" ;
   this.OV29Delete = "" ;
   this.ZV31Display = "" ;
   this.OV31Display = "" ;
   this.Z85BR_Information_ID = 0 ;
   this.O85BR_Information_ID = 0 ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.AV18ddo_BR_Information_IDTitleControlIdToReplace = "" ;
   this.ZV18ddo_BR_Information_IDTitleControlIdToReplace = "" ;
   this.OV18ddo_BR_Information_IDTitleControlIdToReplace = "" ;
   this.AV20ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.ZV20ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.OV20ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.A87JC_ProviderID = 0 ;
   this.Z87JC_ProviderID = 0 ;
   this.O87JC_ProviderID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV24GridCurrentPage = 0 ;
   this.AV21DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV18ddo_BR_Information_IDTitleControlIdToReplace = "" ;
   this.AV20ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.A87JC_ProviderID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV8JC_ProviderID = 0 ;
   this.AV27Update = "" ;
   this.AV29Delete = "" ;
   this.AV31Display = "" ;
   this.A85BR_Information_ID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.AV40Pgmname = "" ;
   this.AV28IsAuthorized_Update = false ;
   this.AV30IsAuthorized_Delete = false ;
   this.AV32IsAuthorized_Display = false ;
   this.AV33IsAuthorized_BR_Information_PatientNo = false ;
   this.Events = {"e118m2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e128m2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e138m2_client": ["DDO_BR_INFORMATION_ID.ONOPTIONCLICKED", true] ,"e148m2_client": ["DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", true] ,"e158m2_client": ["'DOINSERT'", true] ,"e198m2_client": ["ENTER", true] ,"e208m2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV18ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV17BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV19BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_ID","Title")',ctrl:'BR_INFORMATION_ID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{ctrl:'GRID',prop:'Rows'},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'this.DDO_BR_INFORMATION_IDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_INFORMATION_ID',prop:'TitleControlIdToReplace'},{av:'AV18ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.TitleControlIdToReplace',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'TitleControlIdToReplace'},{av:'AV20ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Visible")',ctrl:'JC_PROVIDERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV21DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_INFORMATION_ID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.DDO_BR_INFORMATION_IDContainer.ActiveEventKey',ctrl:'DDO_BR_INFORMATION_ID',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_INFORMATION_IDContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_ID',prop:'SortedStatus'},{av:'AV17BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV19BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_ID","Title")',ctrl:'BR_INFORMATION_ID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.ActiveEventKey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV17BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV19BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_ID","Title")',ctrl:'BR_INFORMATION_ID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV28IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV30IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV32IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV33IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true}],[{av:'AV27Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV29Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'AV31Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Link")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.setVCMap("AV40Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV28IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV30IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV32IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV33IsAuthorized_BR_Information_PatientNo", "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", 0, "boolean", 4, 0);
   this.setVCMap("AV8JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV8JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV40Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV28IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV30IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV32IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV33IsAuthorized_BR_Information_PatientNo", "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", 0, "boolean", 4, 0);
   this.setVCMap("AV8JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV40Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV28IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV30IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV32IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV33IsAuthorized_BR_Information_PatientNo", "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar({rfrVar:"AV8JC_ProviderID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar({rfrVar:"AV40Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV28IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV30IsAuthorized_Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV32IsAuthorized_Display"});
   GridContainer.addRefreshingVar({rfrVar:"AV33IsAuthorized_BR_Information_PatientNo"});
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   this.Initialize( );
});
