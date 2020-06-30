/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:24.54
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secrolefunroleactionassociationww', false, function () {
   this.ServerClass =  "wwpbaseobjects.secrolefunroleactionassociationww" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV9SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.A4SecRoleId=gx.fn.getIntegerValue("SECROLEID",',') ;
      this.AV21i=gx.fn.getIntegerValue("vI",',') ;
      this.AV11SecFunctionalityIdRemoved=gx.fn.getControlValue("vSECFUNCTIONALITYIDREMOVED") ;
      this.AV15SecFunctionalityIdToFind=gx.fn.getIntegerValue("vSECFUNCTIONALITYIDTOFIND",',') ;
      this.AV10SecFunctionalityIdAdded=gx.fn.getControlValue("vSECFUNCTIONALITYIDADDED") ;
      this.AV31SecRoleIdParm=gx.fn.getIntegerValue("vSECROLEIDPARM",',') ;
      this.AV16SecFunctionalityRole=gx.fn.getControlValue("vSECFUNCTIONALITYROLE") ;
      this.AV29SecParentFunctionalityId=gx.fn.getIntegerValue("vSECPARENTFUNCTIONALITYID",',') ;
      this.AV29SecParentFunctionalityId=gx.fn.getIntegerValue("vSECPARENTFUNCTIONALITYID",',') ;
      this.AV9SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.A4SecRoleId=gx.fn.getIntegerValue("SECROLEID",',') ;
      this.AV21i=gx.fn.getIntegerValue("vI",',') ;
      this.AV11SecFunctionalityIdRemoved=gx.fn.getControlValue("vSECFUNCTIONALITYIDREMOVED") ;
      this.AV15SecFunctionalityIdToFind=gx.fn.getIntegerValue("vSECFUNCTIONALITYIDTOFIND",',') ;
      this.AV10SecFunctionalityIdAdded=gx.fn.getControlValue("vSECFUNCTIONALITYIDADDED") ;
      this.AV31SecRoleIdParm=gx.fn.getIntegerValue("vSECROLEIDPARM",',') ;
   };
   this.Valid_Secfunctionalityid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(25) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECFUNCTIONALITYID", gx.fn.currentGridRowImpl(25));
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
         if(  gx.fn.currentGridRowImpl(25) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECPARENTFUNCTIONALITYID", gx.fn.currentGridRowImpl(25));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.s122_client=function()
   {
      this.AV21i = gx.num.trunc( 1 ,0) ;
      this.AV89GXV4 = gx.num.trunc( 1 ,0) ;
      while ( this.AV89GXV4 <= this.AV11SecFunctionalityIdRemoved.length )
      {
         this.AV14SecFunctionalityId = gx.num.trunc( this.AV11SecFunctionalityIdRemoved[this.AV89GXV4 - 1] ,0) ;
         if ( this.AV14SecFunctionalityId == this.AV15SecFunctionalityIdToFind )
         {
            break;
         }
         this.AV21i = gx.num.trunc( this.AV21i + 1 ,0) ;
         this.AV89GXV4 = gx.num.trunc( this.AV89GXV4 + 1 ,0) ;
      }
      if ( this.AV21i > this.AV11SecFunctionalityIdRemoved.length )
      {
         this.AV21i = gx.num.trunc( 0 ,0) ;
      }
   };
   this.s132_client=function()
   {
      this.AV21i = gx.num.trunc( 1 ,0) ;
      this.AV88GXV3 = gx.num.trunc( 1 ,0) ;
      while ( this.AV88GXV3 <= this.AV10SecFunctionalityIdAdded.length )
      {
         this.AV14SecFunctionalityId = gx.num.trunc( this.AV10SecFunctionalityIdAdded[this.AV88GXV3 - 1] ,0) ;
         if ( this.AV14SecFunctionalityId == this.AV15SecFunctionalityIdToFind )
         {
            break;
         }
         this.AV21i = gx.num.trunc( this.AV21i + 1 ,0) ;
         this.AV88GXV3 = gx.num.trunc( this.AV88GXV3 + 1 ,0) ;
      }
      if ( this.AV21i > this.AV10SecFunctionalityIdAdded.length )
      {
         this.AV21i = gx.num.trunc( 0 ,0) ;
      }
   };
   this.e110n2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120n2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130n2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e140n2_client=function()
   {
      return this.executeServerEvent("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e150n2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e190n2_client=function()
   {
      return this.executeServerEvent("VISASSOCIATED.CLICK", true, arguments[0], false, false);
   };
   this.e200n1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,17,18,19,20,21,22,23,24,26,27,28,29,30,31,32,33,34,35,36,37,39,40,41,42,43,44,45,46,47,48,50,52,53,54,56,57];
   this.GXLastCtrlId =57;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secrolefunroleactionassociationww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addCheckBox("Isassociated",26,"vISASSOCIATED","","","IsAssociated","boolean","true","false","e190n2_client",true,false,0,"px","");
   GridContainer.addCheckBox("Isassociatedold",27,"vISASSOCIATEDOLD","","","IsAssociatedOld","boolean","true","false",null,false,false,0,"px","");
   GridContainer.addSingleLineEdit(1,28,"SECFUNCTIONALITYID","缂栧彿","","SecFunctionalityId","int",0,"px",10,10,"right",null,[],1,"SecFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(3,29,"SECFUNCTIONALITYKEY","","","SecFunctionalityKey","svchar",0,"px",100,80,"left",null,[],3,"SecFunctionalityKey",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(8,30,"SECFUNCTIONALITYDESCRIPTION","","","SecFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],8,"SecFunctionalityDescription",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addComboBox(9,31,"SECFUNCTIONALITYTYPE","绫诲瀷","SecFunctionalityType","int",null,0,false,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(2,32,"SECPARENTFUNCTIONALITYID","鐖跺姛鑳界紪鍙? ","","SecParentFunctionalityId","int",0,"px",10,10,"right",null,[],2,"SecParentFunctionalityId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(11,33,"SECPARENTFUNCTIONALITYDESCRIPTION","Parent Functionality","","SecParentFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],11,"SecParentFunctionalityDescription",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addCheckBox(7,34,"SECFUNCTIONALITYACTIVE","鏄惁鍚敤锛?,"","SecFunctionalityActive","boolean","true","false",null,false,false,0,"px","WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_UNNAMEDTABLE1Container = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE1Container", "Dvpanel_unnamedtable1", "DVPANEL_UNNAMEDTABLE1");
   var DVPANEL_UNNAMEDTABLE1Container = this.DVPANEL_UNNAMEDTABLE1Container;
   DVPANEL_UNNAMEDTABLE1Container.setProp("Class", "Class", "", "char");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Width", "Width", "100%", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Height", "Height", "100", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Title", "Title", "", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Visible", "Visible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_UNNAMEDTABLE1Container);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 38, 19, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV78GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV78GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV78GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV81GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV81GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV81GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV80GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV80GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV80GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110n2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120n2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECFUNCTIONALITYKEYContainer = gx.uc.getNew(this, 49, 19, "BootstrapDropDownOptions", "DDO_SECFUNCTIONALITYKEYContainer", "Ddo_secfunctionalitykey", "DDO_SECFUNCTIONALITYKEY");
   var DDO_SECFUNCTIONALITYKEYContainer = this.DDO_SECFUNCTIONALITYKEYContainer;
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Class", "Class", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
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
   DDO_SECFUNCTIONALITYKEYContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECFUNCTIONALITYKEYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV71DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV71DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV71DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYKEYContainer.addV2CFunction('AV56SecFunctionalityKeyTitleFilterData', "vSECFUNCTIONALITYKEYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYKEYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56SecFunctionalityKeyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYKEYTITLEFILTERDATA",UC.ParentObject.AV56SecFunctionalityKeyTitleFilterData); });
   DDO_SECFUNCTIONALITYKEYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYKEYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYKEYContainer.addEventHandler("OnOptionClicked", this.e130n2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYKEYContainer);
   this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer = gx.uc.getNew(this, 51, 19, "BootstrapDropDownOptions", "DDO_SECFUNCTIONALITYDESCRIPTIONContainer", "Ddo_secfunctionalitydescription", "DDO_SECFUNCTIONALITYDESCRIPTION");
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
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV71DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV71DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV71DDO_TitleSettingsIcons); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addV2CFunction('AV60SecFunctionalityDescriptionTitleFilterData', "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV60SecFunctionalityDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV60SecFunctionalityDescriptionTitleFilterData); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECFUNCTIONALITYDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e140n2_client);
   this.setUserControl(DDO_SECFUNCTIONALITYDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 55, 19, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_UNNAMEDTABLE1",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id:19 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECFUNCTIONALITYKEY",gxz:"ZV25SecFunctionalityKey",gxold:"OV25SecFunctionalityKey",gxvar:"AV25SecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25SecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("vSECFUNCTIONALITYKEY",gx.O.AV25SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25SecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("vSECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:0,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vISASSOCIATED",gxz:"ZV18IsAssociated",gxold:"OV18IsAssociated",gxvar:"AV18IsAssociated",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV18IsAssociated=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18IsAssociated=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("vISASSOCIATED",row || gx.fn.currentGridRowImpl(25),gx.O.AV18IsAssociated,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV18IsAssociated=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("vISASSOCIATED",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn,evt:"e190n2_client",values:['true','false']};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:0,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vISASSOCIATEDOLD",gxz:"ZV19IsAssociatedOld",gxold:"OV19IsAssociatedOld",gxvar:"AV19IsAssociatedOld",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV19IsAssociatedOld=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19IsAssociatedOld=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("vISASSOCIATEDOLD",row || gx.fn.currentGridRowImpl(25),gx.O.AV19IsAssociatedOld,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV19IsAssociatedOld=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("vISASSOCIATEDOLD",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Secfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[33],ip:[33,32],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(25),gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYKEY",gxz:"Z3SecFunctionalityKey",gxold:"O3SecFunctionalityKey",gxvar:"A3SecFunctionalityKey",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A3SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z3SecFunctionalityKey=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(25),gx.O.A3SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A3SecFunctionalityKey=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYKEY",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(25),gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYTYPE",gxz:"Z9SecFunctionalityType",gxold:"O9SecFunctionalityType",gxvar:"A9SecFunctionalityType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9SecFunctionalityType=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(25),gx.O.A9SecFunctionalityType);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYTYPE",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Secparentfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYID",gxz:"Z2SecParentFunctionalityId",gxold:"O2SecParentFunctionalityId",gxvar:"A2SecParentFunctionalityId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2SecParentFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(25),gx.O.A2SecParentFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECPARENTFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYDESCRIPTION",gxz:"Z11SecParentFunctionalityDescription",gxold:"O11SecParentFunctionalityDescription",gxvar:"A11SecParentFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A11SecParentFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z11SecParentFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(25),gx.O.A11SecParentFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A11SecParentFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYACTIVE",gxz:"Z7SecFunctionalityActive",gxold:"O7SecFunctionalityActive",gxvar:"A7SecFunctionalityActive",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("SECFUNCTIONALITYACTIVE",row || gx.fn.currentGridRowImpl(25),gx.O.A7SecFunctionalityActive,true)},c2v:function(){if(this.val()!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYACTIVE",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"BTNCONFIRM",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"BTNCANCEL",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gxz:"ZV59ddo_SecFunctionalityKeyTitleControlIdToReplace",gxold:"OV59ddo_SecFunctionalityKeyTitleControlIdToReplace",gxvar:"AV59ddo_SecFunctionalityKeyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV59ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV59ddo_SecFunctionalityKeyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE",gx.O.AV59ddo_SecFunctionalityKeyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV59ddo_SecFunctionalityKeyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxold:"OV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace",gxvar:"AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECFUNCTIONALITYIDADDEDXML",gxz:"ZV12SecFunctionalityIdAddedXml",gxold:"OV12SecFunctionalityIdAddedXml",gxvar:"AV12SecFunctionalityIdAddedXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12SecFunctionalityIdAddedXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12SecFunctionalityIdAddedXml=Value},v2c:function(){gx.fn.setControlValue("vSECFUNCTIONALITYIDADDEDXML",gx.O.AV12SecFunctionalityIdAddedXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12SecFunctionalityIdAddedXml=this.val()},val:function(){return gx.fn.getControlValue("vSECFUNCTIONALITYIDADDEDXML")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECFUNCTIONALITYIDREMOVEDXML",gxz:"ZV13SecFunctionalityIdRemovedXml",gxold:"OV13SecFunctionalityIdRemovedXml",gxvar:"AV13SecFunctionalityIdRemovedXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13SecFunctionalityIdRemovedXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13SecFunctionalityIdRemovedXml=Value},v2c:function(){gx.fn.setControlValue("vSECFUNCTIONALITYIDREMOVEDXML",gx.O.AV13SecFunctionalityIdRemovedXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13SecFunctionalityIdRemovedXml=this.val()},val:function(){return gx.fn.getControlValue("vSECFUNCTIONALITYIDREMOVEDXML")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV35OrderedBy",gxold:"OV35OrderedBy",gxvar:"AV35OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV35OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV35OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV36OrderedDsc",gxold:"OV36OrderedDsc",gxvar:"AV36OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV36OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV36OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV36OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV36OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV25SecFunctionalityKey = "" ;
   this.ZV25SecFunctionalityKey = "" ;
   this.OV25SecFunctionalityKey = "" ;
   this.ZV18IsAssociated = false ;
   this.OV18IsAssociated = false ;
   this.ZV19IsAssociatedOld = false ;
   this.OV19IsAssociatedOld = false ;
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
   this.AV59ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.ZV59ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.OV59ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.ZV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.OV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.AV12SecFunctionalityIdAddedXml = "" ;
   this.ZV12SecFunctionalityIdAddedXml = "" ;
   this.OV12SecFunctionalityIdAddedXml = "" ;
   this.AV13SecFunctionalityIdRemovedXml = "" ;
   this.ZV13SecFunctionalityIdRemovedXml = "" ;
   this.OV13SecFunctionalityIdRemovedXml = "" ;
   this.AV35OrderedBy = 0 ;
   this.ZV35OrderedBy = 0 ;
   this.OV35OrderedBy = 0 ;
   this.AV36OrderedDsc = false ;
   this.ZV36OrderedDsc = false ;
   this.OV36OrderedDsc = false ;
   this.AV25SecFunctionalityKey = "" ;
   this.AV78GridCurrentPage = 0 ;
   this.AV71DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV59ddo_SecFunctionalityKeyTitleControlIdToReplace = "" ;
   this.AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "" ;
   this.AV12SecFunctionalityIdAddedXml = "" ;
   this.AV13SecFunctionalityIdRemovedXml = "" ;
   this.AV35OrderedBy = 0 ;
   this.AV36OrderedDsc = false ;
   this.AV9SecRoleId = 0 ;
   this.AV29SecParentFunctionalityId = 0 ;
   this.AV18IsAssociated = false ;
   this.AV19IsAssociatedOld = false ;
   this.A1SecFunctionalityId = 0 ;
   this.A3SecFunctionalityKey = "" ;
   this.A8SecFunctionalityDescription = "" ;
   this.A9SecFunctionalityType = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.A7SecFunctionalityActive = false ;
   this.A4SecRoleId = 0 ;
   this.A12SecRoleDescription = "" ;
   this.AV21i = 0 ;
   this.AV11SecFunctionalityIdRemoved = [ ] ;
   this.AV15SecFunctionalityIdToFind = 0 ;
   this.AV10SecFunctionalityIdAdded = [ ] ;
   this.AV31SecRoleIdParm = 0 ;
   this.AV16SecFunctionalityRole = {SecFunctionalityId:0,SecFunctionalityDescription:"",SecRoleId:0,Mode:"",Initialized:0,SecFunctionalityId_Z:0,SecFunctionalityDescription_Z:"",SecRoleId_Z:0} ;
   this.AV14SecFunctionalityId = 0 ;
   this.AV89GXV4 = 0 ;
   this.AV88GXV3 = 0 ;
   this.Events = {"e110n2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120n2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130n2_client": ["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED", true] ,"e140n2_client": ["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED", true] ,"e150n2_client": ["ENTER", true] ,"e190n2_client": ["VISASSOCIATED.CLICK", true] ,"e200n1_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}],[{av:'AV56SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV60SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV78GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV81GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]];
   this.EvtParms["START"] = [[{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A12SecRoleDescription',fld:'SECROLEDESCRIPTION',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'TitleControlIdToReplace'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vSECFUNCTIONALITYIDADDEDXML","Visible")',ctrl:'vSECFUNCTIONALITYIDADDEDXML',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vSECFUNCTIONALITYIDREMOVEDXML","Visible")',ctrl:'vSECFUNCTIONALITYIDREMOVEDXML',prop:'Visible'},{av:'AV71DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'}],[{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYKEYContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV56SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV60SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV78GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV81GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]];
   this.EvtParms["DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'}],[{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECFUNCTIONALITYDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV56SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV60SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYKEY","Title")',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYDESCRIPTION","Title")',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV78GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV81GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'}],[{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["ENTER"] = [[{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV16SecFunctionalityRole',fld:'vSECFUNCTIONALITYROLE',pic:''}],[{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV16SecFunctionalityRole',fld:'vSECFUNCTIONALITYROLE',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]];
   this.EvtParms["VISASSOCIATED.CLICK"] = [[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'}],[{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''}]];
   this.EnterCtrl = ["BTNCONFIRM"];
   this.setVCMap("AV9SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV21i", "vI", 0, "int", 10, 0);
   this.setVCMap("AV11SecFunctionalityIdRemoved", "vSECFUNCTIONALITYIDREMOVED", 0, "Collint", 0, 0);
   this.setVCMap("AV15SecFunctionalityIdToFind", "vSECFUNCTIONALITYIDTOFIND", 0, "int", 10, 0);
   this.setVCMap("AV10SecFunctionalityIdAdded", "vSECFUNCTIONALITYIDADDED", 0, "Collint", 0, 0);
   this.setVCMap("AV31SecRoleIdParm", "vSECROLEIDPARM", 0, "int", 4, 0);
   this.setVCMap("AV16SecFunctionalityRole", "vSECFUNCTIONALITYROLE", 0, "WWPBaseObjects\SecFunctionalityRole", 0, 0);
   this.setVCMap("AV29SecParentFunctionalityId", "vSECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV29SecParentFunctionalityId", "vSECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV9SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV21i", "vI", 0, "int", 10, 0);
   this.setVCMap("AV11SecFunctionalityIdRemoved", "vSECFUNCTIONALITYIDREMOVED", 0, "Collint", 0, 0);
   this.setVCMap("AV15SecFunctionalityIdToFind", "vSECFUNCTIONALITYIDTOFIND", 0, "int", 10, 0);
   this.setVCMap("AV10SecFunctionalityIdAdded", "vSECFUNCTIONALITYIDADDED", 0, "Collint", 0, 0);
   this.setVCMap("AV31SecRoleIdParm", "vSECROLEIDPARM", 0, "int", 4, 0);
   this.setVCMap("AV29SecParentFunctionalityId", "vSECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV9SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV21i", "vI", 0, "int", 10, 0);
   this.setVCMap("AV11SecFunctionalityIdRemoved", "vSECFUNCTIONALITYIDREMOVED", 0, "Collint", 0, 0);
   this.setVCMap("AV15SecFunctionalityIdToFind", "vSECFUNCTIONALITYIDTOFIND", 0, "int", 10, 0);
   this.setVCMap("AV10SecFunctionalityIdAdded", "vSECFUNCTIONALITYIDADDED", 0, "Collint", 0, 0);
   this.setVCMap("AV31SecRoleIdParm", "vSECROLEIDPARM", 0, "int", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[19]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar({rfrVar:"AV29SecParentFunctionalityId"});
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar({rfrVar:"AV9SecRoleId"});
   GridContainer.addRefreshingVar({rfrVar:"A4SecRoleId"});
   GridContainer.addRefreshingVar({rfrVar:"AV21i"});
   GridContainer.addRefreshingVar({rfrVar:"AV11SecFunctionalityIdRemoved"});
   GridContainer.addRefreshingVar({rfrVar:"AV15SecFunctionalityIdToFind"});
   GridContainer.addRefreshingVar({rfrVar:"AV10SecFunctionalityIdAdded"});
   GridContainer.addRefreshingVar({rfrVar:"AV31SecRoleIdParm"});
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secrolefunroleactionassociationww);
