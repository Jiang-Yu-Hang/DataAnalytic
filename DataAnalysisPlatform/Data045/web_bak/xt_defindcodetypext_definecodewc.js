/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:20.67
*/
gx.evt.autoSkip = false;
gx.define('xt_defindcodetypext_definecodewc', true, function (CmpContext) {
   this.ServerClass =  "xt_defindcodetypext_definecodewc" ;
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
      this.AV37XT_DefindcodeID=gx.fn.getIntegerValue("vXT_DEFINDCODEID",',') ;
      this.AV8XT_DefindcodeTypeID=gx.fn.getIntegerValue("vXT_DEFINDCODETYPEID",',') ;
      this.AV39tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV8XT_DefindcodeTypeID=gx.fn.getIntegerValue("vXT_DEFINDCODETYPEID",',') ;
      this.AV50Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.e112e2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e122e2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e132e2_client=function()
   {
      return this.executeServerEvent("DDO_XT_DEFINECODENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e142e2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e182e2_client=function()
   {
      return this.executeServerEvent("VMINEU.CLICK", true, arguments[0], false, false);
   };
   this.e192e2_client=function()
   {
      return this.executeServerEvent("VMINDEL.CLICK", true, arguments[0], false, false);
   };
   this.e202e2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e212e2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,41,42,43,44,45,46,47,48,50,51,52,54,55,57,58];
   this.GXLastCtrlId =58;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",40,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"xt_defindcodetypext_definecodewc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",41,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Mineu","vMINEU",42,0,"px",17,"px","e182e2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Mindel","vMINDEL",43,0,"px",17,"px","e192e2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(168,44,"XT_DEFINECODENAME","","","XT_DefineCodeName","svchar",0,"px",100,80,"left",null,[],168,"XT_DefineCodeName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(167,45,"XT_DEFINECODEID","鏁版嵁瀛楀吀涓婚敭","","XT_DefineCodeID","int",0,"px",18,18,"right",null,[],167,"XT_DefineCodeID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 49, 28, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV24GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV24GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV26GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV26GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV25GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV25GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e112e2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e122e2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_XT_DEFINECODENAMEContainer = gx.uc.getNew(this, 53, 28, "BootstrapDropDownOptions", this.CmpContext + "DDO_XT_DEFINECODENAMEContainer", "Ddo_xt_definecodename", "DDO_XT_DEFINECODENAME");
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
   DDO_XT_DEFINECODENAMEContainer.addV2CFunction('AV21DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_DEFINECODENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV21DDO_TitleSettingsIcons); });
   DDO_XT_DEFINECODENAMEContainer.addV2CFunction('AV19XT_DefineCodeNameTitleFilterData', "vXT_DEFINECODENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_DEFINECODENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19XT_DefineCodeNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_DEFINECODENAMETITLEFILTERDATA",UC.ParentObject.AV19XT_DefineCodeNameTitleFilterData); });
   DDO_XT_DEFINECODENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_XT_DEFINECODENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_DEFINECODENAMEContainer.addEventHandler("OnOptionClicked", this.e132e2_client);
   this.setUserControl(DDO_XT_DEFINECODENAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 56, 28, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[17]={ id: 17, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"BTNINSERT",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"UNNAMEDTABLET_DEFINECODENAME",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"FILTERTEXTXT_DEFINECODENAME", format:0,grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id:28 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vXT_DEFINECODENAME",gxz:"ZV34XT_DefineCodeName",gxold:"OV34XT_DefineCodeName",gxvar:"AV34XT_DefineCodeName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34XT_DefineCodeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34XT_DefineCodeName=Value},v2c:function(){gx.fn.setControlValue("vXT_DEFINECODENAME",gx.O.AV34XT_DefineCodeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34XT_DefineCodeName=this.val()},val:function(){return gx.fn.getControlValue("vXT_DEFINECODENAME")},nac:gx.falseFn};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:40,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV31Display",gxold:"OV31Display",gxvar:"AV31Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV31Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(40),gx.O.AV31Display,gx.O.AV47Display_GXI)},c2v:function(){gx.O.AV47Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV31Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(40))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(40))}, gxvar_GXI:'AV47Display_GXI',nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:40,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vMINEU",gxz:"ZV36mineu",gxold:"OV36mineu",gxvar:"AV36mineu",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV36mineu=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36mineu=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vMINEU",row || gx.fn.currentGridRowImpl(40),gx.O.AV36mineu,gx.O.AV48Mineu_GXI)},c2v:function(){gx.O.AV48Mineu_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV36mineu=this.val()},val:function(row){return gx.fn.getGridControlValue("vMINEU",row || gx.fn.currentGridRowImpl(40))},val_GXI:function(row){return gx.fn.getGridControlValue("vMINEU_GXI",row || gx.fn.currentGridRowImpl(40))}, gxvar_GXI:'AV48Mineu_GXI',nac:gx.falseFn,evt:"e182e2_client"};
   GXValidFnc[43]={ id:43 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:40,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vMINDEL",gxz:"ZV40mindel",gxold:"OV40mindel",gxvar:"AV40mindel",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV40mindel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40mindel=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vMINDEL",row || gx.fn.currentGridRowImpl(40),gx.O.AV40mindel,gx.O.AV49Mindel_GXI)},c2v:function(){gx.O.AV49Mindel_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV40mindel=this.val()},val:function(row){return gx.fn.getGridControlValue("vMINDEL",row || gx.fn.currentGridRowImpl(40))},val_GXI:function(row){return gx.fn.getGridControlValue("vMINDEL_GXI",row || gx.fn.currentGridRowImpl(40))}, gxvar_GXI:'AV49Mindel_GXI',nac:gx.falseFn,evt:"e192e2_client"};
   GXValidFnc[44]={ id:44 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:40,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODENAME",gxz:"Z168XT_DefineCodeName",gxold:"O168XT_DefineCodeName",gxvar:"A168XT_DefineCodeName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A168XT_DefineCodeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z168XT_DefineCodeName=Value},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINECODENAME",row || gx.fn.currentGridRowImpl(40),gx.O.A168XT_DefineCodeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A168XT_DefineCodeName=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_DEFINECODENAME",row || gx.fn.currentGridRowImpl(40))},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:40,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODEID",gxz:"Z167XT_DefineCodeID",gxold:"O167XT_DefineCodeID",gxvar:"A167XT_DefineCodeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A167XT_DefineCodeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z167XT_DefineCodeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINECODEID",row || gx.fn.currentGridRowImpl(40),gx.O.A167XT_DefineCodeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A167XT_DefineCodeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("XT_DEFINECODEID",row || gx.fn.currentGridRowImpl(40),',')},nac:gx.falseFn};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_XT_DefineCodeNameTitleControlIdToReplace",gxold:"OV20ddo_XT_DefineCodeNameTitleControlIdToReplace",gxvar:"AV20ddo_XT_DefineCodeNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_XT_DefineCodeNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_XT_DefineCodeNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE",gx.O.AV20ddo_XT_DefineCodeNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_XT_DefineCodeNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPEID",gxz:"Z165XT_DefindcodeTypeID",gxold:"O165XT_DefindcodeTypeID",gxvar:"A165XT_DefindcodeTypeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z165XT_DefindcodeTypeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("XT_DEFINDCODETYPEID",gx.O.A165XT_DefindcodeTypeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("XT_DEFINDCODETYPEID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 55 , function() {
   });
   GXValidFnc[57]={ id:57 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV34XT_DefineCodeName = "" ;
   this.ZV34XT_DefineCodeName = "" ;
   this.OV34XT_DefineCodeName = "" ;
   this.ZV31Display = "" ;
   this.OV31Display = "" ;
   this.ZV36mineu = "" ;
   this.OV36mineu = "" ;
   this.ZV40mindel = "" ;
   this.OV40mindel = "" ;
   this.Z168XT_DefineCodeName = "" ;
   this.O168XT_DefineCodeName = "" ;
   this.Z167XT_DefineCodeID = 0 ;
   this.O167XT_DefineCodeID = 0 ;
   this.AV20ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.ZV20ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.OV20ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.A165XT_DefindcodeTypeID = 0 ;
   this.Z165XT_DefindcodeTypeID = 0 ;
   this.O165XT_DefindcodeTypeID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV34XT_DefineCodeName = "" ;
   this.AV24GridCurrentPage = 0 ;
   this.AV21DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV20ddo_XT_DefineCodeNameTitleControlIdToReplace = "" ;
   this.A165XT_DefindcodeTypeID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV8XT_DefindcodeTypeID = 0 ;
   this.A432XT_TenantCode = "" ;
   this.AV31Display = "" ;
   this.AV36mineu = "" ;
   this.AV40mindel = "" ;
   this.A168XT_DefineCodeName = "" ;
   this.A167XT_DefineCodeID = 0 ;
   this.AV50Pgmname = "" ;
   this.AV37XT_DefindcodeID = 0 ;
   this.AV39tCurrentCode = "" ;
   this.Events = {"e112e2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e122e2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e132e2_client": ["DDO_XT_DEFINECODENAME.ONOPTIONCLICKED", true] ,"e142e2_client": ["'DOINSERT'", true] ,"e182e2_client": ["VMINEU.CLICK", true] ,"e192e2_client": ["VMINDEL.CLICK", true] ,"e202e2_client": ["ENTER", true] ,"e212e2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'sPrefix'},{av:'AV20ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34XT_DefineCodeName',fld:'vXT_DEFINECODENAME',pic:''}],[{av:'AV39tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV19XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINECODENAME","Title")',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vMINEU","Visible")',ctrl:'vMINEU',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMINDEL","Visible")',ctrl:'vMINDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_XT_DEFINECODENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_XT_DEFINECODENAME',prop:'TitleControlIdToReplace'},{av:'AV20ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPEID","Visible")',ctrl:'XT_DEFINDCODETYPEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV21DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34XT_DefineCodeName',fld:'vXT_DEFINECODENAME',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34XT_DefineCodeName',fld:'vXT_DEFINECODENAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34XT_DefineCodeName',fld:'vXT_DEFINECODENAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_XT_DEFINECODENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV34XT_DefineCodeName',fld:'vXT_DEFINECODENAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'this.DDO_XT_DEFINECODENAMEContainer.ActiveEventKey',ctrl:'DDO_XT_DEFINECODENAME',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_DEFINECODENAMEContainer.SortedStatus',ctrl:'DDO_XT_DEFINECODENAME',prop:'SortedStatus'},{av:'AV39tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV19XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("XT_DEFINECODENAME","Title")',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'AV24GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV25GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV26GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vMINEU","Visible")',ctrl:'vMINEU',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMINDEL","Visible")',ctrl:'vMINDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV31Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV36mineu',fld:'vMINEU',pic:''},{av:'gx.fn.getCtrlProperty("vMINEU","Tooltiptext")',ctrl:'vMINEU',prop:'Tooltiptext'},{av:'AV40mindel',fld:'vMINDEL',pic:''},{av:'gx.fn.getCtrlProperty("vMINDEL","Tooltiptext")',ctrl:'vMINDEL',prop:'Tooltiptext'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV37XT_DefindcodeID',fld:'vXT_DEFINDCODEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["VMINEU.CLICK"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["VMINDEL.CLICK"] = [[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39tCurrentCode',fld:'vTCURRENTCODE',pic:''}],[]];
   this.setVCMap("AV50Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV37XT_DefindcodeID", "vXT_DEFINDCODEID", 0, "int", 18, 0);
   this.setVCMap("AV8XT_DefindcodeTypeID", "vXT_DEFINDCODETYPEID", 0, "int", 18, 0);
   this.setVCMap("AV39tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV8XT_DefindcodeTypeID", "vXT_DEFINDCODETYPEID", 0, "int", 18, 0);
   this.setVCMap("AV50Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8XT_DefindcodeTypeID", "vXT_DEFINDCODETYPEID", 0, "int", 18, 0);
   this.setVCMap("AV50Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[28]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar({rfrVar:"AV8XT_DefindcodeTypeID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar({rfrVar:"AV50Pgmname"});
   this.Initialize( );
});
