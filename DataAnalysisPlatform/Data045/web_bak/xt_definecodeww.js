/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:44.27
*/
gx.evt.autoSkip = false;
gx.define('xt_definecodeww', false, function () {
   this.ServerClass =  "xt_definecodeww" ;
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
      this.AV60Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV42IsAuthorized_XT_DefindcodeTypeName=gx.fn.getControlValue("vISAUTHORIZED_XT_DEFINDCODETYPENAME") ;
      this.AV53BAS_TenantTenantCode=gx.fn.getControlValue("vBAS_TENANTTENANTCODE") ;
      this.AV60Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV41IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV42IsAuthorized_XT_DefindcodeTypeName=gx.fn.getControlValue("vISAUTHORIZED_XT_DEFINDCODETYPENAME") ;
      this.AV53BAS_TenantTenantCode=gx.fn.getControlValue("vBAS_TENANTTENANTCODE") ;
   };
   this.Valid_Xt_defindcodetypeid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(34) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("XT_DEFINDCODETYPEID", gx.fn.currentGridRowImpl(34));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e112g1_client=function()
   {
      this.clearMessages();
      this.call("xt_intialdefinecode.aspx", [this.AV53BAS_TenantTenantCode]);
      this.refreshOutputs([{av:'AV53BAS_TenantTenantCode',fld:'vBAS_TENANTTENANTCODE',pic:''}]);
      return gx.$.Deferred().resolve();
   };
   this.e202g2_client=function()
   {
      this.clearMessages();
      this.call("xt_definecodeoperate.aspx", [2, this.A167XT_DefineCodeID]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e122g2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e132g2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e142g2_client=function()
   {
      return this.executeServerEvent("DDO_XT_DEFINECODENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e152g2_client=function()
   {
      return this.executeServerEvent("DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e162g2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e212g2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e222g2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,43,44,45,47,48,49,51,53,55,56];
   this.GXLastCtrlId =56;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",34,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"xt_definecodeww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",35,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Minu","vMINU",36,0,"px",17,"px","e202g2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",37,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(167,38,"XT_DEFINECODEID","鏁版嵁瀛楀吀涓婚敭","","XT_DefineCodeID","int",0,"px",18,18,"right",null,[],167,"XT_DefineCodeID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(168,39,"XT_DEFINECODENAME","","","XT_DefineCodeName","svchar",0,"px",100,80,"left",null,[],168,"XT_DefineCodeName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(165,40,"XT_DEFINDCODETYPEID","鏁版嵁瀛楀吀绫诲瀷涓婚敭","","XT_DefindcodeTypeID","int",0,"px",18,18,"right",null,[],165,"XT_DefindcodeTypeID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(166,41,"XT_DEFINDCODETYPENAME","","","XT_DefindcodeTypeName","svchar",0,"px",40,40,"left",null,[],166,"XT_DefindcodeTypeName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(171,42,"XT_DEFINECODEORDER","鏁版嵁瀛楀吀淇℃伅鎺掑簭","","XT_DefineCodeOrder","int",0,"px",4,4,"right",null,[],171,"XT_DefineCodeOrder",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 46, 28, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e122g2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e132g2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_XT_DEFINECODENAMEContainer = gx.uc.getNew(this, 50, 28, "BootstrapDropDownOptions", "DDO_XT_DEFINECODENAMEContainer", "Ddo_xt_definecodename", "DDO_XT_DEFINECODENAME");
   var DDO_XT_DEFINECODENAMEContainer = this.DDO_XT_DEFINECODENAMEContainer;
   DDO_XT_DEFINECODENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_DEFINECODENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_DEFINECODENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_DEFINECODENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_DEFINECODENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_XT_DEFINECODENAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_XT_DEFINECODENAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_XT_DEFINECODENAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_XT_DEFINECODENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_XT_DEFINECODENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_XT_DEFINECODENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_DEFINECODENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_DEFINECODENAMEContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_DEFINECODENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_XT_DEFINECODENAMEContainer.addV2CFunction('AV20XT_DefineCodeNameTitleFilterData', "vXT_DEFINECODENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_DEFINECODENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20XT_DefineCodeNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_DEFINECODENAMETITLEFILTERDATA",UC.ParentObject.AV20XT_DefineCodeNameTitleFilterData); });
   DDO_XT_DEFINECODENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_XT_DEFINECODENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_DEFINECODENAMEContainer.addEventHandler("OnOptionClicked", this.e142g2_client);
   this.setUserControl(DDO_XT_DEFINECODENAMEContainer);
   this.DDO_XT_DEFINDCODETYPENAMEContainer = gx.uc.getNew(this, 52, 28, "BootstrapDropDownOptions", "DDO_XT_DEFINDCODETYPENAMEContainer", "Ddo_xt_defindcodetypename", "DDO_XT_DEFINDCODETYPENAME");
   var DDO_XT_DEFINDCODETYPENAMEContainer = this.DDO_XT_DEFINDCODETYPENAMEContainer;
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.addV2CFunction('AV32DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_DEFINDCODETYPENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV32DDO_TitleSettingsIcons); });
   DDO_XT_DEFINDCODETYPENAMEContainer.addV2CFunction('AV28XT_DefindcodeTypeNameTitleFilterData', "vXT_DEFINDCODETYPENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_DEFINDCODETYPENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28XT_DefindcodeTypeNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_DEFINDCODETYPENAMETITLEFILTERDATA",UC.ParentObject.AV28XT_DefindcodeTypeNameTitleFilterData); });
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_DEFINDCODETYPENAMEContainer.addEventHandler("OnOptionClicked", this.e152g2_client);
   this.setUserControl(DDO_XT_DEFINDCODETYPENAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 54, 28, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[24]={ id: 24, fld:"BTNINTIALDATA",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id:28 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vXT_DEFINDCODETYPENAME",gxz:"ZV48XT_DefindcodeTypeName",gxold:"OV48XT_DefindcodeTypeName",gxvar:"AV48XT_DefindcodeTypeName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV48XT_DefindcodeTypeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV48XT_DefindcodeTypeName=Value},v2c:function(){gx.fn.setControlValue("vXT_DEFINDCODETYPENAME",gx.O.AV48XT_DefindcodeTypeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV48XT_DefindcodeTypeName=this.val()},val:function(){return gx.fn.getControlValue("vXT_DEFINDCODETYPENAME")},nac:gx.falseFn};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV37Display",gxold:"OV37Display",gxvar:"AV37Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV37Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(34),gx.O.AV37Display,gx.O.AV57Display_GXI)},c2v:function(){gx.O.AV57Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV37Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(34))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(34))}, gxvar_GXI:'AV57Display_GXI',nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vMINU",gxz:"ZV52minu",gxold:"OV52minu",gxvar:"AV52minu",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV52minu=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV52minu=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vMINU",row || gx.fn.currentGridRowImpl(34),gx.O.AV52minu,gx.O.AV58Minu_GXI)},c2v:function(){gx.O.AV58Minu_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV52minu=this.val()},val:function(row){return gx.fn.getGridControlValue("vMINU",row || gx.fn.currentGridRowImpl(34))},val_GXI:function(row){return gx.fn.getGridControlValue("vMINU_GXI",row || gx.fn.currentGridRowImpl(34))}, gxvar_GXI:'AV58Minu_GXI',nac:gx.falseFn,evt:"e202g2_client"};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV40Delete",gxold:"OV40Delete",gxvar:"AV40Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV40Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(34),gx.O.AV40Delete,gx.O.AV59Delete_GXI)},c2v:function(){gx.O.AV59Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV40Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(34))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(34))}, gxvar_GXI:'AV59Delete_GXI',nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODEID",gxz:"Z167XT_DefineCodeID",gxold:"O167XT_DefineCodeID",gxvar:"A167XT_DefineCodeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A167XT_DefineCodeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z167XT_DefineCodeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINECODEID",row || gx.fn.currentGridRowImpl(34),gx.O.A167XT_DefineCodeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A167XT_DefineCodeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("XT_DEFINECODEID",row || gx.fn.currentGridRowImpl(34),',')},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODENAME",gxz:"Z168XT_DefineCodeName",gxold:"O168XT_DefineCodeName",gxvar:"A168XT_DefineCodeName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A168XT_DefineCodeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z168XT_DefineCodeName=Value},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINECODENAME",row || gx.fn.currentGridRowImpl(34),gx.O.A168XT_DefineCodeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A168XT_DefineCodeName=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_DEFINECODENAME",row || gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:this.Valid_Xt_defindcodetypeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPEID",gxz:"Z165XT_DefindcodeTypeID",gxold:"O165XT_DefindcodeTypeID",gxvar:"A165XT_DefindcodeTypeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z165XT_DefindcodeTypeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINDCODETYPEID",row || gx.fn.currentGridRowImpl(34),gx.O.A165XT_DefindcodeTypeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("XT_DEFINDCODETYPEID",row || gx.fn.currentGridRowImpl(34),',')},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPENAME",gxz:"Z166XT_DefindcodeTypeName",gxold:"O166XT_DefindcodeTypeName",gxvar:"A166XT_DefindcodeTypeName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A166XT_DefindcodeTypeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z166XT_DefindcodeTypeName=Value},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINDCODETYPENAME",row || gx.fn.currentGridRowImpl(34),gx.O.A166XT_DefindcodeTypeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A166XT_DefindcodeTypeName=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_DEFINDCODETYPENAME",row || gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZZ",ro:1,isacc:0,grid:34,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODEORDER",gxz:"Z171XT_DefineCodeOrder",gxold:"O171XT_DefineCodeOrder",gxvar:"A171XT_DefineCodeOrder",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A171XT_DefineCodeOrder=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z171XT_DefineCodeOrder=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINECODEORDER",row || gx.fn.currentGridRowImpl(34),gx.O.A171XT_DefineCodeOrder,0)},c2v:function(){if(this.val()!==undefined)gx.O.A171XT_DefineCodeOrder=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("XT_DEFINECODEORDER",row || gx.fn.currentGridRowImpl(34),',')},nac:gx.falseFn};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_XT_DefineCodeNameTitleControlIdToReplace",gxold:"OV23ddo_XT_DefineCodeNameTitleControlIdToReplace",gxvar:"AV23ddo_XT_DefineCodeNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_XT_DefineCodeNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_XT_DefineCodeNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE",gx.O.AV23ddo_XT_DefineCodeNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_XT_DefineCodeNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace",gxold:"OV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace",gxvar:"AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE",gx.O.AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV48XT_DefindcodeTypeName = "" ;
   this.ZV48XT_DefindcodeTypeName = "" ;
   this.OV48XT_DefindcodeTypeName = "" ;
   this.ZV37Display = "" ;
   this.OV37Display = "" ;
   this.ZV52minu = "" ;
   this.OV52minu = "" ;
   this.ZV40Delete = "" ;
   this.OV40Delete = "" ;
   this.Z167XT_DefineCodeID = 0 ;
   this.O167XT_DefineCodeID = 0 ;
   this.Z168XT_DefineCodeName = "" ;
   this.O168XT_DefineCodeName = "" ;
   this.Z165XT_DefindcodeTypeID = 0 ;
   this.O165XT_DefindcodeTypeID = 0 ;
   this.Z166XT_DefindcodeTypeName = "" ;
   this.O166XT_DefindcodeTypeName = "" ;
   this.Z171XT_DefineCodeOrder = 0 ;
   this.O171XT_DefineCodeOrder = 0 ;
   this.AV23ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.ZV23ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.OV23ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.ZV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.OV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV48XT_DefindcodeTypeName = "" ;
   this.AV34GridCurrentPage = 0 ;
   this.AV32DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV23ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV37Display = "" ;
   this.AV52minu = "" ;
   this.AV40Delete = "" ;
   this.A167XT_DefineCodeID = 0 ;
   this.A168XT_DefineCodeName = "" ;
   this.A165XT_DefindcodeTypeID = 0 ;
   this.A166XT_DefindcodeTypeName = "" ;
   this.A171XT_DefineCodeOrder = 0 ;
   this.AV60Pgmname = "" ;
   this.AV41IsAuthorized_Delete = false ;
   this.AV42IsAuthorized_XT_DefindcodeTypeName = false ;
   this.AV53BAS_TenantTenantCode = "" ;
   this.Events = {"e122g2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e132g2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e142g2_client": ["DDO_XT_DEFINECODENAME.ONOPTIONCLICKED", true] ,"e152g2_client": ["DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED", true] ,"e162g2_client": ["'DOINSERT'", true] ,"e212g2_client": ["ENTER", true] ,"e222g2_client": ["CANCEL", true] ,"e112g1_client": ["'DOINTIALDATA'", false] ,"e202g2_client": ["VMINU.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true}],[{av:'AV20XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV28XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINECODENAME","Title")',ctrl:'XT_DEFINECODENAME',prop:'Title'},{ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPENAME","Title")',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'},{ctrl:'BTNINTIALDATA',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'this.DDO_XT_DEFINECODENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_XT_DEFINECODENAME',prop:'TitleControlIdToReplace'},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_XT_DEFINDCODETYPENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'TitleControlIdToReplace'},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV32DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_XT_DEFINECODENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'this.DDO_XT_DEFINECODENAMEContainer.ActiveEventKey',ctrl:'DDO_XT_DEFINECODENAME',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_DEFINECODENAMEContainer.SortedStatus',ctrl:'DDO_XT_DEFINECODENAME',prop:'SortedStatus'},{av:'AV20XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV28XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINECODENAME","Title")',ctrl:'XT_DEFINECODENAME',prop:'Title'},{ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPENAME","Title")',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'},{ctrl:'BTNINTIALDATA',prop:'Visible'}]];
   this.EvtParms["DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'this.DDO_XT_DEFINDCODETYPENAMEContainer.ActiveEventKey',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_DEFINDCODETYPENAMEContainer.SortedStatus',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'SortedStatus'},{av:'AV20XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV28XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINECODENAME","Title")',ctrl:'XT_DEFINECODENAME',prop:'Title'},{ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPENAME","Title")',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'},{ctrl:'BTNINTIALDATA',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'A165XT_DefindcodeTypeID',fld:'XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV52minu',fld:'vMINU',pic:''},{av:'gx.fn.getCtrlProperty("vMINU","Tooltiptext")',ctrl:'vMINU',prop:'Tooltiptext'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("XT_DEFINECODENAME","Link")',ctrl:'XT_DEFINECODENAME',prop:'Link'},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPENAME","Link")',ctrl:'XT_DEFINDCODETYPENAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["'DOINTIALDATA'"] = [[{av:'AV53BAS_TenantTenantCode',fld:'vBAS_TENANTTENANTCODE',pic:''}],[{av:'AV53BAS_TenantTenantCode',fld:'vBAS_TENANTTENANTCODE',pic:''}]];
   this.EvtParms["VMINU.CLICK"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV60Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV42IsAuthorized_XT_DefindcodeTypeName", "vISAUTHORIZED_XT_DEFINDCODETYPENAME", 0, "boolean", 4, 0);
   this.setVCMap("AV53BAS_TenantTenantCode", "vBAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("AV60Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV42IsAuthorized_XT_DefindcodeTypeName", "vISAUTHORIZED_XT_DEFINDCODETYPENAME", 0, "boolean", 4, 0);
   this.setVCMap("AV53BAS_TenantTenantCode", "vBAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("AV60Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV41IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV42IsAuthorized_XT_DefindcodeTypeName", "vISAUTHORIZED_XT_DEFINDCODETYPENAME", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[28]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar({rfrVar:"AV60Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV41IsAuthorized_Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV42IsAuthorized_XT_DefindcodeTypeName"});
   this.Initialize( );
});
gx.createParentObj(xt_definecodeww);
