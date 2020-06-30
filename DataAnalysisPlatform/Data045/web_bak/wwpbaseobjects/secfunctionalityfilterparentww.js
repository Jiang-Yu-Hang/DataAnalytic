/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:18.84
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secfunctionalityfilterparentww', false, function () {
   this.ServerClass =  "wwpbaseobjects.secfunctionalityfilterparentww" ;
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
      this.AV8SecParentFunctionalityId=gx.fn.getIntegerValue("vSECPARENTFUNCTIONALITYID",',') ;
      this.AV95Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV8SecParentFunctionalityId=gx.fn.getIntegerValue("vSECPARENTFUNCTIONALITYID",',') ;
      this.AV95Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Valid_Secparentfunctionalityid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(23) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECPARENTFUNCTIONALITYID", gx.fn.currentGridRowImpl(23));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Secparentfunctionalityid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(23) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECPARENTFUNCTIONALITYID", gx.fn.currentGridRowImpl(23));
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
      this.s152_client();
      if ( this.AV26OrderedBy == 1 )
      {
         this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus =  (this.AV27OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV26OrderedBy == 2 )
      {
         this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus =  (this.AV27OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus =  ""  ;
      this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus =  ""  ;
   };
   this.e110l2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120l2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130l2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e140l2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e180l2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e190l1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,35,36,37,39,41,43,44,45,46,47,48];
   this.GXLastCtrlId =48;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",23,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secfunctionalityfilterparentww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(1,24,"SECFUNCTIONALITYID","缂栧彿","","SecFunctionalityId","int",0,"px",10,10,"right",null,[],1,"SecFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(3,25,"SECFUNCTIONALITYKEY","","","SecFunctionalityKey","svchar",0,"px",100,80,"left",null,[],3,"SecFunctionalityKey",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(8,26,"SECFUNCTIONALITYDESCRIPTION","","","SecFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],8,"SecFunctionalityDescription",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addComboBox(9,27,"SECFUNCTIONALITYTYPE","绫诲瀷","SecFunctionalityType","int",null,0,false,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(2,28,"SECPARENTFUNCTIONALITYID","鐖跺姛鑳界紪鍙? ","","SecParentFunctionalityId","int",0,"px",10,10,"right",null,[],2,"SecParentFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(11,29,"SECPARENTFUNCTIONALITYDESCRIPTION","鐖跺姛鑳?,"","SecParentFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],11,"SecParentFunctionalityDescription",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addCheckBox(7,30,"SECFUNCTIONALITYACTIVE","鏄惁鍚敤锛?,"","SecFunctionalityActive","boolean","true","false",null,false,false,0,"px","WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 34, 24, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV82GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV82GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV82GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV85GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV85GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV85GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV84GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV84GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV84GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110l2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120l2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECFUNCTIONALITYKEYContainer = gx.uc.getNew(this, 38, 24, "BootstrapDropDownOptions", "DDO_SECFUNCTIONALITYKEYContainer", "Ddo_secfunctionalitykey", "DDO_SECFUNCTIONALITYKEY");
   var DDO_SECFUNCTIONALITYKEYContainer = this.DDO_SECFUNCTIONALITYKEYContainer;
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Class", "Class", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecFunctionalityFilterParentWWGetFilterData", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV53DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV53DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV53DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV38SecFunctionalityKeyTitleFilterData', "vSECFUNCTIONALITYKEYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38SecFunctionalityKeyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYKEYTITLEFILTERDATA",UC.ParentObject.AV38SecFunctionalityKeyTitleFilterData); });
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYKEYContainer.addEventHandler("OnOptionClicked", this.e130l2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYKEYContainer);
   this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer = gx.uc.getNew(this, 40, 39, "BootstrapDropDownOptions", "DDO_SECFUNCTIONALITYDESCRIPTIONContainer", "Ddo_secfunctionalitydescription", "DDO_SECFUNCTIONALITYDESCRIPTION");
   var DDO_SECFUNCTIONALITYDESCRIPTIONContainer = this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer;
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Class", "Class", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecFunctionalityFilterParentWWGetFilterData", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV53DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV53DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV53DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV42SecFunctionalityDescriptionTitleFilterData', "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42SecFunctionalityDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV42SecFunctionalityDescriptionTitleFilterData); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e140l2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 42, 39, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[17]={ id: 17, fld:"BTN_CANCEL",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[24]={ id:24 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(23),gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(23),',')},nac:gx.falseFn};
   GXValidFnc[25]={ id:25 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYKEY",gxz:"Z3SecFunctionalityKey",gxold:"O3SecFunctionalityKey",gxvar:"A3SecFunctionalityKey",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A3SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z3SecFunctionalityKey=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(23),gx.O.A3SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A3SecFunctionalityKey=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(23))},nac:gx.falseFn};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(23),gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(23))},nac:gx.falseFn};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYTYPE",gxz:"Z9SecFunctionalityType",gxold:"O9SecFunctionalityType",gxvar:"A9SecFunctionalityType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9SecFunctionalityType=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(23),gx.O.A9SecFunctionalityType);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(23),',')},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:this.Valid_Secparentfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYID",gxz:"Z2SecParentFunctionalityId",gxold:"O2SecParentFunctionalityId",gxvar:"A2SecParentFunctionalityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2SecParentFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(23),gx.O.A2SecParentFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECPARENTFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(23),',')},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYDESCRIPTION",gxz:"Z11SecParentFunctionalityDescription",gxold:"O11SecParentFunctionalityDescription",gxvar:"A11SecParentFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A11SecParentFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z11SecParentFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(23),gx.O.A11SecParentFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A11SecParentFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(23))},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:23,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYACTIVE",gxz:"Z7SecFunctionalityActive",gxold:"O7SecFunctionalityActive",gxvar:"A7SecFunctionalityActive",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("SECFUNCTIONALITYACTIVE",row || gx.fn.currentGridRowImpl(23),gx.O.A7SecFunctionalityActive,true)},c2v:function(){if(this.val()!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYACTIVE",row || gx.fn.currentGridRowImpl(23))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gxz:"ZV41ddo_SecFunctionalityKeyTitleControlIdToReplace",gxold:"OV41ddo_SecFunctionalityKeyTitleControlIdToReplace",gxvar:"AV41ddo_SecFunctionalityKeyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gx.O.AV41ddo_SecFunctionalityKeyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41ddo_SecFunctionalityKeyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxold:"OV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxvar:"AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV26OrderedBy",gxold:"OV26OrderedBy",gxvar:"AV26OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV26OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV26OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV27OrderedDsc",gxold:"OV27OrderedDsc",gxvar:"AV27OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV27OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV27OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYKEY",gxz:"ZV39TFSecFunctionalityKey",gxold:"OV39TFSecFunctionalityKey",gxvar:"AV39TFSecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV39TFSecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39TFSecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYKEY",gx.O.AV39TFSecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV39TFSecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYKEY_SEL",gxz:"ZV40TFSecFunctionalityKey_Sel",gxold:"OV40TFSecFunctionalityKey_Sel",gxvar:"AV40TFSecFunctionalityKey_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV40TFSecFunctionalityKey_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40TFSecFunctionalityKey_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYKEY_SEL",gx.O.AV40TFSecFunctionalityKey_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV40TFSecFunctionalityKey_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYKEY_SEL")},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYDESCRIPTION",gxz:"ZV43TFSecFunctionalityDescription",gxold:"OV43TFSecFunctionalityDescription",gxvar:"AV43TFSecFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43TFSecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43TFSecFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYDESCRIPTION",gx.O.AV43TFSecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43TFSecFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYDESCRIPTION_SEL",gxz:"ZV44TFSecFunctionalityDescription_Sel",gxold:"OV44TFSecFunctionalityDescription_Sel",gxvar:"AV44TFSecFunctionalityDescription_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV44TFSecFunctionalityDescription_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44TFSecFunctionalityDescription_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYDESCRIPTION_SEL",gx.O.AV44TFSecFunctionalityDescription_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV44TFSecFunctionalityDescription_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYDESCRIPTION_SEL")},nac:gx.falseFn};
   this.Z1SecFunctionalityId = 0 ;
   this.O1SecFunctionalityId = 0 ;
   this.Z3SecFunctionalityKey = "" ;
   this.O3SecFunctionalityKey = "" ;
   this.Z8SecFunctionalityDescription = "" ;
   this.O8SecFunctionalityDescription = "" ;
   this.Z9SecFunctionalityType = 0 ;
   this.O9SecFunctionalityType = 0 ;
   this.Z2SecParentFunctionalityId = 0 ;
   this.O2SecParentFunctionalityId = 0 ;
   this.Z11SecParentFunctionalityDescription = "" ;
   this.O11SecParentFunctionalityDescription = "" ;
   this.Z7SecFunctionalityActive = false ;
   this.O7SecFunctionalityActive = false ;
   this.AV41ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.ZV41ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.OV41ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.ZV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.OV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.AV26OrderedBy = 0 ;
   this.ZV26OrderedBy = 0 ;
   this.OV26OrderedBy = 0 ;
   this.AV27OrderedDsc = false ;
   this.ZV27OrderedDsc = false ;
   this.OV27OrderedDsc = false ;
   this.AV39TFSecFunctionalityKey = "" ;
   this.ZV39TFSecFunctionalityKey = "" ;
   this.OV39TFSecFunctionalityKey = "" ;
   this.AV40TFSecFunctionalityKey_Sel = "" ;
   this.ZV40TFSecFunctionalityKey_Sel = "" ;
   this.OV40TFSecFunctionalityKey_Sel = "" ;
   this.AV43TFSecFunctionalityDescription = "" ;
   this.ZV43TFSecFunctionalityDescription = "" ;
   this.OV43TFSecFunctionalityDescription = "" ;
   this.AV44TFSecFunctionalityDescription_Sel = "" ;
   this.ZV44TFSecFunctionalityDescription_Sel = "" ;
   this.OV44TFSecFunctionalityDescription_Sel = "" ;
   this.AV82GridCurrentPage = 0 ;
   this.AV53DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV41ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.AV26OrderedBy = 0 ;
   this.AV27OrderedDsc = false ;
   this.AV39TFSecFunctionalityKey = "" ;
   this.AV40TFSecFunctionalityKey_Sel = "" ;
   this.AV43TFSecFunctionalityDescription = "" ;
   this.AV44TFSecFunctionalityDescription_Sel = "" ;
   this.AV8SecParentFunctionalityId = 0 ;
   this.A1SecFunctionalityId = 0 ;
   this.A3SecFunctionalityKey = "" ;
   this.A8SecFunctionalityDescription = "" ;
   this.A9SecFunctionalityType = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.A7SecFunctionalityActive = false ;
   this.AV95Pgmname = "" ;
   this.Events = {"e110l2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120l2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130l2_client": ["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", true] ,"e140l2_client": ["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", true] ,"e180l2_client": ["ENTER", true] ,"e190l1_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV41ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV95Pgmname',fld:'vPGMNAME',pic:''},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true}],[{av:'AV38SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV42SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV82GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV85GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'A2SecParentFunctionalityId',fld:'SECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV8SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'A11SecParentFunctionalityDescription',fld:'SECPARENTFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV95Pgmname',fld:'vPGMNAME',pic:''},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYKEY","Visible")',ctrl:'vTFSECFUNCTIONALITYKEY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYKEY_SEL","Visible")',ctrl:'vTFSECFUNCTIONALITYKEY_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYDESCRIPTION","Visible")',ctrl:'vTFSECFUNCTIONALITYDESCRIPTION',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYDESCRIPTION_SEL","Visible")',ctrl:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'TitleControlIdToReplace'},{av:'AV41ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV53DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.FilteredText_set',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_set'},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SelectedValue_set',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_set'},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.FilteredText_set',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'FilteredText_set'},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SelectedValue_set',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SelectedValue_set'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV41ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV95Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV41ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV95Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV41ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV95Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.FilteredText_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_get'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SelectedValue_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_get'}],[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV38SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV42SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV82GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV85GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV39TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV40TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV41ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV95Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.FilteredText_get',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'FilteredText_get'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SelectedValue_get',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SelectedValue_get'}],[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV43TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV44TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV38SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV42SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV82GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV85GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}],[{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Link")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Link'}]];
   this.setVCMap("AV8SecParentFunctionalityId", "vSECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV95Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8SecParentFunctionalityId", "vSECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV95Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8SecParentFunctionalityId", "vSECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV95Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[43]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[41]);
   GridContainer.addRefreshingVar({rfrVar:"AV8SecParentFunctionalityId"});
   GridContainer.addRefreshingVar({rfrVar:"AV95Pgmname"});
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secfunctionalityfilterparentww);
