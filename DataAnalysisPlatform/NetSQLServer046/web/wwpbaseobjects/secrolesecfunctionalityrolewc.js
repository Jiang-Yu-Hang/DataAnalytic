/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:55:9.45
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secrolesecfunctionalityrolewc', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.secrolesecfunctionalityrolewc" ;
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
      this.AV79Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV8SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.AV16IsAuthorized_SecFunctionalityDescription=gx.fn.getControlValue("vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION") ;
      this.AV8SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.AV79Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV16IsAuthorized_SecFunctionalityDescription=gx.fn.getControlValue("vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION") ;
   };
   this.Valid_Secfunctionalityid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(29) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECFUNCTIONALITYID", gx.fn.currentGridRowImpl(29));
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
      if ( this.AV20OrderedBy == 1 )
      {
         this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus =  (this.AV21OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV20OrderedBy == 2 )
      {
         this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus =  (this.AV21OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s152_client=function()
   {
      this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus =  ""  ;
      this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus =  ""  ;
   };
   this.e110w2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120w2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130w2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e140w2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e180w2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e190w2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,30,31,32,33,34,35,36,37,39,40,41,43,45,46,48,49,50,51];
   this.GXLastCtrlId =51;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",29,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secrolesecfunctionalityrolewc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(1,30,"SECFUNCTIONALITYID","鍔熻兘缂栧彿","","SecFunctionalityId","int",0,"px",10,10,"right",null,[],1,"SecFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(3,31,"SECFUNCTIONALITYKEY","","","SecFunctionalityKey","svchar",0,"px",100,80,"left",null,[],3,"SecFunctionalityKey",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addComboBox(9,32,"SECFUNCTIONALITYTYPE","Functionality Type","SecFunctionalityType","int",null,0,false,false,0,"px","WWColumn");
   GridContainer.addSingleLineEdit(8,33,"SECFUNCTIONALITYDESCRIPTION","","","SecFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],8,"SecFunctionalityDescription",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(11,34,"SECPARENTFUNCTIONALITYDESCRIPTION","Parent Functionality","","SecParentFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],11,"SecParentFunctionalityDescription",false,0,false,false,"Attribute",1,"WWColumn");
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
   DVPANEL_TABLEHEADERContainer.setProp("Title", "Title", "閫夐」", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEHEADERContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 38, 23, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV73GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV73GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV73GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV72GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV72GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV72GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110w2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120w2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECFUNCTIONALITYKEYContainer = gx.uc.getNew(this, 42, 23, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECFUNCTIONALITYKEYContainer", "Ddo_secfunctionalitykey", "DDO_SECFUNCTIONALITYKEY");
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
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListProc", "Datalistproc", "WWPBaseObjects.SecRoleSecFunctionalityRoleWCGetFilterData", "str");
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
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV58DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV58DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV58DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV43SecFunctionalityKeyTitleFilterData', "vSECFUNCTIONALITYKEYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43SecFunctionalityKeyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYKEYTITLEFILTERDATA",UC.ParentObject.AV43SecFunctionalityKeyTitleFilterData); });
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYKEYContainer.addEventHandler("OnOptionClicked", this.e130w2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYKEYContainer);
   this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer = gx.uc.getNew(this, 44, 23, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECFUNCTIONALITYDESCRIPTIONContainer", "Ddo_secfunctionalitydescription", "DDO_SECFUNCTIONALITYDESCRIPTION");
   var DDO_SECFUNCTIONALITYDESCRIPTIONContainer = this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer;
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Class", "Class", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
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
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV58DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV58DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV58DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV50SecFunctionalityDescriptionTitleFilterData', "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV50SecFunctionalityDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV50SecFunctionalityDescriptionTitleFilterData); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e140w2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 47, 23, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[17]={ id: 17, fld:"UNNAMEDTABLEECFUNCTIONALITYKEY",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"FILTERTEXTSECFUNCTIONALITYKEY", format:0,grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id:23 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECFUNCTIONALITYKEY",gxz:"ZV12SecFunctionalityKey",gxold:"OV12SecFunctionalityKey",gxvar:"AV12SecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12SecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("vSECFUNCTIONALITYKEY",gx.O.AV12SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12SecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("vSECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:this.Valid_Secfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[34,31,32,33],ip:[34,31,32,33,30],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(29),gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(29),',')},nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYKEY",gxz:"Z3SecFunctionalityKey",gxold:"O3SecFunctionalityKey",gxvar:"A3SecFunctionalityKey",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A3SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z3SecFunctionalityKey=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(29),gx.O.A3SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A3SecFunctionalityKey=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(29))},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYTYPE",gxz:"Z9SecFunctionalityType",gxold:"O9SecFunctionalityType",gxvar:"A9SecFunctionalityType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9SecFunctionalityType=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(29),gx.O.A9SecFunctionalityType);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(29),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(29),gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(29))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYDESCRIPTION",gxz:"Z11SecParentFunctionalityDescription",gxold:"O11SecParentFunctionalityDescription",gxvar:"A11SecParentFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A11SecParentFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z11SecParentFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(29),gx.O.A11SecParentFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A11SecParentFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(29))},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gxz:"ZV46ddo_SecFunctionalityKeyTitleControlIdToReplace",gxold:"OV46ddo_SecFunctionalityKeyTitleControlIdToReplace",gxvar:"AV46ddo_SecFunctionalityKeyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV46ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gx.O.AV46ddo_SecFunctionalityKeyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV46ddo_SecFunctionalityKeyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxold:"OV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxvar:"AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEID",gxz:"Z4SecRoleId",gxold:"O4SecRoleId",gxvar:"A4SecRoleId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A4SecRoleId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z4SecRoleId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECROLEID",gx.O.A4SecRoleId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A4SecRoleId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECROLEID",',')},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV20OrderedBy",gxold:"OV20OrderedBy",gxvar:"AV20OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV20OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV20OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV21OrderedDsc",gxold:"OV21OrderedDsc",gxvar:"AV21OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV21OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYKEY",gxz:"ZV44TFSecFunctionalityKey",gxold:"OV44TFSecFunctionalityKey",gxvar:"AV44TFSecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV44TFSecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44TFSecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYKEY",gx.O.AV44TFSecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV44TFSecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFSECFUNCTIONALITYKEY_SEL",gxz:"ZV45TFSecFunctionalityKey_Sel",gxold:"OV45TFSecFunctionalityKey_Sel",gxvar:"AV45TFSecFunctionalityKey_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV45TFSecFunctionalityKey_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV45TFSecFunctionalityKey_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFSECFUNCTIONALITYKEY_SEL",gx.O.AV45TFSecFunctionalityKey_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV45TFSecFunctionalityKey_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFSECFUNCTIONALITYKEY_SEL")},nac:gx.falseFn};
   this.AV12SecFunctionalityKey = "" ;
   this.ZV12SecFunctionalityKey = "" ;
   this.OV12SecFunctionalityKey = "" ;
   this.Z1SecFunctionalityId = 0 ;
   this.O1SecFunctionalityId = 0 ;
   this.Z3SecFunctionalityKey = "" ;
   this.O3SecFunctionalityKey = "" ;
   this.Z9SecFunctionalityType = 0 ;
   this.O9SecFunctionalityType = 0 ;
   this.Z8SecFunctionalityDescription = "" ;
   this.O8SecFunctionalityDescription = "" ;
   this.Z11SecParentFunctionalityDescription = "" ;
   this.O11SecParentFunctionalityDescription = "" ;
   this.AV46ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.ZV46ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.OV46ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.ZV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.OV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.A4SecRoleId = 0 ;
   this.Z4SecRoleId = 0 ;
   this.O4SecRoleId = 0 ;
   this.AV20OrderedBy = 0 ;
   this.ZV20OrderedBy = 0 ;
   this.OV20OrderedBy = 0 ;
   this.AV21OrderedDsc = false ;
   this.ZV21OrderedDsc = false ;
   this.OV21OrderedDsc = false ;
   this.AV44TFSecFunctionalityKey = "" ;
   this.ZV44TFSecFunctionalityKey = "" ;
   this.OV44TFSecFunctionalityKey = "" ;
   this.AV45TFSecFunctionalityKey_Sel = "" ;
   this.ZV45TFSecFunctionalityKey_Sel = "" ;
   this.OV45TFSecFunctionalityKey_Sel = "" ;
   this.AV12SecFunctionalityKey = "" ;
   this.AV70GridCurrentPage = 0 ;
   this.AV58DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV46ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.A4SecRoleId = 0 ;
   this.AV20OrderedBy = 0 ;
   this.AV21OrderedDsc = false ;
   this.AV44TFSecFunctionalityKey = "" ;
   this.AV45TFSecFunctionalityKey_Sel = "" ;
   this.AV8SecRoleId = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.A1SecFunctionalityId = 0 ;
   this.A3SecFunctionalityKey = "" ;
   this.A9SecFunctionalityType = 0 ;
   this.A8SecFunctionalityDescription = "" ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.AV79Pgmname = "" ;
   this.AV16IsAuthorized_SecFunctionalityDescription = false ;
   this.Events = {"e110w2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120w2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130w2_client": ["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", true] ,"e140w2_client": ["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", true] ,"e180w2_client": ["ENTER", true] ,"e190w2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'sPrefix'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true}],[{av:'AV43SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV50SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV72GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV73GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYKEY","Visible")',ctrl:'vTFSECFUNCTIONALITYKEY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFSECFUNCTIONALITYKEY_SEL","Visible")',ctrl:'vTFSECFUNCTIONALITYKEY_SEL',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'TitleControlIdToReplace'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECROLEID","Visible")',ctrl:'SECROLEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV58DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.FilteredText_set',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_set'},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SelectedValue_set',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_set'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.FilteredText_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_get'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SelectedValue_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_get'}],[{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV43SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV50SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV72GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV73GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'}],[{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV43SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV50SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV72GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV73GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}],[{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Link")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Link'}]];
   this.setVCMap("AV79Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV16IsAuthorized_SecFunctionalityDescription", "vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV79Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV16IsAuthorized_SecFunctionalityDescription", "vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV79Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV16IsAuthorized_SecFunctionalityDescription", "vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[23]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[49]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar({rfrVar:"AV8SecRoleId"});
   GridContainer.addRefreshingVar(this.GXValidFnc[43]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar({rfrVar:"AV79Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV16IsAuthorized_SecFunctionalityDescription"});
   this.Initialize( );
});
