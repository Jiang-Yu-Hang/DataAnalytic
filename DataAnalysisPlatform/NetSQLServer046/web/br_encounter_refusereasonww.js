/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:32.49
*/
gx.evt.autoSkip = false;
gx.define('br_encounter_refusereasonww', false, function () {
   this.ServerClass =  "br_encounter_refusereasonww" ;
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
      this.AV36TFBR_Encounter_RefuseReason_Status_Sels=gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS") ;
      this.AV63Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV45IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV47IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
      this.AV36TFBR_Encounter_RefuseReason_Status_Sels=gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS") ;
      this.AV63Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV45IsAuthorized_Update=gx.fn.getControlValue("vISAUTHORIZED_UPDATE") ;
      this.AV47IsAuthorized_Delete=gx.fn.getControlValue("vISAUTHORIZED_DELETE") ;
   };
   this.Validv_Tfbr_encounter_refusereason_noapprovedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV29TFBR_Encounter_RefuseReason_NoApproveDate)==0) || new gx.date.gxdate( this.AV29TFBR_Encounter_RefuseReason_NoApproveDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter_Refuse Reason_No Approve Date瓒呯晫");
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
   this.Validv_Tfbr_encounter_refusereason_noapprovedate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To)==0) || new gx.date.gxdate( this.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Encounter_Refuse Reason_No Approve Date_To瓒呯晫");
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
   this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate)==0) || new gx.date.gxdate( this.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter_Refuse Reason_No Approve Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo)==0) || new gx.date.gxdate( this.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Encounter_Refuse Reason_No Approve Date Aux Date To瓒呯晫");
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
         this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTERIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus =  ""  ;
   };
   this.e117c2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e127c2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e137c2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e147c2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e157c2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e167c2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e177c2_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e187c2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e227c2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e237c2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,32,33,34,35,36,37,38,39,40,41,42,44,45,46,48,50,52,54,56,58,59,60,61,62,63,64,65,66,67,68,69,70];
   this.GXLastCtrlId =70;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",31,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encounter_refusereasonww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",32,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Update","vUPDATE",33,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Delete","vDELETE",34,0,"px",17,"px",null,"","","DeleteAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(348,35,"BR_ENCOUNTER_REFUSEREASONID","","","BR_Encounter_RefuseReasonID","int",0,"px",18,18,"right",null,[],348,"BR_Encounter_RefuseReasonID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(19,36,"BR_ENCOUNTERID","","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(349,37,"BR_ENCOUNTER_REFUSEREASON_REASON","","","BR_Encounter_RefuseReason_Reason","svchar",0,"px",300,80,"left",null,[],349,"BR_Encounter_RefuseReason_Reason",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(350,38,"BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","","","BR_Encounter_RefuseReason_NoApproveDate","dtime",0,"px",19,19,"right",null,[],350,"BR_Encounter_RefuseReason_NoApproveDate",true,8,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(351,39,"BR_ENCOUNTER_REFUSEREASON_STATUS","","BR_Encounter_RefuseReason_Status","int",null,0,true,false,0,"px","WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 43, 32, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV40GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV40GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV42GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV42GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV41GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV41GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV41GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e117c2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e127c2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer = gx.uc.getNew(this, 47, 32, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASONIDContainer", "Ddo_br_encounter_refusereasonid", "DDO_BR_ENCOUNTER_REFUSEREASONID");
   var DDO_BR_ENCOUNTER_REFUSEREASONIDContainer = this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer;
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.addV2CFunction('AV38DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV38DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.addV2CFunction('AV16BR_Encounter_RefuseReasonIDTitleFilterData', "vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_Encounter_RefuseReasonIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA",UC.ParentObject.AV16BR_Encounter_RefuseReasonIDTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.addEventHandler("OnOptionClicked", this.e137c2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASONIDContainer);
   this.DDO_BR_ENCOUNTERIDContainer = gx.uc.getNew(this, 49, 48, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERIDContainer", "Ddo_br_encounterid", "DDO_BR_ENCOUNTERID");
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
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV38DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV38DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV20BR_EncounterIDTitleFilterData', "vBR_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV20BR_EncounterIDTitleFilterData); });
   DDO_BR_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e147c2_client);
   this.setUserControl(DDO_BR_ENCOUNTERIDContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer = gx.uc.getNew(this, 51, 48, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer", "Ddo_br_encounter_refusereason_reason", "DDO_BR_ENCOUNTER_REFUSEREASON_REASON");
   var DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListProc", "Datalistproc", "BR_Encounter_RefuseReasonWWGetFilterData", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addV2CFunction('AV38DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV38DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addV2CFunction('AV24BR_Encounter_RefuseReason_ReasonTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Encounter_RefuseReason_ReasonTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA",UC.ParentObject.AV24BR_Encounter_RefuseReason_ReasonTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.addEventHandler("OnOptionClicked", this.e157c2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer = gx.uc.getNew(this, 53, 48, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer", "Ddo_br_encounter_refusereason_noapprovedate", "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE");
   var DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addV2CFunction('AV38DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV38DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addV2CFunction('AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA",UC.ParentObject.AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.addEventHandler("OnOptionClicked", this.e167c2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer);
   this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer = gx.uc.getNew(this, 55, 48, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer", "Ddo_br_encounter_refusereason_status", "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS");
   var DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer = this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer;
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:鏈鐞?2:宸插鐞?, "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_FilterSelected", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.addV2CFunction('AV38DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV38DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV38DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.addV2CFunction('AV34BR_Encounter_RefuseReason_StatusTitleFilterData', "vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34BR_Encounter_RefuseReason_StatusTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA",UC.ParentObject.AV34BR_Encounter_RefuseReason_StatusTitleFilterData); });
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.addEventHandler("OnOptionClicked", this.e177c2_client);
   this.setUserControl(DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 57, 48, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[32]={ id:32 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV43Display",gxold:"OV43Display",gxvar:"AV43Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV43Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31),gx.O.AV43Display,gx.O.AV60Display_GXI)},c2v:function(){gx.O.AV60Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV43Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV60Display_GXI',nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV44Update",gxold:"OV44Update",gxvar:"AV44Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV44Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44Update=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vUPDATE",row || gx.fn.currentGridRowImpl(31),gx.O.AV44Update,gx.O.AV61Update_GXI)},c2v:function(){gx.O.AV61Update_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV44Update=this.val()},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vUPDATE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV61Update_GXI',nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV46Delete",gxold:"OV46Delete",gxvar:"AV46Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV46Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV46Delete=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETE",row || gx.fn.currentGridRowImpl(31),gx.O.AV46Delete,gx.O.AV62Delete_GXI)},c2v:function(){gx.O.AV62Delete_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV46Delete=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(31))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETE_GXI",row || gx.fn.currentGridRowImpl(31))}, gxvar_GXI:'AV62Delete_GXI',nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASONID",gxz:"Z348BR_Encounter_RefuseReasonID",gxold:"O348BR_Encounter_RefuseReasonID",gxvar:"A348BR_Encounter_RefuseReasonID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A348BR_Encounter_RefuseReasonID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z348BR_Encounter_RefuseReasonID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASONID",row || gx.fn.currentGridRowImpl(31),gx.O.A348BR_Encounter_RefuseReasonID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A348BR_Encounter_RefuseReasonID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_REFUSEREASONID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:300,dec:0,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_REASON",gxz:"Z349BR_Encounter_RefuseReason_Reason",gxold:"O349BR_Encounter_RefuseReason_Reason",gxvar:"A349BR_Encounter_RefuseReason_Reason",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A349BR_Encounter_RefuseReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z349BR_Encounter_RefuseReason_Reason=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_REASON",row || gx.fn.currentGridRowImpl(31),gx.O.A349BR_Encounter_RefuseReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.A349BR_Encounter_RefuseReason_Reason=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_REFUSEREASON_REASON",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"dtime",len:10,dec:8,sign:false,ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",gxz:"Z350BR_Encounter_RefuseReason_NoApproveDate",gxold:"O350BR_Encounter_RefuseReason_NoApproveDate",gxvar:"A350BR_Encounter_RefuseReason_NoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A350BR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z350BR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",row || gx.fn.currentGridRowImpl(31),gx.O.A350BR_Encounter_RefuseReason_NoApproveDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A350BR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",row || gx.fn.currentGridRowImpl(31))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:31,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_STATUS",gxz:"Z351BR_Encounter_RefuseReason_Status",gxold:"O351BR_Encounter_RefuseReason_Status",gxvar:"A351BR_Encounter_RefuseReason_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A351BR_Encounter_RefuseReason_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z351BR_Encounter_RefuseReason_Status=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("BR_ENCOUNTER_REFUSEREASON_STATUS",row || gx.fn.currentGridRowImpl(31),gx.O.A351BR_Encounter_RefuseReason_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A351BR_Encounter_RefuseReason_Status=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_REFUSEREASON_STATUS",row || gx.fn.currentGridRowImpl(31),',')},nac:gx.falseFn};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace",gxold:"OV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace",gxvar:"AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_EncounterIDTitleControlIdToReplace",gxold:"OV23ddo_BR_EncounterIDTitleControlIdToReplace",gxvar:"AV23ddo_BR_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace",gxold:"OV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace",gxvar:"AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace",gxold:"OV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace",gxvar:"AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE",gx.O.AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE",gxz:"ZV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace",gxold:"OV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace",gxvar:"AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE",gx.O.AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASONID",gxz:"ZV17TFBR_Encounter_RefuseReasonID",gxold:"OV17TFBR_Encounter_RefuseReasonID",gxvar:"AV17TFBR_Encounter_RefuseReasonID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17TFBR_Encounter_RefuseReasonID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17TFBR_Encounter_RefuseReasonID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASONID",gx.O.AV17TFBR_Encounter_RefuseReasonID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17TFBR_Encounter_RefuseReasonID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTER_REFUSEREASONID",',')},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASONID_TO",gxz:"ZV18TFBR_Encounter_RefuseReasonID_To",gxold:"OV18TFBR_Encounter_RefuseReasonID_To",gxvar:"AV18TFBR_Encounter_RefuseReasonID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_Encounter_RefuseReasonID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_Encounter_RefuseReasonID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASONID_TO",gx.O.AV18TFBR_Encounter_RefuseReasonID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_Encounter_RefuseReasonID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTER_REFUSEREASONID_TO",',')},nac:gx.falseFn};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID",gxz:"ZV21TFBR_EncounterID",gxold:"OV21TFBR_EncounterID",gxvar:"AV21TFBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21TFBR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21TFBR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID",gx.O.AV21TFBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21TFBR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTERID_TO",gxz:"ZV22TFBR_EncounterID_To",gxold:"OV22TFBR_EncounterID_To",gxvar:"AV22TFBR_EncounterID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_EncounterID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_EncounterID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTERID_TO",gx.O.AV22TFBR_EncounterID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_EncounterID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_ENCOUNTERID_TO",',')},nac:gx.falseFn};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_REASON",gxz:"ZV25TFBR_Encounter_RefuseReason_Reason",gxold:"OV25TFBR_Encounter_RefuseReason_Reason",gxvar:"AV25TFBR_Encounter_RefuseReason_Reason",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25TFBR_Encounter_RefuseReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25TFBR_Encounter_RefuseReason_Reason=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON",gx.O.AV25TFBR_Encounter_RefuseReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25TFBR_Encounter_RefuseReason_Reason=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON")},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL",gxz:"ZV26TFBR_Encounter_RefuseReason_Reason_Sel",gxold:"OV26TFBR_Encounter_RefuseReason_Reason_Sel",gxvar:"AV26TFBR_Encounter_RefuseReason_Reason_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26TFBR_Encounter_RefuseReason_Reason_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26TFBR_Encounter_RefuseReason_Reason_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL",gx.O.AV26TFBR_Encounter_RefuseReason_Reason_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26TFBR_Encounter_RefuseReason_Reason_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL")},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounter_refusereason_noapprovedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",gxz:"ZV29TFBR_Encounter_RefuseReason_NoApproveDate",gxold:"OV29TFBR_Encounter_RefuseReason_NoApproveDate",gxvar:"AV29TFBR_Encounter_RefuseReason_NoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[66],ip:[66],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE",gx.O.AV29TFBR_Encounter_RefuseReason_NoApproveDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Encounter_RefuseReason_NoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE")},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_encounter_refusereason_noapprovedate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO",gxz:"ZV30TFBR_Encounter_RefuseReason_NoApproveDate_To",gxold:"OV30TFBR_Encounter_RefuseReason_NoApproveDate_To",gxvar:"AV30TFBR_Encounter_RefuseReason_NoApproveDate_To",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[67],ip:[67],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV30TFBR_Encounter_RefuseReason_NoApproveDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO",gx.O.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO")},nac:gx.falseFn};
   GXValidFnc[68]={ id: 68, fld:"DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATES",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE",gxz:"ZV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate",gxold:"OV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate",gxvar:"AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[69],ip:[69],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE",gx.O.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[70]={ id:70 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_encounter_refusereason_noapprovedateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO",gxz:"ZV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo",gxold:"OV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo",gxvar:"AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[70],ip:[70],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO",gx.O.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO")},nac:gx.falseFn};
   this.ZV43Display = "" ;
   this.OV43Display = "" ;
   this.ZV44Update = "" ;
   this.OV44Update = "" ;
   this.ZV46Delete = "" ;
   this.OV46Delete = "" ;
   this.Z348BR_Encounter_RefuseReasonID = 0 ;
   this.O348BR_Encounter_RefuseReasonID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z349BR_Encounter_RefuseReason_Reason = "" ;
   this.O349BR_Encounter_RefuseReason_Reason = "" ;
   this.Z350BR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.O350BR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.Z351BR_Encounter_RefuseReason_Status = 0 ;
   this.O351BR_Encounter_RefuseReason_Status = 0 ;
   this.AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.ZV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.OV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = "" ;
   this.ZV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = "" ;
   this.OV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV17TFBR_Encounter_RefuseReasonID = 0 ;
   this.ZV17TFBR_Encounter_RefuseReasonID = 0 ;
   this.OV17TFBR_Encounter_RefuseReasonID = 0 ;
   this.AV18TFBR_Encounter_RefuseReasonID_To = 0 ;
   this.ZV18TFBR_Encounter_RefuseReasonID_To = 0 ;
   this.OV18TFBR_Encounter_RefuseReasonID_To = 0 ;
   this.AV21TFBR_EncounterID = 0 ;
   this.ZV21TFBR_EncounterID = 0 ;
   this.OV21TFBR_EncounterID = 0 ;
   this.AV22TFBR_EncounterID_To = 0 ;
   this.ZV22TFBR_EncounterID_To = 0 ;
   this.OV22TFBR_EncounterID_To = 0 ;
   this.AV25TFBR_Encounter_RefuseReason_Reason = "" ;
   this.ZV25TFBR_Encounter_RefuseReason_Reason = "" ;
   this.OV25TFBR_Encounter_RefuseReason_Reason = "" ;
   this.AV26TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.ZV26TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.OV26TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.AV29TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.ZV29TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.OV29TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.ZV30TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.OV30TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.ZV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.OV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.ZV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.OV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV40GridCurrentPage = 0 ;
   this.AV38DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "" ;
   this.AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV17TFBR_Encounter_RefuseReasonID = 0 ;
   this.AV18TFBR_Encounter_RefuseReasonID_To = 0 ;
   this.AV21TFBR_EncounterID = 0 ;
   this.AV22TFBR_EncounterID_To = 0 ;
   this.AV25TFBR_Encounter_RefuseReason_Reason = "" ;
   this.AV26TFBR_Encounter_RefuseReason_Reason_Sel = "" ;
   this.AV29TFBR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = gx.date.nullDate() ;
   this.AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = gx.date.nullDate() ;
   this.AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = gx.date.nullDate() ;
   this.AV43Display = "" ;
   this.AV44Update = "" ;
   this.AV46Delete = "" ;
   this.A348BR_Encounter_RefuseReasonID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A349BR_Encounter_RefuseReason_Reason = "" ;
   this.A350BR_Encounter_RefuseReason_NoApproveDate = gx.date.nullDate() ;
   this.A351BR_Encounter_RefuseReason_Status = 0 ;
   this.AV36TFBR_Encounter_RefuseReason_Status_Sels = [ ] ;
   this.AV63Pgmname = "" ;
   this.AV45IsAuthorized_Update = false ;
   this.AV47IsAuthorized_Delete = false ;
   this.Events = {"e117c2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e127c2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e137c2_client": ["DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED", true] ,"e147c2_client": ["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e157c2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED", true] ,"e167c2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED", true] ,"e177c2_client": ["DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED", true] ,"e187c2_client": ["'DOINSERT'", true] ,"e227c2_client": ["ENTER", true] ,"e237c2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASONID","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_STATUS'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASONID","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASONID_TO","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID","Visible")',ctrl:'vTFBR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTERID_TO","Visible")',ctrl:'vTFBR_ENCOUNTERID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_REASON","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO","Visible")',ctrl:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'TitleControlIdToReplace'},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'TitleControlIdToReplace'},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV38DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SelectedValue_set'},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredText_set'},{av:'AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredTextTo_set'},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SelectedValue_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SelectedValue_set'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'FilteredText_set'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_set'},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.FilteredText_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'FilteredText_set'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASONID","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_STATUS'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTERIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASONID","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_STATUS'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASONID","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_STATUS'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredText_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredText_get'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASONID","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_STATUS'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'ActiveEventKey'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SelectedValue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASONIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'this.DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASONID","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE","Title")',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_REFUSEREASON_STATUS'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Visible")',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Visible")',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}],[{av:'AV43Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV44Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Tooltiptext")',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV46Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Tooltiptext")',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_REFUSEREASON_REASON","Link")',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV36TFBR_Encounter_RefuseReason_Status_Sels", "vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV63Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV45IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV47IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV36TFBR_Encounter_RefuseReason_Status_Sels", "vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV63Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV45IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV47IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   this.setVCMap("AV36TFBR_Encounter_RefuseReason_Status_Sels", "vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV63Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV45IsAuthorized_Update", "vISAUTHORIZED_UPDATE", 0, "boolean", 4, 0);
   this.setVCMap("AV47IsAuthorized_Delete", "vISAUTHORIZED_DELETE", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[60]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar(this.GXValidFnc[64]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar({rfrVar:"AV36TFBR_Encounter_RefuseReason_Status_Sels"});
   GridContainer.addRefreshingVar({rfrVar:"AV63Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV45IsAuthorized_Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV47IsAuthorized_Delete"});
   this.Initialize( );
});
gx.createParentObj(br_encounter_refusereasonww);
