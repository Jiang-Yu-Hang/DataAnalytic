/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:22.39
*/
gx.evt.autoSkip = false;
gx.define('br_encounterreasonww', false, function () {
   this.ServerClass =  "br_encounterreasonww" ;
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
      this.AV39TFBR_EncounterReason_Status_Sels=gx.fn.getControlValue("vTFBR_ENCOUNTERREASON_STATUS_SELS") ;
      this.AV73Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV52IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV54IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV39TFBR_EncounterReason_Status_Sels=gx.fn.getControlValue("vTFBR_ENCOUNTERREASON_STATUS_SELS") ;
      this.AV73Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV52IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV54IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.Validv_Tfbr_encounterreason_israndnoapprovedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV29TFBR_EncounterReason_IsRandNoApproveDate)==0) || new gx.date.gxdate( this.AV29TFBR_EncounterReason_IsRandNoApproveDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter Reason_Is Rand No Approve Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tfbr_encounterreason_israndnoapprovedate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV30TFBR_EncounterReason_IsRandNoApproveDate_To)==0) || new gx.date.gxdate( this.AV30TFBR_EncounterReason_IsRandNoApproveDate_To ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter Reason_Is Rand No Approve Date_To瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Ddo_br_encounterreason_israndnoapprovedateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate)==0) || new gx.date.gxdate( this.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter Reason_Is Rand No Approve Date Aux Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Ddo_br_encounterreason_israndnoapprovedateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo)==0) || new gx.date.gxdate( this.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter Reason_Is Rand No Approve Date Aux Date To瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

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
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 7 )
      {
         this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus =  ""  ;
   };
   this.e11762_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12762_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERREASON_REASON.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERREASON_STATUS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e19762_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e20762_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e24762_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e25762_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,44,46,47,48,50,52,54,56,58,60,62,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79];
   this.GXLastCtrlId =79;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encounterreasonww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(347,35,"BR_ENCOUNTER_ID","","","BR_Encounter_ID","int",0,"px",15,15,"right",null,[],347,"BR_Encounter_ID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(19,36,"BR_ENCOUNTERID","","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(340,37,"BR_ENCOUNTERREASON_REASON","","","BR_EncounterReason_Reason","svchar",0,"px",300,80,"left",null,[],340,"BR_EncounterReason_Reason",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(341,38,"BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","","","BR_EncounterReason_IsRandNoApproveDate","dtime",0,"px",19,19,"right",null,[],341,"BR_EncounterReason_IsRandNoApproveDate",true,8,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addCheckBox(342,39,"BR_ENCOUNTERREASON_ISRANDAPPROVE","","","BR_EncounterReason_IsRandApprove","boolean","true","false",null,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addComboBox(343,40,"BR_ENCOUNTERREASON_STATUS","","BR_EncounterReason_Status","int",null,0,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(344,41,"BR_ENCOUNTERREASON_ISRANDAPPROVER","","","BR_EncounterReason_IsRandApprover","svchar",0,"px",40,40,"left",null,[],344,"BR_EncounterReason_IsRandApprover",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 45, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV47GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV47GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV49GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV49GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV49GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV48GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV48GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV48GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11762_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12762_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_ENCOUNTER_IDContainer = gx.uc.getNew(this, 49, 32, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_IDContainer", "Ddo_br_encounter_id", "DDO_BR_ENCOUNTER_ID");
   var DDO_BR_ENCOUNTER_IDContainer = this.DDO_BR_ENCOUNTER_IDContainer;
   DDO_BR_ENCOUNTER_IDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_IDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_IDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_IDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_IDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_IDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTER_IDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_IDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_IDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_IDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_IDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_IDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_IDContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_IDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_IDContainer.addV2CFunction('AV16BR_Encounter_IDTitleFilterData', "vBR_ENCOUNTER_IDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_IDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Encounter_IDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_IDTITLEFILTERDATA",UC.ParentObject.AV16BR_Encounter_IDTitleFilterData); });
   DDO_BR_ENCOUNTER_IDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_IDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_IDContainer.addEventHandler("OnOptionClicked", this.e13762_client);
   this.setUserControl(DDO_BR_ENCOUNTER_IDContainer);
   this.DDO_BR_ENCOUNTERIDContainer = gx.uc.getNew(this, 51, 50, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERIDContainer", "Ddo_br_encounterid", "DDO_BR_ENCOUNTERID");
   var DDO_BR_ENCOUNTERIDContainer = this.DDO_BR_ENCOUNTERIDContainer;
   DDO_BR_ENCOUNTERIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV20BR_EncounterIDTitleFilterData', "vBR_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV20BR_EncounterIDTitleFilterData); });
   DDO_BR_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e14762_client);
   this.setUserControl(DDO_BR_ENCOUNTERIDContainer);
   this.DDO_BR_ENCOUNTERREASON_REASONContainer = gx.uc.getNew(this, 53, 50, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERREASON_REASONContainer", "Ddo_br_encounterreason_reason", "DDO_BR_ENCOUNTERREASON_REASON");
   var DDO_BR_ENCOUNTERREASON_REASONContainer = this.DDO_BR_ENCOUNTERREASON_REASONContainer;
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("DataListProc", "Datalistproc", "BR_EncounterReasonWWGetFilterData", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERREASON_REASONContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERREASON_REASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERREASON_REASONContainer.addV2CFunction('AV24BR_EncounterReason_ReasonTitleFilterData', "vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERREASON_REASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_EncounterReason_ReasonTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA",UC.ParentObject.AV24BR_EncounterReason_ReasonTitleFilterData); });
   DDO_BR_ENCOUNTERREASON_REASONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERREASON_REASONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERREASON_REASONContainer.addEventHandler("OnOptionClicked", this.e15762_client);
   this.setUserControl(DDO_BR_ENCOUNTERREASON_REASONContainer);
   this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer = gx.uc.getNew(this, 55, 50, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer", "Ddo_br_encounterreason_israndnoapprovedate", "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE");
   var DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer = this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer;
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.addV2CFunction('AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData', "vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA",UC.ParentObject.AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData); });
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.addEventHandler("OnOptionClicked", this.e16762_client);
   this.setUserControl(DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer);
   this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer = gx.uc.getNew(this, 57, 50, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer", "Ddo_br_encounterreason_israndapprove", "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE");
   var DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer = this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer;
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:WWP_TSChecked,2:WWP_TSUnChecked", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.addV2CFunction('AV34BR_EncounterReason_IsRandApproveTitleFilterData', "vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34BR_EncounterReason_IsRandApproveTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA",UC.ParentObject.AV34BR_EncounterReason_IsRandApproveTitleFilterData); });
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.addEventHandler("OnOptionClicked", this.e17762_client);
   this.setUserControl(DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer);
   this.DDO_BR_ENCOUNTERREASON_STATUSContainer = gx.uc.getNew(this, 59, 50, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERREASON_STATUSContainer", "Ddo_br_encounterreason_status", "DDO_BR_ENCOUNTERREASON_STATUS");
   var DDO_BR_ENCOUNTERREASON_STATUSContainer = this.DDO_BR_ENCOUNTERREASON_STATUSContainer;
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", true, "bool");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:鏈鐞?2:宸插鐞?, "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_FilterSelected", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERREASON_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERREASON_STATUSContainer.addV2CFunction('AV37BR_EncounterReason_StatusTitleFilterData', "vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERREASON_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV37BR_EncounterReason_StatusTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA",UC.ParentObject.AV37BR_EncounterReason_StatusTitleFilterData); });
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERREASON_STATUSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERREASON_STATUSContainer.addEventHandler("OnOptionClicked", this.e18762_client);
   this.setUserControl(DDO_BR_ENCOUNTERREASON_STATUSContainer);
   this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer = gx.uc.getNew(this, 61, 50, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer", "Ddo_br_encounterreason_israndapprover", "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER");
   var DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer = this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer;
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("DataListProc", "Datalistproc", "BR_EncounterReasonWWGetFilterData", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.addV2CFunction('AV41BR_EncounterReason_IsRandApproverTitleFilterData', "vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.addC2VFunction(function(UC) { UC.ParentObject.AV41BR_EncounterReason_IsRandApproverTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA",UC.ParentObject.AV41BR_EncounterReason_IsRandApproverTitleFilterData); });
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.addEventHandler("OnOptionClicked", this.e19762_client);
   this.setUserControl(DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 63, 50, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV50Display",gxold:"OV50Display",gxvar:"AV50Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV50Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV50Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV50Display,gx.O.AV70Display_GXI)},c2v:function(){gx.O.AV70Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV50Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV70Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV51Update",gxold:"OV51Update",gxvar:"AV51Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV51Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV51Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV51Update,gx.O.AV71Update_GXI)},c2v:function(){gx.O.AV71Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV51Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV71Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV53Delete",gxold:"OV53Delete",gxvar:"AV53Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV53Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV53Delete,gx.O.AV72Delete_GXI)},c2v:function(){gx.O.AV72Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV53Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV72Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:15,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ID",gxz:"Z347BR_Encounter_ID",gxold:"O347BR_Encounter_ID",gxvar:"A347BR_Encounter_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A347BR_Encounter_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z347BR_Encounter_ID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_ID",row || gx.fn.currentGridRowImpl(31),gx.O.A347BR_Encounter_ID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A347BR_Encounter_ID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_ID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:300,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_REASON",gxz:"Z340BR_EncounterReason_Reason",gxold:"O340BR_EncounterReason_Reason",gxvar:"A340BR_EncounterReason_Reason",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A340BR_EncounterReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z340BR_EncounterReason_Reason=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERREASON_REASON",row || gx.fn.currentGridRowImpl(31),gx.O.A340BR_EncounterReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.A340BR_EncounterReason_Reason=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTERREASON_REASON",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"dtime",len:10,dec:8,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",gxz:"Z341BR_EncounterReason_IsRandNoApproveDate",gxold:"O341BR_EncounterReason_IsRandNoApproveDate",gxvar:"A341BR_EncounterReason_IsRandNoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A341BR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z341BR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",row || gx.fn.currentGridRowImpl(31),gx.O.A341BR_EncounterReason_IsRandNoApproveDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A341BR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISRANDAPPROVE",gxz:"Z342BR_EncounterReason_IsRandApprove",gxold:"O342BR_EncounterReason_IsRandApprove",gxvar:"A342BR_EncounterReason_IsRandApprove",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A342BR_EncounterReason_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z342BR_EncounterReason_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTERREASON_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(31),gx.O.A342BR_EncounterReason_IsRandApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.A342BR_EncounterReason_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_STATUS",gxz:"Z343BR_EncounterReason_Status",gxold:"O343BR_EncounterReason_Status",gxvar:"A343BR_EncounterReason_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A343BR_EncounterReason_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z343BR_EncounterReason_Status=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("BR_ENCOUNTERREASON_STATUS",row || gx.fn.currentGridRowImpl(31),gx.O.A343BR_EncounterReason_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A343BR_EncounterReason_Status=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERREASON_STATUS",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISRANDAPPROVER",gxz:"Z344BR_EncounterReason_IsRandApprover",gxold:"O344BR_EncounterReason_IsRandApprover",gxvar:"A344BR_EncounterReason_IsRandApprover",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A344BR_EncounterReason_IsRandApprover=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z344BR_EncounterReason_IsRandApprover=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVER",row || gx.fn.currentGridRowImpl(31),gx.O.A344BR_EncounterReason_IsRandApprover,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A344BR_EncounterReason_IsRandApprover=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVER",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Encounter_IDTitleControlIdToReplace",gxold:"OV19ddo_BR_Encounter_IDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Encounter_IDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Encounter_IDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Encounter_IDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Encounter_IDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Encounter_IDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_EncounterIDTitleControlIdToReplace",gxold:"OV23ddo_BR_EncounterIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace",gxold:"OV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace",gxvar:"AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace",gxold:"OV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace",gxvar:"AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE",gx.O.AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gxz:"ZV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace",gxold:"OV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace",gxvar:"AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gx.O.AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE",gxz:"ZV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace",gxold:"OV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace",gxvar:"AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE",gx.O.AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE",gxz:"ZV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace",gxold:"OV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace",gxvar:"AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE",gx.O.AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:15,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_ID",gxz:"ZV17TFBR_Encounter_ID",gxold:"OV17TFBR_Encounter_ID",gxvar:"AV17TFBR_Encounter_ID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Encounter_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Encounter_ID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_ID",gx.O.AV17TFBR_Encounter_ID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Encounter_ID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTER_ID",',')},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"int",len:15,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_ID_TO",gxz:"ZV18TFBR_Encounter_ID_To",gxold:"OV18TFBR_Encounter_ID_To",gxvar:"AV18TFBR_Encounter_ID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Encounter_ID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Encounter_ID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_ID_TO",gx.O.AV18TFBR_Encounter_ID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Encounter_ID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTER_ID_TO",',')},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID",gxz:"ZV21TFBR_EncounterID",gxold:"OV21TFBR_EncounterID",gxvar:"AV21TFBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID",gx.O.AV21TFBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID_TO",gxz:"ZV22TFBR_EncounterID_To",gxold:"OV22TFBR_EncounterID_To",gxvar:"AV22TFBR_EncounterID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_EncounterID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_EncounterID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID_TO",gx.O.AV22TFBR_EncounterID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_EncounterID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID_TO",',')},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_REASON",gxz:"ZV25TFBR_EncounterReason_Reason",gxold:"OV25TFBR_EncounterReason_Reason",gxvar:"AV25TFBR_EncounterReason_Reason",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_EncounterReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_EncounterReason_Reason=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_REASON",gx.O.AV25TFBR_EncounterReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_EncounterReason_Reason=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTERREASON_REASON")},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_REASON_SEL",gxz:"ZV26TFBR_EncounterReason_Reason_Sel",gxold:"OV26TFBR_EncounterReason_Reason_Sel",gxvar:"AV26TFBR_EncounterReason_Reason_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_EncounterReason_Reason_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_EncounterReason_Reason_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_REASON_SEL",gx.O.AV26TFBR_EncounterReason_Reason_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_EncounterReason_Reason_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTERREASON_REASON_SEL")},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounterreason_israndnoapprovedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",gxz:"ZV29TFBR_EncounterReason_IsRandNoApproveDate",gxold:"OV29TFBR_EncounterReason_IsRandNoApproveDate",gxvar:"AV29TFBR_EncounterReason_IsRandNoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[72],ip:[72],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",gx.O.AV29TFBR_EncounterReason_IsRandNoApproveDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE")},nac:gx.falseFn};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounterreason_israndnoapprovedate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO",gxz:"ZV30TFBR_EncounterReason_IsRandNoApproveDate_To",gxold:"OV30TFBR_EncounterReason_IsRandNoApproveDate_To",gxvar:"AV30TFBR_EncounterReason_IsRandNoApproveDate_To",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[73],ip:[73],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_EncounterReason_IsRandNoApproveDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_EncounterReason_IsRandNoApproveDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO",gx.O.AV30TFBR_EncounterReason_IsRandNoApproveDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_EncounterReason_IsRandNoApproveDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO")},nac:gx.falseFn};
   GXValidFnc[74]={ id: 74, fld:"DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATES",grid:0};
   GXValidFnc[75]={ id:75 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounterreason_israndnoapprovedateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATE",gxz:"ZV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate",gxold:"OV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate",gxvar:"AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[75],ip:[75],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATE",gx.O.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounterreason_israndnoapprovedateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATETO",gxz:"ZV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo",gxold:"OV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo",gxvar:"AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[76],ip:[76],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATETO",gx.O.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATETO")},nac:gx.falseFn};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL",gxz:"ZV35TFBR_EncounterReason_IsRandApprove_Sel",gxold:"OV35TFBR_EncounterReason_IsRandApprove_Sel",gxvar:"AV35TFBR_EncounterReason_IsRandApprove_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35TFBR_EncounterReason_IsRandApprove_Sel=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV35TFBR_EncounterReason_IsRandApprove_Sel=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL",gx.O.AV35TFBR_EncounterReason_IsRandApprove_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35TFBR_EncounterReason_IsRandApprove_Sel=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL",',')},nac:gx.falseFn};
   GXValidFnc[78]={ id:78 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_ISRANDAPPROVER",gxz:"ZV42TFBR_EncounterReason_IsRandApprover",gxold:"OV42TFBR_EncounterReason_IsRandApprover",gxvar:"AV42TFBR_EncounterReason_IsRandApprover",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV42TFBR_EncounterReason_IsRandApprover=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42TFBR_EncounterReason_IsRandApprover=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_ISRANDAPPROVER",gx.O.AV42TFBR_EncounterReason_IsRandApprover,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV42TFBR_EncounterReason_IsRandApprover=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTERREASON_ISRANDAPPROVER")},nac:gx.falseFn};
   GXValidFnc[79]={ id:79 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL",gxz:"ZV43TFBR_EncounterReason_IsRandApprover_Sel",gxold:"OV43TFBR_EncounterReason_IsRandApprover_Sel",gxvar:"AV43TFBR_EncounterReason_IsRandApprover_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43TFBR_EncounterReason_IsRandApprover_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43TFBR_EncounterReason_IsRandApprover_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL",gx.O.AV43TFBR_EncounterReason_IsRandApprover_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43TFBR_EncounterReason_IsRandApprover_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL")},nac:gx.falseFn};
   this.ZV50Display = "" ;
   this.OV50Display = "" ;
   this.ZV51Update = "" ;
   this.OV51Update = "" ;
   this.ZV53Delete = "" ;
   this.OV53Delete = "" ;
   this.Z347BR_Encounter_ID = 0 ;
   this.O347BR_Encounter_ID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z340BR_EncounterReason_Reason = "" ;
   this.O340BR_EncounterReason_Reason = "" ;
   this.Z341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.O341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.Z342BR_EncounterReason_IsRandApprove = false ;
   this.O342BR_EncounterReason_IsRandApprove = false ;
   this.Z343BR_EncounterReason_Status = 0 ;
   this.O343BR_EncounterReason_Status = 0 ;
   this.Z344BR_EncounterReason_IsRandApprover = "" ;
   this.O344BR_EncounterReason_IsRandApprover = "" ;
   this.AV19ddo_BR_Encounter_IDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Encounter_IDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Encounter_IDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = "" ;
   this.ZV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = "" ;
   this.OV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = "" ;
   this.AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = "" ;
   this.ZV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = "" ;
   this.OV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace = "" ;
   this.ZV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace = "" ;
   this.OV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace = "" ;
   this.AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = "" ;
   this.ZV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = "" ;
   this.OV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Encounter_ID = 0 ;
   this.ZV17TFBR_Encounter_ID = 0 ;
   this.OV17TFBR_Encounter_ID = 0 ;
   this.AV18TFBR_Encounter_ID_To = 0 ;
   this.ZV18TFBR_Encounter_ID_To = 0 ;
   this.OV18TFBR_Encounter_ID_To = 0 ;
   this.AV21TFBR_EncounterID = 0 ;
   this.ZV21TFBR_EncounterID = 0 ;
   this.OV21TFBR_EncounterID = 0 ;
   this.AV22TFBR_EncounterID_To = 0 ;
   this.ZV22TFBR_EncounterID_To = 0 ;
   this.OV22TFBR_EncounterID_To = 0 ;
   this.AV25TFBR_EncounterReason_Reason = "" ;
   this.ZV25TFBR_EncounterReason_Reason = "" ;
   this.OV25TFBR_EncounterReason_Reason = "" ;
   this.AV26TFBR_EncounterReason_Reason_Sel = "" ;
   this.ZV26TFBR_EncounterReason_Reason_Sel = "" ;
   this.OV26TFBR_EncounterReason_Reason_Sel = "" ;
   this.AV29TFBR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.ZV29TFBR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.OV29TFBR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.AV30TFBR_EncounterReason_IsRandNoApproveDate_To = gx.date.nullDate() ;
   this.ZV30TFBR_EncounterReason_IsRandNoApproveDate_To = gx.date.nullDate() ;
   this.OV30TFBR_EncounterReason_IsRandNoApproveDate_To = gx.date.nullDate() ;
   this.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate = gx.date.nullDate() ;
   this.ZV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate = gx.date.nullDate() ;
   this.OV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate = gx.date.nullDate() ;
   this.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.ZV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.OV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV35TFBR_EncounterReason_IsRandApprove_Sel = 0 ;
   this.ZV35TFBR_EncounterReason_IsRandApprove_Sel = 0 ;
   this.OV35TFBR_EncounterReason_IsRandApprove_Sel = 0 ;
   this.AV42TFBR_EncounterReason_IsRandApprover = "" ;
   this.ZV42TFBR_EncounterReason_IsRandApprover = "" ;
   this.OV42TFBR_EncounterReason_IsRandApprover = "" ;
   this.AV43TFBR_EncounterReason_IsRandApprover_Sel = "" ;
   this.ZV43TFBR_EncounterReason_IsRandApprover_Sel = "" ;
   this.OV43TFBR_EncounterReason_IsRandApprover_Sel = "" ;
   this.AV47GridCurrentPage = 0 ;
   this.AV45DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Encounter_IDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = "" ;
   this.AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace = "" ;
   this.AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Encounter_ID = 0 ;
   this.AV18TFBR_Encounter_ID_To = 0 ;
   this.AV21TFBR_EncounterID = 0 ;
   this.AV22TFBR_EncounterID_To = 0 ;
   this.AV25TFBR_EncounterReason_Reason = "" ;
   this.AV26TFBR_EncounterReason_Reason_Sel = "" ;
   this.AV29TFBR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.AV30TFBR_EncounterReason_IsRandNoApproveDate_To = gx.date.nullDate() ;
   this.AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate = gx.date.nullDate() ;
   this.AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV35TFBR_EncounterReason_IsRandApprove_Sel = 0 ;
   this.AV42TFBR_EncounterReason_IsRandApprover = "" ;
   this.AV43TFBR_EncounterReason_IsRandApprover_Sel = "" ;
   this.AV50Display = "" ;
   this.AV51Update = "" ;
   this.AV53Delete = "" ;
   this.A347BR_Encounter_ID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A340BR_EncounterReason_Reason = "" ;
   this.A341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.A342BR_EncounterReason_IsRandApprove = false ;
   this.A343BR_EncounterReason_Status = 0 ;
   this.A344BR_EncounterReason_IsRandApprover = "" ;
   this.AV39TFBR_EncounterReason_Status_Sels = [ ] ;
   this.AV73Pgmname = "" ;
   this.AV52IsAuthorized_Update = false ;
   this.AV54IsAuthorized_Delete = false ;
   this.Events = {"e11762_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12762_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13762_client": ["DDO_BR_ENCOUNTER_ID.ONOPTIONCLICKED", true] ,"e14762_client": ["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e15762_client": ["DDO_BR_ENCOUNTERREASON_REASON.ONOPTIONCLICKED", true] ,"e16762_client": ["DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE.ONOPTIONCLICKED", true] ,"e17762_client": ["DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE.ONOPTIONCLICKED", true] ,"e18762_client": ["DDO_BR_ENCOUNTERREASON_STATUS.ONOPTIONCLICKED", true] ,"e19762_client": ["DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER.ONOPTIONCLICKED", true] ,"e20762_client": ["'DOINSERT'", true] ,"e24762_client": ["ENTER", true] ,"e25762_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_ID","Visible")',ctrl:'vTFBR_ENCOUNTER_ID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_ID_TO","Visible")',ctrl:'vTFBR_ENCOUNTER_ID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID","Visible")',ctrl:'vTFBR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID_TO","Visible")',ctrl:'vTFBR_ENCOUNTERID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_REASON","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_REASON',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_REASON_SEL","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_REASON_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_ISRANDAPPROVER","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL","Visible")',ctrl:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'TitleControlIdToReplace'},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'TitleControlIdToReplace'},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'TitleControlIdToReplace'},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'TitleControlIdToReplace'},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV45DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SelectedValue_set'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'FilteredText_set'},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SelectedValue_set'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SelectedValue_set'},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV31DDO_BR_EncounterReason_IsRandNoApproveDateAuxDate',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATE',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'FilteredText_set'},{av:'AV32DDO_BR_EncounterReason_IsRandNoApproveDateAuxDateTo',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEAUXDATETO',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'FilteredTextTo_set'},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SelectedValue_set'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'FilteredText_set'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTER_IDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERREASON_REASON.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERREASON_STATUS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_ID',fld:'vTFBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV18TFBR_Encounter_ID_To',fld:'vTFBR_ENCOUNTER_ID_TO',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_EncounterReason_Reason',fld:'vTFBR_ENCOUNTERREASON_REASON',pic:''},{av:'AV26TFBR_EncounterReason_Reason_Sel',fld:'vTFBR_ENCOUNTERREASON_REASON_SEL',pic:''},{av:'AV29TFBR_EncounterReason_IsRandNoApproveDate',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_EncounterReason_IsRandNoApproveDate_To',fld:'vTFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV35TFBR_EncounterReason_IsRandApprove_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'AV19ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39TFBR_EncounterReason_Status_Sels',fld:'vTFBR_ENCOUNTERREASON_STATUS_SELS',pic:''},{av:'AV73Pgmname',fld:'vPGMNAME',pic:''},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV42TFBR_EncounterReason_IsRandApprover',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER',pic:''},{av:'AV43TFBR_EncounterReason_IsRandApprover_Sel',fld:'vTFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_IDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV37BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV41BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ID","Title")',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Title")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Title")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV47GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV48GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV49GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A347BR_Encounter_ID',fld:'BR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9',hsh:true},{av:'AV52IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV54IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV50Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV51Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV53Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_REASON","Link")',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A347BR_Encounter_ID',fld:'BR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9',hsh:true}],[]];
   this.setVCMap("AV39TFBR_EncounterReason_Status_Sels", "vTFBR_ENCOUNTERREASON_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV73Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV52IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV54IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV39TFBR_EncounterReason_Status_Sels", "vTFBR_ENCOUNTERREASON_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV73Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV52IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV54IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV39TFBR_EncounterReason_Status_Sels", "vTFBR_ENCOUNTERREASON_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV73Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV52IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV54IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
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
   GridContainer.addRefreshingVar(this.GXValidFnc[77]);
   GridContainer.addRefreshingVar(this.GXValidFnc[78]);
   GridContainer.addRefreshingVar(this.GXValidFnc[79]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar({rfrVar:"AV39TFBR_EncounterReason_Status_Sels"});
   GridContainer.addRefreshingVar({rfrVar:"AV73Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV52IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV54IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_encounterreasonww);
