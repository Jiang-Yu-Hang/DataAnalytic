/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:18.6
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secfunctionalityww', false, function () {
   this.ServerClass =  "wwpbaseobjects.secfunctionalityww" ;
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
      this.AV105Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV18IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV19IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV105Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV18IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV19IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.Valid_Secparentfunctionalityid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(36) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECPARENTFUNCTIONALITYID", gx.fn.currentGridRowImpl(36));
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
      if ( this.AV29OrderedBy == 1 )
      {
         this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus =  (this.AV30OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV29OrderedBy == 2 )
      {
         this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus =  (this.AV30OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus =  ""  ;
      this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus =  ""  ;
   };
   this.e110h2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120h2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130h2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e140h2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e150h2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e190h2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e200h2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,57,59,61,62,63,64,65,66];
   this.GXLastCtrlId =66;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",36,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secfunctionalityww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",37,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",38,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",39,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Funcassociaterole","vFUNCASSOCIATEROLE",40,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Uaviewchildren","vUAVIEWCHILDREN",41,0,"px",17,"px",null,"","","","WWActionColumn");
   GridContainer.addSingleLineEdit(1,42,"SECFUNCTIONALITYID","缂栧彿","","SecFunctionalityId","int",0,"px",10,10,"right",null,[],1,"SecFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(3,43,"SECFUNCTIONALITYKEY","","","SecFunctionalityKey","svchar",0,"px",100,80,"left",null,[],3,"SecFunctionalityKey",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(8,44,"SECFUNCTIONALITYDESCRIPTION","","","SecFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],8,"SecFunctionalityDescription",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addComboBox(9,45,"SECFUNCTIONALITYTYPE","绫诲瀷","SecFunctionalityType","int",null,0,false,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(2,46,"SECPARENTFUNCTIONALITYID","鐖跺姛鑳界紪鍙? ","","SecParentFunctionalityId","int",0,"px",10,10,"right",null,[],2,"SecParentFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(11,47,"SECPARENTFUNCTIONALITYDESCRIPTION","鐖跺姛鑳?,"","SecParentFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],11,"SecParentFunctionalityDescription",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addCheckBox(7,48,"SECFUNCTIONALITYACTIVE","鏄惁鍚敤锛?,"","SecFunctionalityActive","boolean","true","false",null,false,false,0,"px","WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 52, 26, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV85GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV85GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV85GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV88GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV88GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV88GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV87GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV87GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV87GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110h2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120h2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECFUNCTIONALITYKEYContainer = gx.uc.getNew(this, 56, 26, "BootstrapDropDownOptions", "DDO_SECFUNCTIONALITYKEYContainer", "Ddo_secfunctionalitykey", "DDO_SECFUNCTIONALITYKEY");
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
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecFunctionalityWWGetFilterData", "str");
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
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV55DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV55DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV55DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV40SecFunctionalityKeyTitleFilterData', "vSECFUNCTIONALITYKEYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40SecFunctionalityKeyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYKEYTITLEFILTERDATA",UC.ParentObject.AV40SecFunctionalityKeyTitleFilterData); });
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYKEYContainer.addEventHandler("OnOptionClicked", this.e130h2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYKEYContainer);
   this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer = gx.uc.getNew(this, 58, 26, "BootstrapDropDownOptions", "DDO_SECFUNCTIONALITYDESCRIPTIONContainer", "Ddo_secfunctionalitydescription", "DDO_SECFUNCTIONALITYDESCRIPTION");
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
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecFunctionalityWWGetFilterData", "str");
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
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV55DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV55DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV55DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV44SecFunctionalityDescriptionTitleFilterData', "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44SecFunctionalityDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV44SecFunctionalityDescriptionTitleFilterData); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e140h2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 60, 26, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECFUNCTIONALITYKEY",gxz:"ZV22SecFunctionalityKey",gxold:"OV22SecFunctionalityKey",gxvar:"AV22SecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22SecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("vSECFUNCTIONALITYKEY",gx.O.AV22SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22SecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("vSECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECFUNCTIONALITYDESCRIPTION",gxz:"ZV10SecFunctionalityDescription",gxold:"OV10SecFunctionalityDescription",gxvar:"AV10SecFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV10SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV10SecFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("vSECFUNCTIONALITYDESCRIPTION",gx.O.AV10SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV10SecFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("vSECFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV89Display",gxold:"OV89Display",gxvar:"AV89Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV89Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV89Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(36),gx.O.AV89Display,gx.O.AV100Display_GXI)},c2v:function(){gx.O.AV100Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV89Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(36))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(36))}, gxvar_GXI:'AV100Display_GXI',nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV11Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(36),gx.O.AV11Update,gx.O.AV101Update_GXI)},c2v:function(){gx.O.AV101Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV11Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(36))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(36))}, gxvar_GXI:'AV101Update_GXI',nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV12Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(36),gx.O.AV12Delete,gx.O.AV102Delete_GXI)},c2v:function(){gx.O.AV102Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV12Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(36))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(36))}, gxvar_GXI:'AV102Delete_GXI',nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vFUNCASSOCIATEROLE",gxz:"ZV91FuncAssociateRole",gxold:"OV91FuncAssociateRole",gxvar:"AV91FuncAssociateRole",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV91FuncAssociateRole=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV91FuncAssociateRole=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vFUNCASSOCIATEROLE",row || gx.fn.currentGridRowImpl(36),gx.O.AV91FuncAssociateRole,gx.O.AV103Funcassociaterole_GXI)},c2v:function(){gx.O.AV103Funcassociaterole_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV91FuncAssociateRole=this.val()},val:function(row){return gx.fn.getGridControlValue("vFUNCASSOCIATEROLE",row || gx.fn.currentGridRowImpl(36))},val_GXI:function(row){return gx.fn.getGridControlValue("vFUNCASSOCIATEROLE_GXI",row || gx.fn.currentGridRowImpl(36))}, gxvar_GXI:'AV103Funcassociaterole_GXI',nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUAVIEWCHILDREN",gxz:"ZV24UAViewChildren",gxold:"OV24UAViewChildren",gxvar:"AV24UAViewChildren",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV24UAViewChildren=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24UAViewChildren=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUAVIEWCHILDREN",row || gx.fn.currentGridRowImpl(36),gx.O.AV24UAViewChildren,gx.O.AV104Uaviewchildren_GXI)},c2v:function(){gx.O.AV104Uaviewchildren_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV24UAViewChildren=this.val()},val:function(row){return gx.fn.getGridControlValue("vUAVIEWCHILDREN",row || gx.fn.currentGridRowImpl(36))},val_GXI:function(row){return gx.fn.getGridControlValue("vUAVIEWCHILDREN_GXI",row || gx.fn.currentGridRowImpl(36))}, gxvar_GXI:'AV104Uaviewchildren_GXI',nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(36),gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(36),',')},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYKEY",gxz:"Z3SecFunctionalityKey",gxold:"O3SecFunctionalityKey",gxvar:"A3SecFunctionalityKey",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A3SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z3SecFunctionalityKey=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(36),gx.O.A3SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A3SecFunctionalityKey=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(36))},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(36),gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(36))},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYTYPE",gxz:"Z9SecFunctionalityType",gxold:"O9SecFunctionalityType",gxvar:"A9SecFunctionalityType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9SecFunctionalityType=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(36),gx.O.A9SecFunctionalityType);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(36),',')},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:this.Valid_Secparentfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYID",gxz:"Z2SecParentFunctionalityId",gxold:"O2SecParentFunctionalityId",gxvar:"A2SecParentFunctionalityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2SecParentFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(36),gx.O.A2SecParentFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECPARENTFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(36),',')},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYDESCRIPTION",gxz:"Z11SecParentFunctionalityDescription",gxold:"O11SecParentFunctionalityDescription",gxvar:"A11SecParentFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A11SecParentFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z11SecParentFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(36),gx.O.A11SecParentFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A11SecParentFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(36))},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:36,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYACTIVE",gxz:"Z7SecFunctionalityActive",gxold:"O7SecFunctionalityActive",gxvar:"A7SecFunctionalityActive",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("SECFUNCTIONALITYACTIVE",row || gx.fn.currentGridRowImpl(36),gx.O.A7SecFunctionalityActive,true)},c2v:function(){if(this.val()!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYACTIVE",row || gx.fn.currentGridRowImpl(36))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gxz:"ZV43ddo_SecFunctionalityKeyTitleControlIdToReplace",gxold:"OV43ddo_SecFunctionalityKeyTitleControlIdToReplace",gxvar:"AV43ddo_SecFunctionalityKeyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gx.O.AV43ddo_SecFunctionalityKeyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43ddo_SecFunctionalityKeyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxold:"OV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxvar:"AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV29OrderedBy",gxold:"OV29OrderedBy",gxvar:"AV29OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV29OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV29OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV30OrderedDsc",gxold:"OV30OrderedDsc",gxvar:"AV30OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV30OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV30OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYKEY",gxz:"ZV41TFSecFunctionalityKey",gxold:"OV41TFSecFunctionalityKey",gxvar:"AV41TFSecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV41TFSecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41TFSecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYKEY",gx.O.AV41TFSecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV41TFSecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYKEY_SEL",gxz:"ZV42TFSecFunctionalityKey_Sel",gxold:"OV42TFSecFunctionalityKey_Sel",gxvar:"AV42TFSecFunctionalityKey_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV42TFSecFunctionalityKey_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42TFSecFunctionalityKey_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYKEY_SEL",gx.O.AV42TFSecFunctionalityKey_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV42TFSecFunctionalityKey_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYKEY_SEL")},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYDESCRIPTION",gxz:"ZV45TFSecFunctionalityDescription",gxold:"OV45TFSecFunctionalityDescription",gxvar:"AV45TFSecFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV45TFSecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45TFSecFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYDESCRIPTION",gx.O.AV45TFSecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV45TFSecFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYDESCRIPTION_SEL",gxz:"ZV46TFSecFunctionalityDescription_Sel",gxold:"OV46TFSecFunctionalityDescription_Sel",gxvar:"AV46TFSecFunctionalityDescription_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV46TFSecFunctionalityDescription_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46TFSecFunctionalityDescription_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYDESCRIPTION_SEL",gx.O.AV46TFSecFunctionalityDescription_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV46TFSecFunctionalityDescription_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYDESCRIPTION_SEL")},nac:gx.falseFn};
   this.AV22SecFunctionalityKey = "" ;
   this.ZV22SecFunctionalityKey = "" ;
   this.OV22SecFunctionalityKey = "" ;
   this.AV10SecFunctionalityDescription = "" ;
   this.ZV10SecFunctionalityDescription = "" ;
   this.OV10SecFunctionalityDescription = "" ;
   this.ZV89Display = "" ;
   this.OV89Display = "" ;
   this.ZV11Update = "" ;
   this.OV11Update = "" ;
   this.ZV12Delete = "" ;
   this.OV12Delete = "" ;
   this.ZV91FuncAssociateRole = "" ;
   this.OV91FuncAssociateRole = "" ;
   this.ZV24UAViewChildren = "" ;
   this.OV24UAViewChildren = "" ;
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
   this.AV43ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.ZV43ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.OV43ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.ZV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.OV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.AV29OrderedBy = 0 ;
   this.ZV29OrderedBy = 0 ;
   this.OV29OrderedBy = 0 ;
   this.AV30OrderedDsc = false ;
   this.ZV30OrderedDsc = false ;
   this.OV30OrderedDsc = false ;
   this.AV41TFSecFunctionalityKey = "" ;
   this.ZV41TFSecFunctionalityKey = "" ;
   this.OV41TFSecFunctionalityKey = "" ;
   this.AV42TFSecFunctionalityKey_Sel = "" ;
   this.ZV42TFSecFunctionalityKey_Sel = "" ;
   this.OV42TFSecFunctionalityKey_Sel = "" ;
   this.AV45TFSecFunctionalityDescription = "" ;
   this.ZV45TFSecFunctionalityDescription = "" ;
   this.OV45TFSecFunctionalityDescription = "" ;
   this.AV46TFSecFunctionalityDescription_Sel = "" ;
   this.ZV46TFSecFunctionalityDescription_Sel = "" ;
   this.OV46TFSecFunctionalityDescription_Sel = "" ;
   this.AV22SecFunctionalityKey = "" ;
   this.AV10SecFunctionalityDescription = "" ;
   this.AV85GridCurrentPage = 0 ;
   this.AV55DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV43ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.AV29OrderedBy = 0 ;
   this.AV30OrderedDsc = false ;
   this.AV41TFSecFunctionalityKey = "" ;
   this.AV42TFSecFunctionalityKey_Sel = "" ;
   this.AV45TFSecFunctionalityDescription = "" ;
   this.AV46TFSecFunctionalityDescription_Sel = "" ;
   this.AV89Display = "" ;
   this.AV11Update = "" ;
   this.AV12Delete = "" ;
   this.AV91FuncAssociateRole = "" ;
   this.AV24UAViewChildren = "" ;
   this.A1SecFunctionalityId = 0 ;
   this.A3SecFunctionalityKey = "" ;
   this.A8SecFunctionalityDescription = "" ;
   this.A9SecFunctionalityType = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.A7SecFunctionalityActive = false ;
   this.AV105Pgmname = "" ;
   this.AV18IsAuthorized_Update = false ;
   this.AV19IsAuthorized_Delete = false ;
   this.Events = {"e110h2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120h2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130h2_client": ["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", true] ,"e140h2_client": ["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", true] ,"e150h2_client": ["'DOINSERT'", true] ,"e190h2_client": ["ENTER", true] ,"e200h2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV40SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV44SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV85GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV87GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV88GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYKEY","Visible")',ctrl:'vTFSECFUNCTIONALITYKEY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYKEY_SEL","Visible")',ctrl:'vTFSECFUNCTIONALITYKEY_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYDESCRIPTION","Visible")',ctrl:'vTFSECFUNCTIONALITYDESCRIPTION',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYDESCRIPTION_SEL","Visible")',ctrl:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'TitleControlIdToReplace'},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV55DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SelectedValue_set',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SelectedValue_set'},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.FilteredText_set',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'FilteredText_set'},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SelectedValue_set',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_set'},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.FilteredText_set',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_set'},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.FilteredText_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_get'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SelectedValue_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_get'}],[{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV40SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV44SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV85GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV87GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV88GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.FilteredText_get',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'FilteredText_get'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SelectedValue_get',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SelectedValue_get'}],[{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV40SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV44SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV85GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV87GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV88GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV89Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'AV91FuncAssociateRole',fld:'vFUNCASSOCIATEROLE',pic:''},{av:'gx.fn.getCtrlProperty("vFUNCASSOCIATEROLE","Tooltiptext")',ctrl:'vFUNCASSOCIATEROLE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vFUNCASSOCIATEROLE","Link")',ctrl:'vFUNCASSOCIATEROLE',prop:'Link'},{av:'AV24UAViewChildren',fld:'vUAVIEWCHILDREN',pic:''},{av:'gx.fn.getCtrlProperty("vUAVIEWCHILDREN","Tooltiptext")',ctrl:'vUAVIEWCHILDREN',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUAVIEWCHILDREN","Link")',ctrl:'vUAVIEWCHILDREN',prop:'Link'},{av:'gx.fn.getCtrlProperty("vUAVIEWCHILDREN","Class")',ctrl:'vUAVIEWCHILDREN',prop:'Class'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Link")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true}],[]];
   this.setVCMap("AV105Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV18IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV19IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV105Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV18IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV19IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV105Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV18IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV19IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar(this.GXValidFnc[30]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar({rfrVar:"AV105Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV18IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV19IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secfunctionalityww);
