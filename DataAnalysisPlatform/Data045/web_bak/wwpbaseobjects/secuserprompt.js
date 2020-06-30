/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:28.76
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secuserprompt', false, function () {
   this.ServerClass =  "wwpbaseobjects.secuserprompt" ;
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
      this.AV7InOutSecUserId=gx.fn.getIntegerValue("vINOUTSECUSERID",',') ;
      this.AV8InOutSecUserName=gx.fn.getControlValue("vINOUTSECUSERNAME") ;
   };
   this.e110y2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e120y2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e130y2_client=function()
   {
      return this.executeServerEvent("DDO_SECUSERNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e170y2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e180y2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,17,18,19,20,21,22,23,24,26,27,28,29,30,31,32,33,34,35,36,38,39,40,42,44,45];
   this.GXLastCtrlId =45;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secuserprompt",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Select","vSELECT",26,0,"px",17,"px","e170y2_client","","","SelectAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(6,27,"SECUSERID","缂栧彿","","SecUserId","int",0,"px",4,4,"right",null,[],6,"SecUserId",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(14,28,"SECUSERNAME","","","SecUserName","svchar",0,"px",100,80,"left",null,[],14,"SecUserName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(15,29,"SECUSERPASSWORD","瀵嗙爜","","SecUserPassword","svchar",0,"px",100,80,"left",null,[],15,"SecUserPassword",false,0,false,true,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(178,30,"SECUSERCRTUSER","鍒涘缓浜?,"","SecUserCrtUser","svchar",0,"px",100,80,"left",null,[],178,"SecUserCrtUser",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(179,31,"SECUSERUPDUSER","鏇存柊浜?,"","SecUserUpdUser","svchar",0,"px",40,40,"left",null,[],179,"SecUserUpdUser",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(180,32,"SECUSERCRTDATE","鍒涘缓鏃堕棿","","SecUserCrtDate","dtime",0,"px",14,14,"right",null,[],180,"SecUserCrtDate",false,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(181,33,"SECUSERUPDDATE","鏇存柊鏃堕棿","","SecUserUpdDate","dtime",0,"px",19,19,"right",null,[],181,"SecUserUpdDate",false,8,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 37, 19, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV45GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV45GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV48GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV48GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV48GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV47GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV47GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV47GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e110y2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e120y2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECUSERNAMEContainer = gx.uc.getNew(this, 41, 19, "BootstrapDropDownOptions", "DDO_SECUSERNAMEContainer", "Ddo_secusername", "DDO_SECUSERNAME");
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
   DDO_SECUSERNAMEContainer.addV2CFunction('AV42DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV42DDO_TitleSettingsIcons); });
   DDO_SECUSERNAMEContainer.addV2CFunction('AV34SecUserNameTitleFilterData', "vSECUSERNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECUSERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34SecUserNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECUSERNAMETITLEFILTERDATA",UC.ParentObject.AV34SecUserNameTitleFilterData); });
   DDO_SECUSERNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECUSERNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECUSERNAMEContainer.addEventHandler("OnOptionClicked", this.e130y2_client);
   this.setUserControl(DDO_SECUSERNAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 43, 19, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[19]={ id:19 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vSECUSERNAME",gxz:"ZV49SecUserName",gxold:"OV49SecUserName",gxvar:"AV49SecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV49SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV49SecUserName=Value},v2c:function(){gx.fn.setControlValue("vSECUSERNAME",gx.O.AV49SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV49SecUserName=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV28Select",gxold:"OV28Select",gxvar:"AV28Select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV28Select=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28Select=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vSELECT",row || gx.fn.currentGridRowImpl(25),gx.O.AV28Select,gx.O.AV53Select_GXI)},c2v:function(){gx.O.AV53Select_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV28Select=this.val()},val:function(row){return gx.fn.getGridControlValue("vSELECT",row || gx.fn.currentGridRowImpl(25))},val_GXI:function(row){return gx.fn.getGridControlValue("vSELECT_GXI",row || gx.fn.currentGridRowImpl(25))}, gxvar_GXI:'AV53Select_GXI',nac:gx.falseFn,evt:"e170y2_client",std:"ENTER"};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERID",row || gx.fn.currentGridRowImpl(25),gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECUSERID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(25),gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERPASSWORD",gxz:"Z15SecUserPassword",gxold:"O15SecUserPassword",gxvar:"A15SecUserPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A15SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15SecUserPassword=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERPASSWORD",row || gx.fn.currentGridRowImpl(25),gx.O.A15SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.A15SecUserPassword=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERPASSWORD",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERCRTUSER",gxz:"Z178SecUserCrtUser",gxold:"O178SecUserCrtUser",gxvar:"A178SecUserCrtUser",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A178SecUserCrtUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z178SecUserCrtUser=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERCRTUSER",row || gx.fn.currentGridRowImpl(25),gx.O.A178SecUserCrtUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A178SecUserCrtUser=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERCRTUSER",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERUPDUSER",gxz:"Z179SecUserUpdUser",gxold:"O179SecUserUpdUser",gxvar:"A179SecUserUpdUser",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A179SecUserUpdUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z179SecUserUpdUser=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERUPDUSER",row || gx.fn.currentGridRowImpl(25),gx.O.A179SecUserUpdUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A179SecUserUpdUser=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERUPDUSER",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERCRTDATE",gxz:"Z180SecUserCrtDate",gxold:"O180SecUserCrtDate",gxvar:"A180SecUserCrtDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A180SecUserCrtDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z180SecUserCrtDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERCRTDATE",row || gx.fn.currentGridRowImpl(25),gx.O.A180SecUserCrtDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A180SecUserCrtDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("SECUSERCRTDATE",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"dtime",len:10,dec:8,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERUPDDATE",gxz:"Z181SecUserUpdDate",gxold:"O181SecUserUpdDate",gxvar:"A181SecUserUpdDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A181SecUserUpdDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z181SecUserUpdDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERUPDDATE",row || gx.fn.currentGridRowImpl(25),gx.O.A181SecUserUpdDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A181SecUserUpdDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("SECUSERUPDDATE",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV37ddo_SecUserNameTitleControlIdToReplace",gxold:"OV37ddo_SecUserNameTitleControlIdToReplace",gxvar:"AV37ddo_SecUserNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV37ddo_SecUserNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37ddo_SecUserNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE",gx.O.AV37ddo_SecUserNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV37ddo_SecUserNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV49SecUserName = "" ;
   this.ZV49SecUserName = "" ;
   this.OV49SecUserName = "" ;
   this.ZV28Select = "" ;
   this.OV28Select = "" ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.Z15SecUserPassword = "" ;
   this.O15SecUserPassword = "" ;
   this.Z178SecUserCrtUser = "" ;
   this.O178SecUserCrtUser = "" ;
   this.Z179SecUserUpdUser = "" ;
   this.O179SecUserUpdUser = "" ;
   this.Z180SecUserCrtDate = gx.date.nullDate() ;
   this.O180SecUserCrtDate = gx.date.nullDate() ;
   this.Z181SecUserUpdDate = gx.date.nullDate() ;
   this.O181SecUserUpdDate = gx.date.nullDate() ;
   this.AV37ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.ZV37ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.OV37ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV49SecUserName = "" ;
   this.AV45GridCurrentPage = 0 ;
   this.AV42DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV37ddo_SecUserNameTitleControlIdToReplace = "" ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV7InOutSecUserId = 0 ;
   this.AV8InOutSecUserName = "" ;
   this.AV28Select = "" ;
   this.A6SecUserId = 0 ;
   this.A14SecUserName = "" ;
   this.A15SecUserPassword = "" ;
   this.A178SecUserCrtUser = "" ;
   this.A179SecUserUpdUser = "" ;
   this.A180SecUserCrtDate = gx.date.nullDate() ;
   this.A181SecUserUpdDate = gx.date.nullDate() ;
   this.Events = {"e110y2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e120y2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e130y2_client": ["DDO_SECUSERNAME.ONOPTIONCLICKED", true] ,"e170y2_client": ["ENTER", true] ,"e180y2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV49SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV37ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'}],[{av:'AV34SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_SECUSERNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECUSERNAME',prop:'TitleControlIdToReplace'},{av:'AV37ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV42DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV49SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV37ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV49SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV37ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECUSERNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV49SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV37ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_SECUSERNAMEContainer.ActiveEventKey',ctrl:'DDO_SECUSERNAME',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECUSERNAMEContainer.SortedStatus',ctrl:'DDO_SECUSERNAME',prop:'SortedStatus'},{av:'AV34SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{ctrl:'SECUSERNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("SECUSERNAME","Title")',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV28Select',fld:'vSELECT',pic:''},{av:'gx.fn.getCtrlProperty("vSELECT","Tooltiptext")',ctrl:'vSELECT',prop:'Tooltiptext'}]];
   this.EvtParms["ENTER"] = [[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true},{av:'A14SecUserName',fld:'SECUSERNAME',pic:'',hsh:true}],[{av:'AV7InOutSecUserId',fld:'vINOUTSECUSERID',pic:'ZZZ9'},{av:'AV8InOutSecUserName',fld:'vINOUTSECUSERNAME',pic:''}]];
   this.EnterCtrl = ["vSELECT"];
   this.setVCMap("AV7InOutSecUserId", "vINOUTSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV8InOutSecUserName", "vINOUTSECUSERNAME", 0, "svchar", 100, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[19]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[42]);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secuserprompt);
