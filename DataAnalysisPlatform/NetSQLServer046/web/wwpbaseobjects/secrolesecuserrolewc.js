/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:54:57.81
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secrolesecuserrolewc', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.secrolesecuserrolewc" ;
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
      this.AV60Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV13IsAuthorized_SecUserName=gx.fn.getControlValue("vISAUTHORIZED_SECUSERNAME") ;
      this.AV8SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.AV8SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.AV60Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV13IsAuthorized_SecUserName=gx.fn.getControlValue("vISAUTHORIZED_SECUSERNAME") ;
   };
   this.Valid_Secuserid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(29) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECUSERID", gx.fn.currentGridRowImpl(29));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e110x2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120x2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130x2_client=function()
   {
      return this.executeServerEvent("DDO_SECUSERNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e170x2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e180x2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,30,31,32,33,34,36,37,38,40,41,43,44];
   this.GXLastCtrlId =44;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",29,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secrolesecuserrolewc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(6,30,"SECUSERID","璐﹀彿涓婚敭","","SecUserId","int",0,"px",4,4,"right",null,[],6,"SecUserId",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(14,31,"SECUSERNAME","","","SecUserName","svchar",0,"px",100,80,"left",null,[],14,"SecUserName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 35, 23, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV49GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV49GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV49GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV52GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV52GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV52GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV51GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV51GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110x2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120x2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECUSERNAMEContainer = gx.uc.getNew(this, 39, 23, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECUSERNAMEContainer", "Ddo_secusername", "DDO_SECUSERNAME");
   var DDO_SECUSERNAMEContainer = this.DDO_SECUSERNAMEContainer;
   DDO_SECUSERNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_SECUSERNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECUSERNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECUSERNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECUSERNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECUSERNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECUSERNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECUSERNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECUSERNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECUSERNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECUSERNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECUSERNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECUSERNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECUSERNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECUSERNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECUSERNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECUSERNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECUSERNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECUSERNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECUSERNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECUSERNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECUSERNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECUSERNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECUSERNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECUSERNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECUSERNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECUSERNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECUSERNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECUSERNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECUSERNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECUSERNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECUSERNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECUSERNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECUSERNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECUSERNAMEContainer.addV2CFunction('AV39DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV39DDO_TitleSettingsIcons); });
   DDO_SECUSERNAMEContainer.addV2CFunction('AV35SecUserNameTitleFilterData', "vSECUSERNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV35SecUserNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERNAMETITLEFILTERDATA",UC.ParentObject.AV35SecUserNameTitleFilterData); });
   DDO_SECUSERNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECUSERNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECUSERNAMEContainer.addEventHandler("OnOptionClicked", this.e130x2_client);
   this.setUserControl(DDO_SECUSERNAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 42, 23, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[17]={ id: 17, fld:"UNNAMEDTABLEECUSERNAME",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"FILTERTEXTSECUSERNAME", format:0,grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id:23 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECUSERNAME",gxz:"ZV55SecUserName",gxold:"OV55SecUserName",gxvar:"AV55SecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV55SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV55SecUserName=Value},v2c:function(){gx.fn.setControlValue("vSECUSERNAME",gx.O.AV55SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV55SecUserName=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[31],ip:[31,30],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERID",row || gx.fn.currentGridRowImpl(29),gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECUSERID",row || gx.fn.currentGridRowImpl(29),',')},nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:29,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(29),gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(29))},nac:gx.falseFn};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV38ddo_SecUserNameTitleControlIdToReplace",gxold:"OV38ddo_SecUserNameTitleControlIdToReplace",gxvar:"AV38ddo_SecUserNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV38ddo_SecUserNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38ddo_SecUserNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gx.O.AV38ddo_SecUserNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV38ddo_SecUserNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEID",gxz:"Z4SecRoleId",gxold:"O4SecRoleId",gxvar:"A4SecRoleId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A4SecRoleId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z4SecRoleId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECROLEID",gx.O.A4SecRoleId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A4SecRoleId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECROLEID",',')},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV57OrderedBy",gxold:"OV57OrderedBy",gxvar:"AV57OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV57OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV57OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV57OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV57OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV17OrderedDsc",gxold:"OV17OrderedDsc",gxvar:"AV17OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV17OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV55SecUserName = "" ;
   this.ZV55SecUserName = "" ;
   this.OV55SecUserName = "" ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.AV38ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.ZV38ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.OV38ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.A4SecRoleId = 0 ;
   this.Z4SecRoleId = 0 ;
   this.O4SecRoleId = 0 ;
   this.AV57OrderedBy = 0 ;
   this.ZV57OrderedBy = 0 ;
   this.OV57OrderedBy = 0 ;
   this.AV17OrderedDsc = false ;
   this.ZV17OrderedDsc = false ;
   this.OV17OrderedDsc = false ;
   this.AV55SecUserName = "" ;
   this.AV49GridCurrentPage = 0 ;
   this.AV39DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV38ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.A4SecRoleId = 0 ;
   this.AV57OrderedBy = 0 ;
   this.AV17OrderedDsc = false ;
   this.AV8SecRoleId = 0 ;
   this.A6SecUserId = 0 ;
   this.A14SecUserName = "" ;
   this.AV60Pgmname = "" ;
   this.AV13IsAuthorized_SecUserName = false ;
   this.Events = {"e110x2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120x2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130x2_client": ["DDO_SECUSERNAME.ONOPTIONCLICKED", true] ,"e170x2_client": ["ENTER", true] ,"e180x2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'sPrefix'},{av:'AV38ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV55SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV13IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true}],[{av:'AV35SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV49GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'}],[{ctrl:'GRID',prop:'Rows'},{av:'AV13IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'this.DDO_SECUSERNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECUSERNAME',prop:'TitleControlIdToReplace'},{av:'AV38ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECROLEID","Visible")',ctrl:'SECROLEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV39DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV55SecUserName',fld:'vSECUSERNAME',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV55SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV38ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV55SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV38ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECUSERNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV55SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV38ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.DDO_SECUSERNAMEContainer.ActiveEventKey',ctrl:'DDO_SECUSERNAME',prop:'ActiveEventKey'}],[{av:'AV57OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECUSERNAMEContainer.SortedStatus',ctrl:'DDO_SECUSERNAME',prop:'SortedStatus'},{av:'AV35SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV49GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV13IsAuthorized_SecUserName',fld:'vISAUTHORIZED_SECUSERNAME',pic:'',hsh:true},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("SECUSERNAME","Link")',ctrl:'SECUSERNAME',prop:'Link'}]];
   this.setVCMap("AV60Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV13IsAuthorized_SecUserName", "vISAUTHORIZED_SECUSERNAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV60Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV13IsAuthorized_SecUserName", "vISAUTHORIZED_SECUSERNAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV60Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV13IsAuthorized_SecUserName", "vISAUTHORIZED_SECUSERNAME", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[23]);
   GridContainer.addRefreshingVar(this.GXValidFnc[43]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar({rfrVar:"AV8SecRoleId"});
   GridContainer.addRefreshingVar(this.GXValidFnc[40]);
   GridContainer.addRefreshingVar({rfrVar:"AV60Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV13IsAuthorized_SecUserName"});
   this.Initialize( );
});
