/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:6:22.82
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secfunctionalitysecfunctionalityrolewc', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.secfunctionalitysecfunctionalityrolewc" ;
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
      this.AV50Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV8SecFunctionalityId=gx.fn.getIntegerValue("vSECFUNCTIONALITYID",',') ;
      this.AV20IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV13IsAuthorized_SecRoleName=gx.fn.getControlValue("vISAUTHORIZED_SECROLENAME") ;
      this.AV8SecFunctionalityId=gx.fn.getIntegerValue("vSECFUNCTIONALITYID",',') ;
      this.AV50Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV20IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV13IsAuthorized_SecRoleName=gx.fn.getControlValue("vISAUTHORIZED_SECROLENAME") ;
   };
   this.Valid_Secroleid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(29) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECROLEID", gx.fn.currentGridRowImpl(29));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV16OrderedBy == 1 )
      {
         this.DDO_SECROLENAMEContainer.SortedStatus =  (this.AV17OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV16OrderedBy == 2 )
      {
         this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus =  (this.AV17OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_SECROLENAMEContainer.SortedStatus =  ""  ;
      this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus =  ""  ;
   };
   this.e110s2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120s2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130s2_client=function()
   {
      return this.executeServerEvent("DDO_SECROLENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e140s2_client=function()
   {
      return this.executeServerEvent("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e180s2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e190s2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,30,31,32,33,34,35,36,38,39,40,42,44,45,47,48,49,50,51,52];
   this.GXLastCtrlId =52;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",29,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secfunctionalitysecfunctionalityrolewc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","增加空白行",true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Delete","vDELETE",30,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(4,31,"SECROLEID","角色编号","","SecRoleId","int",0,"px",4,4,"right",null,[],4,"SecRoleId",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(13,32,"SECROLENAME","","","SecRoleName","svchar",0,"px",40,40,"left",null,[],13,"SecRoleName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(12,33,"SECROLEDESCRIPTION","","","SecRoleDescription","svchar",0,"px",120,80,"left",null,[],12,"SecRoleDescription",true,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", this.CmpContext + "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
   var DVPANEL_TABLEHEADERContainer = this.DVPANEL_TABLEHEADERContainer;
   DVPANEL_TABLEHEADERContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEHEADERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEHEADERContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_TABLEHEADERContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Title", "Title", "选项", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEHEADERContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 37, 23, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.setProp("Caption", "Caption", "<CURRENT_PAGE>页/<TOTAL_PAGES>页 记录：<TOTAL_RECORDS>条", "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridCaption", "Emptygridcaption", "WWP_PagingEmptyGridCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageCaption", "Rowsperpagecaption", "WWP_PagingRowsPerPage", "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV40GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV40GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV43GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV43GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV42GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV42GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110s2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120s2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECROLENAMEContainer = gx.uc.getNew(this, 41, 23, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECROLENAMEContainer", "Ddo_secrolename", "DDO_SECROLENAME");
   var DDO_SECROLENAMEContainer = this.DDO_SECROLENAMEContainer;
   DDO_SECROLENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_SECROLENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECROLENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECROLENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECROLENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECROLENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECROLENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECROLENAMEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECROLENAMEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECROLENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECROLENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECROLENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECROLENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECROLENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECROLENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECROLENAMEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SECROLENAMEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SECROLENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SECROLENAMEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SECROLENAMEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SECROLENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SECROLENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECROLENAMEContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGetFilterData", "str");
   DDO_SECROLENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SECROLENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECROLENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECROLENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECROLENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECROLENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECROLENAMEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SECROLENAMEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SECROLENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECROLENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECROLENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SECROLENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECROLENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECROLENAMEContainer.addV2CFunction('AV30DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECROLENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV30DDO_TitleSettingsIcons); });
   DDO_SECROLENAMEContainer.addV2CFunction('AV22SecRoleNameTitleFilterData', "vSECROLENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECROLENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV22SecRoleNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECROLENAMETITLEFILTERDATA",UC.ParentObject.AV22SecRoleNameTitleFilterData); });
   DDO_SECROLENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECROLENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECROLENAMEContainer.addEventHandler("OnOptionClicked", this.e130s2_client);
   this.setUserControl(DDO_SECROLENAMEContainer);
   this.DDO_SECROLEDESCRIPTIONContainer = gx.uc.getNew(this, 43, 23, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECROLEDESCRIPTIONContainer", "Ddo_secroledescription", "DDO_SECROLEDESCRIPTION");
   var DDO_SECROLEDESCRIPTIONContainer = this.DDO_SECROLEDESCRIPTIONContainer;
   DDO_SECROLEDESCRIPTIONContainer.setProp("Class", "Class", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGetFilterData", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECROLEDESCRIPTIONContainer.addV2CFunction('AV30DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECROLEDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV30DDO_TitleSettingsIcons); });
   DDO_SECROLEDESCRIPTIONContainer.addV2CFunction('AV26SecRoleDescriptionTitleFilterData', "vSECROLEDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECROLEDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26SecRoleDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECROLEDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV26SecRoleDescriptionTitleFilterData); });
   DDO_SECROLEDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECROLEDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e140s2_client);
   this.setUserControl(DDO_SECROLEDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 46, 23, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"UNNAMEDTABLEECROLENAME",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"FILTERTEXTSECROLENAME", format:0,grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id:23 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECROLENAME",gxz:"ZV46SecRoleName",gxold:"OV46SecRoleName",gxvar:"AV46SecRoleName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV46SecRoleName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46SecRoleName=Value},v2c:function(){gx.fn.setControlValue("vSECROLENAME",gx.O.AV46SecRoleName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV46SecRoleName=this.val()},val:function(){return gx.fn.getControlValue("vSECROLENAME")},nac:gx.falseFn};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV18Delete",gxold:"OV18Delete",gxvar:"AV18Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV18Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(29),gx.O.AV18Delete,gx.O.AV49Delete_GXI)},c2v:function(){gx.O.AV49Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV18Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(29))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(29))}, gxvar_GXI:'AV49Delete_GXI',nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:this.Valid_Secroleid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEID",gxz:"Z4SecRoleId",gxold:"O4SecRoleId",gxvar:"A4SecRoleId",ucs:[],op:[32,33],ip:[32,33,31],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A4SecRoleId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z4SecRoleId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECROLEID",row || gx.fn.currentGridRowImpl(29),gx.O.A4SecRoleId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A4SecRoleId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECROLEID",row || gx.fn.currentGridRowImpl(29),',')},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLENAME",gxz:"Z13SecRoleName",gxold:"O13SecRoleName",gxvar:"A13SecRoleName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A13SecRoleName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z13SecRoleName=Value},v2c:function(row){gx.fn.setGridControlValue("SECROLENAME",row || gx.fn.currentGridRowImpl(29),gx.O.A13SecRoleName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A13SecRoleName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECROLENAME",row || gx.fn.currentGridRowImpl(29))},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:120,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEDESCRIPTION",gxz:"Z12SecRoleDescription",gxold:"O12SecRoleDescription",gxvar:"A12SecRoleDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A12SecRoleDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z12SecRoleDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECROLEDESCRIPTION",row || gx.fn.currentGridRowImpl(29),gx.O.A12SecRoleDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A12SecRoleDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECROLEDESCRIPTION",row || gx.fn.currentGridRowImpl(29))},nac:gx.falseFn};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECROLENAMETITLECONTROLIDTOREPLACE",gxz:"ZV25ddo_SecRoleNameTitleControlIdToReplace",gxold:"OV25ddo_SecRoleNameTitleControlIdToReplace",gxvar:"AV25ddo_SecRoleNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25ddo_SecRoleNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25ddo_SecRoleNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE",gx.O.AV25ddo_SecRoleNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25ddo_SecRoleNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV29ddo_SecRoleDescriptionTitleControlIdToReplace",gxold:"OV29ddo_SecRoleDescriptionTitleControlIdToReplace",gxvar:"AV29ddo_SecRoleDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29ddo_SecRoleDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29ddo_SecRoleDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV29ddo_SecRoleDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29ddo_SecRoleDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYID",gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECFUNCTIONALITYID",',')},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV16OrderedBy",gxold:"OV16OrderedBy",gxvar:"AV16OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV16OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV16OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV17OrderedDsc",gxold:"OV17OrderedDsc",gxvar:"AV17OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV17OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLENAME",gxz:"ZV23TFSecRoleName",gxold:"OV23TFSecRoleName",gxvar:"AV23TFSecRoleName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23TFSecRoleName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23TFSecRoleName=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLENAME",gx.O.AV23TFSecRoleName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23TFSecRoleName=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLENAME")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLENAME_SEL",gxz:"ZV24TFSecRoleName_Sel",gxold:"OV24TFSecRoleName_Sel",gxvar:"AV24TFSecRoleName_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24TFSecRoleName_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24TFSecRoleName_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLENAME_SEL",gx.O.AV24TFSecRoleName_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24TFSecRoleName_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLENAME_SEL")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLEDESCRIPTION",gxz:"ZV27TFSecRoleDescription",gxold:"OV27TFSecRoleDescription",gxvar:"AV27TFSecRoleDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27TFSecRoleDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27TFSecRoleDescription=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLEDESCRIPTION",gx.O.AV27TFSecRoleDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27TFSecRoleDescription=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLEDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECROLEDESCRIPTION_SEL",gxz:"ZV28TFSecRoleDescription_Sel",gxold:"OV28TFSecRoleDescription_Sel",gxvar:"AV28TFSecRoleDescription_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28TFSecRoleDescription_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28TFSecRoleDescription_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECROLEDESCRIPTION_SEL",gx.O.AV28TFSecRoleDescription_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV28TFSecRoleDescription_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECROLEDESCRIPTION_SEL")},nac:gx.falseFn};
   this.AV46SecRoleName = "" ;
   this.ZV46SecRoleName = "" ;
   this.OV46SecRoleName = "" ;
   this.ZV18Delete = "" ;
   this.OV18Delete = "" ;
   this.Z4SecRoleId = 0 ;
   this.O4SecRoleId = 0 ;
   this.Z13SecRoleName = "" ;
   this.O13SecRoleName = "" ;
   this.Z12SecRoleDescription = "" ;
   this.O12SecRoleDescription = "" ;
   this.AV25ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.ZV25ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.OV25ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.AV29ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.ZV29ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.OV29ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.A1SecFunctionalityId = 0 ;
   this.Z1SecFunctionalityId = 0 ;
   this.O1SecFunctionalityId = 0 ;
   this.AV16OrderedBy = 0 ;
   this.ZV16OrderedBy = 0 ;
   this.OV16OrderedBy = 0 ;
   this.AV17OrderedDsc = false ;
   this.ZV17OrderedDsc = false ;
   this.OV17OrderedDsc = false ;
   this.AV23TFSecRoleName = "" ;
   this.ZV23TFSecRoleName = "" ;
   this.OV23TFSecRoleName = "" ;
   this.AV24TFSecRoleName_Sel = "" ;
   this.ZV24TFSecRoleName_Sel = "" ;
   this.OV24TFSecRoleName_Sel = "" ;
   this.AV27TFSecRoleDescription = "" ;
   this.ZV27TFSecRoleDescription = "" ;
   this.OV27TFSecRoleDescription = "" ;
   this.AV28TFSecRoleDescription_Sel = "" ;
   this.ZV28TFSecRoleDescription_Sel = "" ;
   this.OV28TFSecRoleDescription_Sel = "" ;
   this.AV46SecRoleName = "" ;
   this.AV40GridCurrentPage = 0 ;
   this.AV30DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV25ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.AV29ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.A1SecFunctionalityId = 0 ;
   this.AV16OrderedBy = 0 ;
   this.AV17OrderedDsc = false ;
   this.AV23TFSecRoleName = "" ;
   this.AV24TFSecRoleName_Sel = "" ;
   this.AV27TFSecRoleDescription = "" ;
   this.AV28TFSecRoleDescription_Sel = "" ;
   this.AV8SecFunctionalityId = 0 ;
   this.AV18Delete = "" ;
   this.A4SecRoleId = 0 ;
   this.A13SecRoleName = "" ;
   this.A12SecRoleDescription = "" ;
   this.AV50Pgmname = "" ;
   this.AV20IsAuthorized_Delete = false ;
   this.AV13IsAuthorized_SecRoleName = false ;
   this.Events = {"e110s2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120s2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130s2_client": ["DDO_SECROLENAME.ONOPTIONCLICKED", true] ,"e140s2_client": ["DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED", true] ,"e180s2_client": ["ENTER", true] ,"e190s2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}],[{av:'AV22SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV26SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vTFSECROLENAME","Visible")',ctrl:'vTFSECROLENAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECROLENAME_SEL","Visible")',ctrl:'vTFSECROLENAME_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECROLEDESCRIPTION","Visible")',ctrl:'vTFSECROLEDESCRIPTION',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECROLEDESCRIPTION_SEL","Visible")',ctrl:'vTFSECROLEDESCRIPTION_SEL',prop:'Visible'},{av:'this.DDO_SECROLENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECROLENAME',prop:'TitleControlIdToReplace'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECROLEDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYID","Visible")',ctrl:'SECFUNCTIONALITYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV30DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'this.DDO_SECROLENAMEContainer.FilteredText_set',ctrl:'DDO_SECROLENAME',prop:'FilteredText_set'},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'this.DDO_SECROLENAMEContainer.SelectedValue_set',ctrl:'DDO_SECROLENAME',prop:'SelectedValue_set'},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.FilteredText_set',ctrl:'DDO_SECROLEDESCRIPTION',prop:'FilteredText_set'},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SelectedValue_set',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SelectedValue_set'},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECROLENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'this.DDO_SECROLENAMEContainer.ActiveEventKey',ctrl:'DDO_SECROLENAME',prop:'ActiveEventKey'},{av:'this.DDO_SECROLENAMEContainer.FilteredText_get',ctrl:'DDO_SECROLENAME',prop:'FilteredText_get'},{av:'this.DDO_SECROLENAMEContainer.SelectedValue_get',ctrl:'DDO_SECROLENAME',prop:'SelectedValue_get'}],[{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV22SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV26SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'}]];
   this.EvtParms["DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECROLEDESCRIPTION',prop:'ActiveEventKey'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.FilteredText_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'FilteredText_get'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SelectedValue_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SelectedValue_get'}],[{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV22SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV26SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true}],[{av:'AV18Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Link")',ctrl:'SECROLENAME',prop:'Link'}]];
   this.setVCMap("AV50Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8SecFunctionalityId", "vSECFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV20IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV13IsAuthorized_SecRoleName", "vISAUTHORIZED_SECROLENAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecFunctionalityId", "vSECFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV50Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV20IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV13IsAuthorized_SecRoleName", "vISAUTHORIZED_SECROLENAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecFunctionalityId", "vSECFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV50Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV20IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV13IsAuthorized_SecRoleName", "vISAUTHORIZED_SECROLENAME", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[23]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar({rfrVar:"AV8SecFunctionalityId"});
   GridContainer.addRefreshingVar(this.GXValidFnc[42]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar({rfrVar:"AV50Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV20IsAuthorized_Delete"});
   GridContainer.addRefreshingVar({rfrVar:"AV13IsAuthorized_SecRoleName"});
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   this.Initialize( );
});
