/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:47.13
*/
gx.evt.autoSkip = false;
gx.define('jc_providerww', false, function () {
   this.ServerClass =  "jc_providerww" ;
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
         this.DDO_JC_PROVIDERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_JC_PROVIDERNAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_JC_PROVIDERPHONEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_JC_PROVIDERUSERContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_JC_PROVIDERIDContainer.SortedStatus =  ""  ;
      this.DDO_JC_PROVIDERNAMEContainer.SortedStatus =  ""  ;
      this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus =  ""  ;
      this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus =  ""  ;
      this.DDO_JC_PROVIDERPHONEContainer.SortedStatus =  ""  ;
      this.DDO_JC_PROVIDERUSERContainer.SortedStatus =  ""  ;
   };
   this.e238i2_client=function()
   {
      this.clearMessages();
      this.popupOpenUrl(gx.http.formatLink("wwpbaseobjects.addressdisplay.aspx",[this.A161JC_ProviderAddresss, ""]), []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e118i2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e128i2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e138i2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e148i2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e158i2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e168i2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e178i2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e188i2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERUSER.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e198i2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e248i2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e258i2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,49,51,53,55,57,59,61,62,63,64,65,66,67,68,69,70,71,72,73,74];
   this.GXLastCtrlId =74;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"jc_providerww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(87,35,"JC_PROVIDERID","","","JC_ProviderID","int",0,"px",18,18,"right",null,[],87,"JC_ProviderID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(89,36,"JC_PROVIDERNAME","","","JC_ProviderName","svchar",410,"px",200,80,"left",null,[],89,"JC_ProviderName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(160,37,"JC_PROVIDERSHORTNAME","","","JC_ProviderShortName","svchar",0,"px",100,80,"left",null,[],160,"JC_ProviderShortName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(161,38,"JC_PROVIDERADDRESSS","","","JC_ProviderAddresss","svchar",410,"px",1024,80,"left","e238i2_client",[],161,"JC_ProviderAddresss",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(162,39,"JC_PROVIDERPHONE","","","JC_ProviderPhone","char",0,"px",20,20,"left",null,[],162,"JC_ProviderPhone",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(163,40,"JC_PROVIDERUSER","","","JC_ProviderUser","svchar",0,"px",40,40,"left",null,[],163,"JC_ProviderUser",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e118i2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e128i2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_JC_PROVIDERIDContainer = gx.uc.getNew(this, 48, 32, "BootstrapDropDownOptions", "DDO_JC_PROVIDERIDContainer", "Ddo_jc_providerid", "DDO_JC_PROVIDERID");
   var DDO_JC_PROVIDERIDContainer = this.DDO_JC_PROVIDERIDContainer;
   DDO_JC_PROVIDERIDContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_JC_PROVIDERIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_JC_PROVIDERIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_JC_PROVIDERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_JC_PROVIDERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_JC_PROVIDERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_JC_PROVIDERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_JC_PROVIDERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_JC_PROVIDERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_JC_PROVIDERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_JC_PROVIDERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERIDContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERIDContainer.addV2CFunction('AV16JC_ProviderIDTitleFilterData', "vJC_PROVIDERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16JC_ProviderIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERIDTITLEFILTERDATA",UC.ParentObject.AV16JC_ProviderIDTitleFilterData); });
   DDO_JC_PROVIDERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERIDContainer.addEventHandler("OnOptionClicked", this.e138i2_client);
   this.setUserControl(DDO_JC_PROVIDERIDContainer);
   this.DDO_JC_PROVIDERNAMEContainer = gx.uc.getNew(this, 50, 49, "BootstrapDropDownOptions", "DDO_JC_PROVIDERNAMEContainer", "Ddo_jc_providername", "DDO_JC_PROVIDERNAME");
   var DDO_JC_PROVIDERNAMEContainer = this.DDO_JC_PROVIDERNAMEContainer;
   DDO_JC_PROVIDERNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListProc", "Datalistproc", "JC_ProviderWWGetFilterData", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_JC_PROVIDERNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERNAMEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERNAMEContainer.addV2CFunction('AV20JC_ProviderNameTitleFilterData', "vJC_PROVIDERNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20JC_ProviderNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERNAMETITLEFILTERDATA",UC.ParentObject.AV20JC_ProviderNameTitleFilterData); });
   DDO_JC_PROVIDERNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERNAMEContainer.addEventHandler("OnOptionClicked", this.e148i2_client);
   this.setUserControl(DDO_JC_PROVIDERNAMEContainer);
   this.DDO_JC_PROVIDERSHORTNAMEContainer = gx.uc.getNew(this, 52, 49, "BootstrapDropDownOptions", "DDO_JC_PROVIDERSHORTNAMEContainer", "Ddo_jc_providershortname", "DDO_JC_PROVIDERSHORTNAME");
   var DDO_JC_PROVIDERSHORTNAMEContainer = this.DDO_JC_PROVIDERSHORTNAMEContainer;
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("DataListProc", "Datalistproc", "JC_ProviderWWGetFilterData", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERSHORTNAMEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERSHORTNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERSHORTNAMEContainer.addV2CFunction('AV24JC_ProviderShortNameTitleFilterData', "vJC_PROVIDERSHORTNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERSHORTNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24JC_ProviderShortNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERSHORTNAMETITLEFILTERDATA",UC.ParentObject.AV24JC_ProviderShortNameTitleFilterData); });
   DDO_JC_PROVIDERSHORTNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERSHORTNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERSHORTNAMEContainer.addEventHandler("OnOptionClicked", this.e158i2_client);
   this.setUserControl(DDO_JC_PROVIDERSHORTNAMEContainer);
   this.DDO_JC_PROVIDERADDRESSSContainer = gx.uc.getNew(this, 54, 49, "BootstrapDropDownOptions", "DDO_JC_PROVIDERADDRESSSContainer", "Ddo_jc_provideraddresss", "DDO_JC_PROVIDERADDRESSS");
   var DDO_JC_PROVIDERADDRESSSContainer = this.DDO_JC_PROVIDERADDRESSSContainer;
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("DataListProc", "Datalistproc", "JC_ProviderWWGetFilterData", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERADDRESSSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERADDRESSSContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERADDRESSSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERADDRESSSContainer.addV2CFunction('AV28JC_ProviderAddresssTitleFilterData', "vJC_PROVIDERADDRESSSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERADDRESSSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28JC_ProviderAddresssTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERADDRESSSTITLEFILTERDATA",UC.ParentObject.AV28JC_ProviderAddresssTitleFilterData); });
   DDO_JC_PROVIDERADDRESSSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERADDRESSSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERADDRESSSContainer.addEventHandler("OnOptionClicked", this.e168i2_client);
   this.setUserControl(DDO_JC_PROVIDERADDRESSSContainer);
   this.DDO_JC_PROVIDERPHONEContainer = gx.uc.getNew(this, 56, 49, "BootstrapDropDownOptions", "DDO_JC_PROVIDERPHONEContainer", "Ddo_jc_providerphone", "DDO_JC_PROVIDERPHONE");
   var DDO_JC_PROVIDERPHONEContainer = this.DDO_JC_PROVIDERPHONEContainer;
   DDO_JC_PROVIDERPHONEContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERPHONEContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERPHONEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERPHONEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERPHONEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_JC_PROVIDERPHONEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_JC_PROVIDERPHONEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_JC_PROVIDERPHONEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_JC_PROVIDERPHONEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("DataListProc", "Datalistproc", "JC_ProviderWWGetFilterData", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_JC_PROVIDERPHONEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_JC_PROVIDERPHONEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERPHONEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERPHONEContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERPHONEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERPHONEContainer.addV2CFunction('AV32JC_ProviderPhoneTitleFilterData', "vJC_PROVIDERPHONETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERPHONEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32JC_ProviderPhoneTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERPHONETITLEFILTERDATA",UC.ParentObject.AV32JC_ProviderPhoneTitleFilterData); });
   DDO_JC_PROVIDERPHONEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERPHONEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERPHONEContainer.addEventHandler("OnOptionClicked", this.e178i2_client);
   this.setUserControl(DDO_JC_PROVIDERPHONEContainer);
   this.DDO_JC_PROVIDERUSERContainer = gx.uc.getNew(this, 58, 49, "BootstrapDropDownOptions", "DDO_JC_PROVIDERUSERContainer", "Ddo_jc_provideruser", "DDO_JC_PROVIDERUSER");
   var DDO_JC_PROVIDERUSERContainer = this.DDO_JC_PROVIDERUSERContainer;
   DDO_JC_PROVIDERUSERContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERUSERContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERUSERContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERUSERContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERUSERContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERUSERContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERUSERContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_JC_PROVIDERUSERContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_JC_PROVIDERUSERContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_JC_PROVIDERUSERContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_JC_PROVIDERUSERContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("DataListProc", "Datalistproc", "JC_ProviderWWGetFilterData", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_JC_PROVIDERUSERContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_JC_PROVIDERUSERContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERUSERContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERUSERContainer.addV2CFunction('AV40DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERUSERContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV40DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERUSERContainer.addV2CFunction('AV36JC_ProviderUserTitleFilterData', "vJC_PROVIDERUSERTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERUSERContainer.addC2VFunction(function(UC) { UC.ParentObject.AV36JC_ProviderUserTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERUSERTITLEFILTERDATA",UC.ParentObject.AV36JC_ProviderUserTitleFilterData); });
   DDO_JC_PROVIDERUSERContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERUSERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERUSERContainer.addEventHandler("OnOptionClicked", this.e188i2_client);
   this.setUserControl(DDO_JC_PROVIDERUSERContainer);
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
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z87JC_ProviderID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERID",row || gx.fn.currentGridRowImpl(31),gx.O.A87JC_ProviderID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("JC_PROVIDERID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"svchar",len:200,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERNAME",gxz:"Z89JC_ProviderName",gxold:"O89JC_ProviderName",gxvar:"A89JC_ProviderName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A89JC_ProviderName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z89JC_ProviderName=Value},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERNAME",row || gx.fn.currentGridRowImpl(31),gx.O.A89JC_ProviderName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A89JC_ProviderName=this.val()},val:function(row){return gx.fn.getGridControlValue("JC_PROVIDERNAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERSHORTNAME",gxz:"Z160JC_ProviderShortName",gxold:"O160JC_ProviderShortName",gxvar:"A160JC_ProviderShortName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A160JC_ProviderShortName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z160JC_ProviderShortName=Value},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERSHORTNAME",row || gx.fn.currentGridRowImpl(31),gx.O.A160JC_ProviderShortName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A160JC_ProviderShortName=this.val()},val:function(row){return gx.fn.getGridControlValue("JC_PROVIDERSHORTNAME",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERADDRESSS",gxz:"Z161JC_ProviderAddresss",gxold:"O161JC_ProviderAddresss",gxvar:"A161JC_ProviderAddresss",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A161JC_ProviderAddresss=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z161JC_ProviderAddresss=Value},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERADDRESSS",row || gx.fn.currentGridRowImpl(31),gx.O.A161JC_ProviderAddresss,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A161JC_ProviderAddresss=this.val()},val:function(row){return gx.fn.getGridControlValue("JC_PROVIDERADDRESSS",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn,evt:"e238i2_client"};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERPHONE",gxz:"Z162JC_ProviderPhone",gxold:"O162JC_ProviderPhone",gxvar:"A162JC_ProviderPhone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'tel',v2v:function(Value){if(Value!==undefined)gx.O.A162JC_ProviderPhone=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z162JC_ProviderPhone=Value},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERPHONE",row || gx.fn.currentGridRowImpl(31),gx.O.A162JC_ProviderPhone,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A162JC_ProviderPhone=this.val()},val:function(row){return gx.fn.getGridControlValue("JC_PROVIDERPHONE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERUSER",gxz:"Z163JC_ProviderUser",gxold:"O163JC_ProviderUser",gxvar:"A163JC_ProviderUser",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A163JC_ProviderUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z163JC_ProviderUser=Value},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERUSER",row || gx.fn.currentGridRowImpl(31),gx.O.A163JC_ProviderUser,0)},c2v:function(){if(this.val()!==undefined)gx.O.A163JC_ProviderUser=this.val()},val:function(row){return gx.fn.getGridControlValue("JC_PROVIDERUSER",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_JC_ProviderIDTitleControlIdToReplace",gxold:"OV19ddo_JC_ProviderIDTitleControlIdToReplace",gxvar:"AV19ddo_JC_ProviderIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_JC_ProviderIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_JC_ProviderIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_JC_ProviderIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_JC_ProviderIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_JC_ProviderNameTitleControlIdToReplace",gxold:"OV23ddo_JC_ProviderNameTitleControlIdToReplace",gxvar:"AV23ddo_JC_ProviderNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_JC_ProviderNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_JC_ProviderNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE",gx.O.AV23ddo_JC_ProviderNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_JC_ProviderNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_JC_ProviderShortNameTitleControlIdToReplace",gxold:"OV27ddo_JC_ProviderShortNameTitleControlIdToReplace",gxvar:"AV27ddo_JC_ProviderShortNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_JC_ProviderShortNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_JC_ProviderShortNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE",gx.O.AV27ddo_JC_ProviderShortNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_JC_ProviderShortNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_JC_ProviderAddresssTitleControlIdToReplace",gxold:"OV31ddo_JC_ProviderAddresssTitleControlIdToReplace",gxvar:"AV31ddo_JC_ProviderAddresssTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_JC_ProviderAddresssTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_JC_ProviderAddresssTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_JC_ProviderAddresssTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_JC_ProviderAddresssTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_JC_ProviderPhoneTitleControlIdToReplace",gxold:"OV35ddo_JC_ProviderPhoneTitleControlIdToReplace",gxvar:"AV35ddo_JC_ProviderPhoneTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_JC_ProviderPhoneTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_JC_ProviderPhoneTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE",gx.O.AV35ddo_JC_ProviderPhoneTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_JC_ProviderPhoneTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE",gxz:"ZV39ddo_JC_ProviderUserTitleControlIdToReplace",gxold:"OV39ddo_JC_ProviderUserTitleControlIdToReplace",gxvar:"AV39ddo_JC_ProviderUserTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39ddo_JC_ProviderUserTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39ddo_JC_ProviderUserTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE",gx.O.AV39ddo_JC_ProviderUserTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39ddo_JC_ProviderUserTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERID",gxz:"ZV17TFJC_ProviderID",gxold:"OV17TFJC_ProviderID",gxvar:"AV17TFJC_ProviderID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFJC_ProviderID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFJC_ProviderID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERID",gx.O.AV17TFJC_ProviderID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFJC_ProviderID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFJC_PROVIDERID",',')},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERID_TO",gxz:"ZV18TFJC_ProviderID_To",gxold:"OV18TFJC_ProviderID_To",gxvar:"AV18TFJC_ProviderID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFJC_ProviderID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFJC_ProviderID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERID_TO",gx.O.AV18TFJC_ProviderID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFJC_ProviderID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFJC_PROVIDERID_TO",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERNAME",gxz:"ZV21TFJC_ProviderName",gxold:"OV21TFJC_ProviderName",gxvar:"AV21TFJC_ProviderName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFJC_ProviderName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFJC_ProviderName=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERNAME",gx.O.AV21TFJC_ProviderName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFJC_ProviderName=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERNAME")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERNAME_SEL",gxz:"ZV22TFJC_ProviderName_Sel",gxold:"OV22TFJC_ProviderName_Sel",gxvar:"AV22TFJC_ProviderName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFJC_ProviderName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFJC_ProviderName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERNAME_SEL",gx.O.AV22TFJC_ProviderName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFJC_ProviderName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERNAME_SEL")},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERSHORTNAME",gxz:"ZV25TFJC_ProviderShortName",gxold:"OV25TFJC_ProviderShortName",gxvar:"AV25TFJC_ProviderShortName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFJC_ProviderShortName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFJC_ProviderShortName=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERSHORTNAME",gx.O.AV25TFJC_ProviderShortName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFJC_ProviderShortName=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERSHORTNAME")},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERSHORTNAME_SEL",gxz:"ZV26TFJC_ProviderShortName_Sel",gxold:"OV26TFJC_ProviderShortName_Sel",gxvar:"AV26TFJC_ProviderShortName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFJC_ProviderShortName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFJC_ProviderShortName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERSHORTNAME_SEL",gx.O.AV26TFJC_ProviderShortName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFJC_ProviderShortName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERSHORTNAME_SEL")},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:1024,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERADDRESSS",gxz:"ZV29TFJC_ProviderAddresss",gxold:"OV29TFJC_ProviderAddresss",gxvar:"AV29TFJC_ProviderAddresss",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFJC_ProviderAddresss=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFJC_ProviderAddresss=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERADDRESSS",gx.O.AV29TFJC_ProviderAddresss,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFJC_ProviderAddresss=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERADDRESSS")},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:1024,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERADDRESSS_SEL",gxz:"ZV30TFJC_ProviderAddresss_Sel",gxold:"OV30TFJC_ProviderAddresss_Sel",gxvar:"AV30TFJC_ProviderAddresss_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFJC_ProviderAddresss_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFJC_ProviderAddresss_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERADDRESSS_SEL",gx.O.AV30TFJC_ProviderAddresss_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFJC_ProviderAddresss_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERADDRESSS_SEL")},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERPHONE",gxz:"ZV33TFJC_ProviderPhone",gxold:"OV33TFJC_ProviderPhone",gxvar:"AV33TFJC_ProviderPhone",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33TFJC_ProviderPhone=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33TFJC_ProviderPhone=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERPHONE",gx.O.AV33TFJC_ProviderPhone,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33TFJC_ProviderPhone=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERPHONE")},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERPHONE_SEL",gxz:"ZV34TFJC_ProviderPhone_Sel",gxold:"OV34TFJC_ProviderPhone_Sel",gxvar:"AV34TFJC_ProviderPhone_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34TFJC_ProviderPhone_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34TFJC_ProviderPhone_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERPHONE_SEL",gx.O.AV34TFJC_ProviderPhone_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34TFJC_ProviderPhone_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERPHONE_SEL")},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERUSER",gxz:"ZV37TFJC_ProviderUser",gxold:"OV37TFJC_ProviderUser",gxvar:"AV37TFJC_ProviderUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37TFJC_ProviderUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37TFJC_ProviderUser=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERUSER",gx.O.AV37TFJC_ProviderUser,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37TFJC_ProviderUser=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERUSER")},nac:gx.falseFn};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFJC_PROVIDERUSER_SEL",gxz:"ZV38TFJC_ProviderUser_Sel",gxold:"OV38TFJC_ProviderUser_Sel",gxvar:"AV38TFJC_ProviderUser_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38TFJC_ProviderUser_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38TFJC_ProviderUser_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFJC_PROVIDERUSER_SEL",gx.O.AV38TFJC_ProviderUser_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV38TFJC_ProviderUser_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFJC_PROVIDERUSER_SEL")},nac:gx.falseFn};
   this.ZV45Display = "" ;
   this.OV45Display = "" ;
   this.ZV46Update = "" ;
   this.OV46Update = "" ;
   this.ZV48Delete = "" ;
   this.OV48Delete = "" ;
   this.Z87JC_ProviderID = 0 ;
   this.O87JC_ProviderID = 0 ;
   this.Z89JC_ProviderName = "" ;
   this.O89JC_ProviderName = "" ;
   this.Z160JC_ProviderShortName = "" ;
   this.O160JC_ProviderShortName = "" ;
   this.Z161JC_ProviderAddresss = "" ;
   this.O161JC_ProviderAddresss = "" ;
   this.Z162JC_ProviderPhone = "" ;
   this.O162JC_ProviderPhone = "" ;
   this.Z163JC_ProviderUser = "" ;
   this.O163JC_ProviderUser = "" ;
   this.AV19ddo_JC_ProviderIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_JC_ProviderIDTitleControlIdToReplace = "" ;
   this.OV19ddo_JC_ProviderIDTitleControlIdToReplace = "" ;
   this.AV23ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.ZV23ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.OV23ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.AV27ddo_JC_ProviderShortNameTitleControlIdToReplace = "" ;
   this.ZV27ddo_JC_ProviderShortNameTitleControlIdToReplace = "" ;
   this.OV27ddo_JC_ProviderShortNameTitleControlIdToReplace = "" ;
   this.AV31ddo_JC_ProviderAddresssTitleControlIdToReplace = "" ;
   this.ZV31ddo_JC_ProviderAddresssTitleControlIdToReplace = "" ;
   this.OV31ddo_JC_ProviderAddresssTitleControlIdToReplace = "" ;
   this.AV35ddo_JC_ProviderPhoneTitleControlIdToReplace = "" ;
   this.ZV35ddo_JC_ProviderPhoneTitleControlIdToReplace = "" ;
   this.OV35ddo_JC_ProviderPhoneTitleControlIdToReplace = "" ;
   this.AV39ddo_JC_ProviderUserTitleControlIdToReplace = "" ;
   this.ZV39ddo_JC_ProviderUserTitleControlIdToReplace = "" ;
   this.OV39ddo_JC_ProviderUserTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFJC_ProviderID = 0 ;
   this.ZV17TFJC_ProviderID = 0 ;
   this.OV17TFJC_ProviderID = 0 ;
   this.AV18TFJC_ProviderID_To = 0 ;
   this.ZV18TFJC_ProviderID_To = 0 ;
   this.OV18TFJC_ProviderID_To = 0 ;
   this.AV21TFJC_ProviderName = "" ;
   this.ZV21TFJC_ProviderName = "" ;
   this.OV21TFJC_ProviderName = "" ;
   this.AV22TFJC_ProviderName_Sel = "" ;
   this.ZV22TFJC_ProviderName_Sel = "" ;
   this.OV22TFJC_ProviderName_Sel = "" ;
   this.AV25TFJC_ProviderShortName = "" ;
   this.ZV25TFJC_ProviderShortName = "" ;
   this.OV25TFJC_ProviderShortName = "" ;
   this.AV26TFJC_ProviderShortName_Sel = "" ;
   this.ZV26TFJC_ProviderShortName_Sel = "" ;
   this.OV26TFJC_ProviderShortName_Sel = "" ;
   this.AV29TFJC_ProviderAddresss = "" ;
   this.ZV29TFJC_ProviderAddresss = "" ;
   this.OV29TFJC_ProviderAddresss = "" ;
   this.AV30TFJC_ProviderAddresss_Sel = "" ;
   this.ZV30TFJC_ProviderAddresss_Sel = "" ;
   this.OV30TFJC_ProviderAddresss_Sel = "" ;
   this.AV33TFJC_ProviderPhone = "" ;
   this.ZV33TFJC_ProviderPhone = "" ;
   this.OV33TFJC_ProviderPhone = "" ;
   this.AV34TFJC_ProviderPhone_Sel = "" ;
   this.ZV34TFJC_ProviderPhone_Sel = "" ;
   this.OV34TFJC_ProviderPhone_Sel = "" ;
   this.AV37TFJC_ProviderUser = "" ;
   this.ZV37TFJC_ProviderUser = "" ;
   this.OV37TFJC_ProviderUser = "" ;
   this.AV38TFJC_ProviderUser_Sel = "" ;
   this.ZV38TFJC_ProviderUser_Sel = "" ;
   this.OV38TFJC_ProviderUser_Sel = "" ;
   this.AV42GridCurrentPage = 0 ;
   this.AV40DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_JC_ProviderIDTitleControlIdToReplace = "" ;
   this.AV23ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.AV27ddo_JC_ProviderShortNameTitleControlIdToReplace = "" ;
   this.AV31ddo_JC_ProviderAddresssTitleControlIdToReplace = "" ;
   this.AV35ddo_JC_ProviderPhoneTitleControlIdToReplace = "" ;
   this.AV39ddo_JC_ProviderUserTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFJC_ProviderID = 0 ;
   this.AV18TFJC_ProviderID_To = 0 ;
   this.AV21TFJC_ProviderName = "" ;
   this.AV22TFJC_ProviderName_Sel = "" ;
   this.AV25TFJC_ProviderShortName = "" ;
   this.AV26TFJC_ProviderShortName_Sel = "" ;
   this.AV29TFJC_ProviderAddresss = "" ;
   this.AV30TFJC_ProviderAddresss_Sel = "" ;
   this.AV33TFJC_ProviderPhone = "" ;
   this.AV34TFJC_ProviderPhone_Sel = "" ;
   this.AV37TFJC_ProviderUser = "" ;
   this.AV38TFJC_ProviderUser_Sel = "" ;
   this.AV45Display = "" ;
   this.AV46Update = "" ;
   this.AV48Delete = "" ;
   this.A87JC_ProviderID = 0 ;
   this.A89JC_ProviderName = "" ;
   this.A160JC_ProviderShortName = "" ;
   this.A161JC_ProviderAddresss = "" ;
   this.A162JC_ProviderPhone = "" ;
   this.A163JC_ProviderUser = "" ;
   this.AV68Pgmname = "" ;
   this.AV47IsAuthorized_Update = false ;
   this.AV49IsAuthorized_Delete = false ;
   this.Events = {"e118i2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e128i2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e138i2_client": ["DDO_JC_PROVIDERID.ONOPTIONCLICKED", true] ,"e148i2_client": ["DDO_JC_PROVIDERNAME.ONOPTIONCLICKED", true] ,"e158i2_client": ["DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED", true] ,"e168i2_client": ["DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED", true] ,"e178i2_client": ["DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED", true] ,"e188i2_client": ["DDO_JC_PROVIDERUSER.ONOPTIONCLICKED", true] ,"e198i2_client": ["'DOINSERT'", true] ,"e248i2_client": ["ENTER", true] ,"e258i2_client": ["CANCEL", true] ,"e238i2_client": ["JC_PROVIDERADDRESSS.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERID","Visible")',ctrl:'vTFJC_PROVIDERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERID_TO","Visible")',ctrl:'vTFJC_PROVIDERID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERNAME","Visible")',ctrl:'vTFJC_PROVIDERNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERNAME_SEL","Visible")',ctrl:'vTFJC_PROVIDERNAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERSHORTNAME","Visible")',ctrl:'vTFJC_PROVIDERSHORTNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERSHORTNAME_SEL","Visible")',ctrl:'vTFJC_PROVIDERSHORTNAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERADDRESSS","Visible")',ctrl:'vTFJC_PROVIDERADDRESSS',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERADDRESSS_SEL","Visible")',ctrl:'vTFJC_PROVIDERADDRESSS_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERPHONE","Visible")',ctrl:'vTFJC_PROVIDERPHONE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERPHONE_SEL","Visible")',ctrl:'vTFJC_PROVIDERPHONE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERUSER","Visible")',ctrl:'vTFJC_PROVIDERUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFJC_PROVIDERUSER_SEL","Visible")',ctrl:'vTFJC_PROVIDERUSER_SEL',prop:'Visible'},{av:'this.DDO_JC_PROVIDERIDContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_JC_PROVIDERNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERNAME',prop:'TitleControlIdToReplace'},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'TitleControlIdToReplace'},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'TitleControlIdToReplace'},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_JC_PROVIDERPHONEContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERPHONE',prop:'TitleControlIdToReplace'},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_JC_PROVIDERUSERContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERUSER',prop:'TitleControlIdToReplace'},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV40DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'this.DDO_JC_PROVIDERUSERContainer.SelectedValue_set',ctrl:'DDO_JC_PROVIDERUSER',prop:'SelectedValue_set'},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'this.DDO_JC_PROVIDERUSERContainer.FilteredText_set',ctrl:'DDO_JC_PROVIDERUSER',prop:'FilteredText_set'},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'this.DDO_JC_PROVIDERPHONEContainer.SelectedValue_set',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SelectedValue_set'},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'this.DDO_JC_PROVIDERPHONEContainer.FilteredText_set',ctrl:'DDO_JC_PROVIDERPHONE',prop:'FilteredText_set'},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SelectedValue_set',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SelectedValue_set'},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.FilteredText_set',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'FilteredText_set'},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SelectedValue_set',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SelectedValue_set'},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.FilteredText_set',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'FilteredText_set'},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'this.DDO_JC_PROVIDERNAMEContainer.SelectedValue_set',ctrl:'DDO_JC_PROVIDERNAME',prop:'SelectedValue_set'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'this.DDO_JC_PROVIDERNAMEContainer.FilteredText_set',ctrl:'DDO_JC_PROVIDERNAME',prop:'FilteredText_set'},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_JC_PROVIDERIDContainer.FilteredText_set',ctrl:'DDO_JC_PROVIDERID',prop:'FilteredText_set'},{av:'this.DDO_JC_PROVIDERIDContainer.FilteredTextTo_set',ctrl:'DDO_JC_PROVIDERID',prop:'FilteredTextTo_set'},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'}]];
   this.EvtParms["JC_PROVIDERADDRESSS.CLICK"] = [[{av:'A161JC_ProviderAddresss',fld:'JC_PROVIDERADDRESSS',pic:'',hsh:true}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_JC_PROVIDERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERID',prop:'ActiveEventKey'},{av:'this.DDO_JC_PROVIDERIDContainer.FilteredText_get',ctrl:'DDO_JC_PROVIDERID',prop:'FilteredText_get'},{av:'this.DDO_JC_PROVIDERIDContainer.FilteredTextTo_get',ctrl:'DDO_JC_PROVIDERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_JC_PROVIDERNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_JC_PROVIDERNAMEContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERNAME',prop:'ActiveEventKey'},{av:'this.DDO_JC_PROVIDERNAMEContainer.FilteredText_get',ctrl:'DDO_JC_PROVIDERNAME',prop:'FilteredText_get'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SelectedValue_get',ctrl:'DDO_JC_PROVIDERNAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'ActiveEventKey'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.FilteredText_get',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'FilteredText_get'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SelectedValue_get',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'ActiveEventKey'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.FilteredText_get',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'FilteredText_get'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SelectedValue_get',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_JC_PROVIDERPHONEContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERPHONE',prop:'ActiveEventKey'},{av:'this.DDO_JC_PROVIDERPHONEContainer.FilteredText_get',ctrl:'DDO_JC_PROVIDERPHONE',prop:'FilteredText_get'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SelectedValue_get',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_JC_PROVIDERUSER.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_JC_PROVIDERUSERContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERUSER',prop:'ActiveEventKey'},{av:'this.DDO_JC_PROVIDERUSERContainer.FilteredText_get',ctrl:'DDO_JC_PROVIDERUSER',prop:'FilteredText_get'},{av:'this.DDO_JC_PROVIDERUSERContainer.SelectedValue_get',ctrl:'DDO_JC_PROVIDERUSER',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERUSERContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'this.DDO_JC_PROVIDERIDContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERSHORTNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERADDRESSSContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'this.DDO_JC_PROVIDERPHONEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERID","Title")',ctrl:'JC_PROVIDERID',prop:'Title'},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERSHORTNAME","Title")',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Title")',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERPHONE","Title")',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERUSER","Title")',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV45Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV46Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV48Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Link")',ctrl:'JC_PROVIDERNAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
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
gx.createParentObj(jc_providerww);
